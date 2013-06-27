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
        #region Position
        private GeoCoordinate _Position;
        public GeoCoordinate Position
        {
            get { return _Position; }
            set { _Position = value; OnPropertyChanged(); }
        }
        #endregion

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

            //var position = new GeoCoordinate();
            //position.Latitude = 77;
            //position.Longitude = 99;

            //Random rand = new Random();
            //Landmark poi = null;
            //for (int i = 0; i < 10; i++)
            //{

            //    poi = new Landmark();
            //    poi.Geocoordinate = new GeoCoordinate(position.Latitude + (rand.Next(0, 9) / 100)
            //        , position.Longitude + (rand.Next(0, 9) / 100));
            //    poi.Name = "Landmark " + i;
            //    Landmarks.Add(poi);
            //}

            Landmarks.Add(GetGoldenGateBridge());
            Landmarks.Add(GetRodeoBeach());
            Landmarks.Add(GetMosconeCenter());
            Landmarks.Add(GetEmbarcadero());
        }

        private Landmark GetGoldenGateBridge()
        {
            Landmark l = new Landmark()
            {
                Name = "Golden Gate Bridge",
                Geocoordinate = new GeoCoordinate(37.81997, -122.47859),
                ImageSource = "Images/GoldenGateBridge.png"
            };
            return l;
        }

        private Landmark GetMosconeCenter()
        {
            Landmark l = new Landmark()
            {
                Name = "Moscone Center",
                Geocoordinate = new GeoCoordinate(37.784173, -122.401557),
                ImageSource = "Images/MosconeCenter.png"
            };
            return l;
        }

        private Landmark GetEmbarcadero()
        {
            Landmark l = new Landmark()
            {
                Name = "Embarcadero",
                Geocoordinate = new GeoCoordinate(37.79625,-122.405115),
                ImageSource = "Images/Embarcadero.png"
            };
            return l;
        }

        private Landmark GetRodeoBeach()
        {
            Landmark l = new Landmark()
            {
                Name = "Rodeo Beach",
                Geocoordinate = new GeoCoordinate(37.8300, -122.5358),
                ImageSource = "Images/RodeoBay.png"
            };
            return l;
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
