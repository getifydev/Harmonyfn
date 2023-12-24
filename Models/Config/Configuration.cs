// Decompiled with JetBrains decompiler
// Type: Harmony.Frontend.Models.Config.Configuration
// Assembly: Harmony, Version=2.1.0.4, Culture=neutral, PublicKeyToken=null
// MVID: 0ACAFB20-2A21-412B-9705-20731E51C852
// Assembly location: C:\Users\vloge\Downloads\HarmonyMultiplayerLauncher\Harmony.dll

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Harmony.Frontend.Models.Config
{
  public class Configuration
  {
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; }

    [JsonPropertyName("launchArgs")]
    public string LaunchArgs { get; set; } = string.Empty;

    [JsonPropertyName("installs")]
    public List<Installation> Installations { get; set; } = new List<Installation>();
  }
}
