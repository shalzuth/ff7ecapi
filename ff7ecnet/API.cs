using Api;
namespace ff7ecnet
{
    public class API
    {
        public Utils.HttpRequest http;
        public long userId;
        static string apiUrl = "https://game-q74z3cyn.app.gl.ffviiec.com";
        public API(long id)
        {
            userId = id;
            http = new Utils.HttpRequest();
        }
        public async Task<PostAnnouncementDetailResponse> PostAnnouncementDetail(PostAnnouncementDetailRequest request)
        {
            return await http.ApiRequestAsync<PostAnnouncementDetailResponse>(apiUrl + "/api/announcement/detail?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostAnnouncementListResponse> PostAnnouncementList(PostAnnouncementListRequest request)
        {
            return await http.ApiRequestAsync<PostAnnouncementListResponse>(apiUrl + "/api/announcement/list?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostAuthGameRegisterResponse> PostAuthGameRegister(PostAuthGameRegisterRequest request)
        {
            return await http.ApiRequestAsync<PostAuthGameRegisterResponse>(apiUrl + "/api/auth/game/register".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostAuthMigrateBridgeEndResponse> PostAuthMigrateBridgeEnd(PostAuthMigrateBridgeEndRequest request)
        {
            return await http.ApiRequestAsync<PostAuthMigrateBridgeEndResponse>(apiUrl + "/api/auth/migrate/bridge/end?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostAuthMigrateBridgeStartResponse> PostAuthMigrateBridgeStart(PostAuthMigrateBridgeStartRequest request)
        {
            return await http.ApiRequestAsync<PostAuthMigrateBridgeStartResponse>(apiUrl + "/api/auth/migrate/bridge/start?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostAuthSessionResponse> PostAuthSession(PostAuthSessionRequest request)
        {
            return await http.ApiRequestAsync<PostAuthSessionResponse>(apiUrl + "/api/auth/session?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<GetCheckResponse> GetCheck(GetCheckRequest request)
        {
            return await http.ApiRequestAsync<GetCheckResponse>(apiUrl + "/api/check?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostInquiryLogSendResponse> PostInquiryLogSend(PostInquiryLogSendRequest request)
        {
            return await http.ApiRequestAsync<PostInquiryLogSendResponse>(apiUrl + "/api/inquiry/log/send?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostMatchRoomMatchingRestartResponse> PostMatchRoomMatchingRestart(PostMatchRoomMatchingRestartRequest request)
        {
            return await http.ApiRequestAsync<PostMatchRoomMatchingRestartResponse>(apiUrl + "/api/match/room/matching/restart?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostMatchRoomMatchingStatsResponse> PostMatchRoomMatchingStats(PostMatchRoomMatchingStatsRequest request)
        {
            return await http.ApiRequestAsync<PostMatchRoomMatchingStatsResponse>(apiUrl + "/api/match/room/matching/stats?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostMatchRoomMatchingStatusResponse> PostMatchRoomMatchingStatus(PostMatchRoomMatchingStatusRequest request)
        {
            return await http.ApiRequestAsync<PostMatchRoomMatchingStatusResponse>(apiUrl + "/api/match/room/matching/status?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostMatchRoomPrivateSearchResponse> PostMatchRoomPrivateSearch(PostMatchRoomPrivateSearchRequest request)
        {
            return await http.ApiRequestAsync<PostMatchRoomPrivateSearchResponse>(apiUrl + "/api/match/room/private/search?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtAccessoryLockResponse> PostPvtAccessoryLock(PostPvtAccessoryLockRequest request)
        {
            return await http.ApiRequestAsync<PostPvtAccessoryLockResponse>(apiUrl + "/api/pvt/accessory/lock?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtAccessorySellResponse> PostPvtAccessorySell(PostPvtAccessorySellRequest request)
        {
            return await http.ApiRequestAsync<PostPvtAccessorySellResponse>(apiUrl + "/api/pvt/accessory/sell?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtAdvertisementResponse> PostPvtAdvertisement(PostPvtAdvertisementRequest request)
        {
            return await http.ApiRequestAsync<PostPvtAdvertisementResponse>(apiUrl + "/api/pvt/advertisement?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtAdvertisingSettingUpdateResponse> PostPvtAdvertisingSettingUpdate(PostPvtAdvertisingSettingUpdateRequest request)
        {
            return await http.ApiRequestAsync<PostPvtAdvertisingSettingUpdateResponse>(apiUrl + "/api/pvt/advertising/setting/update?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtAnotherBattleEndResponse> PostPvtAnotherBattleEnd(PostPvtAnotherBattleEndRequest request)
        {
            return await http.ApiRequestAsync<PostPvtAnotherBattleEndResponse>(apiUrl + "/api/pvt/another/battle/end?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtAnotherBattleStartResponse> PostPvtAnotherBattleStart(PostPvtAnotherBattleStartRequest request)
        {
            return await http.ApiRequestAsync<PostPvtAnotherBattleStartResponse>(apiUrl + "/api/pvt/another/battle/start?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtAreaMultiBattleContinueResponse> PostPvtAreaMultiBattleContinue(PostPvtAreaMultiBattleContinueRequest request)
        {
            return await http.ApiRequestAsync<PostPvtAreaMultiBattleContinueResponse>(apiUrl + "/api/pvt/area/multi/battle/continue?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtAreaMultiBattleEndResponse> PostPvtAreaMultiBattleEnd(PostPvtAreaMultiBattleEndRequest request)
        {
            return await http.ApiRequestAsync<PostPvtAreaMultiBattleEndResponse>(apiUrl + "/api/pvt/area/multi/battle/end?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtAreaMultiBattleStartResponse> PostPvtAreaMultiBattleStart(PostPvtAreaMultiBattleStartRequest request)
        {
            return await http.ApiRequestAsync<PostPvtAreaMultiBattleStartResponse>(apiUrl + "/api/pvt/area/multi/battle/start?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtAreaSoloBattleContinueResponse> PostPvtAreaSoloBattleContinue(PostPvtAreaSoloBattleContinueRequest request)
        {
            return await http.ApiRequestAsync<PostPvtAreaSoloBattleContinueResponse>(apiUrl + "/api/pvt/area/solo/battle/continue?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtAreaSoloBattleEndResponse> PostPvtAreaSoloBattleEnd(PostPvtAreaSoloBattleEndRequest request)
        {
            return await http.ApiRequestAsync<PostPvtAreaSoloBattleEndResponse>(apiUrl + "/api/pvt/area/solo/battle/end?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtAreaSoloBattleStartResponse> PostPvtAreaSoloBattleStart(PostPvtAreaSoloBattleStartRequest request)
        {
            return await http.ApiRequestAsync<PostPvtAreaSoloBattleStartResponse>(apiUrl + "/api/pvt/area/solo/battle/start?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtBattleDeleteResponse> PostPvtBattleDelete(PostPvtBattleDeleteRequest request)
        {
            return await http.ApiRequestAsync<PostPvtBattleDeleteResponse>(apiUrl + "/api/pvt/battle/delete?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtBattleRestartInfoResponse> PostPvtBattleRestartInfo(PostPvtBattleRestartInfoRequest request)
        {
            return await http.ApiRequestAsync<PostPvtBattleRestartInfoResponse>(apiUrl + "/api/pvt/battle/restart/info?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtBoxGachaDrawResponse> PostPvtBoxGachaDraw(PostPvtBoxGachaDrawRequest request)
        {
            return await http.ApiRequestAsync<PostPvtBoxGachaDrawResponse>(apiUrl + "/api/pvt/box/gacha/draw?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtBoxGachaRewardGroupUpdateResponse> PostPvtBoxGachaRewardGroupUpdate(PostPvtBoxGachaRewardGroupUpdateRequest request)
        {
            return await http.ApiRequestAsync<PostPvtBoxGachaRewardGroupUpdateResponse>(apiUrl + "/api/pvt/box/gacha/reward/group/update?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtBridgeBackupResponse> PostPvtBridgeBackup(PostPvtBridgeBackupRequest request)
        {
            return await http.ApiRequestAsync<PostPvtBridgeBackupResponse>(apiUrl + "/api/pvt/bridge/backup?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtCharacterGrowthBoardOpenResponse> PostPvtCharacterGrowthBoardOpen(PostPvtCharacterGrowthBoardOpenRequest request)
        {
            return await http.ApiRequestAsync<PostPvtCharacterGrowthBoardOpenResponse>(apiUrl + "/api/pvt/character/growth/board/open?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtCharacterStoryBattleEndResponse> PostPvtCharacterStoryBattleEnd(PostPvtCharacterStoryBattleEndRequest request)
        {
            return await http.ApiRequestAsync<PostPvtCharacterStoryBattleEndResponse>(apiUrl + "/api/pvt/character/story/battle/end?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtCharacterStoryBattleStartResponse> PostPvtCharacterStoryBattleStart(PostPvtCharacterStoryBattleStartRequest request)
        {
            return await http.ApiRequestAsync<PostPvtCharacterStoryBattleStartResponse>(apiUrl + "/api/pvt/character/story/battle/start?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtCharacterStoryResultResponse> PostPvtCharacterStoryResult(PostPvtCharacterStoryResultRequest request)
        {
            return await http.ApiRequestAsync<PostPvtCharacterStoryResultResponse>(apiUrl + "/api/pvt/character/story/result?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtChocoboExpeditionEditResponse> PostPvtChocoboExpeditionEdit(PostPvtChocoboExpeditionEditRequest request)
        {
            return await http.ApiRequestAsync<PostPvtChocoboExpeditionEditResponse>(apiUrl + "/api/pvt/chocobo/expedition/edit?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtChocoboExpeditionExtendResponse> PostPvtChocoboExpeditionExtend(PostPvtChocoboExpeditionExtendRequest request)
        {
            return await http.ApiRequestAsync<PostPvtChocoboExpeditionExtendResponse>(apiUrl + "/api/pvt/chocobo/expedition/extend?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtChocoboExpeditionResultResponse> PostPvtChocoboExpeditionResult(PostPvtChocoboExpeditionResultRequest request)
        {
            return await http.ApiRequestAsync<PostPvtChocoboExpeditionResultResponse>(apiUrl + "/api/pvt/chocobo/expedition/result?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtChocoboExpeditionShortenResponse> PostPvtChocoboExpeditionShorten(PostPvtChocoboExpeditionShortenRequest request)
        {
            return await http.ApiRequestAsync<PostPvtChocoboExpeditionShortenResponse>(apiUrl + "/api/pvt/chocobo/expedition/shorten?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtChocoboFarmDungeonTreasureResponse> PostPvtChocoboFarmDungeonTreasure(PostPvtChocoboFarmDungeonTreasureRequest request)
        {
            return await http.ApiRequestAsync<PostPvtChocoboFarmDungeonTreasureResponse>(apiUrl + "/api/pvt/chocobo/farm/dungeon/treasure?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtChocoboFeedResponse> PostPvtChocoboFeed(PostPvtChocoboFeedRequest request)
        {
            return await http.ApiRequestAsync<PostPvtChocoboFeedResponse>(apiUrl + "/api/pvt/chocobo/feed?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtChocoboLockResponse> PostPvtChocoboLock(PostPvtChocoboLockRequest request)
        {
            return await http.ApiRequestAsync<PostPvtChocoboLockResponse>(apiUrl + "/api/pvt/chocobo/lock?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtChocoboNameUpdateResponse> PostPvtChocoboNameUpdate(PostPvtChocoboNameUpdateRequest request)
        {
            return await http.ApiRequestAsync<PostPvtChocoboNameUpdateResponse>(apiUrl + "/api/pvt/chocobo/name/update?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtChocoboSellResponse> PostPvtChocoboSell(PostPvtChocoboSellRequest request)
        {
            return await http.ApiRequestAsync<PostPvtChocoboSellResponse>(apiUrl + "/api/pvt/chocobo/sell?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtCraftCancelResponse> PostPvtCraftCancel(PostPvtCraftCancelRequest request)
        {
            return await http.ApiRequestAsync<PostPvtCraftCancelResponse>(apiUrl + "/api/pvt/craft/cancel?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtCraftEndResponse> PostPvtCraftEnd(PostPvtCraftEndRequest request)
        {
            return await http.ApiRequestAsync<PostPvtCraftEndResponse>(apiUrl + "/api/pvt/craft/end?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtCraftShortenResponse> PostPvtCraftShorten(PostPvtCraftShortenRequest request)
        {
            return await http.ApiRequestAsync<PostPvtCraftShortenResponse>(apiUrl + "/api/pvt/craft/shorten?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtCraftStartResponse> PostPvtCraftStart(PostPvtCraftStartRequest request)
        {
            return await http.ApiRequestAsync<PostPvtCraftStartResponse>(apiUrl + "/api/pvt/craft/start?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtDailyQuestContinueResponse> PostPvtDailyQuestContinue(PostPvtDailyQuestContinueRequest request)
        {
            return await http.ApiRequestAsync<PostPvtDailyQuestContinueResponse>(apiUrl + "/api/pvt/daily/quest/continue?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtDailyQuestEndResponse> PostPvtDailyQuestEnd(PostPvtDailyQuestEndRequest request)
        {
            return await http.ApiRequestAsync<PostPvtDailyQuestEndResponse>(apiUrl + "/api/pvt/daily/quest/end?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtDailyQuestSettingResponse> PostPvtDailyQuestSetting(PostPvtDailyQuestSettingRequest request)
        {
            return await http.ApiRequestAsync<PostPvtDailyQuestSettingResponse>(apiUrl + "/api/pvt/daily/quest/setting?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtDailyQuestStartResponse> PostPvtDailyQuestStart(PostPvtDailyQuestStartRequest request)
        {
            return await http.ApiRequestAsync<PostPvtDailyQuestStartResponse>(apiUrl + "/api/pvt/daily/quest/start?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtDebugErrorResponse> PostPvtDebugError(PostPvtDebugErrorRequest request)
        {
            return await http.ApiRequestAsync<PostPvtDebugErrorResponse>(apiUrl + "/api/pvt/debug/error?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtDungeonAnotherBuffDebuffSelectResponse> PostPvtDungeonAnotherBuffDebuffSelect(PostPvtDungeonAnotherBuffDebuffSelectRequest request)
        {
            return await http.ApiRequestAsync<PostPvtDungeonAnotherBuffDebuffSelectResponse>(apiUrl + "/api/pvt/dungeon/another/buff/debuff/select?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtDungeonAnotherContinueResponse> PostPvtDungeonAnotherContinue(PostPvtDungeonAnotherContinueRequest request)
        {
            return await http.ApiRequestAsync<PostPvtDungeonAnotherContinueResponse>(apiUrl + "/api/pvt/dungeon/another/continue?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtDungeonAnotherEndResponse> PostPvtDungeonAnotherEnd(PostPvtDungeonAnotherEndRequest request)
        {
            return await http.ApiRequestAsync<PostPvtDungeonAnotherEndResponse>(apiUrl + "/api/pvt/dungeon/another/end?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtDungeonAnotherItemResponse> PostPvtDungeonAnotherItem(PostPvtDungeonAnotherItemRequest request)
        {
            return await http.ApiRequestAsync<PostPvtDungeonAnotherItemResponse>(apiUrl + "/api/pvt/dungeon/another/item?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtDungeonAnotherStartResponse> PostPvtDungeonAnotherStart(PostPvtDungeonAnotherStartRequest request)
        {
            return await http.ApiRequestAsync<PostPvtDungeonAnotherStartResponse>(apiUrl + "/api/pvt/dungeon/another/start?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtDungeonAnotherTreasureResponse> PostPvtDungeonAnotherTreasure(PostPvtDungeonAnotherTreasureRequest request)
        {
            return await http.ApiRequestAsync<PostPvtDungeonAnotherTreasureResponse>(apiUrl + "/api/pvt/dungeon/another/treasure?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtDungeonAnotherTriggerLockResponse> PostPvtDungeonAnotherTriggerLock(PostPvtDungeonAnotherTriggerLockRequest request)
        {
            return await http.ApiRequestAsync<PostPvtDungeonAnotherTriggerLockResponse>(apiUrl + "/api/pvt/dungeon/another/trigger/lock?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtDungeonDeleteResponse> PostPvtDungeonDelete(PostPvtDungeonDeleteRequest request)
        {
            return await http.ApiRequestAsync<PostPvtDungeonDeleteResponse>(apiUrl + "/api/pvt/dungeon/delete?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtDungeonLoadResponse> PostPvtDungeonLoad(PostPvtDungeonLoadRequest request)
        {
            return await http.ApiRequestAsync<PostPvtDungeonLoadResponse>(apiUrl + "/api/pvt/dungeon/load?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtDungeonSaveResponse> PostPvtDungeonSave(PostPvtDungeonSaveRequest request)
        {
            return await http.ApiRequestAsync<PostPvtDungeonSaveResponse>(apiUrl + "/api/pvt/dungeon/save?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtDungeonSelectDramaResponse> PostPvtDungeonSelectDrama(PostPvtDungeonSelectDramaRequest request)
        {
            return await http.ApiRequestAsync<PostPvtDungeonSelectDramaResponse>(apiUrl + "/api/pvt/dungeon/select/drama?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtDungeonStoryEndResponse> PostPvtDungeonStoryEnd(PostPvtDungeonStoryEndRequest request)
        {
            return await http.ApiRequestAsync<PostPvtDungeonStoryEndResponse>(apiUrl + "/api/pvt/dungeon/story/end?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtDungeonStoryRestartResponse> PostPvtDungeonStoryRestart(PostPvtDungeonStoryRestartRequest request)
        {
            return await http.ApiRequestAsync<PostPvtDungeonStoryRestartResponse>(apiUrl + "/api/pvt/dungeon/story/restart?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtDungeonStoryStartResponse> PostPvtDungeonStoryStart(PostPvtDungeonStoryStartRequest request)
        {
            return await http.ApiRequestAsync<PostPvtDungeonStoryStartResponse>(apiUrl + "/api/pvt/dungeon/story/start?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtDungeonStoryTreasureResponse> PostPvtDungeonStoryTreasure(PostPvtDungeonStoryTreasureRequest request)
        {
            return await http.ApiRequestAsync<PostPvtDungeonStoryTreasureResponse>(apiUrl + "/api/pvt/dungeon/story/treasure?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtDungeonStoryTriggerLockResponse> PostPvtDungeonStoryTriggerLock(PostPvtDungeonStoryTriggerLockRequest request)
        {
            return await http.ApiRequestAsync<PostPvtDungeonStoryTriggerLockResponse>(apiUrl + "/api/pvt/dungeon/story/trigger/lock?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtEventClashClearHigherListResponse> PostPvtEventClashClearHigherList(PostPvtEventClashClearHigherListRequest request)
        {
            return await http.ApiRequestAsync<PostPvtEventClashClearHigherListResponse>(apiUrl + "/api/pvt/event/clash/clear/higher/list?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtEventClashClearListResponse> PostPvtEventClashClearList(PostPvtEventClashClearListRequest request)
        {
            return await http.ApiRequestAsync<PostPvtEventClashClearListResponse>(apiUrl + "/api/pvt/event/clash/clear/list?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtEventMultiBattleContinueResponse> PostPvtEventMultiBattleContinue(PostPvtEventMultiBattleContinueRequest request)
        {
            return await http.ApiRequestAsync<PostPvtEventMultiBattleContinueResponse>(apiUrl + "/api/pvt/event/multi/battle/continue?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtEventMultiBattleEndResponse> PostPvtEventMultiBattleEnd(PostPvtEventMultiBattleEndRequest request)
        {
            return await http.ApiRequestAsync<PostPvtEventMultiBattleEndResponse>(apiUrl + "/api/pvt/event/multi/battle/end?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtEventMultiBattleStartResponse> PostPvtEventMultiBattleStart(PostPvtEventMultiBattleStartRequest request)
        {
            return await http.ApiRequestAsync<PostPvtEventMultiBattleStartResponse>(apiUrl + "/api/pvt/event/multi/battle/start?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtEventScenarioResultResponse> PostPvtEventScenarioResult(PostPvtEventScenarioResultRequest request)
        {
            return await http.ApiRequestAsync<PostPvtEventScenarioResultResponse>(apiUrl + "/api/pvt/event/scenario/result?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtEventScoreDungeonAnotherBuffDebuffSelectResponse> PostPvtEventScoreDungeonAnotherBuffDebuffSelect(PostPvtEventScoreDungeonAnotherBuffDebuffSelectRequest request)
        {
            return await http.ApiRequestAsync<PostPvtEventScoreDungeonAnotherBuffDebuffSelectResponse>(apiUrl + "/api/pvt/event/score/dungeon/another/buff/debuff/select?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtEventScoreDungeonAnotherItemResponse> PostPvtEventScoreDungeonAnotherItem(PostPvtEventScoreDungeonAnotherItemRequest request)
        {
            return await http.ApiRequestAsync<PostPvtEventScoreDungeonAnotherItemResponse>(apiUrl + "/api/pvt/event/score/dungeon/another/item?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtEventScoreDungeonAnotherTreasureResponse> PostPvtEventScoreDungeonAnotherTreasure(PostPvtEventScoreDungeonAnotherTreasureRequest request)
        {
            return await http.ApiRequestAsync<PostPvtEventScoreDungeonAnotherTreasureResponse>(apiUrl + "/api/pvt/event/score/dungeon/another/treasure?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtEventScoreDungeonAnotherTriggerLockResponse> PostPvtEventScoreDungeonAnotherTriggerLock(PostPvtEventScoreDungeonAnotherTriggerLockRequest request)
        {
            return await http.ApiRequestAsync<PostPvtEventScoreDungeonAnotherTriggerLockResponse>(apiUrl + "/api/pvt/event/score/dungeon/another/trigger/lock?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtEventScoreDungeonBattleEndResponse> PostPvtEventScoreDungeonBattleEnd(PostPvtEventScoreDungeonBattleEndRequest request)
        {
            return await http.ApiRequestAsync<PostPvtEventScoreDungeonBattleEndResponse>(apiUrl + "/api/pvt/event/score/dungeon/battle/end?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtEventScoreDungeonBattleStartResponse> PostPvtEventScoreDungeonBattleStart(PostPvtEventScoreDungeonBattleStartRequest request)
        {
            return await http.ApiRequestAsync<PostPvtEventScoreDungeonBattleStartResponse>(apiUrl + "/api/pvt/event/score/dungeon/battle/start?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtEventScoreDungeonCurrentRankResponse> PostPvtEventScoreDungeonCurrentRank(PostPvtEventScoreDungeonCurrentRankRequest request)
        {
            return await http.ApiRequestAsync<PostPvtEventScoreDungeonCurrentRankResponse>(apiUrl + "/api/pvt/event/score/dungeon/current/rank?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtEventScoreDungeonEndResponse> PostPvtEventScoreDungeonEnd(PostPvtEventScoreDungeonEndRequest request)
        {
            return await http.ApiRequestAsync<PostPvtEventScoreDungeonEndResponse>(apiUrl + "/api/pvt/event/score/dungeon/end?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtEventScoreDungeonFriendRankingResponse> PostPvtEventScoreDungeonFriendRanking(PostPvtEventScoreDungeonFriendRankingRequest request)
        {
            return await http.ApiRequestAsync<PostPvtEventScoreDungeonFriendRankingResponse>(apiUrl + "/api/pvt/event/score/dungeon/friend/ranking?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtEventScoreDungeonGroupRankingResponse> PostPvtEventScoreDungeonGroupRanking(PostPvtEventScoreDungeonGroupRankingRequest request)
        {
            return await http.ApiRequestAsync<PostPvtEventScoreDungeonGroupRankingResponse>(apiUrl + "/api/pvt/event/score/dungeon/group/ranking?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtEventScoreDungeonRankingRewardReceiveResponse> PostPvtEventScoreDungeonRankingRewardReceive(PostPvtEventScoreDungeonRankingRewardReceiveRequest request)
        {
            return await http.ApiRequestAsync<PostPvtEventScoreDungeonRankingRewardReceiveResponse>(apiUrl + "/api/pvt/event/score/dungeon/ranking/reward/receive?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtEventScoreDungeonScoreGetResponse> PostPvtEventScoreDungeonScoreGet(PostPvtEventScoreDungeonScoreGetRequest request)
        {
            return await http.ApiRequestAsync<PostPvtEventScoreDungeonScoreGetResponse>(apiUrl + "/api/pvt/event/score/dungeon/score/get?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtEventScoreDungeonScoreRewardReceiveResponse> PostPvtEventScoreDungeonScoreRewardReceive(PostPvtEventScoreDungeonScoreRewardReceiveRequest request)
        {
            return await http.ApiRequestAsync<PostPvtEventScoreDungeonScoreRewardReceiveResponse>(apiUrl + "/api/pvt/event/score/dungeon/score/reward/receive?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtEventScoreDungeonStartResponse> PostPvtEventScoreDungeonStart(PostPvtEventScoreDungeonStartRequest request)
        {
            return await http.ApiRequestAsync<PostPvtEventScoreDungeonStartResponse>(apiUrl + "/api/pvt/event/score/dungeon/start?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtEventSelectDramaResponse> PostPvtEventSelectDrama(PostPvtEventSelectDramaRequest request)
        {
            return await http.ApiRequestAsync<PostPvtEventSelectDramaResponse>(apiUrl + "/api/pvt/event/select/drama?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtEventSoloBattleContinueResponse> PostPvtEventSoloBattleContinue(PostPvtEventSoloBattleContinueRequest request)
        {
            return await http.ApiRequestAsync<PostPvtEventSoloBattleContinueResponse>(apiUrl + "/api/pvt/event/solo/battle/continue?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtEventSoloBattleEndResponse> PostPvtEventSoloBattleEnd(PostPvtEventSoloBattleEndRequest request)
        {
            return await http.ApiRequestAsync<PostPvtEventSoloBattleEndResponse>(apiUrl + "/api/pvt/event/solo/battle/end?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtEventSoloBattleStartResponse> PostPvtEventSoloBattleStart(PostPvtEventSoloBattleStartRequest request)
        {
            return await http.ApiRequestAsync<PostPvtEventSoloBattleStartResponse>(apiUrl + "/api/pvt/event/solo/battle/start?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtFriendApproveResponse> PostPvtFriendApprove(PostPvtFriendApproveRequest request)
        {
            return await http.ApiRequestAsync<PostPvtFriendApproveResponse>(apiUrl + "/api/pvt/friend/approve?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtFriendCancelResponse> PostPvtFriendCancel(PostPvtFriendCancelRequest request)
        {
            return await http.ApiRequestAsync<PostPvtFriendCancelResponse>(apiUrl + "/api/pvt/friend/cancel?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtFriendDissolveResponse> PostPvtFriendDissolve(PostPvtFriendDissolveRequest request)
        {
            return await http.ApiRequestAsync<PostPvtFriendDissolveResponse>(apiUrl + "/api/pvt/friend/dissolve?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtFriendListResponse> PostPvtFriendList(PostPvtFriendListRequest request)
        {
            return await http.ApiRequestAsync<PostPvtFriendListResponse>(apiUrl + "/api/pvt/friend/list?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtFriendReceiveListResponse> PostPvtFriendReceiveList(PostPvtFriendReceiveListRequest request)
        {
            return await http.ApiRequestAsync<PostPvtFriendReceiveListResponse>(apiUrl + "/api/pvt/friend/receive/list?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtFriendRejectResponse> PostPvtFriendReject(PostPvtFriendRejectRequest request)
        {
            return await http.ApiRequestAsync<PostPvtFriendRejectResponse>(apiUrl + "/api/pvt/friend/reject?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtFriendRequestResponse> PostPvtFriend(PostPvtFriendRequestRequest request)
        {
            return await http.ApiRequestAsync<PostPvtFriendRequestResponse>(apiUrl + "/api/pvt/friend/request?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtFriendRequestListResponse> PostPvtFriendList(PostPvtFriendRequestListRequest request)
        {
            return await http.ApiRequestAsync<PostPvtFriendRequestListResponse>(apiUrl + "/api/pvt/friend/request/list?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtGachaDrawResponse> PostPvtGachaDraw(PostPvtGachaDrawRequest request)
        {
            return await http.ApiRequestAsync<PostPvtGachaDrawResponse>(apiUrl + "/api/pvt/gacha/draw?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtGachaStampSheetChoiceResponse> PostPvtGachaStampSheetChoice(PostPvtGachaStampSheetChoiceRequest request)
        {
            return await http.ApiRequestAsync<PostPvtGachaStampSheetChoiceResponse>(apiUrl + "/api/pvt/gacha/stamp/sheet/choice?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtGachaWishChoiceResponse> PostPvtGachaWishChoice(PostPvtGachaWishChoiceRequest request)
        {
            return await http.ApiRequestAsync<PostPvtGachaWishChoiceResponse>(apiUrl + "/api/pvt/gacha/wish/choice?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtGiftHistoryResponse> PostPvtGiftHistory(PostPvtGiftHistoryRequest request)
        {
            return await http.ApiRequestAsync<PostPvtGiftHistoryResponse>(apiUrl + "/api/pvt/gift/history?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtGiftListResponse> PostPvtGiftList(PostPvtGiftListRequest request)
        {
            return await http.ApiRequestAsync<PostPvtGiftListResponse>(apiUrl + "/api/pvt/gift/list?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtGiftOpenResponse> PostPvtGiftOpen(PostPvtGiftOpenRequest request)
        {
            return await http.ApiRequestAsync<PostPvtGiftOpenResponse>(apiUrl + "/api/pvt/gift/open?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtHonorSettingResponse> PostPvtHonorSetting(PostPvtHonorSettingRequest request)
        {
            return await http.ApiRequestAsync<PostPvtHonorSettingResponse>(apiUrl + "/api/pvt/honor/setting?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtLimitedReleaseStartResponse> PostPvtLimitedReleaseStart(PostPvtLimitedReleaseStartRequest request)
        {
            return await http.ApiRequestAsync<PostPvtLimitedReleaseStartResponse>(apiUrl + "/api/pvt/limited/release/start?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtLoginBonusResponse> PostPvtLoginBonus(PostPvtLoginBonusRequest request)
        {
            return await http.ApiRequestAsync<PostPvtLoginBonusResponse>(apiUrl + "/api/pvt/login/bonus?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtLogSendResponse> PostPvtLogSend(PostPvtLogSendRequest request)
        {
            return await http.ApiRequestAsync<PostPvtLogSendResponse>(apiUrl + "/api/pvt/log/send?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtMatchSessionResponse> PostPvtMatchSession(PostPvtMatchSessionRequest request)
        {
            return await http.ApiRequestAsync<PostPvtMatchSessionResponse>(apiUrl + "/api/pvt/match/session?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtMateriaEnhanceResponse> PostPvtMateriaEnhance(PostPvtMateriaEnhanceRequest request)
        {
            return await http.ApiRequestAsync<PostPvtMateriaEnhanceResponse>(apiUrl + "/api/pvt/materia/enhance?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtMateriaEvolveResponse> PostPvtMateriaEvolve(PostPvtMateriaEvolveRequest request)
        {
            return await http.ApiRequestAsync<PostPvtMateriaEvolveResponse>(apiUrl + "/api/pvt/materia/evolve?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtMateriaLockResponse> PostPvtMateriaLock(PostPvtMateriaLockRequest request)
        {
            return await http.ApiRequestAsync<PostPvtMateriaLockResponse>(apiUrl + "/api/pvt/materia/lock?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtMateriaSellResponse> PostPvtMateriaSell(PostPvtMateriaSellRequest request)
        {
            return await http.ApiRequestAsync<PostPvtMateriaSellResponse>(apiUrl + "/api/pvt/materia/sell?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtMissionProgressResponse> PostPvtMissionProgress(PostPvtMissionProgressRequest request)
        {
            return await http.ApiRequestAsync<PostPvtMissionProgressResponse>(apiUrl + "/api/pvt/mission/progress?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtMissionReceiveResponse> PostPvtMissionReceive(PostPvtMissionReceiveRequest request)
        {
            return await http.ApiRequestAsync<PostPvtMissionReceiveResponse>(apiUrl + "/api/pvt/mission/receive?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtMissionSpecialChangeResponse> PostPvtMissionSpecialChange(PostPvtMissionSpecialChangeRequest request)
        {
            return await http.ApiRequestAsync<PostPvtMissionSpecialChangeResponse>(apiUrl + "/api/pvt/mission/special/change?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtMissionSpecialReceiveResponse> PostPvtMissionSpecialReceive(PostPvtMissionSpecialReceiveRequest request)
        {
            return await http.ApiRequestAsync<PostPvtMissionSpecialReceiveResponse>(apiUrl + "/api/pvt/mission/special/receive?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtMissionSupplyResponse> PostPvtMissionSupply(PostPvtMissionSupplyRequest request)
        {
            return await http.ApiRequestAsync<PostPvtMissionSupplyResponse>(apiUrl + "/api/pvt/mission/supply?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtNoticeCheckResponse> PostPvtNoticeCheck(PostPvtNoticeCheckRequest request)
        {
            return await http.ApiRequestAsync<PostPvtNoticeCheckResponse>(apiUrl + "/api/pvt/notice/check?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtPartyMultiSetUpsertResponse> PostPvtPartyMultiSetUpsert(PostPvtPartyMultiSetUpsertRequest request)
        {
            return await http.ApiRequestAsync<PostPvtPartyMultiSetUpsertResponse>(apiUrl + "/api/pvt/party/multi/set/upsert?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtPartySoloSetUpsertResponse> PostPvtPartySoloSetUpsert(PostPvtPartySoloSetUpsertRequest request)
        {
            return await http.ApiRequestAsync<PostPvtPartySoloSetUpsertResponse>(apiUrl + "/api/pvt/party/solo/set/upsert?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtProfileGetResponse> PostPvtProfileGet(PostPvtProfileGetRequest request)
        {
            return await http.ApiRequestAsync<PostPvtProfileGetResponse>(apiUrl + "/api/pvt/profile/get?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtProfileUpdateResponse> PostPvtProfileUpdate(PostPvtProfileUpdateRequest request)
        {
            return await http.ApiRequestAsync<PostPvtProfileUpdateResponse>(apiUrl + "/api/pvt/profile/update?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtRecoveryItemResponse> PostPvtRecoveryItem(PostPvtRecoveryItemRequest request)
        {
            return await http.ApiRequestAsync<PostPvtRecoveryItemResponse>(apiUrl + "/api/pvt/recovery/item?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtRecoveryStoneResponse> PostPvtRecoveryStone(PostPvtRecoveryStoneRequest request)
        {
            return await http.ApiRequestAsync<PostPvtRecoveryStoneResponse>(apiUrl + "/api/pvt/recovery/stone?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtRoomMatchingCancelResponse> PostPvtRoomMatchingCancel(PostPvtRoomMatchingCancelRequest request)
        {
            return await http.ApiRequestAsync<PostPvtRoomMatchingCancelResponse>(apiUrl + "/api/pvt/room/matching/cancel?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtRoomMatchingStartResponse> PostPvtRoomMatchingStart(PostPvtRoomMatchingStartRequest request)
        {
            return await http.ApiRequestAsync<PostPvtRoomMatchingStartResponse>(apiUrl + "/api/pvt/room/matching/start?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtRoomPrivateCreateResponse> PostPvtRoomPrivateCreate(PostPvtRoomPrivateCreateRequest request)
        {
            return await http.ApiRequestAsync<PostPvtRoomPrivateCreateResponse>(apiUrl + "/api/pvt/room/private/create?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtRoomPrivateEnterResponse> PostPvtRoomPrivateEnter(PostPvtRoomPrivateEnterRequest request)
        {
            return await http.ApiRequestAsync<PostPvtRoomPrivateEnterResponse>(apiUrl + "/api/pvt/room/private/enter?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtRoomPrivateInviteApproveResponse> PostPvtRoomPrivateInviteApprove(PostPvtRoomPrivateInviteApproveRequest request)
        {
            return await http.ApiRequestAsync<PostPvtRoomPrivateInviteApproveResponse>(apiUrl + "/api/pvt/room/private/invite/approve?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtRoomPrivateInviteReceiveListResponse> PostPvtRoomPrivateInviteReceiveList(PostPvtRoomPrivateInviteReceiveListRequest request)
        {
            return await http.ApiRequestAsync<PostPvtRoomPrivateInviteReceiveListResponse>(apiUrl + "/api/pvt/room/private/invite/receive/list?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtRoomPrivateInviteSendResponse> PostPvtRoomPrivateInviteSend(PostPvtRoomPrivateInviteSendRequest request)
        {
            return await http.ApiRequestAsync<PostPvtRoomPrivateInviteSendResponse>(apiUrl + "/api/pvt/room/private/invite/send?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtRoomPrivateInviteTargetListResponse> PostPvtRoomPrivateInviteTargetList(PostPvtRoomPrivateInviteTargetListRequest request)
        {
            return await http.ApiRequestAsync<PostPvtRoomPrivateInviteTargetListResponse>(apiUrl + "/api/pvt/room/private/invite/target/list?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtRoomSoloCreateResponse> PostPvtRoomSoloCreate(PostPvtRoomSoloCreateRequest request)
        {
            return await http.ApiRequestAsync<PostPvtRoomSoloCreateResponse>(apiUrl + "/api/pvt/room/solo/create?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtSeasonPassReceiveResponse> PostPvtSeasonPassReceive(PostPvtSeasonPassReceiveRequest request)
        {
            return await http.ApiRequestAsync<PostPvtSeasonPassReceiveResponse>(apiUrl + "/api/pvt/season/pass/receive?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtShopExchangeResponse> PostPvtShopExchange(PostPvtShopExchangeRequest request)
        {
            return await http.ApiRequestAsync<PostPvtShopExchangeResponse>(apiUrl + "/api/pvt/shop/exchange?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtShopExtendAccessoryResponse> PostPvtShopExtendAccessory(PostPvtShopExtendAccessoryRequest request)
        {
            return await http.ApiRequestAsync<PostPvtShopExtendAccessoryResponse>(apiUrl + "/api/pvt/shop/extend/accessory?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtShopExtendChocoboResponse> PostPvtShopExtendChocobo(PostPvtShopExtendChocoboRequest request)
        {
            return await http.ApiRequestAsync<PostPvtShopExtendChocoboResponse>(apiUrl + "/api/pvt/shop/extend/chocobo?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtShopExtendCraftResponse> PostPvtShopExtendCraft(PostPvtShopExtendCraftRequest request)
        {
            return await http.ApiRequestAsync<PostPvtShopExtendCraftResponse>(apiUrl + "/api/pvt/shop/extend/craft?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtShopExtendMateriaResponse> PostPvtShopExtendMateria(PostPvtShopExtendMateriaRequest request)
        {
            return await http.ApiRequestAsync<PostPvtShopExtendMateriaResponse>(apiUrl + "/api/pvt/shop/extend/materia?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtShopResetCheckResponse> PostPvtShopResetCheck(PostPvtShopResetCheckRequest request)
        {
            return await http.ApiRequestAsync<PostPvtShopResetCheckResponse>(apiUrl + "/api/pvt/shop/reset/check?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtShopResetLineupResponse> PostPvtShopResetLineup(PostPvtShopResetLineupRequest request)
        {
            return await http.ApiRequestAsync<PostPvtShopResetLineupResponse>(apiUrl + "/api/pvt/shop/reset/lineup?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtSteamAchievementResponse> PostPvtSteamAchievement(PostPvtSteamAchievementRequest request)
        {
            return await http.ApiRequestAsync<PostPvtSteamAchievementResponse>(apiUrl + "/api/pvt/steam/achievement?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtStorePeopleUpdateResponse> PostPvtStorePeopleUpdate(PostPvtStorePeopleUpdateRequest request)
        {
            return await http.ApiRequestAsync<PostPvtStorePeopleUpdateResponse>(apiUrl + "/api/pvt/store/people/update?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtStorePurchaseAndroidUpdateResponse> PostPvtStorePurchaseAndroidUpdate(PostPvtStorePurchaseAndroidUpdateRequest request)
        {
            return await http.ApiRequestAsync<PostPvtStorePurchaseAndroidUpdateResponse>(apiUrl + "/api/pvt/store/purchase/android/update?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtStorePurchaseIosUpdateResponse> PostPvtStorePurchaseIosUpdate(PostPvtStorePurchaseIosUpdateRequest request)
        {
            return await http.ApiRequestAsync<PostPvtStorePurchaseIosUpdateResponse>(apiUrl + "/api/pvt/store/purchase/ios/update?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtStorePurchaseRestartResponse> PostPvtStorePurchaseRestart(PostPvtStorePurchaseRestartRequest request)
        {
            return await http.ApiRequestAsync<PostPvtStorePurchaseRestartResponse>(apiUrl + "/api/pvt/store/purchase/restart?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtStorePurchaseRestartSteamResponse> PostPvtStorePurchaseRestartSteam(PostPvtStorePurchaseRestartSteamRequest request)
        {
            return await http.ApiRequestAsync<PostPvtStorePurchaseRestartSteamResponse>(apiUrl + "/api/pvt/store/purchase/restart/steam?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtStorePurchaseStartResponse> PostPvtStorePurchaseStart(PostPvtStorePurchaseStartRequest request)
        {
            return await http.ApiRequestAsync<PostPvtStorePurchaseStartResponse>(apiUrl + "/api/pvt/store/purchase/start?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtStorePurchaseStartSteamResponse> PostPvtStorePurchaseStartSteam(PostPvtStorePurchaseStartSteamRequest request)
        {
            return await http.ApiRequestAsync<PostPvtStorePurchaseStartSteamResponse>(apiUrl + "/api/pvt/store/purchase/start/steam?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtStorePurchaseSteamUpdateResponse> PostPvtStorePurchaseSteamUpdate(PostPvtStorePurchaseSteamUpdateRequest request)
        {
            return await http.ApiRequestAsync<PostPvtStorePurchaseSteamUpdateResponse>(apiUrl + "/api/pvt/store/purchase/steam/update?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtStoryBattleEndResponse> PostPvtStoryBattleEnd(PostPvtStoryBattleEndRequest request)
        {
            return await http.ApiRequestAsync<PostPvtStoryBattleEndResponse>(apiUrl + "/api/pvt/story/battle/end?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtStoryBattleStartResponse> PostPvtStoryBattleStart(PostPvtStoryBattleStartRequest request)
        {
            return await http.ApiRequestAsync<PostPvtStoryBattleStartResponse>(apiUrl + "/api/pvt/story/battle/start?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtStoryResultResponse> PostPvtStoryResult(PostPvtStoryResultRequest request)
        {
            return await http.ApiRequestAsync<PostPvtStoryResultResponse>(apiUrl + "/api/pvt/story/result?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtStorySelectDramaResponse> PostPvtStorySelectDrama(PostPvtStorySelectDramaRequest request)
        {
            return await http.ApiRequestAsync<PostPvtStorySelectDramaResponse>(apiUrl + "/api/pvt/story/select/drama?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtTowerBattleContinueResponse> PostPvtTowerBattleContinue(PostPvtTowerBattleContinueRequest request)
        {
            return await http.ApiRequestAsync<PostPvtTowerBattleContinueResponse>(apiUrl + "/api/pvt/tower/battle/continue?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtTowerBattleEndResponse> PostPvtTowerBattleEnd(PostPvtTowerBattleEndRequest request)
        {
            return await http.ApiRequestAsync<PostPvtTowerBattleEndResponse>(apiUrl + "/api/pvt/tower/battle/end?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtTowerBattleStartResponse> PostPvtTowerBattleStart(PostPvtTowerBattleStartRequest request)
        {
            return await http.ApiRequestAsync<PostPvtTowerBattleStartResponse>(apiUrl + "/api/pvt/tower/battle/start?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtTutorialDungeonStoryEndResponse> PostPvtTutorialDungeonStoryEnd(PostPvtTutorialDungeonStoryEndRequest request)
        {
            return await http.ApiRequestAsync<PostPvtTutorialDungeonStoryEndResponse>(apiUrl + "/api/pvt/tutorial/dungeon/story/end?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtTutorialDungeonStoryStartResponse> PostPvtTutorialDungeonStoryStart(PostPvtTutorialDungeonStoryStartRequest request)
        {
            return await http.ApiRequestAsync<PostPvtTutorialDungeonStoryStartResponse>(apiUrl + "/api/pvt/tutorial/dungeon/story/start?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtTutorialDungeonStoryTreasureResponse> PostPvtTutorialDungeonStoryTreasure(PostPvtTutorialDungeonStoryTreasureRequest request)
        {
            return await http.ApiRequestAsync<PostPvtTutorialDungeonStoryTreasureResponse>(apiUrl + "/api/pvt/tutorial/dungeon/story/treasure?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtTutorialGachaDrawResponse> PostPvtTutorialGachaDraw(PostPvtTutorialGachaDrawRequest request)
        {
            return await http.ApiRequestAsync<PostPvtTutorialGachaDrawResponse>(apiUrl + "/api/pvt/tutorial/gacha/draw?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtTutorialProgressStepResponse> PostPvtTutorialProgressStep(PostPvtTutorialProgressStepRequest request)
        {
            return await http.ApiRequestAsync<PostPvtTutorialProgressStepResponse>(apiUrl + "/api/pvt/tutorial/progress/step?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtTutorialRegisterUserNameResponse> PostPvtTutorialRegisterUserName(PostPvtTutorialRegisterUserNameRequest request)
        {
            return await http.ApiRequestAsync<PostPvtTutorialRegisterUserNameResponse>(apiUrl + "/api/pvt/tutorial/register/user/name?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtTutorialSkipResponse> PostPvtTutorialSkip(PostPvtTutorialSkipRequest request)
        {
            return await http.ApiRequestAsync<PostPvtTutorialSkipResponse>(apiUrl + "/api/pvt/tutorial/skip?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtTutorialStoryBattleEndResponse> PostPvtTutorialStoryBattleEnd(PostPvtTutorialStoryBattleEndRequest request)
        {
            return await http.ApiRequestAsync<PostPvtTutorialStoryBattleEndResponse>(apiUrl + "/api/pvt/tutorial/story/battle/end?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtTutorialStoryBattleStartResponse> PostPvtTutorialStoryBattleStart(PostPvtTutorialStoryBattleStartRequest request)
        {
            return await http.ApiRequestAsync<PostPvtTutorialStoryBattleStartResponse>(apiUrl + "/api/pvt/tutorial/story/battle/start?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtTutorialStoryResultResponse> PostPvtTutorialStoryResult(PostPvtTutorialStoryResultRequest request)
        {
            return await http.ApiRequestAsync<PostPvtTutorialStoryResultResponse>(apiUrl + "/api/pvt/tutorial/story/result?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtTutorialStorySelectDramaResponse> PostPvtTutorialStorySelectDrama(PostPvtTutorialStorySelectDramaRequest request)
        {
            return await http.ApiRequestAsync<PostPvtTutorialStorySelectDramaResponse>(apiUrl + "/api/pvt/tutorial/story/select/drama?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtUserHomeBackgroundSettingResponse> PostPvtUserHomeBackgroundSetting(PostPvtUserHomeBackgroundSettingRequest request)
        {
            return await http.ApiRequestAsync<PostPvtUserHomeBackgroundSettingResponse>(apiUrl + "/api/pvt/user/home/background/setting?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtUserSearchResponse> PostPvtUserSearch(PostPvtUserSearchRequest request)
        {
            return await http.ApiRequestAsync<PostPvtUserSearchResponse>(apiUrl + "/api/pvt/user/search?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtUserSettingResponse> PostPvtUserSetting(PostPvtUserSettingRequest request)
        {
            return await http.ApiRequestAsync<PostPvtUserSettingResponse>(apiUrl + "/api/pvt/user/setting?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtUserTitleResponse> PostPvtUserTitle(PostPvtUserTitleRequest request)
        {
            return await http.ApiRequestAsync<PostPvtUserTitleResponse>(apiUrl + "/api/pvt/user/title?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtWeaponEnhanceResponse> PostPvtWeaponEnhance(PostPvtWeaponEnhanceRequest request)
        {
            return await http.ApiRequestAsync<PostPvtWeaponEnhanceResponse>(apiUrl + "/api/pvt/weapon/enhance?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtWeaponMedalExchangeResponse> PostPvtWeaponMedalExchange(PostPvtWeaponMedalExchangeRequest request)
        {
            return await http.ApiRequestAsync<PostPvtWeaponMedalExchangeResponse>(apiUrl + "/api/pvt/weapon/medal/exchange?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtWeaponRarityUpResponse> PostPvtWeaponRarityUp(PostPvtWeaponRarityUpRequest request)
        {
            return await http.ApiRequestAsync<PostPvtWeaponRarityUpResponse>(apiUrl + "/api/pvt/weapon/rarity/up?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtWeaponReleaseResponse> PostPvtWeaponRelease(PostPvtWeaponReleaseRequest request)
        {
            return await http.ApiRequestAsync<PostPvtWeaponReleaseResponse>(apiUrl + "/api/pvt/weapon/release?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtWeaponStockExchangeResponse> PostPvtWeaponStockExchange(PostPvtWeaponStockExchangeRequest request)
        {
            return await http.ApiRequestAsync<PostPvtWeaponStockExchangeResponse>(apiUrl + "/api/pvt/weapon/stock/exchange?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostPvtWeaponUpgradeResponse> PostPvtWeaponUpgrade(PostPvtWeaponUpgradeRequest request)
        {
            return await http.ApiRequestAsync<PostPvtWeaponUpgradeResponse>(apiUrl + "/api/pvt/weapon/upgrade?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
        public async Task<PostSerialRegisterResponse> PostSerialRegister(PostSerialRegisterRequest request)
        {
            return await http.ApiRequestAsync<PostSerialRegisterResponse>(apiUrl + "/api/serial/register?user_id={0}".Replace("{0}",userId.ToString()), request);
        }
    }
}
