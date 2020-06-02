using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Fleka.DotnetVcmp.Interop {
    public delegate byte OnServerInitializeDelegate();
    public delegate void OnServerShutdownDelegate();
    public delegate void OnServerFrameDelegate(float elapsedTime);

    public delegate byte OnPluginCommandDelegate(uint commandIdentifier, [MarshalAs(UnmanagedType.LPStr)] string message);
    public delegate byte OnIncomingConnection([MarshalAs(UnmanagedType.LPStr)] string name, IntPtr nameBufferSize, [MarshalAs(UnmanagedType.LPStr)] string userPassword, [MarshalAs(UnmanagedType.LPStr)] string ipAddress);
    public unsafe delegate void OnClientScriptData(int playerID, byte* data, IntPtr size);

    public delegate void OnPlayerConnectDelegate(int playerID);
    public delegate void OnPlayerDisconnectDelegate(int playerID, DisconnectReason disconnectReason);

    public delegate byte OnPlayerRequestClassDelegate(int playerID, int offset);
    public delegate byte OnPlayerRequestSpawnDelegate(int playerID);
    public delegate void OnPlayerSpawnDelegate(int playerID);
    public delegate void OnPlayerDeathDelegate(int playerID, int killerID, int reason, BodyPart bodyPart);
    public delegate void OnPlayerUpdateDelegate(int playerID, PlayerUpdate updateType);

    public delegate byte OnPlayerRequestEnterVehicleDelegate(int playerID, int vehicleID, int slotIndex);
    public delegate void OnPlayerEnterVehicleDelegate(int playerID, int vehicleID, int slotIndex);
    public delegate void OnPlayerExitVehicleDelegate(int playerID, int vehicleID);

    public delegate void OnPlayerNameChangeDelegate(int playerID, [MarshalAs(UnmanagedType.LPStr)] string previousName, [MarshalAs(UnmanagedType.LPStr)] string currentName);
    public delegate void OnPlayerStateChangeDelegate(int playerID, PlayerState previousState, PlayerState currentState);
    public delegate void OnPlayerActionChangeDelegate(int playerID, int previousAction, int currentAction);
    public delegate void OnPlayerOnFireChangeDelegate(int playerID, bool isOnFire);
    public delegate void OnPlayerCrouchChangeDelegate(int playerID, bool isCrouching);
    public delegate void OnPlayerGameKeysChangeDelegate(int playerID, uint previousKeys, uint currentKeys);
    public delegate void OnPlayerBeginTypingDelegate(int playerID);
    public delegate void OnPlayerEndTypingDelegate(int playerID);
    public delegate void OnPlayerAwayChangeDelegate(int playerID, byte isAway);

    public delegate byte OnPlayerMessageDelegate(int playerID, [MarshalAs(UnmanagedType.LPStr)] string message);
    public delegate byte OnPlayerCommandDelegate(int playerID, [MarshalAs(UnmanagedType.LPStr)] string message);
    public delegate byte OnPlayerPrivateMessageDelegate(int playerID, int targetPlayerID, [MarshalAs(UnmanagedType.LPStr)] string message);

    public delegate void OnPlayerKeyBindDownDelegate(int playerID, int bindID);
    public delegate void OnPlayerKeyBindUpDelegate(int playerID, int bindID);
    public delegate void OnPlayerSpectateDelegate(int playerID, int targetPlayerID);
    public delegate void OnPlayerCrashReportDelegate(int playerID, [MarshalAs(UnmanagedType.LPStr)] string report);

    public delegate void OnVehicleUpdateDelegate(int vehicleID, VehicleUpdate updateType);
    public delegate void OnVehicleExplodeDelegate(int vehicleID);
    public delegate void OnVehicleRespawnDelegate(int vehicleID);

    public delegate void OnObjectShotDelegate(int objectID, int playerID, int weaponID);
    public delegate void OnObjectTouchedDelegate(int objectID, int playerID);

    public delegate byte OnPickupPickAttemptDelegate(int pickupID, int playerID);
    public delegate void OnPickupPickedDelegate(int pickupID, int playerID);
    public delegate void OnPickupRespawnDelegate(int pickupID);

    public delegate void OnCheckpointEnteredDelegate(int checkpointID, int playerID);
    public delegate void OnCheckpointExitedDelegate(int checkpointID, int playerID);

    public delegate void OnEntityPoolChangeDelegate(EntityPool entityType, int entityID, byte isDeleted);
    public unsafe delegate void OnServerPerformanceReportDelegate(IntPtr entryCount, byte** description, ulong times);

    public delegate void OnPlayerModuleListDelegate(int playerID, [MarshalAs(UnmanagedType.LPStr)] string list);
}
