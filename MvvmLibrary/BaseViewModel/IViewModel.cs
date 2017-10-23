using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MvvmLibrary.BaseViewModel
{
    /// <inheritdoc />
    /// <summary>
    /// Interfaz de la que hereda BaseViewModel y por ende todos los ViewModels.
    /// Hereda de INotifyPropertyChanged
    ///  Implementa el titulo y el estado del View.
    /// </summary>
    public interface IViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Titulo del View.
        /// </summary>
        string Titulo { get; set; }

        /// <summary>
        /// Estado del View.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="action"></param>
        void SetState<T>(Action<T> action) where T : class, IViewModel;
    }
}
