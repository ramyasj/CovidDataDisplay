using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using CovidDataCore;

namespace CovidDataRetriver
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var covidSummary = CovidDataCore.GetCovidData.GetData();
            var globalSummary = covidSummary.Result.Global;
            totalCaseslabel.Text = globalSummary.TotalConfirmed;
            newCaseslabel.Text = globalSummary.NewConfirmed.ToString() ;
            totalDeathslabel.Text = globalSummary.TotalDeaths;
            totalnewDeathslabel.Text = globalSummary.NewDeaths;
            contriesList.ItemsSource = covidSummary.Result.Countries;

        }
    }
}
