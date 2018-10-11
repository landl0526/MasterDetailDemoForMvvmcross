using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MvvmCrossDemo.ViewModels
{
    public class MasterPageViewModel : MvxViewModel
    {
        public ObservableCollection<MyMasterDetailPageMenuItem> MenuItems { get; set; }

        public MasterPageViewModel()
        {
            MenuItems = new ObservableCollection<MyMasterDetailPageMenuItem>(new[]
            {
                    new MyMasterDetailPageMenuItem { Id = 0, Title = "Page 1" },
                    new MyMasterDetailPageMenuItem { Id = 1, Title = "Page 2" },
                    new MyMasterDetailPageMenuItem { Id = 2, Title = "Page 3" },
                    new MyMasterDetailPageMenuItem { Id = 3, Title = "Page 4" },
                    new MyMasterDetailPageMenuItem { Id = 4, Title = "Page 5" },
                });
        }

        MyMasterDetailPageMenuItem selectedMenu;
        public MyMasterDetailPageMenuItem SelectedMenu
        {
            set
            {
                selectedMenu = value;
                RaisePropertyChanged();
            }
            get
            {
                return selectedMenu;
            }
        }
    }
}
