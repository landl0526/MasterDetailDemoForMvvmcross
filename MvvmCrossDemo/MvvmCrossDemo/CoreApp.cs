using MvvmCross.IoC;
using MvvmCross.ViewModels;
using MvvmCrossDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MvvmCrossDemo
{
    public class CoreApp : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<MasterDetailPageViewModel>();
        }
    }
}
