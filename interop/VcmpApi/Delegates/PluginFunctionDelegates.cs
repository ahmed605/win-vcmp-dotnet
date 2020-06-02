using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Fleka.DotnetVcmp.Interop {
    public delegate uint GetServerVersionDelegate();
    public delegate VcmpError GetServerSettingsDelegate(out ServerSettings serverSettings);
    public delegate VcmpError ExportFunctionsDelegate(int pluginID, out IntPtr functionList, ulong size);
    public delegate uint GetNumberOfPluginsDelegate();
    public delegate VcmpError GetPluginInfoDelegate(int pluginID, out PluginInfo pluginInfo);
    public delegate int FindPluginDelegate([MarshalAs(UnmanagedType.LPStr)] string pluginName);
    public unsafe delegate IntPtr* GetPluginExportsDelegate(int pluginID, out ulong size);
    public delegate VcmpError SendPluginCommandDelegate(uint commandIdentifier, [MarshalAs(UnmanagedType.LPStr)] string format, [MarshalAs(UnmanagedType.LPStr)] string formatFirstParameter);
    public delegate ulong GetTimeDelegate();
    public delegate VcmpError LogMessageDelegate([MarshalAs(UnmanagedType.LPStr)] string format, [MarshalAs(UnmanagedType.LPStr)] string formatFirstParameter);
    public delegate VcmpError GetLastErrorDelegate();

    public delegate VcmpError SendClientScriptDataDelegate(int playerID, IntPtr data, ulong size);
    public delegate VcmpError SendClientMessageDelegate(int playerID, uint color, [MarshalAs(UnmanagedType.LPStr)] string format, [MarshalAs(UnmanagedType.LPStr)] string formatFirstParameter);
    public delegate VcmpError SendGameMessageDelegate(int playerID, [MarshalAs(UnmanagedType.LPStr)] string format, [MarshalAs(UnmanagedType.LPStr)] string formatFirstParameter);

    public delegate VcmpError SetServerNameDelegate([MarshalAs(UnmanagedType.LPStr)] string text);
    public delegate VcmpError GetServerNameDelegate([MarshalAs(UnmanagedType.LPStr)] StringBuilder buffer, ulong size);
    public delegate VcmpError SetMaxPlayersDelegate(uint maxPlayers);
    public delegate uint GetMaxPlayersDelegate();
    public delegate VcmpError SetServerPasswordDelegate([MarshalAs(UnmanagedType.LPStr)] string password);
    public delegate VcmpError GetServerPasswordDelegate([MarshalAs(UnmanagedType.LPStr)] StringBuilder buffer, ulong size);
    public delegate VcmpError SetGameModeTextDelegate([MarshalAs(UnmanagedType.LPStr)] string gameMode);
    public delegate VcmpError GetGameModeTextDelegate([MarshalAs(UnmanagedType.LPStr)] StringBuilder buffer, ulong size);
    public delegate void ShutdownServerDelegate();

    public delegate VcmpError SetServerOptionDelegate(ServerOption option, byte toggle);
    public delegate byte GetServerOptionDelegate(ServerOption option);
    public delegate void SetWorldBoundsDelegate(float maximumX, float minimumX, float maximumY, float minimumY);
    public delegate void GetWorldBoundsDelegate(out float maximumX, out float minimumX, out float maximumY, out float minimumY);
    public delegate void SetWastedSettingsDelegate(uint deathTimer, uint fadeTimer, float fadeInSpeed, float fadeOutSpeed, uint fadeColor, uint corpseFadeStart, uint corpseFadeTime);
    public delegate void GetWastedSettingsDelegate(out uint deathTimer, out uint fadeTimer, out float fadeInSpeed, out float fadeOutSpeed, out uint fadeColor, out uint corpseFadeStart, out uint corpseFadeTime);
    public delegate void SetTimeRateDelegate(int timeRate);
    public delegate int GetTimeRateDelegate();
    public delegate void SetHourDelegate(int hour);
    public delegate int GetHourDelegate();
    public delegate void SetMinuteDelegate(int minute);
    public delegate int GetMinuteDelegate();
    public delegate void SetWeatherDelegate(int weather);
    public delegate int GetWeatherDelegate();
    public delegate void SetGravityDelegate(float gravity);
    public delegate float GetGravityDelegate();
    public delegate void SetGameSpeedDelegate(float gameSpeed);
    public delegate float GetGameSpeedDelegate();
    public delegate void SetWaterLevelDelegate(float waterLevel);
    public delegate float GetWaterLevelDelegate();
    public delegate void SetMaximumFlightAltitudeDelegate(float height);
    public delegate float GetMaximumFlightAltitudeDelegate();
    public delegate void SetKillCommandDelayDelegate(int delay);
    public delegate int GetKillCommandDelayDelegate();
    public delegate void SetVehiclesForcedRespawnHeightDelegate(float height);
    public delegate float GetVehiclesForcedRespawnHeightDelegate();

    public delegate VcmpError CreateExplosionDelegate(int world, int type, float x, float y, float z, int responsiblePlayerID, byte atGroundLevel);
    public delegate VcmpError PlaySoundDelegate(int world, int soundID, float x, float y, float z);
    public delegate void HideMapObjectDelegate(int modelIndex, short tenthX, short tenthY, short tenthZ);
    public delegate void ShowMapObjectDelegate(int modelIndex, short tenthX, short tenthY, short tehthZ);
    public delegate void ShowAllMapObjectsDelegate();

    public delegate VcmpError SetWeaponDataValueDelegate(int weaponID, int fieldID, double value);
    public delegate double GetWeaponDataValueDelegate(int weaponID, int fieldID);
    public delegate VcmpError ResetWeaponDataValueDelegate(int weaponID, int fieldID);
    public delegate byte IsWeaponDataValueModifiedDelegate(int weaponID, int fieldID);
    public delegate VcmpError ResetWeaponDataDelegate(int weaponID);
    public delegate void ResetAllWeaponDataDelegate();

    public delegate int GetKeyBindUnusedSlotDelegate();
    public delegate VcmpError GetKeyBindDataDelegate(int bindID, out byte isCalledOnRelease, out int keyOne, out int keyTwo, out int keyThree);
    public delegate VcmpError RegisterKeyBindDelegate(int bindID, byte isCalledOnRelease, int keyOne, int keyTwo, int keyThree);
    public delegate VcmpError RemoveKeyBindDelegate(int bindID);
    public delegate void RemoveAllKeyBindsDelegate();

    public delegate int CreateCoordBlipDelegate(int index, int world, float x, float y, float z, int scale, uint color, int sprite);
    public delegate VcmpError DestroyCoordBlipDelegate(int index);
    public delegate VcmpError GetCoordBlipInfoDelegate(int index, out int world, out float x, out float y, out float z, out int scale, out uint color, out int sprite);

    public delegate VcmpError AddRadioStreamDelegate(int radioID, [MarshalAs(UnmanagedType.LPStr)] string radioName, [MarshalAs(UnmanagedType.LPStr)] string radioUrl, byte isListed);
    public delegate VcmpError RemoveRadioStreamDelegate(int radioID);

    public delegate int AddPlayerClassDelegate(int teamID, uint color, int modelIndex, float x, float y, float z, float angle, int weaponOne, int weaponOneAmmo, int weaponTwo, int weaponTwoAmmo, int weaponThree, int weaponThreeAmmo);
    public delegate void SetSpawnPlayerPositionDelegate(float x, float y, float z);
    public delegate void SetSpawnCameraPositionDelegate(float x, float y, float z);
    public delegate void SetSpawnCameraLookAtDelegate(float x, float y, float z);

    public delegate bool IsPlayerAdminDelegate(int playerID);
    public delegate VcmpError SetPlayerAdminDelegate(int playerID, byte toggle);
    public delegate VcmpError GetPlayerIPDelegate(int playerID, [MarshalAs(UnmanagedType.LPStr)] StringBuilder buffer, ulong size);
    public delegate VcmpError GetPlayerUidDelegate(int playerID, [MarshalAs(UnmanagedType.LPStr)] StringBuilder buffer, ulong size);
    public delegate VcmpError GetPlayerUid2Delegate(int playerID, [MarshalAs(UnmanagedType.LPStr)] StringBuilder buffer, ulong size);
    public delegate VcmpError KickPlayerDelegate(int playerID);
    public delegate VcmpError BanPlayerDelegate(int playerID);
    public delegate void BanIPDelegate([MarshalAs(UnmanagedType.LPStr)] string ipAddress);
    public delegate byte UnbanIPDelegate([MarshalAs(UnmanagedType.LPStr)] string ipAddress);
    public delegate byte IsIPBannedDelegate([MarshalAs(UnmanagedType.LPStr)] string ipAddress);

    public delegate int GetPlayerIDFromNameDelegate([MarshalAs(UnmanagedType.LPStr)] string name);
    public delegate byte IsPlayerConnectedDelegate(int playerID);
    public delegate byte IsPlayerStreamedForPlayerDelegate(int checkedPlayerID, int playerID);
    public delegate uint GetPlayerKeyDelegate(int playerID);
    public delegate VcmpError GetPlayerNameDelegate(int playerID, [MarshalAs(UnmanagedType.LPStr)] StringBuilder buffer, ulong size);
    public delegate VcmpError SetPlayerNameDelegate(int playerID, [MarshalAs(UnmanagedType.LPStr)] string name);
    public delegate PlayerState GetPlayerStateDelegate(int playerID);
    public delegate VcmpError SetPlayerOptionDelegate(int playerID, PlayerOption option, byte toggle);
    public delegate byte GetPlayerOptionDelegate(int playerID, PlayerOption option);

    public delegate VcmpError SetPlayerWorldDelegate(int playerID, int world);
    public delegate int GetPlayerWorldDelegate(int playerID);
    public delegate VcmpError SetPlayerSecondaryWorldDelegate(int playerID, int secondaryWorld);
    public delegate int GetPlayerSecondaryWorldDelegate(int playerID);
    public delegate int GetPlayerUniqueWorldDelegate(int playerID);
    public delegate byte IsPlayerWorldCompatibleDelegate(int playerID, int world);

    public delegate int GetPlayerClassDelegate(int playerID);
    public delegate VcmpError SetPlayerTeamDelegate(int playerID, int teamID);
    public delegate int GetPlayerTeamDelegate(int playerID);
    public delegate VcmpError SetPlayerSkinDelegate(int playerID, int skinID);
    public delegate int GetPlayerSkinDelegate(int playerID);
    public delegate VcmpError SetPlayerColorDelegate(int playerID, uint color);
    public delegate uint GetPlayerColorDelegate(int playerID);

    public delegate byte IsPlayerSpawnedDelegate(int playerID);
    public delegate VcmpError ForcePlayerSpawnDelegate(int playerID);
    public delegate VcmpError ForcePlayerSelectDelegate(int playerID);
    public delegate void ForceAllSelectDelegate();
    public delegate byte IsPlayerTypingDelegate(int playerID);

    public delegate VcmpError GivePlayerMoneyDelegate(int playerID, int amount);
    public delegate VcmpError SetPlayerMoneyDelegate(int playerID, int amount);
    public delegate int GetPlayerMoneyDelegate(int playerID);
    public delegate VcmpError SetPlayerScoreDelegate(int playerID, int score);
    public delegate int GetPlayerScoreDelegate(int playerID);
    public delegate VcmpError SetPlayerWantedLevelDelegate(int playerID, int level);
    public delegate int GetPlayerWantedLevelDelegate(int playerID);
    public delegate int GetPlayerPingDelegate(int playerID);
    public delegate double GetPlayerFpsDelegate(int playerID);

    public delegate VcmpError SetPlayerHealthDelegate(int playerID, float health);
    public delegate float GetPlayerHealthDelegate(int playerID);
    public delegate VcmpError SetPlayerArmorDelegate(int playerID, float armor);
    public delegate float GetPlayerArmorDelegate(int playerID);
    public delegate VcmpError SetPlayerImmunityFlagsDelegate(int playerID, uint flags);
    public delegate uint GetPlayerImmunityFlagsDelegate(int playerID);

    public delegate VcmpError SetPlayerPositionDelegate(int playerID, float x, float y, float z);
    public delegate VcmpError GetPlayerPositionDelegate(int playerID, out float x, out float y, out float z);
    public delegate VcmpError SetPlayerSpeedDelegate(int playerID, float x, float y, float z);
    public delegate VcmpError GetPlayerSpeedDelegate(int playerID, float x, float y, float z);
    public delegate VcmpError AddPlayerSpeedDelegate(int playerID, float x, float y, float z);
    public delegate VcmpError SetPlayerHeadingDelegate(int playerID, float angle);
    public delegate float GetPlayerHeadingDelegate(int playerID);
    public delegate VcmpError SetPlayerAlphaDelegate(int playerID);
    public delegate int GetPlayerAlphaDelegate(int playerID);
    public delegate VcmpError GetPlayerAimPositionDelegate(int playerID, out float x, out float y, out float z);
    public delegate VcmpError GetPlayerAimDirectionDelegate(int playerID, out float x, out float y, out float z);

    public delegate byte IsPlayerOnFireDelegate(int playerID);
    public delegate byte IsPlayerCrouchingDelegate(int playerID);
    public delegate int GetPlayerActionDelegate(int playerID);
    public delegate uint GetPlayerGameKeysDelegate(int playerID);

    public delegate VcmpError PutPlayerInVehicleDelegate(int playerID, int vehicleID, int slotIndex, byte makeRoom, byte warp);
    public delegate VcmpError RemovePlayerFromVehicleDelegate(int playerID);
    public delegate PlayerVehicle GetPlayerInVehicleStatusDelegate(int playerID);
    public delegate int GetPlayerInVehicleSlotDelegate(int playerID, int vehicleID);
    public delegate int GetPlayerVehicleIDDelegate(int playerID);

    public delegate VcmpError GivePlayerWeaponDelegate(int playerID, int weaponID, int ammo);
    public delegate VcmpError SetPlayerWeaponDelegate(int playerID, int weaponID, int ammo);
    public delegate int GetPlayerWeaponDelegate(int playerID);
    public delegate int GetPlayerWeaponAmmoDelegate(int playerID);
    public delegate VcmpError SetPlayerWeaponSlotDelegate(int playerID, int slot);
    public delegate int GetPlayerWeaponSlotDelegate(int playerID);
    public delegate int GetPlayerWeaponAtSlotDelegate(int playerID, int slot);
    public delegate int GetPlayerAmmoAtSlotDelegate(int playerID, int slot);
    public delegate VcmpError RemovePlayerWeaponDelegate(int playerID, int weaponID);
    public delegate VcmpError RemoveAllWeaponsDelegate(int playerID);

    public delegate VcmpError SetCameraPositionDelegate(int playerID, float positionX, float positionY, float positionZ, float lookX, float lookY, float lookZ);
    public delegate VcmpError RestoreCameraDelegate(int playerID);
    public delegate byte IsCameraLockedDelegate(int playerID);

    public delegate VcmpError SetPlayerAnimationDelegate(int playerID, int groupID, int animationID);
    public delegate int GetPlayerStandingOnVehicleDelegate(int playerID);
    public delegate int GetPlayerStandingOnObjectDelegate(int playerID);
    public delegate byte IsPlayerAwayDelegate(int playerID);
    public delegate int GetPlayerSpectateTargetDelegate(int playerID);
    public delegate VcmpError SetPlayerSpectateTargetDelegate(int playerID, int targetPlayerID);
    public delegate VcmpError RedirectPlayerToServerDelegate(int playerID, [MarshalAs(UnmanagedType.LPStr)] string ipAddress, uint port, [MarshalAs(UnmanagedType.LPStr)] string name, [MarshalAs(UnmanagedType.LPStr)] string serverPassword, [MarshalAs(UnmanagedType.LPStr)] string userPassword);

    public delegate byte CheckEntityExistsDelegate(EntityPool entityPool, int index);

    public delegate int CreateVehicleDelegate(int modelIndex, int world, float x, float y, float z, float angle, int primaryColor, int secondaryColor);
    public delegate VcmpError DeleteVehicleDelegate(int vehicleID);
    public delegate VcmpError SetVehicleOptionDelegate(int vehicleID, VehicleOption option, byte toggle);
    public delegate byte GetVehicleOptionDelegate(int vehicleID, VehicleOption option);
    public delegate int GetVehicleSyncSourceDelegate(int vehicleID);
    public delegate VehicleSync GetVehicleSyncTypeDelegate(int vehicleID);
    public delegate byte IsVehicleStreamedForPlayerDelegate(int vehicleID, int playerID);
    public delegate VcmpError SetVehicleWorldDelegate(int vehicleID, int world);
    public delegate int GetVehicleWorldDelegate(int vehicleID);
    public delegate int GetVehicleModelDelegate(int vehicleID);
    public delegate int GetVehicleOccupantDelegate(int vehicleID);
    public delegate VcmpError RespawnVehicleDelegate(int vehicleID);
    public delegate VcmpError SetVehicleImmunityFlagsDelegate(int vehicleID, uint immunityFlags);
    public delegate uint GetVehicleImmunityFlagsDelegate(int vehicleID);
    public delegate VcmpError ExplodeVehicleDelegate(int vehicleID);
    public delegate byte IsVehicleWreckedDelegate(int vehicleID);
    public delegate VcmpError SetVehiclePositionDelegate(int vehicleID, float x, float y, float z, byte removeOccupants);
    public delegate VcmpError GetVehiclePositionDelegate(int vehicleID, out float x, out float y, out float z);
    public delegate VcmpError SetVehicleRotationDelegate(int vehicleID, float x, float y, float z, float w);
    public delegate VcmpError SetVehicleRotationEulerDelegate(int vehicleID, float x, float y, float z);
    public delegate VcmpError GetVehicleRotationDelegate(int vehicleID, out float x, out float y, out float z, out float w);
    public delegate VcmpError GetVehicleRotationEulerDelegate(int vehicleID, out float x, out float y, out float z);
    public delegate VcmpError SetVehicleSpeedDelegate(int vehicleID, float x, float y, float z, byte add, byte relative);
    public delegate VcmpError GetVehicleSpeedDelegate(int vehicleID, out float x, out float y, out float z);
    public delegate VcmpError SetVehicleTurnSpeedDelegate(int vehicleID, float x, float y, float z, byte relative);
    public delegate VcmpError GetVehicleTurnSpeedDelegate(int vehicleID, out float x, out float y, out float z);
    public delegate VcmpError SetVehicleSpawnPositionDelegate(int vehicleID, float x, float y, float z);
    public delegate VcmpError GetVehicleSpawnPositionDelegate(int vehicleID, out float x, out float y, out float z);
    public delegate VcmpError SetVehicleSpawnRotationDelegate(int vehicleID, float x, float y, float z, float w);
    public delegate VcmpError SetVehicleSpawnRotationEulerDelegate(int vehicleID, float x, float y, float z);
    public delegate VcmpError GetVehicleSpawnRotationDelegate(int vehicleID, out float x, out float y, out float z, out float w);
    public delegate VcmpError GetVehicleSpawnRotationEulerDelegate(int vehicleID, out float x, out float y, out float z);
    public delegate VcmpError SetVehicleIdleRespawnTimerDelegate(int vehicleID, uint milliseconds);
    public delegate uint GetVehicleIdleRespawnTimerDelegate(int vehicleID, uint milliseconds);
    public delegate VcmpError SetVehicleHealthDelegate(int vehicleID, float health);
    public delegate float GetVehicleHealthDelegate(int vehicleID);
    public delegate VcmpError SetVehicleColorDelegate(int vehicleID, int primaryColor, int secondaryColor);
    public delegate VcmpError GetVehicleColorDelegate(int vehicleID, out int primaryColor, out int secondaryColor);
    public delegate VcmpError SetVehiclePartStatusDelegate(int vehicleID, int partID, int status);
    public delegate int GetVehiclePartStatusDelegate(int vehicleID, int partID);
    public delegate VcmpError SetVehicleTireStatusDelegate(int vehicleID, int tireID, int status);
    public delegate int GetVehicleTireStatusDelegate(int vehicleID, int tireID);
    public delegate VcmpError SetVehicleDamageDataDelegate(int vehicleID, uint damageData);
    public delegate uint GetVehicleDamageDataDelegate(int vehicleID);
    public delegate VcmpError SetVehicleRadioDelegate(int vehicleID, int radioID);
    public delegate int GetVehicleRadioDelegate(int vehicleID);
    public delegate VcmpError GetVehicleTurretRotationDelegate(int vehicleID, out float horizontal, out float vertical);

    public delegate void ResetAllVehicleHandlingsDelegate();
    public delegate byte ExistsHandlingRuleDelegate(int modelIndex, int ruleIndex);
    public delegate VcmpError SetHandlingRuleDelegate(int modelIndex, int ruleIndex, double value);
    public delegate double GetHandlingRuleDelegate(int modelIndex, int ruleIndex);
    public delegate VcmpError ResetHandlingRuleDelegate(int modelIndex, int ruleIndex);
    public delegate VcmpError ResetHandlingDelegate(int modelIndex);
    public delegate byte ExistsInstanceHandlingRuleDelegate(int vehicleID, int ruleIndex);
    public delegate VcmpError SetInstanceHandlingRuleDelegate(int vehicleID, int ruleIndex, double value);
    public delegate double GetInstanceHandlingRuleDelegate(int vehicleID, int ruleIndex);
    public delegate VcmpError ResetInstanceHandlingRuleDelegate(int vehicleID, int ruleIndex);
    public delegate VcmpError ResetInstanceHandlingDelegate(int vehicleID);

    public delegate int CreatePickupDelegate(int modelIndex, int world, int quantity, float x, float y, float z, int alpha, byte isAutomatic);
    public delegate VcmpError DeletePickupDelegate(int pickupID);
    public delegate byte IsPickupStreamedForPlayerDelegate(int pickupID, int playerID);
    public delegate VcmpError SetPickupWorldDelegate(int pickupID, int world);
    public delegate int GetPickupWorldDelegate(int pickupID);
    public delegate VcmpError SetPickupAlphaDelegate(int pickupID, int alpha);
    public delegate int GetPickupAlphaDelegate(int pickupID);
    public delegate VcmpError SetPickupIsAutomaticDelegate(int pickupID, byte toggle);
    public delegate byte IsPickupAutomaticDelegate(int pickupID);
    public delegate VcmpError SetPickupAutomaticTimerDelegate(int pickupID, uint durationMilliseconds);
    public delegate uint GetPickupAutomaticTimerDelegate(int pickupID);
    public delegate VcmpError RefreshPickupDelegate(int pickupID);
    public delegate VcmpError SetPickupPositionDelegate(int pickupID, float x, float y, float z);
    public delegate VcmpError GetPickupPositionDelegate(int pickupID, out float x, out float y, out float z);
    public delegate int GetPickupModelDelegate(int pickupID);
    public delegate int GetPickupQuantityDelegate(int pickupID);

    public delegate int CreateCheckpointDelegate(int playerID, int world, byte isSphere, float x, float y, float z, int red, int green, int blue, int alpha, float radius);
    public delegate VcmpError DeleteCheckpointDelegate(int checkpointID);
    public delegate byte IsCheckpointStreamedForPlayerDelegate(int checkpointID, int playerID);
    public delegate byte IsCheckpointSphereDelegate(int checkpointID);
    public delegate VcmpError SetCheckpointWorldDelegate(int checkpointID, int worldID);
    public delegate int GetCheckpointWorldDelegate(int checkpointID);
    public delegate VcmpError SetCheckpointColorDelegate(int checkpointID, int red, int green, int blue, int alpha);
    public delegate VcmpError GetCheckpointColorDelegate(int checkpointID, out int red, out int green, out int blue, out int alpha);
    public delegate VcmpError SetCheckpointPositionDelegate(int checkpointID, float x, float y, float z);
    public delegate VcmpError GetCheckpointPositionDelegate(int checkpointID, out float x, out float y, out float z);
    public delegate VcmpError SetCheckpointRadiusDelegate(int checkpointID, float radius);
    public delegate float GetCheckpointRadiusDelegate(int checkpointID);
    public delegate int GetCheckpointOwnerDelegate(int checkpointID);

    public delegate int CreateObjectDelegate(int modelIndex, int world, float x, float y, float z, int alpha);
    public delegate VcmpError DeleteObjectDelegate(int objectID);
    public delegate byte IsObjectStreamedForPlayerDelegate(int objectID, int playerID);
    public delegate int GetObjectModelDelegate(int objectID);
    public delegate VcmpError SetObjectWorldDelegate(int objectID, int world);
    public delegate int GetObjectWorldDelegate(int objectID);
    public delegate VcmpError SetObjectAlphaDelegate(int objectID, int alpha, uint duration);
    public delegate int GetObjectAlphaDelegate(int objectID);
    public delegate VcmpError MoveObjectToDelegate(int objectID, float x, float y, float z, uint duration);
    public delegate VcmpError MoveObjectByDelegate(int objectID, float x, float y, float z, uint duration);
    public delegate VcmpError SetObjectPositionDelegate(int objectID, float x, float y, float z);
    public delegate VcmpError GetObjectPositionDelegate(int objectID, out float x, out float y, out float z);
    public delegate VcmpError RotateObjectToDelegate(int objectID, float x, float y, float z, float w, uint duration);
    public delegate VcmpError RotateObjectToEulerDelegate(int objectID, float x, float y, float z, uint duration);
    public delegate VcmpError RotateObjectByDelegate(int objectID, float x, float y, float z, float w, uint duration);
    public delegate VcmpError RotateObjectByEulerDelegate(int objectID, float x, float y, float z, uint duration);
    public delegate VcmpError GetObjectRotationDelegate(int objectID, out float x, out float y, out float z, out float w);
    public delegate VcmpError GetObjectRotationEulerDelegate(int objectID, out float x, out float y, out float z);
    public delegate VcmpError SetObjectShotReportEnabledDelegate(int objectID, byte toggle);
    public delegate byte IsObjectShotReportEnabledDelegate(int objectID);
    public delegate VcmpError SetObjectTouchedReportEnabledDelegate(int objectID, byte toggle);
    public delegate byte IsObjectTouchedReportEnabledDelegate(int objectID);

    public delegate VcmpError GetPlayerModuleListDelegate(int playerID);
    
    public delegate VcmpError SetPickupOptionDelegate(int pickupID, PickupOption option, byte toggle);
    public delegate byte GetPickupOptionDelegate(int pickupID, PickupOption option);

    public delegate void SetFallTimerDelegate(ushort timeRate);
    public delegate ushort GetFallTimerDelegate();

    public delegate VcmpError SetVehicleLightsDataDelegate(int vehicleID, uint lightsData);
    public delegate uint GetVehicleLightsDataDelegate(int vehicleID);
}
