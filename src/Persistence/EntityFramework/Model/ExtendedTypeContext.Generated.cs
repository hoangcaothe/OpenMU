// <copyright file="ExtendedTypeContext.Generated.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

//------------------------------------------------------------------------------
// <auto-generated>
//     This source code was auto-generated by a roslyn code generator.
// </auto-generated>
//------------------------------------------------------------------------------

// ReSharper disable All

namespace MUnique.OpenMU.Persistence.EntityFramework.Model;

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using MUnique.OpenMU.Persistence;

/// <summary>
/// DbContext which sets all extended base types to ignore.
/// </summary>
public class ExtendedTypeContext : Microsoft.EntityFrameworkCore.DbContext
{
    /// <inheritdoc/>
    protected override void OnModelCreating(Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder)
    {
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Statistics.MiniGameRankingEntry>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Entities.Account>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Entities.AppearanceData>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Entities.Character>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Entities.CharacterQuestState>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Entities.Guild>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Entities.GuildMember>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Entities.Item>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Entities.ItemAppearance>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Entities.ItemOptionLink>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Entities.ItemStorage>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Entities.LetterBody>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Entities.QuestMonsterKillRequirementState>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Entities.SkillEntry>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.BattleZoneDefinition>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.CharacterClass>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.ChatServerDefinition>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.ChatServerEndpoint>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.ConfigurationUpdate>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.ConfigurationUpdateState>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.ConnectServerDefinition>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.DropItemGroup>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.EnterGate>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.ExitGate>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.GameClientDefinition>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.GameConfiguration>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.GameMapDefinition>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.GameServerConfiguration>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.GameServerDefinition>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.GameServerEndpoint>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.Gate>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.ItemDropItemGroup>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.JewelMix>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.LevelDependentDamage>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.MagicEffectDefinition>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.MasterSkillDefinition>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.MasterSkillRoot>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.MiniGameChangeEvent>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.MiniGameDefinition>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.MiniGameReward>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.MiniGameSpawnWave>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.MiniGameTerrainChange>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.MonsterAttribute>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.MonsterDefinition>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.MonsterSpawnArea>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.Rectangle>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.Skill>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.SkillComboDefinition>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.SkillComboStep>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.StatAttributeDefinition>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.SystemConfiguration>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.WarpInfo>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.Quests.QuestDefinition>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.Quests.QuestItemRequirement>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.Quests.QuestMonsterKillRequirement>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.Quests.QuestReward>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.Items.AttributeRequirement>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.Items.CombinationBonusRequirement>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.Items.IncreasableItemOption>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.Items.ItemBasePowerUpDefinition>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.Items.ItemDefinition>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.Items.ItemLevelBonusTable>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.Items.ItemOfItemSet>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.Items.ItemOption>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.Items.ItemOptionCombinationBonus>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.Items.ItemOptionDefinition>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.Items.ItemOptionOfLevel>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.Items.ItemOptionType>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.Items.ItemSetGroup>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.Items.ItemSlotType>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.Items.LevelBonus>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.ItemCrafting.ItemCrafting>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.ItemCrafting.ItemCraftingRequiredItem>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.ItemCrafting.ItemCraftingResultItem>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.ItemCrafting.SimpleCraftingSettings>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Attributes.PowerUpDefinition>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Attributes.PowerUpDefinitionValue>();
        modelBuilder.Ignore<MUnique.OpenMU.AttributeSystem.AttributeDefinition>();
        modelBuilder.Ignore<MUnique.OpenMU.AttributeSystem.StatAttribute>();
        modelBuilder.Ignore<MUnique.OpenMU.AttributeSystem.ConstValueAttribute>();
        modelBuilder.Ignore<MUnique.OpenMU.AttributeSystem.AttributeRelationship>();
        modelBuilder.Ignore<MUnique.OpenMU.Interfaces.LetterHeader>();
        modelBuilder.Ignore<MUnique.OpenMU.Interfaces.Friend>();
        modelBuilder.Ignore<MUnique.OpenMU.PlugIns.PlugInConfiguration>();

        // All members which are marked with the MemberOfAggregateAttribute, should be defined with ON DELETE CASCADE.
        modelBuilder.Entity<Account>().HasOne(entity => entity.RawVault).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<Account>().HasMany(entity => entity.RawCharacters).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<Account>().HasMany(entity => entity.RawAttributes).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<AppearanceData>().HasMany(entity => entity.RawEquippedItems).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<Character>().HasMany(entity => entity.RawAttributes).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<Character>().HasMany(entity => entity.RawLetters).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<Character>().HasMany(entity => entity.RawLearnedSkills).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<Character>().HasOne(entity => entity.RawInventory).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<Character>().HasMany(entity => entity.RawQuestStates).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<CharacterQuestState>().HasMany(entity => entity.RawRequirementStates).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<Item>().HasMany(entity => entity.RawItemOptions).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<ItemStorage>().HasMany(entity => entity.RawItems).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<LetterBody>().HasOne(entity => entity.RawSenderAppearance).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<BattleZoneDefinition>().HasOne(entity => entity.RawGround).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<BattleZoneDefinition>().HasOne(entity => entity.RawLeftGoal).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<BattleZoneDefinition>().HasOne(entity => entity.RawRightGoal).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<CharacterClass>().HasMany(entity => entity.RawStatAttributes).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<CharacterClass>().HasMany(entity => entity.RawAttributeCombinations).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<CharacterClass>().HasMany(entity => entity.RawBaseAttributeValues).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<CharacterClass>().HasOne(entity => entity.RawComboDefinition).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<ChatServerDefinition>().HasMany(entity => entity.RawEndpoints).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<GameConfiguration>().HasMany(entity => entity.RawJewelMixes).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<GameConfiguration>().HasMany(entity => entity.RawWarpList).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<GameConfiguration>().HasMany(entity => entity.RawDropItemGroups).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<GameConfiguration>().HasMany(entity => entity.RawSkills).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<GameConfiguration>().HasMany(entity => entity.RawCharacterClasses).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<GameConfiguration>().HasMany(entity => entity.RawItems).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<GameConfiguration>().HasMany(entity => entity.RawItemLevelBonusTables).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<GameConfiguration>().HasMany(entity => entity.RawItemSlotTypes).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<GameConfiguration>().HasMany(entity => entity.RawItemOptions).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<GameConfiguration>().HasMany(entity => entity.RawItemOptionTypes).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<GameConfiguration>().HasMany(entity => entity.RawItemSetGroups).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<GameConfiguration>().HasMany(entity => entity.RawItemOptionCombinationBonuses).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<GameConfiguration>().HasMany(entity => entity.RawMaps).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<GameConfiguration>().HasMany(entity => entity.RawMonsters).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<GameConfiguration>().HasMany(entity => entity.RawAttributes).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<GameConfiguration>().HasMany(entity => entity.RawMagicEffects).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<GameConfiguration>().HasMany(entity => entity.RawMasterSkillRoots).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<GameConfiguration>().HasMany(entity => entity.RawPlugInConfigurations).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<GameConfiguration>().HasMany(entity => entity.RawMiniGameDefinitions).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<GameMapDefinition>().HasMany(entity => entity.RawMonsterSpawns).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<GameMapDefinition>().HasMany(entity => entity.RawEnterGates).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<GameMapDefinition>().HasOne(entity => entity.RawBattleZone).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<GameMapDefinition>().HasMany(entity => entity.RawExitGates).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<GameMapDefinition>().HasMany(entity => entity.RawMapRequirements).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<GameMapDefinition>().HasMany(entity => entity.RawCharacterPowerUpDefinitions).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<GameServerDefinition>().HasMany(entity => entity.RawEndpoints).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<MagicEffectDefinition>().HasOne(entity => entity.RawDuration).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<MagicEffectDefinition>().HasMany(entity => entity.RawPowerUpDefinitions).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<MiniGameChangeEvent>().HasOne(entity => entity.RawSpawnArea).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<MiniGameChangeEvent>().HasMany(entity => entity.RawTerrainChanges).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<MiniGameDefinition>().HasMany(entity => entity.RawRewards).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<MiniGameDefinition>().HasMany(entity => entity.RawSpawnWaves).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<MiniGameDefinition>().HasMany(entity => entity.RawChangeEvents).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<MonsterDefinition>().HasOne(entity => entity.RawMerchantStore).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<MonsterDefinition>().HasMany(entity => entity.RawItemCraftings).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<MonsterDefinition>().HasMany(entity => entity.RawAttributes).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<MonsterDefinition>().HasMany(entity => entity.RawQuests).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<Skill>().HasMany(entity => entity.RawRequirements).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<Skill>().HasMany(entity => entity.RawConsumeRequirements).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<Skill>().HasOne(entity => entity.RawMasterDefinition).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<SkillComboDefinition>().HasMany(entity => entity.RawSteps).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<QuestDefinition>().HasMany(entity => entity.RawRequiredMonsterKills).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<QuestDefinition>().HasMany(entity => entity.RawRequiredItems).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<QuestDefinition>().HasMany(entity => entity.RawRewards).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<QuestReward>().HasOne(entity => entity.RawItemReward).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<IncreasableItemOption>().HasMany(entity => entity.RawLevelDependentOptions).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<IncreasableItemOption>().HasOne(entity => entity.RawPowerUpDefinition).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<ItemDefinition>().HasMany(entity => entity.RawRequirements).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<ItemDefinition>().HasMany(entity => entity.RawBasePowerUpAttributes).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<ItemDefinition>().HasMany(entity => entity.RawDropItems).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<ItemLevelBonusTable>().HasMany(entity => entity.RawBonusPerLevel).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<ItemOption>().HasOne(entity => entity.RawPowerUpDefinition).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<ItemOptionCombinationBonus>().HasMany(entity => entity.RawRequirements).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<ItemOptionCombinationBonus>().HasOne(entity => entity.RawBonus).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<ItemOptionDefinition>().HasMany(entity => entity.RawPossibleOptions).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<ItemOptionOfLevel>().HasOne(entity => entity.RawPowerUpDefinition).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<ItemSetGroup>().HasMany(entity => entity.RawItems).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<ItemCrafting>().HasOne(entity => entity.RawSimpleCraftingSettings).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<SimpleCraftingSettings>().HasMany(entity => entity.RawRequiredItems).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<SimpleCraftingSettings>().HasMany(entity => entity.RawResultItems).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<PowerUpDefinition>().HasOne(entity => entity.RawBoost).WithOne().OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<PowerUpDefinitionValue>().HasMany(entity => entity.RawRelatedValues).WithOne().OnDelete(DeleteBehavior.Cascade);

    }

    /// <summary>
    /// Adds the generated join definitions.
    /// </summary>
    /// <param name="modelBuilder">The model builder.</param>
    protected void AddJoinDefinitions(Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>().HasMany(entity => entity.JoinedUnlockedCharacterClasses).WithOne(join => join.Account);
        modelBuilder.Entity<AccountCharacterClass>().HasKey(join => new { join.AccountId, join.CharacterClassId });
        modelBuilder.Entity<Character>().HasMany(entity => entity.JoinedDropItemGroups).WithOne(join => join.Character);
        modelBuilder.Entity<CharacterDropItemGroup>().HasKey(join => new { join.CharacterId, join.DropItemGroupId });
        modelBuilder.Entity<Item>().HasMany(entity => entity.JoinedItemSetGroups).WithOne(join => join.Item);
        modelBuilder.Entity<ItemItemOfItemSet>().HasKey(join => new { join.ItemId, join.ItemOfItemSetId });
        modelBuilder.Entity<ItemAppearance>().HasMany(entity => entity.JoinedVisibleOptions).WithOne(join => join.ItemAppearance);
        modelBuilder.Entity<ItemAppearanceItemOptionType>().HasKey(join => new { join.ItemAppearanceId, join.ItemOptionTypeId });
        modelBuilder.Entity<DropItemGroup>().HasMany(entity => entity.JoinedPossibleItems).WithOne(join => join.DropItemGroup);
        modelBuilder.Entity<DropItemGroupItemDefinition>().HasKey(join => new { join.DropItemGroupId, join.ItemDefinitionId });
        modelBuilder.Entity<GameMapDefinition>().HasMany(entity => entity.JoinedDropItemGroups).WithOne(join => join.GameMapDefinition);
        modelBuilder.Entity<GameMapDefinitionDropItemGroup>().HasKey(join => new { join.GameMapDefinitionId, join.DropItemGroupId });
        modelBuilder.Entity<GameServerConfiguration>().HasMany(entity => entity.JoinedMaps).WithOne(join => join.GameServerConfiguration);
        modelBuilder.Entity<GameServerConfigurationGameMapDefinition>().HasKey(join => new { join.GameServerConfigurationId, join.GameMapDefinitionId });
        modelBuilder.Entity<ItemDropItemGroup>().HasMany(entity => entity.JoinedPossibleItems).WithOne(join => join.ItemDropItemGroup);
        modelBuilder.Entity<ItemDropItemGroupItemDefinition>().HasKey(join => new { join.ItemDropItemGroupId, join.ItemDefinitionId });
        modelBuilder.Entity<MasterSkillDefinition>().HasMany(entity => entity.JoinedRequiredMasterSkills).WithOne(join => join.MasterSkillDefinition);
        modelBuilder.Entity<MasterSkillDefinitionSkill>().HasKey(join => new { join.MasterSkillDefinitionId, join.SkillId });
        modelBuilder.Entity<MonsterDefinition>().HasMany(entity => entity.JoinedDropItemGroups).WithOne(join => join.MonsterDefinition);
        modelBuilder.Entity<MonsterDefinitionDropItemGroup>().HasKey(join => new { join.MonsterDefinitionId, join.DropItemGroupId });
        modelBuilder.Entity<Skill>().HasMany(entity => entity.JoinedQualifiedCharacters).WithOne(join => join.Skill);
        modelBuilder.Entity<SkillCharacterClass>().HasKey(join => new { join.SkillId, join.CharacterClassId });
        modelBuilder.Entity<ItemDefinition>().HasMany(entity => entity.JoinedQualifiedCharacters).WithOne(join => join.ItemDefinition);
        modelBuilder.Entity<ItemDefinitionCharacterClass>().HasKey(join => new { join.ItemDefinitionId, join.CharacterClassId });
        modelBuilder.Entity<ItemDefinition>().HasMany(entity => entity.JoinedPossibleItemSetGroups).WithOne(join => join.ItemDefinition);
        modelBuilder.Entity<ItemDefinitionItemSetGroup>().HasKey(join => new { join.ItemDefinitionId, join.ItemSetGroupId });
        modelBuilder.Entity<ItemDefinition>().HasMany(entity => entity.JoinedPossibleItemOptions).WithOne(join => join.ItemDefinition);
        modelBuilder.Entity<ItemDefinitionItemOptionDefinition>().HasKey(join => new { join.ItemDefinitionId, join.ItemOptionDefinitionId });
        modelBuilder.Entity<ItemCraftingRequiredItem>().HasMany(entity => entity.JoinedPossibleItems).WithOne(join => join.ItemCraftingRequiredItem);
        modelBuilder.Entity<ItemCraftingRequiredItemItemDefinition>().HasKey(join => new { join.ItemCraftingRequiredItemId, join.ItemDefinitionId });
        modelBuilder.Entity<ItemCraftingRequiredItem>().HasMany(entity => entity.JoinedRequiredItemOptions).WithOne(join => join.ItemCraftingRequiredItem);
        modelBuilder.Entity<ItemCraftingRequiredItemItemOptionType>().HasKey(join => new { join.ItemCraftingRequiredItemId, join.ItemOptionTypeId });

    }
}
