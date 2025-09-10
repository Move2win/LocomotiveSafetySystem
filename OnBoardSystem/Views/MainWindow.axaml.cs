using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;
using Avalonia.Threading;
using MsBox.Avalonia;
using MsBox.Avalonia.Enums;

namespace OnBoardSystem.Views
{
    public partial class MainWindow : Window
    {
        #region Variable initialization.
        //LocomotiveSafetySystemFolder => "C:\Users\%username%\Documents\LocomotiveSafetySystem"
        readonly string LocomotiveSafetySystemFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "LocomotiveSafetySystem");
        //Current active view indicator
        string CurrentView = "InitialView";
        #endregion

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}