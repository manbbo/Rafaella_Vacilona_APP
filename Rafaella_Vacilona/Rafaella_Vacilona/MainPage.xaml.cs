using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Rafaella_Vacilona
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        #region Variables
        private string _rate, _moneyFirst, _moneyResult;
        
        public string Rate
        { get { return _rate; } set { SetField<string>(ref _rate, value, "Rate"); } }

        public string MoneyFirst
        { get { return _moneyFirst; } set { SetField<string>(ref _moneyFirst, value, "MoneyFirst"); } }

        public string MoneyResult
        { get { return _moneyResult; } set { SetField<string>(ref _moneyResult, value, "MoneyResult"); } }
        #endregion

        #region PROPERTY CHANGED
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        private event PropertyChangedEventHandler PropertyChanged;
        #endregion

        public async void OnButtonClicked(object sender, EventArgs args)
        {
            float mF = float.Parse(MoneyFirst.Trim()), rt = float.Parse(Rate.Trim()),
                result = mF / rt;

            await DisplayAlert("RESULTADO",
                "RAFA, O RESULTADO FOI '" + result + "' DINHEIROS",
                "TÁ BOM CARALHO");

            Entry entry = this.FindByName<Entry>("resultado");
            entry.Text = ""+result;
        }

        public MainPage()
        {
            InitializeComponent();

            BindingContext = this;

            Rate = "1";
            MoneyFirst = "1";
        }
	}
}
