﻿// Decompiled with JetBrains decompiler
// Type: Harmony.Backend.Controllers.FortniteController
// Assembly: Shard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6F3E0BBF-2B21-48FA-A25C-D99F6888BB4F
// Assembly location: C:\Users\vloge\Downloads\HarmonyMultiplayerLauncher\Shard.dll

using Microsoft.AspNetCore.Mvc;
using Harmony.Backend.Models.Fortnite;
using System;

namespace Harmony.Backend.Controllers
{
  [Route("[controller]/api/")]
  [ApiController]
  public class FortniteController : ControllerBase
  {
    [HttpGet("versioncheck")]
    [HttpGet("v2/versioncheck/{platform}")]
    public ActionResult<VersionCheck> CheckUpdateStatus(string platform) => (ActionResult<VersionCheck>) new VersionCheck("NO_UPDATE");

    [HttpPost("game/v2/tryPlayOnPlatform/account/{accountId}")]
    public ActionResult CheckIfPlatformPlayAllowed(string accountId)
    {
      this.Response.ContentType = "text/plain";
      return (ActionResult) this.Content("true");
    }

    [HttpGet("game/v2/enabled_features")]
    public ActionResult<string[]> GetEnabledFeatures() => (ActionResult<string[]>) Array.Empty<string>();

    [HttpGet("game/v2/world/info")]
    public ActionResult<object> GetWorldInfo() => (ActionResult<object>) new object();

    [HttpGet("game/v2/twitch/{accountId}")]
    public ActionResult<object> GetTwitchInfo(string accountId) => (ActionResult<object>) new object();

    [HttpGet("game/v2/privacy/account/{accountId}")]
    public ActionResult<PrivacySettings> GetPrivacySettings(
      string accountId)
    {
      return (ActionResult<PrivacySettings>) new PrivacySettings(accountId);
    }

    [HttpGet("receipts/v1/account/{accountId}/receipts")]
    public ActionResult<string[]> GetReceipts(string accountId) => (ActionResult<string[]>) Array.Empty<string>();

    [HttpGet("matchmaking/session/findPlayer/{accountId}")]
    public ActionResult<string[]> FindMatchmakingSession(string accountId) => (ActionResult<string[]>) Array.Empty<string>();
  }
}
