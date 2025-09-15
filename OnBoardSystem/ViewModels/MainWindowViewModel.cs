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
        //Create OprationViewTimer and related arguments.
        private static Timer? OprationViewTimer;
        private static readonly TimeSpan period = TimeSpan.Zero;
        private static readonly TimeSpan dueTime = TimeSpan.FromSeconds(0.5);
        private static bool isPaused = false;

        #endregion

        public MainWindowViewModel()
        {
            //Set clock timer interval to 1 seconds.
            Timer ClockTimer = new(OnClockTimerTick, null, TimeSpan.Zero, TimeSpan.FromSeconds(1));
            //Set Opration view UI refreash timer interval to 500 milliseconds.
            OprationViewTimer = new(OnOprationViewTimerTick, null, period, dueTime);
            //Pause on creation.
            OprationViewTimerPause();
        }

        #region UI refreash timers.
        //Clock timer refreash method.
        private void OnClockTimerTick(object? state)
        {
            TxtDate_Text = DateTime.Now.ToString("yyyy/MM/dd");
            TxtTime_Text = DateTime.Now.ToString("HH:mm:ss");
        }

        //OprationView refreash method.
        private void OnOprationViewTimerTick(object? state)
        {

        }

        //Pause OprationViewTimer.
        public static void OprationViewTimerPause()
        {
            if (OprationViewTimer != null && !isPaused)
            {
                isPaused = true;
                OprationViewTimer.Change(Timeout.Infinite, Timeout.Infinite);
            }
        }

        //Resume OprationViewTimer.
        public static void OprationViewTimerResume()
        {
            if (OprationViewTimer != null && isPaused)
            {   
                isPaused = false;
                OprationViewTimer.Change(dueTime, period);
            }
        }
        #endregion

        #region Menu button events.
        //Up
        [RelayCommand]
        public void MenuButton1_Click()
        {
            ViewSwitcher Views = new(this);
            if (CurrentView == "InitialView")
            {

            }
            else if (CurrentView == "RegisterView")
            {

            }
            else if (CurrentView == "ManifestLoginView")
            {

            }
            else if (CurrentView == "OprationView")
            {
                
            }
            else if (CurrentView == "MenuView")
            {

            }
        }

        //Down
        [RelayCommand]
        public void MenuButton2_Click()
        {
            ViewSwitcher Views = new(this);
            if (CurrentView == "InitialView")
            {

            }
            else if (CurrentView == "RegisterView")
            {

            }
            else if (CurrentView == "ManifestLoginView")
            {

            }
            else if (CurrentView == "OprationView")
            {
                
            }
            else if (CurrentView == "MenuView")
            {

            }
        }

        //Left
        [RelayCommand]
        public void MenuButton3_Click()
        {
            ViewSwitcher Views = new(this);
            if (CurrentView == "InitialView")
            {

            }
            else if (CurrentView == "RegisterView")
            {

            }
            else if (CurrentView == "ManifestLoginView")
            {

            }
            else if (CurrentView == "OprationView")
            {

            }
            else if (CurrentView == "MenuView")
            {

            }
        }

        //Right
        [RelayCommand]
        public void MenuButton4_Click()
        {
            ViewSwitcher Views = new(this);
            if (CurrentView == "InitialView")
            {

            }
            else if (CurrentView == "RegisterView")
            {

            }
            else if (CurrentView == "ManifestLoginView")
            {

            }
            else if (CurrentView == "OprationView")
            {

            }
            else if (CurrentView == "MenuView")
            {

            }
        }

        //Start, Comfirm
        [RelayCommand]
        public void MenuButton5_Click()
        {
            ViewSwitcher Views = new(this);
            Views.SetupInitialView(ref CurrentView);
        }

        //Clear
        [RelayCommand]
        public void MenuButton6_Click()
        {
            ViewSwitcher Views = new(this);
            if (CurrentView == "InitialView")
            {

            }
            else if (CurrentView == "RegisterView")
            {

            }
            else if (CurrentView == "ManifestLoginView")
            {

            }
            else if (CurrentView == "OprationView")
            {

            }
            else if (CurrentView == "MenuView")
            {

            }
        }

        //Not used
        [RelayCommand]
        public void MenuButton7_Click()
        {
            ViewSwitcher Views = new(this);
            if (CurrentView == "InitialView")
            {

            }
            else if (CurrentView == "RegisterView")
            {

            }
            else if (CurrentView == "ManifestLoginView")
            {

            }
            else if (CurrentView == "OprationView")
            {

            }
            else if (CurrentView == "MenuView")
            {

            }
        }

        //Menu
        [RelayCommand]
        public void MenuButton8_Click()
        {
            ViewSwitcher Views = new(this);
            if (CurrentView == "InitialView")
            {

            }
            else if (CurrentView == "RegisterView")
            {

            }
            else if (CurrentView == "ManifestLoginView")
            {

            }
            else if (CurrentView == "OprationView")
            {

            }
            else if (CurrentView == "MenuView")
            {

            }
        }
        #endregion
    }
}
