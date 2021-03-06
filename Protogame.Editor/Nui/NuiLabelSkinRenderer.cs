﻿using System;
using Microsoft.Xna.Framework;
using Protogame;

namespace Protogame.Editor.Nui
{
    public class NuiLabelSkinRenderer : ISkinRenderer<Label>
    {
        private readonly I2DRenderUtilities _renderUtilities;
        private readonly ILayoutPosition _layoutPosition;
        private readonly IAssetReference<FontAsset> _fontAsset;

        public NuiLabelSkinRenderer(
            I2DRenderUtilities renderUtilities, 
            IAssetManager assetManager,
            ILayoutPosition layoutPosition)
        {
            _renderUtilities = renderUtilities;
            _layoutPosition = layoutPosition;
            _fontAsset = assetManager.Get<FontAsset>("font.UISmall");
        }

        public void Render(IRenderContext renderContext, Rectangle layout, Label label)
        {
            var textColor = label.TextColor ?? Color.Black;
            if (label.AttachTo != null)
            {
                if (label.AttachTo.Focused)
                {
                    textColor = new Color(2, 141, 31, 255);
                }
            }

            _renderUtilities.RenderText(
                renderContext,
                _layoutPosition.GetPositionInLayout(layout, label.HorizontalAlignment ?? HorizontalAlignment.Center, label.VerticalAlignment ?? VerticalAlignment.Center),
                label.Text,
                label.Font ?? _fontAsset,
                label.HorizontalAlignment ?? HorizontalAlignment.Center,
                label.VerticalAlignment ?? VerticalAlignment.Center,
                textColor: textColor,
                renderShadow: false);
        }

        public Vector2 MeasureText(IRenderContext renderContext, string text, Label label)
        {
            throw new NotSupportedException();
        }
    }
}
