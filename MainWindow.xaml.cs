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

namespace Practice___IComparable___Sorting
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Player> players = new List<Player>
        {
            new Player { Name = "John-", Score = 80 },
            new Player { Name = "Alice", Score = 95 },
            new Player { Name = "will", Score = 70 },
            new Player { Name = "Eve", Score = 85 },
            new Player { Name = "Jeff", Score = 60 }

        };

            DisplayPlayers("Unsorted", players);

            List<Player> sortedPlayers = players.OrderBy(p => p.Name).ToList();
            DisplayPlayers("Players Sorted by Name", sortedPlayers);

            sortedPlayers.Sort(new ScoreComparer());
            DisplayPlayers("Players Sorted by Score", sortedPlayers);

            sortedPlayers.Sort(new Ndescendcompare());
            DisplayPlayers("Players Sorted by Name - Descending", sortedPlayers);

            sortedPlayers.Sort(new ScoreDescendingCompare());
            DisplayPlayers("Players Sorted by Score - Descending", sortedPlayers);
        }

        private void DisplayPlayers(string title, List<Player> players)
        {
            MessageBox.Show($"{title}:\n\n{string.Join("\n", players)}");
        }
    }
}
