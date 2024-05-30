using LanguageSwitcher;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace libs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public bool flag = true;

        private void SwitchLanguage(object sender, RoutedEventArgs e)
        {
            Window1 window = new Window1();

            flag = !flag;

            if (flag)
            {
                Megatext.Text = LanguageSwitcher.Language.rusMegaText;
                Smalltext.Text = LanguageSwitcher.Language.rusText;
                Button1.Content = LanguageSwitcher.Language.rusButton1;
                Button2.Content = LanguageSwitcher.Language.rusButton2;
            }
            else
            {
                Megatext.Text = LanguageSwitcher.Language.engMegaText;
                Smalltext.Text = LanguageSwitcher.Language.engText;
                Button1.Content = LanguageSwitcher.Language.engButton1;
                Button2.Content = LanguageSwitcher.Language.engButton2;
            }
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Window1 win = new Window1();
            win.Show();
        }
    }
}