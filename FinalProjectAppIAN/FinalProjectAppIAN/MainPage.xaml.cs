using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using System.Net.Http;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FinalProjectAppIAN
{ 
    public sealed partial class MainPage : Page
    {
        ObservableCollection<DisplayClass> Displayy;
        public MainPage()
        {
            this.InitializeComponent();
            Displayy = new ObservableCollection<DisplayClass>();
            lvResults.ItemsSource = Displayy;
            


        }

     

        private async void Current_Button_Click(object sender, RoutedEventArgs e)
        {

            Displayy.Clear();
            using (var http = new HttpClient())
            {
                
                var response = await http.GetStringAsync("https://finalprojectcomp494.azurewebsites.net/api/weather/7");//the response of the website is made by the call Async.                                                                                      //var result = await response.Content.ReadAsStringAsync(); //the result of the content, read id as a string format 

                var serializer = JsonConvert.DeserializeObject<DisplayClass>(response);
                CurrentTemp.Text = serializer.TempF.ToString() + " Fahrenheit / " + ((serializer.TempF- 32)*.5).ToString() + " Celsius" ;
                CurrentTitle.Text = serializer.Weather;
                CurrentWind.Text = "Winds: " + serializer.WindDir + " at " + serializer.WindMph.ToString() + " mph";
                CurrentHumidity.Text = "Relative Humidity: " + serializer.RelativeHumidity;
                CurrentUpdated.Text = serializer.ObservationTime;

                var response2 = await http.GetStringAsync("https://finalprojectcomp494.azurewebsites.net/api/weather/");
                List<Weather> serializer2 = JsonConvert.DeserializeObject<List<Weather>>(response2);
                lvResults.ItemsSource = serializer2;

            }
        }

        //private async void Threeday_Button_Click(object sender, RoutedEventArgs e)
        //{
        //    var http = new HttpClient();
        //    var response = await http.GetStringAsync("https://finalprojectcomp494.azurewebsites.net/api/weather/");//the response of the website is made by the call Async.                                                                                      //var result = await response.Content.ReadAsStringAsync(); //the result of the content, read id as a string format 
          
           
        //        List<Weather> serializer = JsonConvert.DeserializeObject<List<Weather>>(response);
        //    foreach (var item in response)
        //    {
        //        CurrentID.Text = serializer[0].id.ToString();
        //        CurrentPeriod.Text = serializer[1].period.ToString();
        //        CurrentIcon.Text = serializer[2].Icon;
        //        CurrentTitle2.Text = serializer[3].Title;
        //        CurrentText.Text = serializer[4].Fcttext;
        //        CurrentCheck.Text = serializer[5].Lastcheck;
        //    }
        //}
       
       public RoutedEventHandler Page_Loaded { get; private set; }
    }

    //public static Currentweather(object sender, RoutedEventArgs e)
    //{
    //    var http = new HttpClient();
    //    var response = await http.GetAsync("https://finalprojectcomp494.azurewebsites.net/api/weather/");//the response of the website is made by the call Async. 
    //    var result = await response.Content.ReadAsStringAsync(); //the result of the content, read id as a string format 
    //    var serializer = new DataContractJsonSerializer(typeof(RootObject)); //serialize, take all that string convert that to a object graph 

    //    var ms = new MemoryStream(Encoding.UTF8.GetBytes(result)); //memory string 
    //    var data = (RootObject)serializer.ReadObject(ms);//get the data out of the serializer 

    //    return data;
    //}
}

