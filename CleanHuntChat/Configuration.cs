using Dalamud.Configuration;
using Dalamud.Plugin;
using System;

namespace SamplePlugin;

[Serializable]
public class Configuration : IPluginConfiguration
{
    public int Version { get; set; } = 0;
    public bool IsConfigWindowMovable { get; set; } = true;
    public bool SomePropertyToBeSavedAndWithADefault { get; set; } = true;

    public bool ShouldFilterChat { get; set; } = false;
    public int EnabledDurationInMinutes { get; set; } = 1;

    public void Save()
    {
        Plugin.PluginInterface.SavePluginConfig(this);
    }
}