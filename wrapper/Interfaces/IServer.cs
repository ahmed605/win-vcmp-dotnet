using System;
using Fleka.DotnetVcmp.Interop;

namespace Fleka.DotnetVcmp {
    /// <summary>
    /// This interface represents the server.
    /// </summary>
    public interface IServer {
        /// <summary>
        /// The version of the server.
        /// </summary>
        uint Version {
            get;
        }

        /// <summary>
        /// The port the server is listening on.
        /// </summary>
        ushort Port {
            get;
        }

        /// <summary>
        /// The number of plugins the server loaded into the server.
        /// </summary>
        uint PluginCount {
            get;
        }

        /// <summary>
        /// The name of the server.
        /// </summary>
        string Name {
            get;
            set;
        }

        /// <summary>
        /// The maximum number of players that can be in the server at once.
        /// </summary>
        byte MaxPlayers {
            get;
            set;
        }

        /// <summary>
        /// The password of the server. An empty password is represented by <c>null</c>.
        /// </summary>
        string Password {
            get;
            set;
        }

        /// <summary>
        /// The game mode text of the server.
        /// </summary>
        string GameModeText {
            get;
            set;
        }

        /// <summary>
        /// Whether the server is enforcing <see cref="IsFrameLimiterEnabled"/> or not.
        /// </summary>
        bool IsFrameLimiterEnforced {
            get;
            set;
        }

        /// <summary>
        /// Whether the server turns the framelimiter off or on. This option only takes effect if
        /// <see cref="IsFrameLimiterSynchronized"/>is <c>true</c>.
        /// </summary>
        bool IsFrameLimiterEnabled {
            get;
            set;
        }

        /// <summary>
        /// Whether taxis can jump using the horn key or not.
        /// </summary>
        bool IsTaxiJumpEnabled {
            get;
            set;
        }

        /// <summary>
        /// Whether cars can be driven on water or not.
        /// </summary>
        bool IsDriveOnWaterEnabled {
            get;
            set;
        }

        /// <summary>
        /// Whether players can quickly switch between weapons in-battle (this is a common
        /// technique in VCMP) or not.
        /// </summary>
        bool IsFastSwitchEnabled {
            get;
            set;
        }

        /// <summary>
        /// Whether players can damage other players of their own team or not.
        /// </summary>
        bool IsFriendlyFireEnabled {
            get;
            set;
        }

        /// <summary>
        /// Whether players can drive-by in cars or not.
        /// </summary>
        bool IsDriveByEnabled {
            get;
            set;
        }

        /// <summary>
        /// Whether vehicles are automatically given perfect handling or not.
        /// </summary>
        bool IsPerfectHandlingEnabled {
            get;
            set;
        }

        /// <summary>
        /// Whether cars can fly or not.
        /// </summary>
        bool IsFlyingCarsEnabled {
            get;
            set;
        }

        /// <summary>
        /// Whether players can switch weapons mid-air or not.
        /// </summary>
        bool IsSwitchInAirEnabled {
            get;
            set;
        }

        /// <summary>
        /// Whether player markers (their blips on the radar) are shown to other players or not.
        /// </summary>
        bool IsPlayerMarkersEnabled {
            get;
            set;
        }

        /// <summary>
        /// Whether only players in the same team can see each others' markers or not.
        /// </summary>
        bool IsExclusiveTeamMarkersEnabled {
            get;
            set;
        }

        /// <summary>
        /// Whether players remain seated in their bikes even after crashing or not.
        /// </summary>
        bool IsStuntBikeEnabled {
            get;
            set;
        }

        /// <summary>
        /// Whether players can shoot mid-air or notsystem.
        /// </summary>
        bool IsShootInAirEnabled {
            get;
            set;
        }

        /// <summary>
        /// The <see cref="Vector2Range"/> players are forced to be within.
        /// </summary>
        Vector2Range WorldBoundaries {
            get;
            set;
        }

        /// <summary>
        /// Shuts the server down.
        /// </summary>
        void Shutdown();
    }
}
