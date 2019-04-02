using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfApp10
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var Row = int.Parse(TxRow.Text);
            var Col = int.Parse(TxCol.Text);
            var Items = new ObservableCollection<Dictionary<string, string>>();
            Items.Clear();
            for (int r = 0; r < Row; r++)
            {
                var dic = new Dictionary<string, string>();

                for (int c = 0; c < Col; c++)
                {
                    dic.Add($"C{c}", $"C{c}-R{r}");
                }
                Items.Add(dic);
            }
            DataContext = Items;
        }
    }
}
