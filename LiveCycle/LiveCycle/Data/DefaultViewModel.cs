using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveCycle.Models;
using Windows.Devices.Geolocation;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Device.Location;
using System.Collections.ObjectModel;

namespace LiveCycle.Data
{
    public class DefaultViewModel : INotifyPropertyChanged
    {
        public GeoCoordinate Position { get; set; }

        #region Landmarks
        private ObservableCollection<Landmark> _Landmarks;
        public ObservableCollection<Landmark> Landmarks
        {
            get { return _Landmarks; }
            set { _Landmarks = value; OnPropertyChanged(); }
        }
        #endregion

        public void DesignTimeSetup()
        {

            Position = new GeoCoordinate();
            Position.Latitude = 77;
            Position.Longitude = 99;

            Random rand = new Random();
            Landmark poi = null;
            for (int i = 0; i < 10; i++)
            {
                poi = new Landmark();
                poi.Geocoordinate = new GeoCoordinate(Position.Latitude + (rand.Next(0, 9) / 100)
                    , Position.Longitude + (rand.Next(0, 9) / 100));
                poi.Name = "Landmark " + i;
                Landmarks.Add(poi);
            }
        }

        public DefaultViewModel()
        {
            _Landmarks = new ObservableCollection<Landmark>();

            if (DesignerProperties.IsInDesignTool)
                DesignTimeSetup();
        }

        #region INPC
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if(PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
