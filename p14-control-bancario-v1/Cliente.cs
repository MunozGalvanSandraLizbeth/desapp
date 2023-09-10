public class Cliente {
    public string Nombre {get; set;}
    public string Correo {get; set;}
    public CuentaBancaria Cuenta {get; set;}

    public Cliente(string nombre, string correo, CuentaBancaria cuenta) => (Nombre, Correo, Cuenta) = (nombre, correo, cuenta);

    public override string ToString() => $"Nombre: {Nombre}, Correo: {Correo}";
}