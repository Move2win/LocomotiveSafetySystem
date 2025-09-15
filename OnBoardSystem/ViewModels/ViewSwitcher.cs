using OnBoardSystem.Models;

namespace OnBoardSystem.ViewModels
{
    internal class ViewSwitcher(MainWindowViewModel mainWindowViewModel)
    {
        public void SetupInitialView(ref string varCurrentView)
        {
            SetView.NameCheck(ref varCurrentView, "InitialView");
            //GridRow 0 KeyInfo Initialization
            mainWindowViewModel.TxtSpeed_Text = "0.0 KM/H";
            mainWindowViewModel.TxtAcceleration_Text = "▲ 0.0 KM/H/sec";
            mainWindowViewModel.TxtLimiteSpeed_Text = "********";
            mainWindowViewModel.TxtTrainNumber_Text = "X0000";
            mainWindowViewModel.TxtDestination_Text = "DESTINATION";
            //GridRow 1 Chart&Warning Initialization
            mainWindowViewModel.InitialView_IsVisible = true;
            mainWindowViewModel.RegisterView_IsVisible = false;
            mainWindowViewModel.ManifestLoginView_IsVisible = false;
            mainWindowViewModel.OprationView_IsVisible = false;
            mainWindowViewModel.MenuView_IsVisible = false;
            //GridRow 2 CtrlButton Initialization
            mainWindowViewModel.MenuButton1_Background = "Gray";
            mainWindowViewModel.MenuButton1_Opacity = "0.2";
            mainWindowViewModel.MenuButton2_Background = "Gray";
            mainWindowViewModel.MenuButton2_Opacity = "0.2";
            mainWindowViewModel.MenuButton3_Background = "Gray";
            mainWindowViewModel.MenuButton3_Opacity = "0.2";
            mainWindowViewModel.MenuButton4_Background = "Gray";
            mainWindowViewModel.MenuButton4_Opacity = "0.2";
            mainWindowViewModel.MenuButton5_Content = "Start";
            mainWindowViewModel.MenuButton5_Background = "Blue";
            mainWindowViewModel.MenuButton5_Opacity = "1.0";
            mainWindowViewModel.MenuButton5_FontSize = "30";
            mainWindowViewModel.MenuButton6_Content = "";
            mainWindowViewModel.MenuButton6_Background = "Gray";
            mainWindowViewModel.MenuButton6_Opacity = "0.2";
            mainWindowViewModel.MenuButton7_Background = "Gray";
            mainWindowViewModel.MenuButton7_Opacity = "0.2";
            mainWindowViewModel.MenuButton8_Background = "Green";
            mainWindowViewModel.MenuButton8_Opacity = "1";
        }
        public void SetupRegisterView(ref string varCurrentView)
        {
            SetView.NameCheck(ref varCurrentView, "RegisterView");
            //GridRow 0 KeyInfo Initialization
            //No need, already set in SetupInitialView(), this will only be called after SetupInitialView()
            //GridRow 1 Chart&Warning Initialization
            mainWindowViewModel.InitialView_IsVisible = false;
            mainWindowViewModel.RegisterView_IsVisible = true;
            mainWindowViewModel.ManifestLoginView_IsVisible = false;
            mainWindowViewModel.OprationView_IsVisible = false;
            mainWindowViewModel.MenuView_IsVisible = false;
            //GridRow 2 CtrlButton Initialization
            mainWindowViewModel.MenuButton1_Background = "Blue";
            mainWindowViewModel.MenuButton1_Opacity = "1";
            mainWindowViewModel.MenuButton2_Background = "Blue";
            mainWindowViewModel.MenuButton2_Opacity = "1";
            mainWindowViewModel.MenuButton3_Background = "Blue";
            mainWindowViewModel.MenuButton3_Opacity = "1";
            mainWindowViewModel.MenuButton4_Background = "Blue";
            mainWindowViewModel.MenuButton4_Opacity = "1";
            mainWindowViewModel.MenuButton5_Content = "Start";
            mainWindowViewModel.MenuButton6_Content = "Clear";
            mainWindowViewModel.MenuButton6_Background = "Blue";
            mainWindowViewModel.MenuButton6_Opacity = "1";
            mainWindowViewModel.MenuButton6_FontSize = "25";
            //No need, already set in SetupInitialView()
            //mainWindowViewModel.MenuButton5_Background = "Blue";
            //mainWindowViewModel.MenuButton5_Opacity = "1";
        }
        public void SetupManifestLoginView(ref string varCurrentView)
        {
            SetView.NameCheck(ref varCurrentView, "ManifestLoginView");
            //GridRow 0 KeyInfo Initialization
            mainWindowViewModel.TxtSpeed_Text = "0.0 KM/H";
            mainWindowViewModel.TxtAcceleration_Text = "▲ 0.0 KM/H/sec";
            mainWindowViewModel.TxtLimiteSpeed_Text = "********";
            mainWindowViewModel.TxtTrainNumber_Text = "X0000";
            mainWindowViewModel.TxtDestination_Text = "DESTINATION";
            //GridRow 1 Chart&Warning Initialization
            mainWindowViewModel.InitialView_IsVisible = false;
            mainWindowViewModel.RegisterView_IsVisible = false;
            mainWindowViewModel.ManifestLoginView_IsVisible = true;
            mainWindowViewModel.OprationView_IsVisible = false;
            mainWindowViewModel.MenuView_IsVisible = false;
            //GridRow 2 CtrlButton Initialization
            mainWindowViewModel.MenuButton1_Background = "Blue";
            mainWindowViewModel.MenuButton1_Opacity = "1";
            mainWindowViewModel.MenuButton2_Background = "Blue";
            mainWindowViewModel.MenuButton2_Opacity = "1";
            mainWindowViewModel.MenuButton3_Background = "Blue";
            mainWindowViewModel.MenuButton3_Opacity = "1";
            mainWindowViewModel.MenuButton4_Background = "Blue";
            mainWindowViewModel.MenuButton4_Opacity = "1";
            mainWindowViewModel.MenuButton5_Content = "Confirm";
            mainWindowViewModel.MenuButton5_Background = "Blue";
            mainWindowViewModel.MenuButton5_Opacity = "1";
            mainWindowViewModel.MenuButton5_FontSize = "22";
            mainWindowViewModel.MenuButton6_Content = "Clear";
            mainWindowViewModel.MenuButton6_Background = "Blue";
            mainWindowViewModel.MenuButton6_Opacity = "1";
            mainWindowViewModel.MenuButton6_FontSize = "25";
        }
        public void SetupOprationView(ref string varCurrentView)
        {
            SetView.NameCheck(ref varCurrentView, "OprationView");
            //GridRow 0 KeyInfo Initialization
            //No need, already set in SetupManifestLoginView()
            //GridRow 1 Chart&Warning Initialization
            mainWindowViewModel.InitialView_IsVisible = false;
            mainWindowViewModel.RegisterView_IsVisible = false;
            mainWindowViewModel.ManifestLoginView_IsVisible = false;
            mainWindowViewModel.OprationView_IsVisible = true;
            mainWindowViewModel.MenuView_IsVisible = false;
            //OprationChart Initialization
            mainWindowViewModel.BrakeLineCanvas_Left = 10.0f;
            mainWindowViewModel.WarningLineCanvas_Left = 15f;
            //Canvas.SetLeft(_mainWindow.BlockSignal1, 859);
            //Canvas.SetLeft(_mainWindow.BlockSignal2, 420);
            //Canvas.SetLeft(_mainWindow.BlockSignal3, 50);
            //Canvas.SetLeft(_mainWindow.BlockSignal4, -500);
            //_mainWindow.BlockSignal1.Fill = new SolidColorBrush(Colors.Yellow);
            //_mainWindow.BlockSignal2.Fill = new SolidColorBrush(Colors.Green);
            //_mainWindow.BlockSignal3.Fill = new SolidColorBrush(Colors.Red);
            //_mainWindow.BlockSignal4.Fill = new SolidColorBrush(Colors.Red);
            //OprationInfo Initialization
            mainWindowViewModel.TxtBrakeApplicationDistance_Text = "Brake Distance:      10M";
            mainWindowViewModel.TxtWarningDistance_Text = "Warning Distance:  15M";
            mainWindowViewModel.TxtSignal_Text = "Next Signal:            Stop, 0KM/H, 50M";
            mainWindowViewModel.TxtMilepost_Text = "Milepost:                 100KM+0 Northbound";
            //WarningLight Initialization
            mainWindowViewModel.TxtEOTDLight_Foreground = "Gray";
            mainWindowViewModel.TxtEOTDLight_Background = "Black";
            mainWindowViewModel.TxtDefectLight_Foreground = "Gray";
            mainWindowViewModel.TxtDefectLight_Background = "Black";
            mainWindowViewModel.TxtPCSLight_Foreground = "Gray";
            mainWindowViewModel.TxtPCSLight_Background = "Black";
            mainWindowViewModel.TxtEBLight_Foreground = "Gray";
            mainWindowViewModel.TxtEBLight_Background = "Black";
            //WarningBanner Initialization
            mainWindowViewModel.BannerBackground_IsVisible = false;
            mainWindowViewModel.TxtBigRedWarning_IsVisible = false;
            mainWindowViewModel.TxtBigYellowWarning_IsVisible = false;
            //GridRow 2 CtrlButton Initialization
            mainWindowViewModel.MenuButton1_Background = "Gray";
            mainWindowViewModel.MenuButton1_Opacity = "0.2";
            mainWindowViewModel.MenuButton2_Background = "Gray";
            mainWindowViewModel.MenuButton2_Opacity = "0.2";
            mainWindowViewModel.MenuButton3_Background = "Gray";
            mainWindowViewModel.MenuButton3_Opacity = "0.2";
            mainWindowViewModel.MenuButton4_Background = "Gray";
            mainWindowViewModel.MenuButton4_Opacity = "0.2";
            mainWindowViewModel.MenuButton5_Content = "";
            mainWindowViewModel.MenuButton5_Background = "Gray";
            mainWindowViewModel.MenuButton5_Opacity = "0.2";
            mainWindowViewModel.MenuButton6_Content = "";
            mainWindowViewModel.MenuButton6_Background = "Gray";
            mainWindowViewModel.MenuButton6_Opacity = "0.2";
        }
    }
}
