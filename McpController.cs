﻿// Decompiled with JetBrains decompiler
// Type: Harmony.Backend.Controllers.McpController
// Assembly: Shard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6F3E0BBF-2B21-48FA-A25C-D99F6888BB4F
// Assembly location: C:\Users\vloge\Downloads\HarmonyMultiplayerLauncher\Shard.dll

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Harmony.Backend.Models.Exceptions.Failsafe;
using Harmony.Backend.Models.Fortnite;
using Harmony.Backend.Models.Profile;
using Harmony.Backend.Models.Profile.Changes;
using Harmony.Backend.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Harmony.Backend.Controllers
{
  [Route("fortnite/api/game/v2/profile/{accountId}/client")]
  [ApiController]
  public class McpController : ControllerBase
  {
    public static Action OnHarmonyRequested;
    private readonly IProfileService _profileService;
    private readonly string _profile;
    private readonly List<object> _changes;
    private readonly int _rvn;

    public McpController(IProfileService profileService, IHttpContextAccessor accessor)
    {
      this._profileService = profileService;
      this._profile = accessor.HttpContext.Request.Query["profileId"].ToString() ?? "common_core";
      if (!int.TryParse((string) accessor.HttpContext.Request.Query["rvn"], out this._rvn))
        this._rvn = -1;
      this._changes = new List<object>();
    }

    [HttpPost("QueryProfile")]
    [HttpPost("ClientQuestLogin")]
    [HttpPost("GetMcpTimeForLogin")]
    [HttpPost("RefreshExpeditions")]
    [HttpPost("IncrementNamedCounterStat")]
    public ActionResult<McpResponse> QueryProfile(string accountId)
    {
      Action onHarmonyRequested = McpController.OnRiftRequested;
      if (onHarmonyRequested != null)
        onHarmonyRequested();
      McpController.OnHarmonyRequested = (Action) null;
      string profile = this._profile;
      return (ActionResult<McpResponse>) new McpResponse(profile == "profile0" ? this._profileService.GenerateCommonCoreProfile(accountId, this._profile) : (profile == "common_core" ? this._profileService.GenerateCommonCoreProfile(accountId, this._profile) : (profile == "athena" ? this._profileService.GenerateAthenaProfile(accountId, this.Request.GetSeasonNumber()) : this._profileService.GenerateBlankProfile(accountId, this._profile))), this._rvn, this._profile, this._changes);
    }

    [HttpPost("SetHardcoreModifier")]
    public ActionResult<McpResponse> SetHardcoreModifier(string accountId) => (ActionResult<McpResponse>) new McpResponse(this._profileService.GenerateAthenaProfile(accountId, this.Request.GetSeasonNumber()), this._rvn, this._profile, this._changes);

    [HttpPost("SetMtxPlatform")]
    public ActionResult<McpResponse> SetMtxPlatform(
      [FromBody] Harmony.Backend.Models.Commands.Currency.SetMtxPlatform body,
      string accountId)
    {
      this._changes.Add((object) new McpStatModified("current_mtx_platform", (object) body.NewPlatform.ToString()));
      return (ActionResult<McpResponse>) new McpResponse(this._profileService.GenerateCommonCoreProfile(accountId), this._rvn, this._profile, this._changes);
    }

    [HttpPost("EquipBattleRoyaleCustomization")]
    public ActionResult<McpResponse> EquipBattleRoyaleCustomization(
      [FromBody] Harmony.Backend.Models.Commands.Cosmetics.EquipBattleRoyaleCustomization body,
      string accountId)
    {
      string lower = body.SlotName.ToString().ToLower();
      if (!((IEnumerable<string>) Program.WhitelistedCosmetics).Contains<string>(body.ItemToSlot) && !(body.ItemToSlot == ""))
        throw new CosmeticsDisallowedException();
      if (lower == "dance")
        ((string[]) Program.CosmeticLoadout[lower])[body.IndexWithinSlot] = body.ItemToSlot;
      else
        Program.CosmeticLoadout[lower] = (object) body.ItemToSlot;
      this._changes.Add((object) new McpStatModified("favorite_" + lower, Program.CosmeticLoadout[lower]));
      return (ActionResult<McpResponse>) new McpResponse(this._profileService.GenerateAthenaProfile(accountId, this.Request.GetSeasonNumber()), this._rvn, this._profile, this._changes, true);
    }

    [HttpPost("SetBattleRoyaleBanner")]
    public ActionResult<McpResponse> SetBattleRoyaleBanner(
      [FromBody] Harmony.Backend.Models.Commands.Cosmetics.SetBattleRoyaleBanner body,
      string accountId)
    {
      throw new CosmeticsDisallowedException();
    }

    [HttpPost("SetCosmeticLockerSlot")]
    public ActionResult<McpResponse> SetCosmeticLockerSlot(
      [FromBody] Harmony.Backend.Models.Commands.Cosmetics.SetCosmeticLockerSlot body,
      string accountId)
    {
      string lower = body.Category.ToString().ToLower();
      if (!((IEnumerable<string>) Program.WhitelistedCosmetics).Contains<string>(body.ItemToSlot) && !(body.ItemToSlot == ""))
        throw new CosmeticsDisallowedException();
      if (lower == "dance")
        ((string[]) Program.CosmeticLoadout[lower])[body.SlotIndex] = body.ItemToSlot;
      else
        Program.CosmeticLoadout[lower] = (object) body.ItemToSlot;
      AthenaLockerSlotsData athenaLockerSlotsData = new AthenaLockerSlotsData()
      {
        Slots = new Dictionary<string, AthenaLockerSlot>()
        {
          {
            "Character",
            new AthenaLockerSlot((List<ItemVariant>) null, new string[1]
            {
              Program.CosmeticLoadout["character"].ToString()
            })
          },
          {
            "Backpack",
            new AthenaLockerSlot((List<ItemVariant>) null, new string[1]
            {
              Program.CosmeticLoadout["backpack"].ToString()
            })
          },
          {
            "Pickaxe",
            new AthenaLockerSlot((List<ItemVariant>) null, new string[1]
            {
              Program.CosmeticLoadout["pickaxe"].ToString()
            })
          },
          {
            "Glider",
            new AthenaLockerSlot((List<ItemVariant>) null, new string[1]
            {
              Program.CosmeticLoadout["glider"].ToString()
            })
          },
          {
            "SkyDiveContrail",
            new AthenaLockerSlot((List<ItemVariant>) null, new string[1]
            {
              Program.CosmeticLoadout["skydivecontrail"].ToString()
            })
          },
          {
            "LoadingScreen",
            new AthenaLockerSlot((List<ItemVariant>) null, new string[1]
            {
              Program.CosmeticLoadout["loadingscreen"].ToString()
            })
          },
          {
            "MusicPack",
            new AthenaLockerSlot((List<ItemVariant>) null, new string[1]
            {
              Program.CosmeticLoadout["musicpack"].ToString()
            })
          },
          {
            "Dance",
            new AthenaLockerSlot((List<ItemVariant>) null, (string[]) Program.CosmeticLoadout["dance"])
          },
          {
            "ItemWrap",
            new AthenaLockerSlot((List<ItemVariant>) null, (string[]) Program.CosmeticLoadout["itemwrap"])
          }
        }
      };
      this._changes.Add((object) new McpItemAttrChanged(body.LockerItem, "locker_slots_data", (object) athenaLockerSlotsData));
      return (ActionResult<McpResponse>) new McpResponse(this._profileService.GenerateAthenaProfile(accountId, this.Request.GetSeasonNumber()), this._rvn, this._profile, this._changes, true);
    }

    [HttpPost("SetCosmeticLockerBanner")]
    public ActionResult<McpResponse> SetCosmeticLockerBanner(
      [FromBody] Harmony.Backend.Models.Commands.Cosmetics.SetCosmeticLockerBanner body,
      string accountId)
    {
      throw new CosmeticsDisallowedException();
    }

    [HttpPost("SetItemFavoriteStatusBatch")]
    public ActionResult<McpResponse> SetItemFavoriteStatusBatch(
      [FromBody] Harmony.Backend.Models.Commands.Cosmetics.SetItemFavoriteStatusBatch body,
      string accountId)
    {
      throw new CosmeticsDisallowedException();
    }
  }
}
