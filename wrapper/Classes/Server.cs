using System;
using System.Text;
using Fleka.DotnetVcmp.Interop;

namespace Fleka.DotnetVcmp {
    /// <summary>
    /// This is an implementation of <see cref="IServer">.
    /// </summary>
    internal sealed class Server: IServer
    {
        private PluginFunctions _pluginFunctions;

        internal Server(PluginFunctions pluginFunctions) {
            _pluginFunctions = pluginFunctions;
        }

        public uint Version {
            get {
                uint version = _pluginFunctions.GetServerVersion();
                ErrorDetection.ValidateLastError();

                return version;
            }
        }

        public ushort Port {
            get {
                ServerSettings serverSettings;
                _pluginFunctions.GetServerSettings(out serverSettings);
                ErrorDetection.ValidateLastError();

                return (ushort) serverSettings.Port;
            }
        }

        public uint PluginCount {
            get {
                uint pluginCount = _pluginFunctions.GetNumberOfPlugins();
                ErrorDetection.ValidateLastError();

                return pluginCount;
            }
        }

        public string Name {
            get {
                ErrorDetection.ValidateServerInitialized();

                StringBuilder serverNameBuilder = new StringBuilder(255);
                _pluginFunctions.GetServerName(serverNameBuilder, (IntPtr) serverNameBuilder.MaxCapacity);

                try {
                    ErrorDetection.ValidateLastError();
                } catch (BufferTooSmallException) {
                    // The server always returns a BufferTooSmallException regardless of the buffer size.
                    // https://github.com/iSLC/VCMP-SqMod/blob/976d1f4442d1d1da5c450ab140fca500b07d9616/source/Misc/Functions.cpp#L260
                    //
                    // We ignore the exception.
                }

                return serverNameBuilder.ToString();
            }
            set {
                ErrorDetection.ValidateServerInitialized();

                _pluginFunctions.SetServerName(value);
                ErrorDetection.ValidateLastError();
            }
        }

        public byte MaxPlayers {
            get {
                ErrorDetection.ValidateServerInitialized();

                byte maxPlayers;

                maxPlayers = (byte) _pluginFunctions.GetMaxPlayers();
                ErrorDetection.ValidateLastError();

                return maxPlayers;
            } set {
                ErrorDetection.ValidateServerInitialized();

                _pluginFunctions.SetMaxPlayers((uint) value);
                ErrorDetection.ValidateLastError();
            }
        }

        public string Password {
            get {
                ErrorDetection.ValidateServerInitialized();

                StringBuilder passwordBuilder = new StringBuilder(255);
                _pluginFunctions.GetServerPassword(passwordBuilder, (IntPtr) passwordBuilder.MaxCapacity);

                try {
                    ErrorDetection.ValidateLastError();
                } catch (BufferTooSmallException) {
                    // The server always returns a BufferTooSmallException regardless of the buffer size.
                    // https://github.com/iSLC/VCMP-SqMod/blob/976d1f4442d1d1da5c450ab140fca500b07d9616/source/Misc/Functions.cpp#L287
                    //
                    // We ignore the exception.
                }

                return passwordBuilder.ToString();
            } set {
                ErrorDetection.ValidateServerInitialized();

                _pluginFunctions.SetServerPassword(value);
                ErrorDetection.ValidateLastError();
            }
        }

        public string GameModeText {
            get {
                ErrorDetection.ValidateServerInitialized();

                StringBuilder gameModeTextBuilder = new StringBuilder(255);
                _pluginFunctions.GetGameModeText(gameModeTextBuilder, (IntPtr) gameModeTextBuilder.MaxCapacity);

                try {
                    ErrorDetection.ValidateLastError();
                } catch (BufferTooSmallException) {
                    // The server always returns a BufferTooSmallException regardless of the buffer size.
                    // https://github.com/iSLC/VCMP-SqMod/blob/976d1f4442d1d1da5c450ab140fca500b07d9616/source/Misc/Functions.cpp#L314
                    //
                    // We ignore the exception.
                }

                return gameModeTextBuilder.ToString();
            }
            set {
                ErrorDetection.ValidateServerInitialized();

                _pluginFunctions.SetGameModeText(value);
                ErrorDetection.ValidateLastError();
            }
        }

        public bool IsFrameLimiterEnforced {
            get {
                ErrorDetection.ValidateServerInitialized();

                bool isFrameLimiterEnforced = Convert.ToBoolean(_pluginFunctions.GetServerOption(ServerOption.SyncFrameLimiter));
                ErrorDetection.ValidateLastError();

                return isFrameLimiterEnforced;
            }
            set {
                ErrorDetection.ValidateServerInitialized();

                _pluginFunctions.SetServerOption(ServerOption.SyncFrameLimiter, value ? (byte) 1 : (byte) 0);
                ErrorDetection.ValidateLastError();
            }
        }

        public bool IsFrameLimiterEnabled {
            get {
                ErrorDetection.ValidateServerInitialized();

                bool isFrameLimiterEnabled = Convert.ToBoolean(_pluginFunctions.GetServerOption(ServerOption.FrameLimiter));
                ErrorDetection.ValidateLastError();

                return isFrameLimiterEnabled;
            }
            set {
                ErrorDetection.ValidateServerInitialized();

                _pluginFunctions.SetServerOption(ServerOption.FrameLimiter, value ? (byte) 1 : (byte) 0);
                ErrorDetection.ValidateLastError();
            }
        }

        public bool IsTaxiJumpEnabled {
            get {
                ErrorDetection.ValidateServerInitialized();

                bool isTaxiJumpEnabled = Convert.ToBoolean(_pluginFunctions.GetServerOption(ServerOption.TaxiBoostJump));
                ErrorDetection.ValidateLastError();

                return isTaxiJumpEnabled;
            }
            set {
                ErrorDetection.ValidateServerInitialized();

                _pluginFunctions.SetServerOption(ServerOption.TaxiBoostJump, value ? (byte) 1 : (byte) 0);
                ErrorDetection.ValidateLastError();
            }
        }

        public bool IsDriveOnWaterEnabled {
            get {
                ErrorDetection.ValidateServerInitialized();

                bool isDriveOnWaterEnabled = Convert.ToBoolean(_pluginFunctions.GetServerOption(ServerOption.DriveOnWater));
                ErrorDetection.ValidateLastError();

                return isDriveOnWaterEnabled;
            }
            set {
                ErrorDetection.ValidateServerInitialized();

                _pluginFunctions.SetServerOption(ServerOption.DriveOnWater, value ? (byte) 1 : (byte) 0);
                ErrorDetection.ValidateLastError();
            }
        }

        public bool IsFastSwitchEnabled {
            get {
                ErrorDetection.ValidateServerInitialized();

                bool isFastSwitchEnabled = Convert.ToBoolean(_pluginFunctions.GetServerOption(ServerOption.FastSwitch));
                ErrorDetection.ValidateLastError();

                return isFastSwitchEnabled;
            }
            set {
                ErrorDetection.ValidateServerInitialized();

                _pluginFunctions.SetServerOption(ServerOption.FastSwitch, value ? (byte) 1 : (byte) 0);
                ErrorDetection.ValidateLastError();
            }
        }

        public bool IsFriendlyFireEnabled {
            get {
                ErrorDetection.ValidateServerInitialized();

                bool isFriendlyFireEnabled = Convert.ToBoolean(_pluginFunctions.GetServerOption(ServerOption.FriendlyFire));
                ErrorDetection.ValidateLastError();

                return isFriendlyFireEnabled;
            }
            set {
                ErrorDetection.ValidateServerInitialized();

                _pluginFunctions.SetServerOption(ServerOption.FriendlyFire, value ? (byte) 1 : (byte) 0);
                ErrorDetection.ValidateLastError();
            }
        }

        public bool IsDriveByEnabled {
            get {
                ErrorDetection.ValidateServerInitialized();

                bool isDriveByEnabled = !Convert.ToBoolean(_pluginFunctions.GetServerOption(ServerOption.DisableDriveBy));
                ErrorDetection.ValidateLastError();

                return isDriveByEnabled;
            }
            set {
                ErrorDetection.ValidateServerInitialized();

                _pluginFunctions.SetServerOption(ServerOption.DisableDriveBy, !value ? (byte) 1 : (byte) 0);
                ErrorDetection.ValidateLastError();
            }
        }

        public bool IsPerfectHandlingEnabled {
            get {
                ErrorDetection.ValidateServerInitialized();

                bool isPerfectHandlingEnabled = Convert.ToBoolean(_pluginFunctions.GetServerOption(ServerOption.PerfectHandling));
                ErrorDetection.ValidateLastError();

                return isPerfectHandlingEnabled;
            }
            set {
                ErrorDetection.ValidateServerInitialized();

                _pluginFunctions.SetServerOption(ServerOption.PerfectHandling, value ? (byte) 1 : (byte) 0);
                ErrorDetection.ValidateLastError();
            }
        }

        public bool IsFlyingCarsEnabled {
            get {
                ErrorDetection.ValidateServerInitialized();

                bool isDriveOnWaterEnabled = Convert.ToBoolean(_pluginFunctions.GetServerOption(ServerOption.FlyingCars));
                ErrorDetection.ValidateLastError();

                return isDriveOnWaterEnabled;
            }
            set {
                ErrorDetection.ValidateServerInitialized();

                _pluginFunctions.SetServerOption(ServerOption.FlyingCars, value ? (byte) 1 : (byte) 0);
                ErrorDetection.ValidateLastError();
            }
        }

        public bool IsSwitchInAirEnabled {
            get {
                ErrorDetection.ValidateServerInitialized();

                bool isSwitchInAirEnabled = Convert.ToBoolean(_pluginFunctions.GetServerOption(ServerOption.JumpSwitch));
                ErrorDetection.ValidateLastError();

                return isSwitchInAirEnabled;
            }
            set {
                ErrorDetection.ValidateServerInitialized();

                _pluginFunctions.SetServerOption(ServerOption.JumpSwitch, value ? (byte) 1 : (byte) 0);
                ErrorDetection.ValidateLastError();
            }
        }

        public bool IsPlayerMarkersEnabled {
            get {
                ErrorDetection.ValidateServerInitialized();

                bool isPlayerMarkersEnabled = Convert.ToBoolean(_pluginFunctions.GetServerOption(ServerOption.ShowMarkers));
                ErrorDetection.ValidateLastError();

                return isPlayerMarkersEnabled;
            }
            set {
                ErrorDetection.ValidateServerInitialized();

                _pluginFunctions.SetServerOption(ServerOption.ShowMarkers, value ? (byte) 1 : (byte) 0);
                ErrorDetection.ValidateLastError();
            }
        }

        public bool IsExclusiveTeamMarkersEnabled {
            get {
                ErrorDetection.ValidateServerInitialized();

                bool isExclusiveTeamMarkersEnabled = Convert.ToBoolean(_pluginFunctions.GetServerOption(ServerOption.OnlyShowTeamMarkers));
                ErrorDetection.ValidateLastError();

                return isExclusiveTeamMarkersEnabled;
            }
            set {
                ErrorDetection.ValidateServerInitialized();

                _pluginFunctions.SetServerOption(ServerOption.OnlyShowTeamMarkers, value ? (byte) 1 : (byte) 0);
                ErrorDetection.ValidateLastError();
            }
        }

        public bool IsStuntBikeEnabled {
            get {
                ErrorDetection.ValidateServerInitialized();

                bool isStuntBikeEnabled = Convert.ToBoolean(_pluginFunctions.GetServerOption(ServerOption.StuntBike));
                ErrorDetection.ValidateLastError();

                return isStuntBikeEnabled;
            }
            set {
                ErrorDetection.ValidateServerInitialized();

                _pluginFunctions.SetServerOption(ServerOption.StuntBike, value ? (byte) 1 : (byte) 0);
                ErrorDetection.ValidateLastError();
            }
        }

        public bool IsShootInAirEnabled {
            get {
                ErrorDetection.ValidateServerInitialized();

                bool isShootInAirEnabled = Convert.ToBoolean(_pluginFunctions.GetServerOption(ServerOption.ShootInAir));
                ErrorDetection.ValidateLastError();

                return isShootInAirEnabled;
            }
            set {
                ErrorDetection.ValidateServerInitialized();

                _pluginFunctions.SetServerOption(ServerOption.ShootInAir, value ? (byte) 1 : (byte) 0);
                ErrorDetection.ValidateLastError();
            }
        }

        public Vector2Range WorldBoundaries {
            get {
                ErrorDetection.ValidateServerInitialized();

                Vector2Range worldBoundaries = new Vector2Range();

                _pluginFunctions.GetWorldBounds(
                    out worldBoundaries.Maximum.X, out worldBoundaries.Minimum.X,
                    out worldBoundaries.Maximum.Y, out worldBoundaries.Minimum.Y
                );

                return worldBoundaries;
            }
            set {
                ErrorDetection.ValidateServerInitialized();
                
                Vector2Range maximumWorldBoundaries = new Vector2Range {
                    Minimum = new Vector2 { X = -2350f, Y = -1950f },
                    Maximum = new Vector2 { X = 1550f, Y = 1950f }
                };

                // Setting world boundaries outside Vice City's limits has no effect.
                // We throw an exception to inform the user.
                if (!maximumWorldBoundaries.IsInRange(value.Minimum) || !maximumWorldBoundaries.IsInRange(value.Maximum)) {
                    throw new InvalidWorldBoundariesException();
                }

                _pluginFunctions.SetWorldBounds(value.Maximum.X, value.Minimum.X, value.Maximum.Y, value.Minimum.Y);
                ErrorDetection.ValidateLastError();
            }
        }

        public void Shutdown()
        {
            ErrorDetection.ValidateServerInitialized();

            _pluginFunctions.ShutdownServer();
            // This function shuts the server down.
            // We can not check for errors anymore, since the server would have shut down by this point.
        }
    }
}
