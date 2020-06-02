using System;
using System.Runtime.InteropServices;

namespace Fleka.DotnetVcmp.Interop {
    [StructLayout(LayoutKind.Sequential, CharSet=CharSet.Ansi)]
    public struct PluginCallbacks {
        private uint StructSize;

        public OnServerInitializeDelegate OnServerInitialize;
        public OnServerShutdownDelegate OnServerShutdown;
        public OnServerFrameDelegate OnServerFrame;

        public OnPluginCommandDelegate OnPluginCommand;
        public OnIncomingConnection OnIncomingConnection;
        public OnClientScriptData OnClientScriptData;

        public OnPlayerConnectDelegate OnPlayerConnect;
        public OnPlayerDisconnectDelegate OnPlayerDisconnect;

        public OnPlayerRequestClassDelegate OnPlayerRequestClass;
        public OnPlayerRequestSpawnDelegate OnPlayerRequestSpawn;
        public OnPlayerSpawnDelegate OnPlayerSpawn;
        public OnPlayerDeathDelegate OnPlayerDeath;
        public OnPlayerUpdateDelegate OnPlayerUpdate;

        public OnPlayerRequestEnterVehicleDelegate OnPlayerRequestEnterVehicle;
        public OnPlayerEnterVehicleDelegate OnPlayerEnterVehicle;
        public OnPlayerExitVehicleDelegate OnPlayerExitVehicleDelegate;

        public OnPlayerNameChangeDelegate OnPlayerNameChange;
        public OnPlayerStateChangeDelegate OnPlayerStateChange;
        public OnPlayerActionChangeDelegate OnPlayerActionChange;
        public OnPlayerOnFireChangeDelegate OnPlayerOnFireChange;
        public OnPlayerCrouchChangeDelegate OnPlayerCrouchChange;
        public OnPlayerGameKeysChangeDelegate OnPlayerGameKeysChange;
        public OnPlayerBeginTypingDelegate OnPlayerBeginTyping;
        public OnPlayerEndTypingDelegate OnPlayerEndTyping;
        public OnPlayerAwayChangeDelegate OnPlayerAwayChange;

        public OnPlayerMessageDelegate OnPlayerMessage;
        public OnPlayerCommandDelegate OnPlayerCommand;
        public OnPlayerPrivateMessageDelegate OnPlayerPrivateMessage;

        public OnPlayerKeyBindDownDelegate OnPlayerKeyBindDown;
        public OnPlayerKeyBindUpDelegate OnPlayerKeyBindUp;
        public OnPlayerSpectateDelegate OnPlayerSpectate;
        public OnPlayerCrashReportDelegate OnPlayerCrashReport;

        public OnVehicleUpdateDelegate OnVehicleUpdate;
        public OnVehicleExplodeDelegate OnVehicleExplode;
        public OnVehicleRespawnDelegate OnVehicleRespawn;

        public OnObjectShotDelegate OnObjectShot;
        public OnObjectTouchedDelegate OnObjectTouched;

        public OnPickupPickAttemptDelegate OnPickupPickAttempt;
        public OnPickupPickedDelegate OnPickupPicked;
        public OnPickupRespawnDelegate OnPickupRespawn;

        public OnCheckpointEnteredDelegate OnCheckpointEntered;
        public OnCheckpointExitedDelegate OnCheckpointExited;

        public OnEntityPoolChangeDelegate OnEntityPoolChange;
        public OnServerPerformanceReportDelegate OnserverPerformanceReport;

        public OnPlayerModuleListDelegate OnPlayerModuleList;
    }
}
