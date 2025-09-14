using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

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
    }
}
