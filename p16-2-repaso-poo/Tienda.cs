public class Tienda { 
    public string Nombre {get; set;}
    public string Propietario {get; set;}
    public string Domicilio {get; set;}
    public List<Cliente> Clientes {get; set;}

    public Tienda() => Clientes = new List<Cliente>(); //Permite crear una tienda sin darle datos
    public Tienda(string nombre, string propietario, string domicilio) : this() => 
    (Nombre, Propietario, Domicilio) = (nombre, propietario, domicilio);

    public void AgregarCliente(Cliente cliente) => Clientes.Add(cliente);

    public double Total() {
        double total = 0;
        foreach(Cliente cliente in Clientes)
            total = total + cliente.SubTotal();
        return total;
    }

    public double TotalVentas() {
        int total = 0;
        foreach(Cliente cliente in Clientes)
            total = total + cliente.Ventas.Count();
        return total;
    }

    public override string ToString() => $"Nombre: {Nombre}\nPropietario: {Propietario}:\nDomicilio: {Domicilio}"; //override hereda datos
}