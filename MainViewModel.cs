using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfUtilV2.Mvvm;

namespace WpfApp10
{
    public class MainViewModel : BindableBase
    {
        public MainViewModel()
        {
            Columns = new ObservableCollection<string>();

            Items = new ObservableCollection<Dictionary<string, string>>();
        }

        public int Column
        {
            get { return _Column; }
            set { SetProperty(ref _Column, value); }
        }
        private int _Column;

        public int Row
        {
            get { return _Row; }
            set { SetProperty(ref _Row, value); }
        }
        private int _Row;

        public ObservableCollection<Dictionary<string, string>> Items
        {
            get { return _Items; }
            set { SetProperty(ref _Items, value); }
        }
        private ObservableCollection<Dictionary<string, string>> _Items;

        public ObservableCollection<string> Columns
        {
            get { return _Columns; }
            set { SetProperty(ref _Columns, value); }
        }
        private ObservableCollection<string> _Columns;

        public ICommand Execute
        {
            get { return _Execute = _Execute ?? new RelayCommand(Execute_Method); }
        }
        private ICommand _Execute;

        private void Execute_Method(object dummy)
        {
            Items.Clear();
            for (int r = 0; r < Row; r++)
            {
                var dic = new Dictionary<string, string>();

                for (int c = 0; c < Column; c++)
                {
                    dic.Add($"C{c}", $"C{c}-R{r}");
                }
                Items.Add(dic);
            }

            Columns.Clear();
            foreach (var s in Items.First().Keys)
            {
                Columns.Add(s);
            }
        }
    }
}
