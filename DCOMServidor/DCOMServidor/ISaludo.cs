using System;
using System.Runtime.InteropServices;

namespace DCOMServidor
{
    [ComVisible(true)] // Hace que la interfaz sea visible para COM
    [Guid("D1234567-89AB-4CDE-8F01-234567890ABC")] // GUID único para la interfaz
    [InterfaceType(ComInterfaceType.InterfaceIsDual)] // Permite acceso desde COM y .NET
    public interface ISaludo
    {
        string Saludar(string nombre);
    }
}