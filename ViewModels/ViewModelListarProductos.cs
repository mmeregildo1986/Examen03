using Examen03.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Examen03.ViewModels
{
    public class ViewModelListarProductos:ViewModelBase
    {
        #region Propiedades

        public string _Nombre;
        public string Nombre
        {
            get {return _Nombre;}
            set
            {
                _Nombre = value;
                OnPropertyChanged(nameof(Nombre));
            }
        }
        public double _Precio;
        public double Precio
        {
            get { return _Precio; }
            set
            {
                _Precio = value;
                OnPropertyChanged(nameof(Precio));
            }
        }
        public string _Descripcion;
        public string Descripcion
        {
            get { return _Descripcion; }
            set
            {
                _Descripcion = value;
                OnPropertyChanged(nameof(Descripcion));
            }
        }

        #endregion
        public ObservableCollection<Producto> Productos { get; }

        #region Comando

        public ICommand AgregarProductoCommand { get; }

        public ViewModelListarProductos() 
        {
            AgregarProductoCommand = new RelayCommand(AgregarLista);
            Productos = new ObservableCollection<Producto>();
        }

        private void AgregarLista()
        {
            Productos.Add(new Producto
            {
                Nombre = _Nombre,
                Precio = _Precio,
                Descripcion= _Descripcion
            });
        }

        #endregion

    }
}
