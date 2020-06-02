using System;
using Fleka.DotnetVcmp.Interop;

namespace Fleka.DotnetVcmp {
    /// <summary>
    /// This structure represents a Vector2 range.
    /// </summary>
    public struct Vector2Range {
        /// <summary>
        /// The lowest possible <see cref="Vector2"/> in this range.
        /// </summary>
        public Vector2 Minimum;
        /// <summary>
        /// The highest possible <see cref="Vector2"/> in this range.
        /// </summary>
        public Vector2 Maximum;

        /// <summary>
        /// Checks whether <paramref="testee"/> is within this <see cref="Vector2Range">.
        /// </summary>
        public bool IsInRange(Vector2 testee) {
            if (testee.X >= Minimum.X
                && testee.Y >= Minimum.Y
                && testee.X <= Maximum.X
                && testee.Y <= Maximum.Y) {
                return true;
            } else {
                return false;
            }
        }
    }
}

