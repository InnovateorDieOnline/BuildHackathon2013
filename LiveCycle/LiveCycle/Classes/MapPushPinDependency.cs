using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Phone.Maps.Controls;
using Microsoft.Phone.Maps.Toolkit;

namespace LiveCycle.Classes
{
    //http://stackoverflow.com/questions/16417978/mvvm-windows-phone-8-adding-a-collection-of-pushpins-to-a-map/16441672#16441672
    public static class MapPushPinDependency
    {
        public static readonly DependencyProperty ItemsSourceProperty =
                DependencyProperty.RegisterAttached(
                 "ItemsSource", typeof(IEnumerable), typeof(MapPushPinDependency),
                 new PropertyMetadata(OnPushPinPropertyChanged));

        private static void OnPushPinPropertyChanged(DependencyObject d,
                DependencyPropertyChangedEventArgs e)
        {
            UIElement uie = (UIElement)d;
            var pushpin = MapExtensions.GetChildren((Map)uie).OfType<MapItemsControl>().FirstOrDefault();
            pushpin.ItemsSource = (IEnumerable)e.NewValue;
        }


        #region Getters and Setters

        public static IEnumerable GetItemsSource(DependencyObject obj)
        {
            return (IEnumerable)obj.GetValue(ItemsSourceProperty);
        }

        public static void SetItemsSource(DependencyObject obj, IEnumerable value)
        {
            obj.SetValue(ItemsSourceProperty, value);
        }

        #endregion
    }
}
