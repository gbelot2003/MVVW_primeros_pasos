using System.Windows;
using WpfApp1.ViewModel;

namespace WpfApp1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        //simplemente se cargan los objetos que se suben al DataContext, la logica
        //sigue manejandose en el ViewModel
        private void StudentViewControl_Loaded(object sender, RoutedEventArgs e)
        {
            StudentViewModel studentViewModel = new StudentViewModel();
            studentViewModel.LoadStudents();

            StudentViewControl.DataContext = studentViewModel;
        }
    }
}
