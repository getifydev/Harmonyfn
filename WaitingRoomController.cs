// Decompiled with JetBrains decompiler
// Type: Harmony.Backend.Controllers.WaitingRoomController
// Assembly: Shard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6F3E0BBF-2B21-48FA-A25C-D99F6888BB4F
// Assembly location: C:\Users\vloge\Downloads\HarmonyMultiplayerLauncher\Shard.dll

using Microsoft.AspNetCore.Mvc;

namespace Harmony.Backend.Controllers
{
  [Route("[controller]/api/waitingroom")]
  [ApiController]
  public class WaitingRoomController : ControllerBase
  {
    public ActionResult GetWaitingRoom() => (ActionResult) this.NoContent();
  }
}
