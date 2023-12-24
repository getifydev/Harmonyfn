// Decompiled with JetBrains decompiler
// Type: Harmony.Frontend.Utilities.Logger
// Assembly: Harmony, Version=2.1.0.4, Culture=neutral, PublicKeyToken=null
// MVID: 0ACAFB20-2A21-412B-9705-20731E51C852
// Assembly location: C:\Users\vloge\Downloads\HarmonyMultiplayerLauncher\Harmony.dll

using Harmony.Frontend.Enums;
using Harmony.Frontend.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace Harmony.Frontend.Utilities
{
  public static class Logger
  {
    private static TextWriter _writer;
    private static readonly List<QueuedLog> _logQueue = new List<QueuedLog>();

    public static void Start()
    {
      if (File.Exists(Strings.LOG_PATH))
        File.Delete(Strings.LOG_PATH);
      Logger._writer = (TextWriter) File.CreateText(Strings.LOG_PATH);
      Logger._writer.WriteLine("# Harmony Log");
      Logger._writer.WriteLine(string.Format("# Started on {0}", (object) DateTime.Now));
      Logger._writer.WriteLine("# If anything goes wrong, please send the entirety of this file in our Discord server's bug report channel.");
      Logger._writer.WriteLine("# Discord invite: discord.gg/Harmonyfn\n");
      Logger._writer.Flush();
    }

    public static void Log(string message, LogCategory category = LogCategory.None, LogType level = LogType.Information)
    {
      Logger._writer.WriteLine(string.Format("[{0} {1}] {2}", (object) DateTime.Now, (object) level.GetDescription(), (object) message));
      Logger._writer.Flush();
    }

    public static void WriteLogQueue() => Logger._logQueue?.ForEach((Action<QueuedLog>) (msg => Logger.Log(msg.Message, msg.Category, msg.Type)));
  }
}
