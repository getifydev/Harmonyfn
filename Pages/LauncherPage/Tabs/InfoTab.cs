﻿// Decompiled with JetBrains decompiler
// Type: Harmony.Frontend.Pages.LauncherPage.Tabs.InfoTab
// Assembly: Haromny, Version=2.1.0.4, Culture=neutral, PublicKeyToken=null
// MVID: 0ACAFB20-2A21-412B-9705-20731E51C852
// Assembly location: C:\Users\vloge\Downloads\HarmonyMultiplayerLauncher\Harmony.dll

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Web;
using Harmony.Frontend.Services;
using Harmony.Frontend.Utilities;
using System;
using System.Threading.Tasks;


#nullable enable
namespace Harmony.Frontend.Pages.LauncherPage.Tabs
{
  public class InfoTab : ComponentBase
  {
    public static bool AllowManualUpdateCheck = true;

    protected override void BuildRenderTree(
    #nullable disable
    RenderTreeBuilder __builder)
    {
      __builder.OpenElement(0, "div");
      __builder.AddAttribute(1, "id", "info-page");
      __builder.AddAttribute(2, "style", "display: none;");
      __builder.AddMarkupContent(3, "\n    ");
      __builder.AddMarkupContent(4, "<div class=\"header\" style=\"transform: translateY(0px);\">\n        <img src=\"/img/Harmonybanner.jpg\" alt=\"Harmony Banner\">\n        <div class=\"fade\"></div>\n    </div>\n    ");
      __builder.OpenElement(5, "div");
      __builder.AddAttribute(6, "class", "section vertical");
      __builder.AddMarkupContent(7, "\n        ");
      __builder.AddMarkupContent(8, "<h1>About Harmony</h1>\n        ");
      __builder.OpenElement(9, "div");
      __builder.AddContent(10, "Made by ");
      __builder.OpenElement(11, "span");
      __builder.AddAttribute(12, "class", "hyperlink");
      __builder.AddAttribute<MouseEventArgs>(13, "onclick", EventCallback.Factory.Create<MouseEventArgs>((object) this, (Action) (() => WindowsUtilities.OpenURL(""))));
      __builder.AddContent(14, "Makks");
      __builder.CloseElement();
      __builder.CloseElement();
      __builder.AddMarkupContent(15, "\n        ");
      __builder.OpenElement(16, "div");
      __builder.AddContent(17, "Launcher made By ");
      __builder.OpenElement(18, "span");
      __builder.AddAttribute(19, "class", "hyperlink");
      __builder.AddAttribute<MouseEventArgs>(20, "onclick", EventCallback.Factory.Create<MouseEventArgs>((object) this, (Action) (() => WindowsUtilities.OpenURL(""))));
      __builder.AddContent(21, "Scar - Discord");
      __builder.CloseElement();
      __builder.CloseElement();
      __builder.AddMarkupContent(22, "\n        ");
      __builder.OpenElement(23, "div");
      __builder.AddContent(24, "Backend made by");
      __builder.OpenElement(25, "span");
      __builder.AddAttribute(26, "class", "hyperlink");
      __builder.AddAttribute<MouseEventArgs>(27, "onclick", EventCallback.Factory.Create<MouseEventArgs>((object) this, (Action) (() => WindowsUtilities.OpenURL(""))));
      __builder.AddContent(28, "android - Discord");
      __builder.CloseElement();
      __builder.CloseElement();
      __builder.AddMarkupContent(29, "\n    ");
      __builder.CloseElement();
      __builder.AddMarkupContent(30, "\n");
      if (InfoTab.AllowManualUpdateCheck)
      {
        __builder.AddContent(31, "        ");
        __builder.OpenElement(32, "div");
        __builder.AddAttribute(33, "class", "section vertical");
        __builder.AddMarkupContent(34, "\n            ");
        __builder.AddMarkupContent(35, "<h1>Updates</h1>\n            ");
        __builder.OpenElement(36, "button");
        __builder.AddAttribute<MouseEventArgs>(37, "onclick", EventCallback.Factory.Create<MouseEventArgs>((object) this, (Func<Task>) (async () =>
        {
          await Hammer.Patch();
          this._updateService.CheckForUpdates();
        })));
        __builder.AddContent(38, "Check for Harmony updates");
        __builder.CloseElement();
        __builder.AddMarkupContent(39, "\n        ");
        __builder.CloseElement();
        __builder.AddMarkupContent(40, "\n");
      }
      __builder.CloseElement();
    }

    [Inject]
    private UpdateService _updateService { get; set; }
  }
}
