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
using JsonConv;

namespace libs
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<AyyLmao> ayyLmaos = new List<AyyLmao>();
            AyyLmao a = new AyyLmao(NamePeople.Text, int.Parse(AgePeople.Text));
            ayyLmaos.Add(a);
            JsonConv<AyyLmao> jsonConv = new JsonConv<AyyLmao>();
            jsonConv.Serialize(ayyLmaos, "lox.json");
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            JsonConv<AyyLmao> jsonConv = new JsonConv<AyyLmao>();
            List<AyyLmao> result = jsonConv.Desirealize("lox.json");
            NamePeople.Text = result[0].name;
            AgePeople.Text = Convert.ToString(result[0].age);
        }
    }
}
