namespace DAL1StSharp.Modelos
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string DocumentoId { get; set; }
        public string RazonSocial { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Nacionalidad { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public int CodPostal { get; set; }
        public string Ciudad { get; set; }
        public int dSucursal { get; set; } //FK Sucursal
        //public Sucursal Sucursal { get; set; } //FK Sucursal
    }
}
