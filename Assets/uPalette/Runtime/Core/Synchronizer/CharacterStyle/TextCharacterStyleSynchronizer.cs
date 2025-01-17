﻿using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

namespace uPalette.Runtime.Core.Synchronizer.CharacterStyle
{
    [AddComponentMenu("")]
    [DisallowMultipleComponent]
    [RequireComponent(typeof(Text))]
    [CharacterStyleSynchronizer(typeof(Text), "Character Style")]
    public sealed class TextCharacterStyleSynchronizer : CharacterStyleSynchronizer<Text>
    {
        protected internal override Foundation.CharacterStyles.CharacterStyle GetValue()
        {
            return new Foundation.CharacterStyles.CharacterStyle
            {
                font = Component.font,
                fontStyle = Component.fontStyle,
                fontSize = Component.fontSize,
                lineSpacing = Component.lineSpacing
            };
        }

        private static int _latestRepaintFrame;

        protected internal override void SetValue(Foundation.CharacterStyles.CharacterStyle value)
        {
            Component.font = value.font;
            Component.fontStyle = value.fontStyle;
            Component.fontSize = value.fontSize;
            Component.lineSpacing = value.lineSpacing;
        }

        protected override bool EqualsToCurrentValue(Foundation.CharacterStyles.CharacterStyle value)
        {
            if (Component.font != value.font
                || Component.fontStyle != value.fontStyle
                || Component.fontSize != value.fontSize
                || Component.lineSpacing != value.lineSpacing)
                return false;

            return true;
        }
    }
}
