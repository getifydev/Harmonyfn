// Decompiled with JetBrains decompiler
// Type: Harmony.Frontend.Models.Nitestats
// Assembly: Harmony, Version=2.1.0.4, Culture=neutral, PublicKeyToken=null
// MVID: 0ACAFB20-2A21-412B-9705-20731E51C852
// Assembly location: C:\Users\vloge\Downloads\HarmonyMultiplayerLauncher\Harmony.dll

using Newtonsoft.Json;

namespace Haromny.Frontend.Models
{
  public static class Nitestats
  {
    public class FlToken
    {
      [JsonProperty("version")]
      public string Version { get; set; }

      [JsonProperty("fltoken")]
      public string Token { get; set; }
    }
  }
}
