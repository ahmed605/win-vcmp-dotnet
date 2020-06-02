using System;
using Fleka.DotnetVcmp.Interop;

namespace Fleka.DotnetVcmp {
    /// <summary>
    /// This structure represents a Vector3 range.
    /// </summary>
    public struct Vector3Range {
        /// <summary>
        /// The lowest possible <see cref="Vector3"/> in this range.
        /// </summary>
        public Vector3 Minimum;
        /// <summary>
        /// The lowest possible <see cref="Vector3"/> in this range.
        /// </summary>
        public Vector3 Maximum;

        /// <summary>
        /// Checks whether <paramref="testee"/> is within this <see cref="Vector3Range">.
        /// </summary>
        public bool IsInRange(Vector3 testee) {
            if (testee.X >= Minimum.X
                && testee.Y >= Minimum.Y
                && testee.Z >= Minimum.Z
                && testee.X <= Maximum.X
                && testee.Y <= Maximum.Y
                && testee.Z <= Maximum.Z) {
                return true;
            } else {
                return false;
            }
        }
    }
}

