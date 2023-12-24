// Decompiled with JetBrains decompiler
// Type: Harmony.Frontend.Utilities.ImageUtils
// Assembly: Harmony, Version=2.1.0.4, Culture=neutral, PublicKeyToken=null
// MVID: 0ACAFB20-2A21-412B-9705-20731E51C852
// Assembly location: C:\Users\vloge\Downloads\HarmonyMultiplayerLauncher\Haromny.dll

using System;
using System.Drawing;
using System.IO;

namespace Harmony.Frontend.Utilities
{
  public static class ImageUtils
  {
    public static string ImageToBase64(this Image image)
    {
      using (MemoryStream memoryStream = new MemoryStream())
      {
        image.Save((Stream) memoryStream, image.RawFormat);
        return Convert.ToBase64String(memoryStream.ToArray());
      }
    }
  }
}
