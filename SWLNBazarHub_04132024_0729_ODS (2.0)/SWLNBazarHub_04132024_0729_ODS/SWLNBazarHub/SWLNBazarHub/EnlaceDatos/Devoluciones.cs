//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SWLNBazarHub.EnlaceDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Devoluciones
    {
        public int DevolucionID { get; set; }
        public Nullable<int> PedidoID { get; set; }
        public Nullable<int> ProductoID { get; set; }
        public Nullable<int> Cantidad { get; set; }
        public string Motivo { get; set; }
        public string Estado { get; set; }
    
        public virtual Pedidos Pedidos { get; set; }
        public virtual Productos Productos { get; set; }
    }
}