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
using Sprint3;

namespace Sprint3
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

        public void AddItems_Click(object sender, RoutedEventArgs e)
        {
            listItems.Items.Clear();

            Manufacturer Sieghardware = Manufacturer.CheckForInstance();

            Air SR71 = new Air("SR-71", 3540, 3, true, "Turbojet-Ramjet hybrid", null);
            Land Verge = new Land("Verge Motorcycle", 112, 2, "Electric", "Hubless rear wheel (houses engine)");
            Sea CypressCay = new Sea("Cypress Cay", 250, 3159, 0.2, "Gas", "Pontoon");

            Sieghardware.AddSeaVehicle(CypressCay);
            Sieghardware.AddLandVehicle(Verge);
            Sieghardware.AddAirVehicle(SR71);

            listItems.Items.Add(SR71.GetName());
            listItems.Items.Add(Verge.GetName());
            listItems.Items.Add(CypressCay.GetName());

            // Clear any previous items in the combobox
            VehicleComboBox.Items.Clear();

            // Add instances of the Vehicle class to the combobox
            VehicleComboBox.Items.Add(SR71);
            VehicleComboBox.Items.Add(Verge);
            VehicleComboBox.Items.Add(CypressCay);

            // This tells the combobox where to find the value and display value
            VehicleComboBox.SelectedValuePath = "VehicleName";
            VehicleComboBox.DisplayMemberPath = "VehicleName";


        }

        public void Vehicle_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Retrieve the selected item: it's an instance of the Vehicle class
            Vehicle selection = (Vehicle)VehicleComboBox.SelectedItem;

            // Get the rent value of the selected item
            int rentValue = selection.ViewRent();

            if (selection != null)
            {
                try
                {
                    if (rentValue == 0)
                    {
                        // Show the items selected
                        MessageBox.Show("You chose to Rent " + selection.VehicleName);
                        selection.SetState(new Unavailable(selection));
                    }
                    else if (rentValue == 1)
                    {
                        // Show the items selected
                        MessageBox.Show("You have returned " + selection.VehicleName);
                        selection.SetState(new Available(selection));
                    }
                }
                catch (Exception ex)
                {
                    // Handle the exception here
                    Console.WriteLine("An exception occurred: " + ex.Message);
                }
            }
            else
            {
                // selectedItem is null, do something else
                Console.WriteLine("selectedItem is null");
            }


        }
    }
}
