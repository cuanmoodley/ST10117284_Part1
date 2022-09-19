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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using dllT1;   // using class library dll
namespace testingpoe1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            datagriduse modules = new datagriduse();
        }
        int valueOne;
        int valueTwo;
        int valueThree;  //values from class libray
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ok_Click(object sender, RoutedEventArgs e) // using dll to display
        {
            valueOne = Convert.ToInt32(textbox1.Text);
            valueTwo = Convert.ToInt32(textbox2.Text);
            valueThree = Convert.ToInt32(textbox3.Text);  //self study hours calculation
            
            textbox4.Text = Convert.ToString(dllT1.Class1.calculation(valueOne, valueTwo, valueThree));
            if (MessageBox.Show("Is the entry correct","Confirm entry",MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                datagriduse temp = new datagriduse();   //linq
                temp.modulename = modname.Text;
                temp.modulecode = modcode.Text;
                temp.dates = date.Text;
                temp.hours = Convert.ToInt32(textbox4.Text);  // adding data to datagrid

                daata.Items.Add(temp);



            }

        }

        private void textbox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
