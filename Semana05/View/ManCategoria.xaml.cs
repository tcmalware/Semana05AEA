using System.Windows;

using Semana05.ViewModel;












namespace Semana05.View
{
    /// <summary>
    ///  Lógica de interacción para ManCategoria.xaml
    /// </summary>
    public partial class ManCategoria : Window
    {
        ManCategoriaViewModel viewModel;
        public ManCategoria()
        {
            InitializeComponent();
            viewModel = new ManCategoriaViewModel();
            this.DataContext = ViewModel;
        }


    }
}