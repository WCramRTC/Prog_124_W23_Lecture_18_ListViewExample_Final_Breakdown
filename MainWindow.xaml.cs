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

namespace Prog_124_W23_Lecture_18_ListViewExample_Final_Breakdown
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Player> players = new List<Player>();
        Party moltenCore;

        public MainWindow()
        {
            InitializeComponent();

            //lvDisplay.Items.Add("Will");
            //lvDisplay.Items.Add("Bander");
            //lvDisplay.Items.Add("Zach");
            //lvDisplay.Items.Add("Sam");
            //lvDisplay.Items.Add("Suleman");

            moltenCore = new Party("Molten Core Party");
            moltenCore.AddPlayer(new Player("BlastKraken", 50, "Ice Mage"));
            moltenCore.AddPlayer(new Player("Xander", 300, "Arms Warrior"));
            moltenCore.AddPlayer(new Player("Sam", 400, "Paladin"));
            moltenCore.AddPlayer(new Player("Zach", 150, "Feral Druid"));
            moltenCore.AddPlayer(new Player("Suleman", 250, "Hunter"));

            lbPartyName.Content = moltenCore;
            DisplayParty(moltenCore);

            //lvDisplay.ItemsSource = moltenCore;
            
        }
        private void btnAddPlayer_Click(object sender, RoutedEventArgs e)
        {
            // When I click this button. I will add a Player to the Molten Core List

            // Because we are not working with an observable collection
            // the listview will not auto update

            // Create a new player
            Player anne = new Player("Anne", 125, "Warlock");
            // add to list molten core
            moltenCore.AddPlayer(anne);
            DisplayParty(moltenCore);

            //lvDisplay.ItemsSource = moltenCore;


        }

        public void DisplayParty(Party party)
        {
            lvDisplay.Items.Clear();

            foreach (Player player in party)
            {
                lvDisplay.Items.Add(player);
            }
        }

        private void lvDisplay_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lbSelectedIndex.Content = $"Current Index: {lvDisplay.SelectedIndex}";
        }


    }
}
