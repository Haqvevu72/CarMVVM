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
using System.Windows.Shapes;
using WpfApp1.Model;
using WpfApp1.ViewModel;

namespace WpfApp1.ViewModel
{
    public partial class MainViewModel
    {
        internal ObservableCollection<Car> cars = new ObservableCollection<Car>()
        {
            new Car("Images\\Car1.webp","Toyota","Prius","2023"),
            new Car("Images\\Car2.webp","Mercedes","Cyristal","2023"),
            new Car("Images\\Car3.webp","Nissan","AUG-A1","2023")
        };

        public MainViewModel() 
        {
            InitializeComponent();
            car_menu.ItemsSource = cars;
        }

    }
}
