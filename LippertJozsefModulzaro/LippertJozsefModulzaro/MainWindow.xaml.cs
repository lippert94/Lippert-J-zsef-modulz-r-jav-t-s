using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LippertJozsefModulzaro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly MainViewModel _vm;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NewLanguageClick(object sender, RoutedEventArgs e)
        {
            LanguageFormViewModel viewModel = new LanguageFormViewModel(new Language()) { IsNew = true };
            LanguageFormWindow languageForm = new LanguageFormWindow { DataContext = viewModel };
            languageForm.ShowDialog();
            var languageList = _vm.LanguageList;
            if (languageForm.DialogResult == true)
                languageList.Add(viewModel.Language);
        }

        private void AmendmentClick(object sender, RoutedEventArgs e)
        {
            if (_vm.SelectLanguage != null)
            {
                LanguageFormViewModel viewModel = new LanguageFormViewModel(_vm.SelectLanguage);
                LanguageFormWindow languageForm = new LanguageFormWindow { DataContext = viewModel };
                languageForm.ShowDialog();
            }
        }
    }
}
