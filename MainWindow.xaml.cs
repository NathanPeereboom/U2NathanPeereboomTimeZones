/* Nathan Peereboom
 * March 28, 2019
 * Converts time from Ottawa to other time zones across Canada
 */


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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace U2NathanPeereboomTimeZones
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


        private void btnProcess_Click(object sender, RoutedEventArgs e)
        {
            int timeOttawa;
            Int32.TryParse(txtInput.Text, out timeOttawa);
            int timeVictoria = timeOttawa - 300;
            if (timeVictoria < 0) timeVictoria += 2400;
            int timeEdmonton = timeOttawa - 200;
            if (timeEdmonton < 0) timeEdmonton += 2400;
            int timeWinnipeg = timeOttawa - 100;
            if (timeWinnipeg < 0) timeWinnipeg += 2400;
            int timeHalifax = timeOttawa + 100;
            if (timeHalifax >= 2400) timeHalifax -= 2400;
            int timeStJohns = timeOttawa + 130;
            if (timeStJohns % 100 >= 60) timeStJohns += 40;
            if (timeStJohns >= 2400) timeStJohns -= 2400;
            lblOutput.Content = "The time in Victoria is " + timeVictoria + Environment.NewLine +
                "The time in Edmonton is " + timeEdmonton + Environment.NewLine +
                "The time in Winnipeg is " + timeWinnipeg + Environment.NewLine +
                "The time in Ottawa is " + timeOttawa + Environment.NewLine +
                "The time in Halifax is " + timeHalifax + Environment.NewLine +
                "The time in St. John's is " + timeStJohns + Environment.NewLine;
        }
    }
}
