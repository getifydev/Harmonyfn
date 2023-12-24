// Decompiled with JetBrains decompiler
// Type: Harmony.Backend.Controllers.LightswitchController
// Assembly: Shard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6F3E0BBF-2B21-48FA-A25C-D99F6888BB4F
// Assembly location: C:\Users\vloge\Downloads\HarmonyMultiplayerLauncher\Shard.dll

using Microsoft.AspNetCore.Mvc;
using Harmony.Backend.Models.Lightswitch;
using System.Collections.Generic;

namespace Harmony.Backend.Controllers
{
  [Route("[controller]/api/service/bulk/status")]
  [ApiController]
  public class LightswitchController : ControllerBase
  {
    public ActionResult<List<LightswitchStatus>> GetLightswitchStatus(
      [FromQuery] string serviceId)
    {
      return (ActionResult<List<LightswitchStatus>>) new List<LightswitchStatus>()
      {
        new LightswitchStatus(serviceId.ToLower())
      };
    }
  }
}
