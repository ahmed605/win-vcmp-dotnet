#include <cstdio>
#include <exception>
#include <iostream>
#include <plugin.h>

#include "plugin_host.hxx"

#if defined(_MSC_VER)
#define EXPORT __declspec(dllexport)
#else
#define EXPORT
#endif

dotnet_vcmp::plugin_host* g_pluginHost;

extern "C" EXPORT unsigned int VcmpPluginInit(PluginFuncs &p_pluginFuncs, PluginCallbacks &p_pluginCallbacks, PluginInfo &p_pluginInfo) {
    g_pluginHost = new dotnet_vcmp::plugin_host(p_pluginFuncs, p_pluginCallbacks, p_pluginInfo);

    try {
        g_pluginHost->setup_plugin_info();
        g_pluginHost->load_config();
        g_pluginHost->init_runtime();
        g_pluginHost->bootstrap();
    } catch (std::exception &exception) {
        std::cout << "[dotnet-vcmp: FATAL] " << exception.what() << std::endl;
    }

    return 1;
}
