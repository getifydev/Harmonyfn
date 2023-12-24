// Decompiled with JetBrains decompiler
// Type: Harmony.Frontend.Pages.Static.Stylesheets
// Assembly: Harmony, Version=2.1.0.4, Culture=neutral, PublicKeyToken=null
// MVID: 0ACAFB20-2A21-412B-9705-20731E51C852
// Assembly location: C:\Users\vloge\Downloads\HarmonyMultiplayerLauncher\Harmony.dll

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Harmony.Frontend.Services;

namespace Harmony.Frontend.Pages.Static
{
  public class Stylesheets : ComponentBase
  {
    protected override void BuildRenderTree(RenderTreeBuilder __builder)
    {
      __builder.AddMarkupContent(0, "<link rel=\"stylesheet\" href=\"css/app.css\">\n<link rel=\"stylesheet\" href=\"css/mods.css\">\n<link rel=\"stylesheet\" href=\"css/fontawesome.css\">\n\n");
      if (!this._configService.RequireFirstTimeSetup)
        return;
      __builder.AddMarkupContent(1, "    <link rel=\"stylesheet\" href=\"css/fts.css\">\n");
    }

    [Inject]
    private ConfigService _configService { get; set; }
  }
}
