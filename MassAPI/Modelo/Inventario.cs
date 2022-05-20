namespace MassAPI.Modelo
{
    public class Inventario
    {
        public int Pk_articulo { get; set; }
        public int Pk_marca { get; set; }

        public string codigo { get; set; }
        public string nombre { get; set; }

        public string descripcion { get; set; }
        public string fechaV { get; set; }
        public decimal Pventa { get; set; }

        public string Marca { get; set; }
        public string Categoria { get; set; }

        public string Eproducto { get; set; }
        public int cant { get; set; }

        public class ddlMarca
        {
            public int idMarca { get; set; }
            public string nombre { get; set; }
        }

        public class ddlArticulo
        {
            public int idarticulo { get; set; }
            public string nombre { get; set; }
        }

        public class ddlUsuarioXinv
        {
            public int idusuario { get; set; }
            public string usuario { get; set; }
        }

        public class listarInventario
        {
            public int Pkarticulo { get; set; }
            public int PkUsuario { get; set; }
            public string Inventario { get; set; }
            public string producto { get; set; }
            public string usuario { get; set; }
            public string fecha { get; set; }
            public string descripcion { get; set; }
        }

        public class detalleInventario
        {
            public int Pkarthasinv { get; set; }
            public string ID { get; set; }
            public string SKU { get; set; }
            public string producto { get; set; }
            public string marca { get; set; }
            public decimal Pcompra { get; set; }
            public decimal Pventa { get; set; }
            public string descripcion { get; set; }
            public int cant { get; set; }

        }
    }
}
