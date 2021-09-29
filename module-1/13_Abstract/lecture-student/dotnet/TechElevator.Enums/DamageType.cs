namespace TechElevator.Enums
{
    /// <summary>
    /// DamageType is an Enum which allows you to select one of a set of suggested values.
    /// For example, if a method required a DamageType, you could provide one by passing it DamageType.Fire
    /// </summary>
    /// <example>
    /// 
    /// DamageType weaponType = DamageType.Stab;
    /// 
    /// switch (weaponType)
    /// {
    ///     case DamageType.Stab:
    ///         // Stab handling code here
    ///         break;
    ///         
    ///     case DamageType.Crushing:
    ///         // Crush handling code here
    ///         break;
    ///     
    ///     default:
    ///         // Handles Fire and ExistentialDread damage types as well as any new damage types in the future
    ///         break;
    /// }
    /// 
    /// </example>
    public enum DamageType
    {
        Stab,
        Crushing,
        Fire,
        ExistentialDread
    }
}
