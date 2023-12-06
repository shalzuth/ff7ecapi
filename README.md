# ff7ecapi
ff7ecapi is an educational repository for teaching how to statically dump assets and to communicate over the network of an example mobile app. This isn't for beginners. Nor a tutorial. But rather an explanation of my thinking process.

# High level process
To understand how to retrieve assets and communicate over the network, the first step is always obtaining the app binary code, and then start sniffing the requests if possible, as well as examining the app code.
I have broken out the solution into multiple projects to better segregate each step to reversing.
1. Download the APK.
    1. I do this in the ApkDumper project. I use qoo, you'll have to fill in the blanks for the token/etc on the download part.
    2. The app is a Unity app after quick inspection (it has libil2cpp.so in the apk).
    3. Use il2cpp dumper to dump out the metadata (or cpp2il to dump out regenerated psuedocode).
    4. In this case, the global-metadata.bin is encrypted. It's a simple xor as seen in the libil2cpp.so, so we can statically dump it out from the .so https://github.com/shalzuth/ff7ecapi/blob/64d1a6512d60f731f4d9afe43148a719a7a0f067/ApkDumper/Unity.cs#L28-L41
2. Inspect the network & file structures. Usually, these are very closely linked together. Opening up the dummy dll's from il2cpp, we can usually see what frameworks they use - I use dnSpy generally. Protobuf is very common, and used here. MessagePack and FlatBuffer are also common ones, and MessagePack is used here for the files.
    1. Dump out Protobufs. I have been using SteamKit's ProtobufDumper recently, it works the best. There are many ways to skin a cat, but I was able to dump out the raw protobins by finding the static constructor address with the dummy dll, then going to that location in the binary to dump out the base64 encoded raw protobin. See https://github.com/shalzuth/ff7ecapi/blob/main/PbDumper/Dumper.cs
    2. Dump out MessagePack. I ended up just going through each class in the dummy dll's, and recreating the classes that way. https://github.com/shalzuth/ff7ecapi/blob/main/MpDumper/Dumper.cs . Initially, I used that methodology for the protobufs, but it wasn't nearly as accurate as dumping out the raw protobins.
    3. The files using MessagePack have some protection. After trying multiple routes, the route that proved successful was checking out other games made by the same developer to see if anyone else has done something. Nier is made by the same devs Applibot, and there's a massive project in reversing it, so I compared and found that it's mostly the same as https://github.com/NieR-Rein-Guide/nier-rein-apps/blob/6d1e6f717b5a5ea90e3e5583184d2b2fb8766d19/src/NierReincarnation.Datamine/Command/Data/ExportAssetsCommand.cs, but the maskLen was changed from 0xbb to 0xab (found via inspection in IDA via the dummy dll address).
3. Inspect the network traffic to figure out how to use the above structures
    1. I usually create a proxy or some hook to watch the traffic live, to inspect what the payload looks like and how to recreate it. In this case, it was a simple REST API over TCP. Fiddler is usually my goto tool for this, but I have been using Titanium more recently.
    2. Copy out the headers - note, different stages of the auth and general state machine use different headers. https://github.com/shalzuth/ff7ecapi/blob/64d1a6512d60f731f4d9afe43148a719a7a0f067/Utils/HttpRequest.cs#L90-L115
    3. The payload is compressed and encrypted (this is usually the case these days). Sift through the dummy dll's to see if you can find any compress/crypt functions, then look at the base address. If you used Cpp2il, there's a chance you can read what the code does - but right now, it's still not advanced enough. So open up IDA/Ghidra/etc., go to the base address of the crypto/compession functions, and start having fun. See https://github.com/shalzuth/ff7ecapi/blob/main/Utils/Compresso.cs from compression, and https://github.com/shalzuth/ff7ecapi/blob/main/Utils/Crypto.cs from encryption. 
    4. There's also a ton of API endpoints - we definitely do not want to write them all out, so parse out all of the endpoints. I used a combination of the dummy dll's to get addresses via Mono.Cecil, and Gee to dump out the strings https://github.com/shalzuth/ff7ecapi/blob/64d1a6512d60f731f4d9afe43148a719a7a0f067/PbDumper/Dumper.cs#L121-L150
4. Putting it all together.
    1. Download assets over the web. This makes it so you don't have to download a new APK or wait for the app to be updated on the app store/etc. You can use the same in-app content upgrade process. See https://github.com/shalzuth/ff7ecapi/blob/main/NetDumper/Dumper.cs
    2. Dump game images. I gutted out this part, but I used AssetsTools to open the Unity files to dump out the downloaded files from DumpOcto
    3. Login to your account and dump out your account info https://github.com/shalzuth/ff7ecapi/blob/64d1a6512d60f731f4d9afe43148a719a7a0f067/ff7ecapi/Program.cs#L43-L45
    4. Search other players https://github.com/shalzuth/ff7ecapi/blob/64d1a6512d60f731f4d9afe43148a719a7a0f067/ff7ecapi/Program.cs#L52-L53
    5. Dump out announcements https://github.com/shalzuth/ff7ecapi/blob/64d1a6512d60f731f4d9afe43148a719a7a0f067/ff7ecapi/Program.cs#L59-L71
5. The gray area
    1. I have intentionally excluded how to do any in-game automation that could have a negative impact on the game, which requires some additional encrypted steps, and different network protocols. No asking about this.

# Support me
Currently under employed - hire me! Email me at githubusername @gmail.com, or discord eth0logy

# Legal stuff
MIT License

Shalzuth isn't endorsed by SQUARE ENIX CO., LTD. or Applibot Inc. and doesn’t reflect the views or opinions of SQUARE ENIX CO., LTD. or Applibot Inc. or anyone officially involved in producing or managing SQUARE ENIX CO., LTD. or Applibot Inc. Game content and materials are trademarks and copyrights of SQUARE ENIX CO., LTD. or Applibot Inc.

https://github.com/SteamRE/SteamKit/blob/master/LICENSE - I use ProtobufDumper
