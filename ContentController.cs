// Decompiled with JetBrains decompiler
// Type: harmony.Backend.Controllers.ContentController
// Assembly: Shard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6F3E0BBF-2B21-48FA-A25C-D99F6888BB4F
// Assembly location: C:\Users\vloge\Downloads\HarmonyLauncherMultiplayer\Shard.dll

using Microsoft.AspNetCore.Mvc;
using Harmony.Backend.Models.Content;
using System;

namespace Harmony.Backend.Controllers
{
  [Route("[controller]/api/pages/fortnite-game")]
  [ApiController]
  public class ContentController : ControllerBase
  {
    public ActionResult<Pages> GetContentPages()
    {
      int seasonNumber = this.Request.GetSeasonNumber();
      Decimal buildVersion = this.Request.GetBuildVersion();
      string str;
      switch (seasonNumber)
      {
        case 10:
          str = "seasonx";
          break;
        case 15:
          str = "season15xmas";
          break;
        default:
          str = string.Format("season{0}", (object) seasonNumber);
          break;
      }
      string stage = str;
      if (buildVersion >= 14.40M && buildVersion < 14.50M)
        stage = "halloween2020";
      string tileImage = "file:///c%3A/Users/S501892/Downloads/Harmony-launcher/HarmonySource-Code-main/Rift-Source-Code-main/Shard/Controllers/HarmonyLauncherHomeBackground.jpg";
      if (seasonNumber >= 5)
        tileImage = "file:///c%3A/Users/S501892/Downloads/Harmony-launcher/HarmonySource-Code-main/Rift-Source-Code-main/Shard/Controllers/HarmonyLauncherHomeBackground.jpg";
      return (ActionResult<Pages>) new Pages()
      {
        BattleRoyaleNews = new BattleRoyaleNewsEntry(new object[1]
        {
          (object) new BattleRoyaleNewsWebsiteMOTD("Harmony", "Welcome to Harmony launch!\nTo go in-game and begin your experience, press F3.", "file:///C:/Users/S501892/Downloads/Harmony.jpg", tileImage, "", "Join Harmony on the Discord")
        }),
        EmergencyNotice = new EmergencyNoticeEntry(new PagesMessage[1]
        {
          new PagesMessage("Harmony", "Press F3 to go in-game.\nDiscord:")
        }),
        SubgameInfo = new SubgameInfoEntry()
        {
          BattleRoyale = new SubgameInfo("Battle Royale", "100 Player PvP", "battleroyale", "", "000000"),
          SaveTheWorld = new SubgameInfo("savetheworld", "Cooperative PvE Adventure", "savetheworld", "", "7615E9FF"),
          Creative = new SubgameInfo("", "Your Islands. Your Friends. Your Rules.", "creative", "", "13BDA1FF")
        },
        SubgameSelect = new SubgameSelectEntry()
        {
          BattleRoyale = new PagesMessage("100 Player PvP", "100 Player PvP Battle Royale.\n\nPvE Progress does not affect Battle Royale.", ""),
          SaveTheWorld = new PagesMessage("Co-op PvE", "Cooperative PvE storm-fighting adventure!", ""),
          Creative = new PagesMessage("NEW - Build Your Own Island!", "Create your own unique games and play with your friends!", "")
        },
        DynamicBackgrounds = new DynamicBackground()
        {
          Backgrounds = new Background(new BackgroundData[2]
          {
            new BackgroundData(stage, "lobby"),
            new BackgroundData(stage, "vault")
          })
        }
      };
    }
  }
}
