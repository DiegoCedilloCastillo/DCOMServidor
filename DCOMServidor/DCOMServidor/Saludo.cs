using System;
using System.Runtime.InteropServices;

namespace DCOMServidor
{
    [ComVisible(true)] // Hace visible la clase para COM
    [Guid("F1234567-89AB-4CDE-8F01-234567890ABC")] // GUID único para la clase
    [ClassInterface(ClassInterfaceType.None)] // Requiere que implemente la interfaz explícitamente
    public class Saludo : ISaludo
    {
        public string Saludar(string nombre)
        {
            return $"Hola, {nombre}! Bienvenido al mundo de DCOM.";
        }
    }
}