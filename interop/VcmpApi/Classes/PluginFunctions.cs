using System;
using System.Runtime.InteropServices;

namespace Fleka.DotnetVcmp.Interop {
    [StructLayout(LayoutKind.Sequential, CharSet=CharSet.Ansi)]
    public sealed class PluginFunctions {
        private uint StructSize;

        public GetServerVersionDelegate GetServerVersion;
        public GetServerSettingsDelegate GetServerSettings;
        public ExportFunctionsDelegate ExportFunctions;
        public GetNumberOfPluginsDelegate GetNumberOfPlugins;
        public GetPluginInfoDelegate GetPluginInfo;
        public FindPluginDelegate FindPlugin;
        public GetPluginExportsDelegate GetPluginExports;
        public SendPluginCommandDelegate SendPluginCommand;
        public GetTimeDelegate GetTime;
        public LogMessageDelegate LogMessage;
        public GetLastErrorDelegate GetLastError;

        public SendClientScriptDataDelegate SendClientScriptData;
        public SendClientMessageDelegate SendClientMessage;
        public SendGameMessageDelegate SendGameMessage;

        public SetServerNameDelegate SetServerName;
        public GetServerNameDelegate GetServerName;
        public SetMaxPlayersDelegate SetMaxPlayers;
        public GetMaxPlayersDelegate GetMaxPlayers;
        public SetServerPasswordDelegate SetServerPassword;
        public GetServerPasswordDelegate GetServerPassword;
        public SetGameModeTextDelegate SetGameModeText;
        public GetGameModeTextDelegate GetGameModeText;
        public ShutdownServerDelegate ShutdownServer;

        public SetServerOptionDelegate SetServerOption;
        public GetServerOptionDelegate GetServerOption;
        public SetWorldBoundsDelegate SetWorldBounds;
        public GetWorldBoundsDelegate GetWorldBounds;
        public SetWastedSettingsDelegate SetWastedSettings;
        public GetWastedSettingsDelegate GetWastedSettings;
        public SetTimeRateDelegate SetTimeRate;
        public GetTimeRateDelegate GetTimeRate;
        public SetHourDelegate SetHour;
        public GetHourDelegate GetHour;
        public SetMinuteDelegate SetMinute;
        public GetMinuteDelegate GetMinute;
        public SetWeatherDelegate SetWeather;
        public GetWeatherDelegate GetWeather;
        public SetGravityDelegate SetGravity;
        public GetGravityDelegate GetGravity;
        public SetGameSpeedDelegate SetGameSpeed;
        public GetGameSpeedDelegate GetGameSpeed;
        public SetWaterLevelDelegate SetWaterLevel;
        public GetWaterLevelDelegate GetWaterLevel;
        public SetMaximumFlightAltitudeDelegate SetMaximumFlightAltitude;
        public GetMaximumFlightAltitudeDelegate GetMaximumFlightAltitude;
        public SetKillCommandDelayDelegate SetKillCommandDelay;
        public GetKillCommandDelayDelegate GetKillCommandDelay;
        public SetVehiclesForcedRespawnHeightDelegate SetVehiclesForcedRespawnHeight;
        public GetVehiclesForcedRespawnHeightDelegate GetVehiclesForcedRespawnHeight;

        public CreateExplosionDelegate CreateExplosion;
        public PlaySoundDelegate PlaySound;
        public HideMapObjectDelegate HideMapObject;
        public ShowMapObjectDelegate ShowMapObject;
        public ShowAllMapObjectsDelegate ShowAllMapObjects;

        public SetWeaponDataValueDelegate SetWeaponDataValue;
        public GetWeaponDataValueDelegate GetWeaponDataValue;
        public ResetWeaponDataValueDelegate ResetWeaponDataValue;
        public IsWeaponDataValueModifiedDelegate IsWeaponDataValueModified;
        public ResetWeaponDataDelegate ResetWeaponData;
        public ResetAllWeaponDataDelegate ResetAllWeaponData;

        public GetKeyBindUnusedSlotDelegate GetKeyBindUnusedSlot;
        public GetKeyBindDataDelegate GetKeyBindData;
        public RegisterKeyBindDelegate RegisterKeyBind;
        public RemoveKeyBindDelegate RemoveKeyBind;
        public RemoveAllKeyBindsDelegate RemoveAllKeyBinds;

        public CreateCoordBlipDelegate CreateCoordBlip;
        public DestroyCoordBlipDelegate DestroyCoordBlip;
        public GetCoordBlipInfoDelegate GetCoordBlipInfo;

        public AddRadioStreamDelegate AddRadioStream;
        public RemoveRadioStreamDelegate RemoveRadioStream;

        public AddPlayerClassDelegate AddPlayerClass;
        public SetSpawnPlayerPositionDelegate SetSpawnPlayerPosition;
        public SetSpawnCameraPositionDelegate SetSpawnCameraPosition;
        public SetSpawnCameraLookAtDelegate SetSpawnCameraLookAt;

        public IsPlayerAdminDelegate IsPlayerAdmin;
        public SetPlayerAdminDelegate SetPlayerAdmin;
        public GetPlayerIPDelegate GetPlayerIP;
        public GetPlayerUidDelegate GetPlayerUid;
        public GetPlayerUid2Delegate GetPlayerUid2;
        public KickPlayerDelegate KickPlayer;
        public BanPlayerDelegate BanPlayer;
        public BanIPDelegate BanIP;
        public UnbanIPDelegate UnbanIP;
        public IsIPBannedDelegate IsIPBanned;

        public GetPlayerIDFromNameDelegate GetPlayerIDFromName;
        public IsPlayerConnectedDelegate IsPlayerConnected;
        public IsPlayerStreamedForPlayerDelegate IsPlayerStreamedForPlayer;
        public GetPlayerKeyDelegate GetPlayerKey;
        public GetPlayerNameDelegate GetPlayerName;
        public SetPlayerAdminDelegate SetPlayerName;
        public GetPlayerStateDelegate GetPlayerState;
        public SetPlayerOptionDelegate SetPlayerOption;
        public GetPlayerOptionDelegate GetPlayerOption;

        public SetPlayerWorldDelegate SetPlayerWorld;
        public GetPlayerWorldDelegate GetPlayerWorld;
        public SetPlayerSecondaryWorldDelegate SetPlayerSecondaryWorld;
        public GetPlayerSecondaryWorldDelegate GetPlayerSecondaryWorld;
        public GetPlayerUniqueWorldDelegate GetPlayerUniqueWorld;
        public IsPlayerWorldCompatibleDelegate IsPlayerWorldCompatible;

        public GetPlayerClassDelegate GetPlayerClass;
        public SetPlayerTeamDelegate SetPlayerTeam;
        public GetPlayerTeamDelegate GetPlayerTeam;
        public SetPlayerSkinDelegate SetPlayerSkin;
        public GetPlayerSkinDelegate GetPlayerSkin;
        public SetPlayerColorDelegate SetPlayerColor;
        public GetPlayerColorDelegate GetPlayerColor;

        public IsPlayerSpawnedDelegate IsPlayerSpawned;
        public ForcePlayerSpawnDelegate ForcePlayerSpawn;
        public ForcePlayerSelectDelegate ForcePlayerSelect;
        public ForceAllSelectDelegate ForceAllSelectDelegate;
        public IsPlayerTypingDelegate IsPlayerTyping;

        public GivePlayerMoneyDelegate GivePlayerMoney;
        public SetPlayerMoneyDelegate SetPlayerMoney;
        public GetPlayerMoneyDelegate GetPlayerMoney;
        public SetPlayerScoreDelegate SetPlayerScore;
        public GetPlayerScoreDelegate GetPlayerScore;
        public SetPlayerWantedLevelDelegate SetPlayerWantedLevel;
        public GetPlayerWantedLevelDelegate GetPlayerWantedLevel;
        public GetPlayerPingDelegate GetPlayerPing;
        public GetPlayerFpsDelegate GetPlayerFps;

        public SetPlayerHealthDelegate SetPlayerHealth;
        public GetPlayerHealthDelegate GetPlayerHealth;
        public SetPlayerArmorDelegate SetPlayerArmor;
        public GetPlayerArmorDelegate GetPlayerArmor;
        public SetPlayerImmunityFlagsDelegate SetPlayerImmunityFlags;
        public GetPlayerImmunityFlagsDelegate GetPlayerImmunityFlags;

        public SetPlayerPositionDelegate SetPlayerPosition;
        public GetPlayerPositionDelegate GetPlayerPosition;
        public SetPlayerSpeedDelegate SetPlayerSpeed;
        public GetPlayerSpeedDelegate GetPlayerSpeed;
        public AddPlayerSpeedDelegate AddPlayerSpeed;
        public SetPlayerHeadingDelegate SetPlayerHeading;
        public GetPlayerHeadingDelegate GetPlayerHeading;
        public SetPlayerAlphaDelegate SetPlayerAlpha;
        public GetPlayerAlphaDelegate GetPlayerAlpha;
        public GetPlayerAimPositionDelegate GetPlayerAimPosition;
        public GetPlayerAimDirectionDelegate GetPlayerAimDirection;

        public IsPlayerOnFireDelegate IsPlayerOnFire;
        public IsPlayerCrouchingDelegate IsPlayerCrouching;
        public GetPlayerActionDelegate GetPlayerAction;
        public GetPlayerGameKeysDelegate GetPlayerGameKeys;

        public PutPlayerInVehicleDelegate PutPlayerInVehicle;
        public RemovePlayerFromVehicleDelegate RemovePlayerFromVehicle;
        public GetPlayerInVehicleStatusDelegate GetPlayerInVehicleStatus;
        public GetPlayerInVehicleSlotDelegate GetPlayerInVehicleSlot;
        public GetPlayerVehicleIDDelegate GetPlayerVehicleID;

        public GivePlayerWeaponDelegate GivePlayerWeapon;
        public SetPlayerWeaponDelegate SetPlayerWeapon;
        public GetPlayerWeaponDelegate GetPlayerWeapon;
        public GetPlayerWeaponAmmoDelegate GetPlayerWeaponAmmo;
        public SetPlayerWeaponSlotDelegate SetPlayerWeaponSlot;
        public GetPlayerWeaponSlotDelegate GetPlayerWeaponSlot;
        public GetPlayerWeaponAtSlotDelegate GetPlayerWeaponAtSlot;
        public GetPlayerAmmoAtSlotDelegate GetPlayerAmmoAtSlot;
        public RemovePlayerWeaponDelegate RemovePlayerWeapon;
        public RemoveAllWeaponsDelegate RemoveAllWeapons;

        public SetCameraPositionDelegate SetCameraPosition;
        public RestoreCameraDelegate RestoreCamera;
        public IsCameraLockedDelegate IsCameraLocked;

        public SetPlayerAnimationDelegate SetPlayerAnimation;
        public GetPlayerStandingOnVehicleDelegate GetPlayerStandingOnVehicle;
        public GetPlayerStandingOnObjectDelegate GetPlayerStandingOnObject;
        public IsPlayerAwayDelegate IsPlayerAway;
        public GetPlayerSpectateTargetDelegate GetPlayerSpectateTarget;
        public SetPlayerSpectateTargetDelegate SetPlayerSpectateTarget;
        public RedirectPlayerToServerDelegate RedirectPlayerToServer;

        public CheckEntityExistsDelegate CheckEntityExists;

        public CreateVehicleDelegate CreateVehicle;
        public DeleteVehicleDelegate DeleteVehicle;
        public SetVehicleOptionDelegate SetVehicleOption;
        public GetVehicleOptionDelegate GetVehicleOption;
        public GetVehicleSyncSourceDelegate GetVehicleSyncSource;
        public GetVehicleSyncTypeDelegate GetVehicleSyncType;
        public IsVehicleStreamedForPlayerDelegate IsVehicleStreamedForPlayer;
        public SetVehicleWorldDelegate SetVehicleWorld;
        public GetVehicleWorldDelegate GetVehicleWorld;
        public GetVehicleModelDelegate GetVehicleModel;
        public GetVehicleOccupantDelegate GetVehicleOccupant;
        public RespawnVehicleDelegate RespawnVehicle;
        public SetVehicleImmunityFlagsDelegate SetVehicleImmunityFlags;
        public GetVehicleImmunityFlagsDelegate GetVehicleImmunityFlags;
        public ExplodeVehicleDelegate ExplodeVehicle;
        public IsVehicleWreckedDelegate IsVehicleWrecked;
        public SetVehiclePositionDelegate SetVehiclePosition;
        public GetVehiclePositionDelegate GetVehiclePosition;
        public SetVehicleRotationDelegate SetVehicleRotation;
        public SetVehicleRotationEulerDelegate SetVehicleRotationEuler;
        public GetVehicleRotationDelegate GetVehicleRotation;
        public GetVehicleRotationEulerDelegate GetVehicleRotationEuler;
        public SetVehicleSpeedDelegate SetVehicleSpeed;
        public GetVehicleSpeedDelegate GetVehicleSpeed;
        public SetVehicleTurnSpeedDelegate SetVehicleTurnSpeed;
        public GetVehicleTurnSpeedDelegate GetVehicleTurnSpeed;
        public SetVehicleSpawnPositionDelegate SetVehicleSpawnPosition;
        public GetVehicleSpawnPositionDelegate GetVehicleSpawnPosition;
        public SetVehicleSpawnRotationDelegate SetVehicleSpawnRotation;
        public SetVehicleSpawnRotationEulerDelegate SetVehicleSpawnRotationEuler;
        public GetVehicleSpawnRotationDelegate GetVehicleSpawnRotation;
        public GetVehicleSpawnRotationEulerDelegate GetVehicleSpawnRotationEuler;
        public SetVehicleIdleRespawnTimerDelegate SetVehicleIdleRespawnTimer;
        public GetVehicleIdleRespawnTimerDelegate GetVehicleIdleRespawnTimer;
        public SetVehicleHealthDelegate SetVehicleHealth;
        public GetVehicleHealthDelegate GetVehicleHealth;
        public SetVehicleColorDelegate SetVehicleColor;
        public GetVehicleColorDelegate GetVehicleColor;
        public SetVehiclePartStatusDelegate SetVehiclePartStatus;
        public GetVehiclePartStatusDelegate GetVehiclePartStatus;
        public SetVehicleTireStatusDelegate SetVehicleTireStatus;
        public GetVehicleTireStatusDelegate GetVehicleTireStatus;
        public SetVehicleDamageDataDelegate SetVehicleDamageData;
        public GetVehicleDamageDataDelegate GetVehicleDamageData;
        public SetVehicleRadioDelegate SetVehicleRadio;
        public GetVehicleRadioDelegate GetVehicleRadio;
        public GetVehicleTurretRotationDelegate GetVehicleTurretRotation;

        public ResetAllVehicleHandlingsDelegate ResetAllVehicleHandlings;
        public ExistsHandlingRuleDelegate ExistsHandlingRule;
        public SetHandlingRuleDelegate SetHandlingRule;
        public GetHandlingRuleDelegate GetHandlingRule;
        public ResetHandlingRuleDelegate ResetHandlingRule;
        public ResetHandlingDelegate ResetHandling;
        public ExistsInstanceHandlingRuleDelegate ExistsInstanceHandlingRule;
        public SetInstanceHandlingRuleDelegate SetInstanceHandlingRule;
        public GetInstanceHandlingRuleDelegate GetInstanceHandlingRule;
        public ResetInstanceHandlingRuleDelegate ResetInstanceHandlingRule;
        public ResetInstanceHandlingDelegate ResetInstanceHandling;

        public CreatePickupDelegate CreatePickup;
        public DeletePickupDelegate DeletePickup;
        public IsPickupStreamedForPlayerDelegate IsPickupStreamedForPlayer;
        public SetPickupWorldDelegate SetPickupWorld;
        public GetPickupWorldDelegate GetPickupWorld;
        public SetPickupAlphaDelegate SetPickupAlpha;
        public GetPickupAlphaDelegate GetPickupAlpha;
        public SetPickupIsAutomaticDelegate SetPickupIsAutomatic;
        public IsPickupAutomaticDelegate IsPickupAutomatic;
        public SetPickupAutomaticTimerDelegate SetPickupAutomaticTimer;
        public GetPickupAutomaticTimerDelegate GetPickupAutomaticTimer;
        public RefreshPickupDelegate RefreshPickup;
        public SetPickupPositionDelegate SetPickupPosition;
        public GetPickupPositionDelegate GetPickupPosition;
        public GetPickupModelDelegate GetPickupModel;
        public GetPickupQuantityDelegate GetPickupQuantity;
        
        public CreateCheckpointDelegate CreateCheckpoint;
        public DeleteCheckpointDelegate DeleteCheckpoint;
        public IsCheckpointStreamedForPlayerDelegate IsCheckpointStreamedForPlayer;
        public IsCheckpointSphereDelegate IsCheckpointSphere;
        public SetCheckpointWorldDelegate SetCheckpointWorld;
        public GetCheckpointWorldDelegate GetCheckpointWorld;
        public SetCheckpointColorDelegate SetCheckpointColor;
        public GetCheckpointColorDelegate GetCheckpointColor;
        public SetCheckpointPositionDelegate SetCheckpointPosition;
        public GetCheckpointPositionDelegate GetCheckpointPosition;
        public SetCheckpointRadiusDelegate SetCheckpointRadius;
        public GetCheckpointRadiusDelegate GetCheckpointRadius;
        public GetCheckpointOwnerDelegate GetCheckpointOwner;

        public CreateObjectDelegate CreateObject;
        public DeleteObjectDelegate DeleteObject;
        public IsObjectStreamedForPlayerDelegate IsObjectStreamedForPlayer;
        public GetObjectModelDelegate GetObjectModel;
        public SetObjectWorldDelegate SetObjectWorld;
        public GetObjectWorldDelegate GetObjectWorld;
        public SetObjectAlphaDelegate SetObjectAlpha;
        public GetObjectAlphaDelegate GetObjectAlpha;
        public MoveObjectToDelegate MoveObjectTo;
        public MoveObjectByDelegate MoveObjectBy;
        public SetObjectPositionDelegate SetObjectPosition;
        public GetObjectPositionDelegate GetObjectPosition;
        public RotateObjectToDelegate RotateObjectToDelegate;
        public RotateObjectToEulerDelegate RotateObjectToEuler;
        public RotateObjectByDelegate RotateObjectBy;
        public RotateObjectByEulerDelegate RotateObjectByEuler;
        public GetObjectRotationDelegate GetObjectRotation;
        public GetObjectRotationEulerDelegate GetObjectRotationEuler;
        public SetObjectShotReportEnabledDelegate SetObjectShotReportEnabled;
        public IsObjectShotReportEnabledDelegate IsObjectShotReportEnabled;
        public SetObjectTouchedReportEnabledDelegate SetObjectTouchedReportEnabled;
        public IsObjectTouchedReportEnabledDelegate IsObjectTouchedReportEnabled;

        public GetPlayerModuleListDelegate GetPlayerModuleList;

        public SetPickupOptionDelegate SetPickupOption;
        public GetPickupOptionDelegate GetPickupOption;

        public SetFallTimerDelegate SetFallTimer;
        public GetFallTimerDelegate GetFallTimer;

        public SetVehicleLightsDataDelegate SetVehicleLightsData;
        public GetVehicleLightsDataDelegate GetVehicleLightsData;
    }
}
