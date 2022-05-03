namespace DAL1StSharp.Modelos
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public int NumUsuario { get; set; }
        public string Password { get; set; }
        public int IdSucursal { get; set; } //FK Sucursal
    }
}
