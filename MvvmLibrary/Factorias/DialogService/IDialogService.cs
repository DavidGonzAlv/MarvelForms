using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MvvmLibrary.Factorias.DialogService
{
    /// <summary>
    /// Interfaz para el servicio de dialogo.
    /// </summary>
    public interface IDialogService
    {
        Task MostrarAlerta(string titulo, string mensaje, string cancelar);
        Task<bool> MostrarAlerta(string titulo, string mensaje, string aceptar, string cancelar);
        Task<string> MostrarActionSheet(string titulo, string cancelar, string destruccion, params string[] botones);
    }
}
