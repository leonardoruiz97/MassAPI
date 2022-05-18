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
    }
}
