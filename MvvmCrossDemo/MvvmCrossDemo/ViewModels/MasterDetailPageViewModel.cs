using MvvmCross;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MvvmCrossDemo.ViewModels
{
    public class MasterDetailPageViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public MasterDetailPageViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public override void ViewAppearing()
        {
            base.ViewAppearing();

            MvxNotifyTask.Create(async () => await this.InitializeViewModels());
        }

        private async Task InitializeViewModels()
        {
            await _navigationService.Navigate<MasterPageViewModel>();
            await _navigationService.Navigate<DetailPageViewModel>();
        }
    }
}
