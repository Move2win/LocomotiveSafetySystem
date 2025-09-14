using CommunityToolkit.Mvvm.ComponentModel;

namespace OnBoardSystem.ViewModels
{
    public partial class ViewModelBase : ObservableObject
    {
        [ObservableProperty] private string txtDate_Text = string.Empty;
        [ObservableProperty] private string txtTime_Text = string.Empty;
        [ObservableProperty] private string txtSpeed_Text = "0.0 KM/H";
        [ObservableProperty] private string txtAcceleration_Text = "▲ 0.0 KM/H/sec";
        [ObservableProperty] private string txtLimiteSpeed_Text = "********";
        [ObservableProperty] private string txtTrainNumber_Text = "X0000";
        [ObservableProperty] private string txtDestination_Text = "DESTINATION";
        [ObservableProperty] private bool initialView_IsVisible = true;
        [ObservableProperty] private bool registerView_IsVisible = false;
        [ObservableProperty] private bool manifestLoginView_IsVisible = false;
        [ObservableProperty] private bool oprationView_IsVisible = false;
        [ObservableProperty] private bool menuView_IsVisible = false;
        [ObservableProperty] private string menuButton1_Background = "Gray";
        [ObservableProperty] private string menuButton2_Background = "Gray";
        [ObservableProperty] private string menuButton3_Background = "Gray";
        [ObservableProperty] private string menuButton4_Background = "Gray";
        [ObservableProperty] private string menuButton5_Background = "Blue";
        [ObservableProperty] private string menuButton6_Background = "Gray";
        [ObservableProperty] private string menuButton7_Background = "Gray";
        [ObservableProperty] private string menuButton8_Background = "Green";
        [ObservableProperty] private string menuButton1_Opacity = "0.2";
        [ObservableProperty] private string menuButton2_Opacity = "0.2";
        [ObservableProperty] private string menuButton3_Opacity = "0.2";
        [ObservableProperty] private string menuButton4_Opacity = "0.2";
        [ObservableProperty] private string menuButton5_Opacity = "1.0";
        [ObservableProperty] private string menuButton6_Opacity = "0.2";
        [ObservableProperty] private string menuButton7_Opacity = "0.2";
        [ObservableProperty] private string menuButton8_Opacity = "1.0";
        [ObservableProperty] private string menuButton5_Content = "Start";
        [ObservableProperty] private string menuButton6_Content = "";
        [ObservableProperty] private string menuButton5_FontSize = "30";
        [ObservableProperty] private string menuButton6_FontSize = "30";
        [ObservableProperty] private float brakeLineCanvas_Left = 10.0f;
        [ObservableProperty] private float warningLineCanvas_Left = 15f;
        [ObservableProperty] private string txtBrakeApplicationDistance_Text = "Brake Distance:      10M";
        [ObservableProperty] private string txtWarningDistance_Text = "Warning Distance:  15M";
        [ObservableProperty] private string txtSignal_Text = "Next Signal:            Stop, 0KM/H, 50M";
        [ObservableProperty] private string txtMilepost_Text = "Milepost:                 100KM+0 Northbound";
        [ObservableProperty] private string txtEOTDLight_Foreground = "Gray";
        [ObservableProperty] private string txtEOTDLight_Background = "Black";
        [ObservableProperty] private string txtDefectLight_Foreground = "Gray";
        [ObservableProperty] private string txtDefectLight_Background = "Black";
        [ObservableProperty] private string txtPCSLight_Foreground = "Gray";
        [ObservableProperty] private string txtPCSLight_Background = "Black";
        [ObservableProperty] private string txtEBLight_Foreground = "Gray";
        [ObservableProperty] private string txtEBLight_Background = "Black";
        [ObservableProperty] private bool bannerBackground_IsVisible = false;
        [ObservableProperty] private bool txtBigRedWarning_IsVisible = false;
        [ObservableProperty] private bool txtBigYellowWarning_IsVisible = false;
    }
}
