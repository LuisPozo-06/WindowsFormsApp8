//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp8
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pasaje
    {
        public int Id { get; set; }
        public Nullable<int> IdVuelo { get; set; }
        public Nullable<int> IdPasajero { get; set; }
        public Nullable<int> IdAsientoAvion { get; set; }
        public string Estado { get; set; }
    
        public virtual AsientoAvion AsientoAvion { get; set; }
        public virtual Pasajero Pasajero { get; set; }
        public virtual Vuelo Vuelo { get; set; }
    }
}
