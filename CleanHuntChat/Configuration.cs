using Dalamud.Configuration;
using System;

namespace SamplePlugin;

[Serializable]
public class Configuration : IPluginConfiguration
{
    public int Version { get; set; } = 1;
    public int EnabledDurationInMinutes { get; set; } = 60;

    public void Save()
    {
        Plugin.PluginInterface.SavePluginConfig(this);
    }
}
