

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
        private Host currentHost { get; set; }
       
        List<Host> hostsList { get; set; }
        public MainWindow()
        {
            InitializeComponent();


            hostsList = new List<Host>()
            {
                new Host()
                {
                    HostName= "Eliel-Hotel",
                    Units= new List<HostingUnit>()
                    {
                        new HostingUnit()
                        {
                            UnitName="Kings Suite",
                            Rooms=3,
                            IsSwimingPool=true,
                            AllOrders=new List<DateTime>(),

                          Uris=new List<string> { "https://triplanco.com/wp-content/uploads/2019/01/hotel_triplanco.jpg"
                        }


                        },
                        new HostingUnit()
                        {
                            UnitName= "Palace Suite",
                            Rooms=2,
                            IsSwimingPool=false,
                            AllOrders=new List< DateTime>(),
                             Uris=new List<string>{ " https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcROMTpoMQx4497usFxROm2Ly1QCqIFYj8Z8a69YVxtfWsN0GJ5d&s"}

                        },
                         new HostingUnit()
                        {
                            UnitName= "luxury Suite",
                            Rooms=2,
                            IsSwimingPool=false,
                            AllOrders=new List< DateTime>(),
                              Uris=new List<string>{ "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSydJh8qsCbGInXldidelO0tK-3Nw3FEyK8lK2LOCIseofiFcsB&s " }

                        }


                        }
                }




            };
            cbHostList.ItemsSource = hostsList;
            cbHostList.DisplayMemberPath = "HostName";
            cbHostList.SelectedIndex = 0;

        }

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
    }
}



