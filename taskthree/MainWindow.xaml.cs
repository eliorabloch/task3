

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

namespace taskthree
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Host> hostsList;
        public MainWindow()
        {
            InitializeComponent();

            hostsList = new List<Host>()
            {
                new Host()
                {
                    HostName= "Tzimerman",
                    Units= new List<HostingUnit>()
                    {
                        new HostingUnit()
                        {
                            UnitName="יופי של צימר",
                            Rooms=3,
                            IsSwimmimgPool=true,
                            AllOrders=new List<DateTime>(),

                           Uris=new List<string> { "https://www.google.com/search?q=hotel+pictures&source=lnms&tbm=isch&sa=X&ved=2ahUKEwiLgO_e55TmAhVL_aQKHdHiBEEQ_AUoAXoECAkQAw&biw=1422&bih=678&dpr=2.25#imgrc=bIXLBaX9yT_KQM:",
                            "https://www.google.com/search?q=hotel+pictures&source=lnms&tbm=isch&sa=X&ved=2ahUKEwiLgO_e55TmAhVL_aQKHdHiBEEQ_AUoAXoECAkQAw&biw=1422&bih=678&dpr=2.25#imgrc=B2z9ePFgFX4fCM:",
                            "https://www.google.com/search?q=hotel+pictures&source=lnms&tbm=isch&sa=X&ved=2ahUKEwiLgO_e55TmAhVL_aQKHdHiBEEQ_AUoAXoECAkQAw&biw=1422&bih=678&dpr=2.25#imgrc=gfZ92jZ_5xcsRM:"}
                        },
                        new HostingUnit()
                        {
                            UnitName= "אחלה של צימר",
                            Rooms=2,
                            IsSwimmimgPool=false,
                            AllOrders=new List< DateTime>()

                        },
                         new HostingUnit()
                        {
                            UnitName= "אחלה של צימר",
                            Rooms=2,
                            IsSwimmimgPool=false,
                            AllOrders=new List< DateTime>()

                        }


                        }
                }




            };
            cbHostList.ItemsSource = hostsList;
            cbHostList.DisplayMemberPath = "HostName";
            cbHostList.SelectedIndex = 0;



        }
        private Host currentHost;

        private void tbHostName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void cbHostList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            InitializeHost(cbHostList.SelectedIndex);
        }
        private void InitializeHost(int index)
        {
            MainGrid.Children.RemoveRange(1, 3);
            currentHost = hostsList[index];
            UpGrid.DataContext = currentHost;
            for (int i = 0; i < currentHost.Units.Count; i++)
            {
                HostingUnitUserControl a = new HostingUnitUserControl(currentHost.Units[i]);
                MainGrid.Children.Add(a);
                Grid.SetRow(a, i + 1);

            };
        }

        private void cbHostList_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}



