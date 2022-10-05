using System.Windows;

using Semana05.ViewModel;
namespace Semana05.View
{
    /// <summary>
    /// Lógica de interacción para ListaCategoria.xaml
    /// </summary>
    public partial class ListaCategoria : Window
    {
        ListaViewModel viewModel;
        public ListaCategoria()
        {
            InitializeComponent();
            viewModel = new ListaViewModel();
            this.DataContext = viewModel;

        }
    }
}