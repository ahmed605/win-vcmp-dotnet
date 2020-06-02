using System;
using Fleka.DotnetVcmp.Interop;

namespace Fleka.DotnetVcmp {
    /// <summary>
    /// This structure represents 2 points.
    /// </summary>
    public struct Vector2 {
        /// <summary>
        /// The horizontal X coordinate of this vector.
        /// </summary>
        public float X;
        /// <summary>
        /// The horizontal Y coordinate of this vector.
        /// </summary>
        public float Y;

        /// <summary>
        /// Adds two <see cref="Vector2"/>s together by adding their X and Y values.
        /// </summary>
        public static Vector2 operator+(Vector2 leftSide, Vector2 rightSide) {
            return new Vector2 {
                X = leftSide.X + rightSide.X,
                Y = leftSide.Y + rightSide.Y
            };
        }

        /// <summary>
        /// Negates the value of the <see cref="Vector2"/> by negating its X and Y values.
        /// </summary>
        public static Vector2 operator-(Vector2 rightSide) {
            return new Vector2 {
                X = -rightSide.X,
                Y = -rightSide.Y
            };
        }

        /// <summary>
        /// Subtracts two <see cref="Vector2"/>s together by subtracting their X and Y values.
        /// </summary>
        public static Vector2 operator-(Vector2 leftSide, Vector2 rightSide) {
            return new Vector2 {
                X = leftSide.X - rightSide.X,
                Y = leftSide.Y - rightSide.Y
            };
        }

        /// <summary>
        /// Multiplies two <see cref="Vector2"/>s together by multiplying their X and Y values.
        /// </summary>
        public static Vector2 operator*(Vector2 leftSide, Vector2 rightSide) {
            return new Vector2 {
                X = leftSide.X * rightSide.X,
                Y = leftSide.Y * rightSide.Y
            };
        }

        /// <summary>
        /// Divides two <see cref="Vector2"/>s together by dividing their X and Y values.
        /// </summary>
        public static Vector2 operator/(Vector2 leftSide, Vector2 rightSide) {
            return new Vector2 {
                X = leftSide.X / rightSide.X,
                Y = leftSide.Y / rightSide.Y
            };
        }
    }
}

