using Entity;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace Semana05.ViewModel
{
    public class ListaViewModel : ViewModelBase
    {
        public ObservableCollection<Categoria> Categorias { get; set; }

        public ICommand NuevoCommand { get; set; }
        public ICommand ConsultarCommand { get; set; }
        public ListaViewModel()
        {
            Categorias = new Model.CategoriaModel().Categorias;

            NuevoCommand = new RelayCommand<Window>(
                param => Abrir()
                );
            ConsultarCommand = new RelayCommand<object>(
                o => { Categorias = (new Model.CategoriaModel()).Categorias; }
                );
            void Abrir()
            {
                ViewModel.ManCategoria window = new ViewModel.ManCategoria();
                window.ShowDialog();
                //Categorias = (new Model.CategoriaModel()).Categorias;

            }
        }
    }
}
