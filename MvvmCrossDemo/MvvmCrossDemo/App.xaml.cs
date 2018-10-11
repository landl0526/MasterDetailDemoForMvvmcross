using MvvmCross.Forms.Core;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MvvmCrossDemo
{
    public partial class App : MvxFormsApplication
    {
        public App()
        {
            InitializeComponent();
        }
    }
}
