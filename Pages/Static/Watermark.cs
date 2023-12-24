// Decompiled with JetBrains decompiler
// Type: Harmony.Frontend.Pages.Static.Watermark
// Assembly: Haromny, Version=2.1.0.4, Culture=neutral, PublicKeyToken=null
// MVID: 0ACAFB20-2A21-412B-9705-20731E51C852
// Assembly location: C:\Users\vloge\Downloads\HarmonyMultiplayerLauncher\Harmony.dll

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Harmony.Frontend.Utilities;

namespace Harmony.Frontend.Pages.Static
{
  public class Watermark : ComponentBase
  {
    protected override void BuildRenderTree(RenderTreeBuilder __builder)
    {
      __builder.OpenElement(0, "div");
      __builder.AddAttribute(1, "class", "watermark");
      __builder.AddAttribute(2, "onclick", "Harmony.tabManager.setTab('info')");
      __builder.AddMarkupContent(3, "\n    ");
      __builder.AddContent(4, Strings.VERSION_STRING);
      __builder.AddMarkupContent(5, "\n");
      __builder.CloseElement();
    }
  }
}
