namespace FakeEquifax.Modelos
{
    public class Peticion
    {
        public int IdPeticion { get; set; }
        public int IdCliente { get; set; } //FK Cliente
        public string Estado { get; set; }
    }
}
