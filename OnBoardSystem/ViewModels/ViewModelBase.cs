using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace OnBoardSystem.ViewModels
{
    public partial class ViewModelBase : ObservableObject
    {
        [ObservableProperty]
        private string txtDate = string.Empty;
        [ObservableProperty]
        private string txtTime = string.Empty;
        [ObservableProperty]
        private string txtSpeed = "0.0 KM/H";
        [ObservableProperty]
        private string txtAcceleration = "▲ 0.0 KM/H/sec";
        [ObservableProperty]
        private string txtLimiteSpeed = "********";
        [ObservableProperty]
        private string txtTrainNumber = "X0000";
        [ObservableProperty]
        private string txtDestination = "DESTINATION";
    }
}
