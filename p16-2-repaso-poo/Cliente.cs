public class Cliente{
    public string Nombre {get; set;}
    public string RFC {get; set;}
    public string Correo {get; set;}
    public string Domicilio {get; set;}
    public List<Venta> Ventas {get; set;}

    public Cliente() => Ventas = new List<Venta>();
    public Cliente(string nombre, string rfc, string correo, string domicilio) => 
    (Nombre, RFC, Correo, Domicilio) = (nombre, rfc, correo, domicilio);

    public void AgregarVenta(Venta venta) => Ventas.Add(venta);

    public double SubTotal() {
        double total = 0;
        foreach(Venta venta in Ventas)
            total = total + venta.Total;
        return total;
    }

    public override string ToString() => $"Nombre: {Nombre,-20} RFC: {RFC,-12} Correo: {Correo,-25} Domicilio: {Domicilio}";
}