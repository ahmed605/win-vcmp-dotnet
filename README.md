# win-vcmp-dotnet

A modified version of [vcmp-dotnet](https://gitlab.com/fleka_e/dotnet-vcmp/) to support Windows and with some fixes and improvements.

### vcmp-dotnet

vcmp-dotnet is a collection of softwares that allow you to script [Vice City: Multiplayer](https://vc-mp.org) servers in any language that supports targeting CoreCLR (C#, F# and VB.Net for example).

> This readme file is currently oriented towards the native API binding and may be updated when the wrapper module is released.

### Changes/Fixes

* Fix `GetPlayerName`, `GetPlayerIP`, `GetPlayerUid` methods
* Fix incorrect CoreClr path for windows version of .NET Core

### Planned features

- [ ] Implementing a full API wrapper
- [ ] Implementing crash handler system

## Compiling

### Requirements

* Visual Studio 2019
* .NET Core 2.0 (Runtime and SDK) or newer
* .NET Stantard 2.0 (Runtime and SDK) or newer

### Locations

| Project                                  | Solutions/Projects location                |
| ---------------------------------------- | ------------------------------------------ |
| Host plugin                              | `/loader/build/dotnet-vcmp.sln`            |
| Native bindings interoperability library | `/interop/Fleka.DotnetVcmp.Interop.csproj` |
| small WIP API wrapper library            | `/wrapper/Fleka.DotnetVcmp.csproj`         |

## Usage

### dotnet.json

You need to have a file called `dotnet.json` in your server's root.

This is a list of keys the file must contain:

| Key                                      | Description                                            |
| ---------------------------------------- | ------------------------------------------------------ |
| `clr.runtime-directory`                  | The directory that contains libcoreclr.so/coreclr.dll. |
| `clr.server-executable`                  | The path to the server binary.                         |
| `clr.assemblies-directory`               | The path to your .NET managed assemblies.              |
| `clr.native-image-assemblies-directory`  | Same as the above but for native image assemblies.     |
| `clr.native-dll-search-directories`      | The directory to search for dynamic libraries.         |
| `app-domain.friendly-name`               | The friendly name of the default AppDomain.            |

Here is an example `dotnet.json` file:

```json
{
    "clr": {
        "runtime-directory": "C:/Program Files/dotnet/shared/Microsoft.NETCore.App/3.0.0",
        "server-executable": "./server64.exe",
        "assemblies-directory": "./dotnet-assemblies",
        "native-image-assemblies-directory": "",
        "native-dll-search-directories": ["C:/libs"]
    },
    "app-domain": {
        "friendly-name": "Example dotnet-vcmp configuration"
    }
}
```

### Interoperability DLL

You need to place `Fleka.DotnetVcmp.Interop.dll` in your assemblies directory. Add `Fleka.DotnetVcmp.Interop` library to your project.

### From managed code

The interoperability DLL executes an entry point with the following signature:

```cs
void EntryPointDelegate(PluginFunctions pluginFunctions, ref PluginCallbacks pluginCallbacks)
```

To designate a function as the entry point, add `[Fleka.DotnetVcmp.Interop.EntryPoint]` before its definition.

> **IMPORTANT**

> Assigning a function to `pluginCallbacks` will _not_ increase its reference count.
> If you are passing a collectable function (such as a lambda), you _must_ keep a
> reference to it elsewhere as well.

### Hello world

Compile this C# code into a .NET managed DLL (with `Fleka.DotnetVcmp.Interop` as a dependency) and place both of them in your assemblies directory.

```cs
public static class MyTestApp {
    private static Fleka.DotnetVcmp.Interop.PluginFunctions _pluginFunctions;

    [Fleka.DotnetVcmp.Interop.EntryPoint]
    public static void MyEntryPoint(Fleka.DotnetVcmp.Interop.PluginFunctions pluginFunctions, ref Fleka.DotnetVcmp.Interop.PluginCallbacks pluginCallbacks) {
        _pluginFunctions = pluginFunctions;

        pluginCallbacks.OnServerInitialize = OnServerInitialize;
    }

    internal static byte OnServerInitialize() {
        _pluginFunctions.LogMessage("%s", "Hello world");

        return 1;
    }
}
```

## Downloads

- [VCMP native plugin (Windows x64)](https://github.com/ahmed605/win-vcmp-dotnet/releases/latest/download/dotnet-vcmp.dll)
- [C# native bindings interoperability DLL (AnyCPU)](https://github.com/ahmed605/win-vcmp-dotnet/releases/latest/download/Fleka.DotnetVcmp.Interop.dll)
