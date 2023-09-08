using System;

namespace VermillionVanguard.ObjectPooler.InspectorAttributes
{
    /// <summary>
    /// Hide the field if it is in Play Mode.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true, Inherited = true)]
    public sealed class HideInPlayModeAttribute : CustomAttribute
    {
    }
}