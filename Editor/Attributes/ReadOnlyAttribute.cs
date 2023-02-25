﻿using System;
using UnityEngine;

namespace PixelSparkStudio.ObjectPooler.InspectorAttributes
{
    /// <summary>
    /// Prevent a serialized field from being edited in inspector.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true, Inherited = true)]
    public sealed class ReadOnlyAttribute : PropertyAttribute
    {
    }
}