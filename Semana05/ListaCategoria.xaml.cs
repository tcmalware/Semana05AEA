﻿using System;
using System.Windows;
using System.Windows.Controls;
using Business;
using Entity;

namespace Semana05
{
    /// <summary>
    /// Lógica de interacción para ListaCategoria.xaml
    /// </summary>
    public partial class ListaCategoria : Window
    {
        public ListaCategoria()
        {
            InitializeComponent();
        }

        private void BtnConsultar_Click(object sender, RoutedEventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            BCategoria Bcategoria = null;
            try
            {
                //0: Listar todas las categorias
                Bcategoria = new BCategoria();
                dgvCategoria.ItemsSource = Bcategoria.Listar(0);
            }
            catch (Exception)
            {
                MessageBox.Show("Comunicarse con el Administrador");
            }
            finally
            {
                Bcategoria = null;
            }
        }

        private void BtnNuevo_Click(object sender, RoutedEventArgs e)
        {
            //Coloco 0 porque es uno nuevo
            ManCategoria manCategoria = new ManCategoria(0);
            manCategoria.ShowDialog();
            Cargar();
        }

        private void DgvCategoria_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int idCategoria;
            var item = (Categoria)dgvCategoria.SelectedItem;
            if (null == item) return;
            idCategoria = Convert.ToInt32(item.IdCategoria);
            //Coloco 0 porque es uno nuevo
            ManCategoria manCategoria = new ManCategoria(idCategoria);
            manCategoria.ShowDialog();
            Cargar();
        }
    }
}