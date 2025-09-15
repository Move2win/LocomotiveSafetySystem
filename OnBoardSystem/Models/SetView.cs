using MsBox.Avalonia;
using MsBox.Avalonia.Enums;
using OnBoardSystem.ViewModels;

namespace OnBoardSystem.Models
{
    public class SetView
    {
        public static void NameCheck(ref string VarCurrentView, string viewName)
        {
            if (viewName == "InitialView" ||
                viewName == "RegisterView" ||
                viewName == "ManifestLoginView" ||
                viewName == "MenuView")
            {
                VarCurrentView = viewName;
                MainWindowViewModel.OprationViewTimerPause();
            }
            else if (viewName == "OprationView")
            {
                VarCurrentView = viewName;
                MainWindowViewModel.OprationViewTimerResume();
            }
            else //TODO: DEBUG ONLY
            {
                var box = MessageBoxManager
                        .GetMessageBoxStandard("Warning", "Wrong viewname: " + viewName,
                        ButtonEnum.Ok);
                var result = box.ShowAsync();
            }
        }
    }
}
