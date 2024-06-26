using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ACE.Entity.Enum.Properties
{
    public enum PropertyBool : ushort
    {
        // properties marked as ServerOnly are properties we never saw in PCAPs, from here:
        // http://ac.yotesfan.com/ace_object/not_used_enums.php
        // source: @OptimShi
        // description attributes are used by the weenie editor for a cleaner display name

        Undef                            = 0,
        [Ephemeral][ServerOnly]
        Stuck                            = 1,
        [Ephemeral]
        Open                             = 2,
        Locked                           = 3,
        RotProof                         = 4,
        AllegianceUpdateRequest          = 5,
        AiUsesMana                       = 6,
        AiUseHumanMagicAnimations        = 7,
        AllowGive                        = 8,
        CurrentlyAttacking               = 9,
        AttackerAi                       = 10,
        [ServerOnly]
        IgnoreCollisions                 = 11,
        [ServerOnly]
        ReportCollisions                 = 12,
        [ServerOnly]
        Ethereal                         = 13,
        [ServerOnly]
        GravityStatus                    = 14,
        [ServerOnly]
        LightsStatus                     = 15,
        [ServerOnly]
        ScriptedCollision                = 16,
        [ServerOnly]
        Inelastic                        = 17,
        [ServerOnly][Ephemeral]
        Visibility                       = 18,
        [ServerOnly]
        Attackable                       = 19,
        SafeSpellComponents              = 20,
        AdvocateState                    = 21,
        Inscribable                      = 22,
        DestroyOnSell                    = 23,
        UiHidden                         = 24,
        IgnoreHouseBarriers              = 25,
        HiddenAdmin                      = 26,
        PkWounder                        = 27,
        PkKiller                         = 28,
        NoCorpse                         = 29,
        UnderLifestoneProtection         = 30,
        ItemManaUpdatePending            = 31,
        [Ephemeral]
        GeneratorStatus                  = 32,
        [Ephemeral]
        ResetMessagePending              = 33,
        DefaultOpen                      = 34,
        DefaultLocked                    = 35,
        DefaultOn                        = 36,
        OpenForBusiness                  = 37,
        IsFrozen                         = 38,
        DealMagicalItems                 = 39,
        LogoffImDead                     = 40,
        ReportCollisionsAsEnvironment    = 41,
        AllowEdgeSlide                   = 42,
        AdvocateQuest                    = 43,
        [Ephemeral][SendOnLogin]
        IsAdmin                          = 44,
        [Ephemeral][SendOnLogin]
        IsArch                           = 45,
        [Ephemeral][SendOnLogin]
        IsSentinel                       = 46,
        [SendOnLogin]
        IsAdvocate                       = 47,
        CurrentlyPoweringUp              = 48,
        [Ephemeral]
        GeneratorEnteredWorld            = 49,
        NeverFailCasting                 = 50,
        VendorService                    = 51,
        AiImmobile                       = 52,
        DamagedByCollisions              = 53,
        IsDynamic                        = 54,
        IsHot                            = 55,
        IsAffecting                      = 56,
        AffectsAis                       = 57,
        SpellQueueActive                 = 58,
        [Ephemeral]
        GeneratorDisabled                = 59,
        IsAcceptingTells                 = 60,
        LoggingChannel                   = 61,
        OpensAnyLock                     = 62,
        UnlimitedUse                     = 63,
        GeneratedTreasureItem            = 64,
        IgnoreMagicResist                = 65,
        IgnoreMagicArmor                 = 66,
        AiAllowTrade                     = 67,
        [SendOnLogin]
        SpellComponentsRequired          = 68,
        IsSellable                       = 69,
        IgnoreShieldsBySkill             = 70,
        NoDraw                           = 71,
        ActivationUntargeted             = 72,
        HouseHasGottenPriorityBootPos    = 73,
        [Ephemeral]
        GeneratorAutomaticDestruction    = 74,
        HouseHooksVisible                = 75,
        HouseRequiresMonarch             = 76,
        HouseHooksEnabled                = 77,
        HouseNotifiedHudOfHookCount      = 78,
        AiAcceptEverything               = 79,
        IgnorePortalRestrictions         = 80,
        RequiresBackpackSlot             = 81,
        DontTurnOrMoveWhenGiving         = 82,
        [ServerOnly]
        NpcLooksLikeObject               = 83,
        IgnoreCloIcons                   = 84,
        AppraisalHasAllowedWielder       = 85,
        ChestRegenOnClose                = 86,
        LogoffInMinigame                 = 87,
        PortalShowDestination            = 88,
        PortalIgnoresPkAttackTimer       = 89,
        NpcInteractsSilently             = 90,
        Retained                         = 91,
        IgnoreAuthor                     = 92,
        Limbo                            = 93,
        AppraisalHasAllowedActivator     = 94,
        ExistedBeforeAllegianceXpChanges = 95,
        IsDeaf                           = 96,
        [Ephemeral][SendOnLogin]
        IsPsr                            = 97,
        Invincible                       = 98,
        Ivoryable                        = 99,
        Dyable                           = 100,
        CanGenerateRare                  = 101,
        CorpseGeneratedRare              = 102,
        NonProjectileMagicImmune         = 103,
        [SendOnLogin]
        ActdReceivedItems                = 104,
        Unknown105                       = 105,
        [Ephemeral]
        FirstEnterWorldDone              = 106,
        RecallsDisabled                  = 107,
        RareUsesTimer                    = 108,
        ActdPreorderReceivedItems        = 109,
        [Ephemeral]
        Afk                              = 110,
        IsGagged                         = 111,
        ProcSpellSelfTargeted            = 112,
        IsAllegianceGagged               = 113,
        EquipmentSetTriggerPiece         = 114,
        Uninscribe                       = 115,
        WieldOnUse                       = 116,
        ChestClearedWhenClosed           = 117,
        NeverAttack                      = 118,
        SuppressGenerateEffect           = 119,
        TreasureCorpse                   = 120,
        EquipmentSetAddLevel             = 121,
        BarberActive                     = 122,
        TopLayerPriority                 = 123,
        NoHeldItemShown                  = 124,
        LoginAtLifestone                 = 125,
        OlthoiPk                         = 126,
        [SendOnLogin]
        Account15Days                    = 127,
        HadNoVitae                       = 128,
        NoOlthoiTalk                     = 129,
        AutowieldLeft                    = 130,

        /* custom */
        [ServerOnly]
        LinkedPortalOneSummon            = 9001,
        [ServerOnly]
        LinkedPortalTwoSummon            = 9002,
        [ServerOnly]
        HouseEvicted                     = 9003,
        [ServerOnly]
        UntrainedSkills                  = 9004,
        [Ephemeral][ServerOnly]
        IsEnvoy                          = 9005,
        [ServerOnly]
        UnspecializedSkills              = 9006,
        [ServerOnly]
        FreeSkillResetRenewed            = 9007,
        [ServerOnly]
        FreeAttributeResetRenewed        = 9008,
        [ServerOnly]
        SkillTemplesTimerReset           = 9009,
        [ServerOnly]
        Empowered                        = 9010,
        [ServerOnly]
        Proto                            = 9011,
        [ServerOnly]
        Ascended                         = 9012,
        [ServerOnly]
        Arramoran                        = 9013,
        [ServerOnly]
        GunBlade                         = 9014,
        [ServerOnly]
        PlayerLootMultiplier             = 9015,
        [ServerOnly]
        SpeedRunning                     = 9016,
        [ServerOnly]
        MultiPet                         = 9017,
        [ServerOnly]
        Hardcore                         = 9018,
        [ServerOnly]
        HasBounty                        = 9019,
        [ServerOnly]
        IsHoTTicking                     = 9020,
        [ServerOnly]
        IsWarChanneling                  = 9021,
        [ServerOnly]
        Hot1                             = 9022,
        Hot2                             = 9023,
        Hot3                             = 9024,
        Hot4                             = 9025,
        Hot5                             = 9026,
        Hot6                             = 9027,
        Hot7                             = 9028,
        Hot8                             = 9029,
        [ServerOnly]
        Sot1                             = 9030,
        Sot2                             = 9031,
        Sot3                             = 9032,
        Sot4                             = 9033,
        Sot5                             = 9034,
        Sot6                             = 9035,
        Sot7                             = 9036,
        Sot8                             = 9037,
        [ServerOnly]
        IsDps                            = 9038,
        IsTank                           = 9039,
        IsHealer                         = 9040,
        IsTankBuffed                     = 9041,
        TankBuffedTimer                  = 9042,
        IsMonk                           = 9043,
        IsDamageBuffed                   = 9044,
        DamageBuffedTimer                = 9045,
        IsAbilityItem                    = 9046,
        Brutalize                        = 9047,
        DoBrutalizeAttack                = 9048,
        LifeWell                         = 9049,
        Stealth                          = 9050,
        IsSneaking                       = 9051,
        IsTaunting                       = 9052,
        TauntTimerActive                 = 9052,
        IsHoTCasting                     = 9053,
        IsSoTCasting                     = 9054,
        MissileAoE                       = 9055,
        DoMissileAoE                     = 9056,
        HasClaimedLandblock              = 9057,
        ClaimableLandblock               = 9058,
        AmIHome                          = 9059,
        IsInvited                        = 9060,
        IsInviting                       = 9061,
        Personal_Struct_Gen_Spawner      = 9062,
    }

    public static class PropertyBoolExtensions
    {
        public static string GetDescription(this PropertyBool prop)
        {
            var description = prop.GetAttributeOfType<DescriptionAttribute>();
            return description?.Description ?? prop.ToString();
        }
    }
}
