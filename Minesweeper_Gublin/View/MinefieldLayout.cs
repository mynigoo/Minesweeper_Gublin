using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Minesweeper_Gublin.View
{
    class MinefieldLayout : WrapPanel
    {
        public static readonly DependencyProperty ItemsInLineProperty = DependencyProperty.Register(
            "ItemsInLine",
            typeof(int),
            typeof(MinefieldLayout),
            new FrameworkPropertyMetadata(1, FrameworkPropertyMetadataOptions.AffectsMeasure),
            new ValidateValueCallback(MinefieldLayout.IsItemsInLineValid));

        public int ItemsInLine
        {
            get
            {
                return (int)GetValue(ItemsInLineProperty);
            }
            set
            {
                SetValue(ItemsInLineProperty, value);
            }
        }

        protected override Size MeasureOverride(Size constraint)
        {
            int itemsInLine = this.ItemsInLine;
            bool horizontal = (this.Orientation == Orientation.Horizontal);
            double itemWidth = this.ItemWidth;
            double itemHeight = this.ItemHeight;
            double h = 0.0, w = 0.0;

            Size max = new Size(0.0, 0.0);
            Size availableSize = new Size();

            UIElementCollection childs = base.InternalChildren;
            UIElement elem = null;

            if (horizontal)
            {
                availableSize = new Size(
                    !double.IsNaN(itemWidth) ? itemWidth : constraint.Width,
                    !double.IsNaN(itemHeight) ? itemHeight : constraint.Height / itemsInLine);
            }
            else
            {
                availableSize = new Size(
                    !double.IsNaN(itemWidth) ? itemWidth : constraint.Width / itemsInLine,
                    !double.IsNaN(itemHeight) ? itemHeight : constraint.Height);
            }

            for (int i = 0, count = childs.Count; i < itemsInLine; i++)
            {
                for (int j = i; j < count; j += itemsInLine)
                {
                    if ((elem = childs[j]) != null)
                    {
                        elem.Measure(availableSize);
                        if (horizontal)
                        {
                            w += elem.DesiredSize.Width;
                        }
                        else
                        {
                            h += elem.DesiredSize.Height;
                        }
                    }
                }
                if (horizontal)
                {
                    max.Width = Math.Max(max.Width, w);
                    w = 0.0;
                }
                else
                {
                    max.Height = Math.Max(max.Height, h);
                    h = 0.0;
                }
            }
            return max;
        }

        protected override Size ArrangeOverride(Size finalSize)
        {
            int itemsInLine = ItemsInLine;
            bool horizontal = (this.Orientation == Orientation.Horizontal);
            double x = 0.0, y = 0.0, w = 0.0, h = 0.0;

            UIElementCollection childs = base.InternalChildren;
            UIElement elem = null;

            for (int i = 0, count = childs.Count; i < itemsInLine; i++)
            {
                for (int j = i; j < count; j += itemsInLine)
                {
                    if ((elem = childs[j]) != null)
                    {
                        w = elem.DesiredSize.Width;
                        h = elem.DesiredSize.Height;
                        elem.Arrange(new Rect(x, y, w, h));
                        if (horizontal)
                        {
                            x += w;
                        }
                        else
                        {
                            y += h;
                        }
                    }
                }
                if (horizontal)
                {
                    x = 0.0;
                    y += h;
                }
                else
                {
                    y = 0.0;
                    x += w;
                }
            }
            return finalSize;
        }

        private static bool IsItemsInLineValid(object value)
        {
            return ((int)value) > 0;
        }
    }

}
