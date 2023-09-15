public class Banco{
    public string Nombre { get; set; }
    public string Direccion { get; set;}
    public List<Cliente>Clientes{ get; set;}

    public Banco() => Clientes = new List<Cliente>();
    public Banco(string nombre, string direccion) : this() => (Nombre, Direccion) = (nombre, direccion);

    public void AgregarCliente(Cliente cliente) => Clientes.Add(cliente);   

    public override string ToString() => $"Nombre : {Nombre}, Domicilio : {Direccion}";
}