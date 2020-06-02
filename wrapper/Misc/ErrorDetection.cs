using System;
using Fleka.DotnetVcmp.Interop;

namespace Fleka.DotnetVcmp {
    internal static class ErrorDetection {
        internal static void ValidateLastError() {
            VcmpError lastError = Main.PluginFunctions.GetLastError();

            switch (lastError) {
                case VcmpError.None:
                    return;

                case VcmpError.NoSuchEntity:
                    throw new NoSuchEntityException();

                case VcmpError.BufferTooSmall:
                    throw new BufferTooSmallException();

                case VcmpError.TooLargeInput:
                    throw new TooLargeInputException();

                case VcmpError.ArgumentOutOfBounds:
                    throw new ArgumentOutOfBoundsException();

                case VcmpError.NullArgument:
                    throw new NullArgumentException();

                case VcmpError.PoolExhausted:
                    throw new PoolExhaustedException();

                case VcmpError.InvalidName:
                    throw new InvalidNameException();

                case VcmpError.RequestDenied:
                    throw new RequestDeniedException();
            }
        }

        internal static void ValidateServerInitialized() {
            if (!Game.IsInitialized) {
                throw new ServerNotInitializedException();
            }
        }
    }
}
