using System;
using System.Collections.Generic;
using System.Text;
using MvvmLibrary.Factorias.DialogService;
using Xamarin.Forms;

namespace MvvmLibrary.Factorias
{
    /// <inheritdoc />
    /// <summary>
    /// Interfaz para la navegacion de las Pages.
    /// Hereda la interfaz IDialogService.
    /// Implementa la Interfaz INavigation de Xamrin.Forms.
    /// </summary>
    public interface IPage : IDialogService
    {
        INavigation Navigation { get; }
    }
}
