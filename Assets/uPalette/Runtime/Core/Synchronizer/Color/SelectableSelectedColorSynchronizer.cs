﻿using UnityEngine;
using UnityEngine.UI;

namespace uPalette.Runtime.Core.Synchronizer.Color
{
    [AddComponentMenu("")]
    [DisallowMultipleComponent]
    [RequireComponent(typeof(Selectable))]
    [ColorSynchronizer(typeof(Selectable), "Transition Selected Color")]
    public sealed class SelectableSelectedColorSynchronizer : ColorSynchronizer<Selectable>
    {
        protected internal override UnityEngine.Color GetValue()
        {
            return Component.colors.selectedColor;
        }

        protected internal override void SetValue(UnityEngine.Color value)
        {
            var colors = Component.colors;
            colors.selectedColor = value;
            Component.colors = colors;
        }

        protected override bool EqualsToCurrentValue(UnityEngine.Color value)
        {
            return Component.colors.selectedColor == value;
        }
    }
}
