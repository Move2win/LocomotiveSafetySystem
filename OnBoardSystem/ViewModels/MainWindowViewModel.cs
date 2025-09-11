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
            //Set clock timer interval to 1 seconds.
            Timer ClockTimer = new(OnClockTimerTick, null, TimeSpan.Zero, TimeSpan.FromSeconds(1));
            //Set Opration view UI refreash timer interval to 500 milliseconds.
            Timer OprationViewTimer = new(OnOprationViewTimerTick, null, TimeSpan.Zero, TimeSpan.FromSeconds(0.5));
        }

        #region UI refreash timers.
        //Clock timer refreash method.
        private void OnClockTimerTick(object? state)
        {
            TxtDate = DateTime.Now.ToString("yyyy/MM/dd");
            TxtTime = DateTime.Now.ToString("HH:mm:ss");
        }

        //OprationView refreash method.
        private void OnOprationViewTimerTick(object? state)
        {

        }
        #endregion

    }
}
