using AppX.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace AppX.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}