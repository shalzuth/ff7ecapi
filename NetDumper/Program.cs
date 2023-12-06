// get latest paths
var r = await new ff7ecnet.API(0).GetCheck(new Api.GetCheckRequest { });

await NetDumper.Dumper.DownloadMasterData(); // raw game data, like json
await NetDumper.Dumper.DownloadTranslations(); // english
await NetDumper.Dumper.DumpOcto(); // raw game assets, like models, images, etc.

// do stuff like use AssetsTools to dump out images, cactuar locations, from octo files, or just parse out master data to see units, weapons, etc.