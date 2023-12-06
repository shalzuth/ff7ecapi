using Api;
using Enums;
using System.Diagnostics;

var api = new ff7ecnet.API(0);
var r = await api.GetCheck(new GetCheckRequest { });
if (r.HasIsMaintenance) return;

if (!File.Exists("account.json"))
{
    Console.WriteLine("1 for new account, 2 for existing account");
    var res = Console.ReadLine();
    if (res.Contains("1"))
    {
        var register = await api.PostAuthGameRegister(new PostAuthGameRegisterRequest { });
        api.userId = register.UserId;
        api.http.DeviceId = Guid.Parse(register.DeviceUuid);
        var devId = api.http.DeviceId;
        api.http.LoginToken = register.LoginToken;
        var login = await api.PostAuthSession(new PostAuthSessionRequest { DeviceUuid = register.DeviceUuid, LoginToken = register.LoginToken });
        var titleResponse = await api.PostPvtUserTitle(new PostPvtUserTitleRequest { });
        var skip = await api.PostPvtTutorialSkip(new PostPvtTutorialSkipRequest { UserName = "Tazo", Message = "Nice to meet you!" });
        var accountInfo = new PostAuthMigrateBridgeEndResponse { LoginToken = register.LoginToken, DeviceUuid = register.DeviceUuid, UserId = register.UserId }; // fake object
        File.WriteAllText("account.json", accountInfo.ToString());
    }
    else if (res.Contains("2"))
    {
        // link your existing account
        var bridge = await api.PostAuthMigrateBridgeStart(new PostAuthMigrateBridgeStartRequest { });
        Console.WriteLine("Login via opened browser : https://psg.sqex-bridge.jp/i18n/ntv/385/update/top?token=" + bridge.BackupToken + "&type=1&lang=en");
        Process.Start("explorer", "\"https://psg.sqex-bridge.jp/i18n/ntv/385/update/top?token=" + bridge.BackupToken + "&type=1&lang=en\"");
        Console.WriteLine("Press Enter after successful login");
        Console.ReadLine();
        var bridgeEnd = await api.PostAuthMigrateBridgeEnd(new PostAuthMigrateBridgeEndRequest { DeviceUuid = bridge.DeviceUuid, BackupToken = bridge.BackupToken });
        File.WriteAllText("account.json", bridgeEnd.ToString());
    }
}
{
    var accountInfo = PostAuthMigrateBridgeEndResponse.Parser.ParseJson(File.ReadAllText("account.json"));
    api = new ff7ecnet.API(accountInfo.UserId);
    api.http.DeviceId = Guid.Parse(accountInfo.DeviceUuid);
    // var r = await api.GetCheck(new GetCheckRequest { });
    var login = await api.PostAuthSession(new PostAuthSessionRequest { DeviceUuid = accountInfo.DeviceUuid.ToLower(), LoginToken = accountInfo.LoginToken });
    var title = await api.PostPvtUserTitle(new PostPvtUserTitleRequest { });
    Console.WriteLine(api.http.UserData);
}


async Task SearchUser(string userId) // the 13 digit alphanumeric code
{
    //var searchResult = await api.PostPvtUserSearch(new PostPvtUserSearchRequest { DisplayUserId = userId });
    var profileResult = await api.PostPvtProfileGet(new PostPvtProfileGetRequest { DisplayUserId = userId });
    Console.WriteLine(profileResult);
}

// example of getting announcements - note, auth isn't required for announcements only
async Task GetAnnouncements()
{
    var announcements = await api.PostAnnouncementList(new PostAnnouncementListRequest
    {
        AnnouncementTypeList = { new List<AnnouncementType> { AnnouncementType.Event, AnnouncementType.Gacha, AnnouncementType.Campaign, AnnouncementType.Sale, AnnouncementType.Info,
            AnnouncementType.Bug, AnnouncementType.Update, AnnouncementType.Maintenance, AnnouncementType.DataUpdate, AnnouncementType.ImportantInfo, AnnouncementType.Topic} },
        Limit = 2,
        Offset = 0
    });
    foreach (var announcement in announcements.AnnouncementSummaryList)
    {
        var detailedInfo = await api.PostAnnouncementDetail(new PostAnnouncementDetailRequest { Id = announcement.AnnouncementId });
        Console.WriteLine(announcement);
        Console.WriteLine(detailedInfo);
    }
}