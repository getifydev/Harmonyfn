// Decompiled with JetBrains decompiler
// Type: Harmony.Backend.Controllers.MatchmakingController
// Assembly: Shard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6F3E0BBF-2B21-48FA-A25C-D99F6888BB4F
// Assembly location: C:\Users\vloge\Downloads\HarmonyMultiplayerLauncher\Shard.dll

using Microsoft.AspNetCore.Mvc;
using Harmony.Backend.Models.Exceptions.Failsafe;
using System.Threading.Tasks;

namespace Harmony.Backend.Controllers
{
  [Route("/fortnite/api/game/v2/matchmakingservice/ticket/player/{playerId}")]
  [ApiController]
  public class MatchmakingController : ControllerBase
  {
    [HttpGet]
    public Task<ActionResult> Get(string playerId) => throw new WrongButtonException();
  }
}
