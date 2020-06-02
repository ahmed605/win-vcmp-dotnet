using System;
using Fleka.DotnetVcmp.Interop;

namespace Fleka.DotnetVcmp {
    /// <summary>
    /// This structure represents three points.
    /// </summary>
    public struct Vector3 {
        /// <summary>
        /// The horizontal X coordinate of this vector.
        /// </summary>
        public float X;
        /// <summary>
        /// The horizontal Y coordinate of this vector.
        /// </summary>
        public float Y;
        /// <summary>
        /// The horizontal Z coordinate of this vector.
        /// </summary>
        public float Z;

        /// <summary>
        /// Adds two <see cref="Vector3"/>s together by adding their X, Y and Z values.
        /// </summary>
        public static Vector3 operator+(Vector3 leftSide, Vector3 rightSide) {
            return new Vector3 {
                X = leftSide.X + rightSide.X,
                Y = leftSide.Y + rightSide.Y,
                Z = leftSide.Z + rightSide.Z
            };
        }

        /// <summary>
        /// Negates the value of the <see cref="Vector3"/> by negating its X, Y and Z values.
        /// </summary>
        public static Vector3 operator-(Vector3 rightSide) {
            return new Vector3 {
                X = -rightSide.X,
                Y = -rightSide.Y,
                Z = -rightSide.Z,
            };
        }

        /// <summary>
        /// Subtracts two <see cref="Vector3"/>s together by subtracting their X, Y and Z values.
        /// </summary>
        public static Vector3 operator-(Vector3 leftSide, Vector3 rightSide) {
            return new Vector3 {
                X = leftSide.X - rightSide.X,
                Y = leftSide.Y - rightSide.Y,
                Z = leftSide.Z - rightSide.Z
            };
        }

        /// <summary>
        /// Multiplies two <see cref="Vector3"/>s together by multiplying their X, Y and Z values.
        /// </summary>
        public static Vector3 operator*(Vector3 leftSide, Vector3 rightSide) {
            return new Vector3 {
                X = leftSide.X * rightSide.X,
                Y = leftSide.Y * rightSide.Y,
                Z = leftSide.Z * rightSide.Z
            };
        }

        /// <summary>
        /// Divides two <see cref="Vector3"/>s together by dividing their X, Y and Z values.
        /// </summary>
        public static Vector3 operator/(Vector3 leftSide, Vector3 rightSide) {
            return new Vector3 {
                X = leftSide.X / rightSide.X,
                Y = leftSide.Y / rightSide.Y,
                Z = leftSide.Z / rightSide.Z
            };
        }
    }
}

