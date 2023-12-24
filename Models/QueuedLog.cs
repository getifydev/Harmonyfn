// Decompiled with JetBrains decompiler
// Type: .Frontend.Models.QueuedLog
// Assembly: Harmony, Version=2.1.0.4, Culture=neutral, PublicKeyToken=null
// MVID: 0ACAFB20-2A21-412B-9705-20731E51C852
// Assembly location: C:\Users\vloge\Downloads\HarmonyMultiplayerLauncher\Harmony.dll

using Harmony.Frontend.Enums;

namespace Harmony.Frontend.Models
{
  public readonly struct QueuedLog
  {
    public readonly string Message;
    public readonly LogCategory Category;
    public readonly LogType Type;

    public QueuedLog(string message, LogCategory category, LogType type)
    {
      this.Message = message;
      this.Category = category;
      this.Type = type;
    }
  }
}
