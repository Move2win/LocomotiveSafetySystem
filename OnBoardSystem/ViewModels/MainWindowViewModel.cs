using System;
using System.IO;
using System.Threading;
using CommunityToolkit.Mvvm.Input;

namespace OnBoardSystem.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        #region Variable initialization.
        //LocomotiveSafetySystemFolder => "C:\Users\%username%\Documents\LocomotiveSafetySystem"
        readonly string LocomotiveSafetySystemFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "LocomotiveSafetySystem");
        //Current active view indicator
        string CurrentView = "InitialView";

        #endregion

        public MainWindowViewModel()
        {
        }
    }
}
