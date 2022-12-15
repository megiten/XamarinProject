using System.ComponentModel;
using Xamarin.Forms;
using XamarinProject.ViewModels;

namespace XamarinProject.Views
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