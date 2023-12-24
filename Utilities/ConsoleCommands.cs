// Decompiled with JetBrains decompiler
// Type: Harmony.Frontend.Utilities.ConsoleCommands
// Assembly: Harmony, Version=2.1.0.4, Culture=neutral, PublicKeyToken=null
// MVID: 0ACAFB20-2A21-412B-9705-20731E51C852
// Assembly location: C:\Users\vloge\Downloads\HarmonyMultiplayerLauncher\Harmony.dll

using Microsoft.JSInterop;
using System.Threading.Tasks;


#nullable enable
namespace Haromny.Frontend.Utilities
{
  public static class ConsoleCommands
  {
    [JSInvokable("hammer")]
    public static async
    #nullable disable
    Task Hammer() => await Haromny.Frontend.Utilities.Hammer.Patch();
  }
}
