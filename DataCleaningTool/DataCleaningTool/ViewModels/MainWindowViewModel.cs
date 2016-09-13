using DataCleaningTool.Base;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace DataCleaningTool.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        #region fields

        private string buttonCaption;
        private ICommand buttonClickCommand;

        #endregion

        #region properties

        public string ButtonCaption
        {
            get { return buttonCaption; }
            set
            {
                SetProperty(ref buttonCaption, value);
            }
        }

        #endregion

        #region commands

        public ICommand ButtonClickCommand
        {
            get { return buttonClickCommand; }
        }

        #endregion

        #region methods

        public MainWindowViewModel()
        {
            ButtonCaption = "OK";
            this.buttonClickCommand = new RelayCommand(ButtonClickAction);
        }

        private void ButtonClickAction(object obj)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (openFileDialog.ShowDialog() == true)
            {
                foreach (string filename in openFileDialog.FileNames)
                    MessageBox.Show(filename);
            }
        }


        #endregion
    }
}
