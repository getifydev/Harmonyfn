// Decompiled with JetBrains decompiler
// Type: Harmony.Frontend.Models.Config.Installation
// Assembly: Harmony, Version=2.1.0.4, Culture=neutral, PublicKeyToken=null
// MVID: 0ACAFB20-2A21-412B-9705-20731E51C852
// Assembly location: C:\Users\vloge\Downloads\HarmonyMultiplayerLauncher\Harmony.dll

using System.Text.Json.Serialization;

namespace Harmony.Frontend.Models.Config
{
  public class Installation
  {
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("path")]
    public string Path { get; set; }

    [JsonPropertyName("id")]
    public string Id => this.Name.ToLower().Replace(" ", "-");
  }
}
