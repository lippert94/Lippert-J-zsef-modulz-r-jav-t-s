using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace LippertJozsefModulzaro
{
    /// <summary>
    /// Interaction logic for LanguageFormWindow.xaml
    /// </summary>
    public partial class LanguageFormWindow : Window
    {
        public LanguageFormWindow()
        {
            InitializeComponent();
        }

        private void SaveClick(object sender, RoutedEventArgs e)
        {
            var languageVM = (LanguageFormViewModel)DataContext;
            if (!languageVM.LanguageValidate())
            {
                MessageBox.Show("Hibás adatbevitel");
                return;
            }
            Close();
        }

        private void WindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var languageVM = (LanguageFormViewModel)DataContext;
            if (!languageVM.LanguageValidate())
            {
                var result = MessageBox.Show("Hibás adatbevitel.\n\rBezárja az ablakot", "Figyelmeztetés", MessageBoxButton.YesNo);
                if (!languageVM.IsNew && result == MessageBoxResult.Yes)
                {
                    languageVM.OriginalValue();
                    DialogResult = false;
                }

            }
        }
    }
}
