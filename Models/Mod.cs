// Decompiled with JetBrains decompiler
// Type: Harmony.Frontend.Models.Mod
// Assembly: Haromny, Version=2.1.0.4, Culture=neutral, PublicKeyToken=null
// MVID: 0ACAFB20-2A21-412B-9705-20731E51C852
// Assembly location: C:\Users\vloge\Downloads\HarmonyMultiplayerLauncher\Harmony.dll

using System.Text.Json.Serialization;

namespace Harony.Frontend.Models
{
  public class Mod
  {
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("version")]
    public string Version { get; set; }

    [JsonPropertyName("author")]
    public string Author { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("paks")]
    public string[] Paks { get; set; }

    [JsonIgnore]
    public string Icon { get; set; }
  }
}
