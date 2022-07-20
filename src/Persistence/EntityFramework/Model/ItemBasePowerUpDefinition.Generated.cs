// <copyright file="ItemBasePowerUpDefinition.Generated.cs" company="MUnique">
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
using MUnique.OpenMU.Persistence;

/// <summary>
/// The Entity Framework Core implementation of <see cref="MUnique.OpenMU.DataModel.Configuration.Items.ItemBasePowerUpDefinition"/>.
/// </summary>
[Table(nameof(ItemBasePowerUpDefinition), Schema = SchemaNames.Configuration)]
internal partial class ItemBasePowerUpDefinition : MUnique.OpenMU.DataModel.Configuration.Items.ItemBasePowerUpDefinition, IIdentifiable
{
    
    
    /// <summary>
    /// Gets or sets the identifier of this instance.
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Gets or sets the identifier of <see cref="TargetAttribute"/>.
    /// </summary>
    public Guid? TargetAttributeId { get; set; }

    /// <summary>
    /// Gets the raw object of <see cref="TargetAttribute" />.
    /// </summary>
    [ForeignKey(nameof(TargetAttributeId))]
    public AttributeDefinition RawTargetAttribute
    {
        get => base.TargetAttribute as AttributeDefinition;
        set => base.TargetAttribute = value;
    }

    /// <inheritdoc/>
    [NotMapped]
    public override MUnique.OpenMU.AttributeSystem.AttributeDefinition TargetAttribute
    {
        get => base.TargetAttribute;set
        {
            base.TargetAttribute = value;
            this.TargetAttributeId = this.RawTargetAttribute?.Id;
        }
    }

    /// <summary>
    /// Gets or sets the identifier of <see cref="BonusPerLevelTable"/>.
    /// </summary>
    public Guid? BonusPerLevelTableId { get; set; }

    /// <summary>
    /// Gets the raw object of <see cref="BonusPerLevelTable" />.
    /// </summary>
    [ForeignKey(nameof(BonusPerLevelTableId))]
    public ItemLevelBonusTable RawBonusPerLevelTable
    {
        get => base.BonusPerLevelTable as ItemLevelBonusTable;
        set => base.BonusPerLevelTable = value;
    }

    /// <inheritdoc/>
    [NotMapped]
    public override MUnique.OpenMU.DataModel.Configuration.Items.ItemLevelBonusTable BonusPerLevelTable
    {
        get => base.BonusPerLevelTable;set
        {
            base.BonusPerLevelTable = value;
            this.BonusPerLevelTableId = this.RawBonusPerLevelTable?.Id;
        }
    }


    /// <inheritdoc/>
    public override bool Equals(object obj)
    {
        var baseObject = obj as IIdentifiable;
        if (baseObject != null)
        {
            return baseObject.Id == this.Id;
        }

        return base.Equals(obj);
    }

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        return this.Id.GetHashCode();
    }

    
}
