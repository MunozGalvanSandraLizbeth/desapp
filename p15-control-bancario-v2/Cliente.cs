public class Cliente{
    public string Nombre {get; set;}
    public string Correo {get; set;}
    public List<CuentaBancaria> Cuentas {get; set;}

    public Cliente(string nombre, string correo, List<CuentaBancaria> cuentas) => (Nombre, Correo, Cuentas) = (nombre, correo, cuentas);

    public void AgregarCuenta(CuentaBancaria cuenta) => Cuentas.Add(cuenta);

    public override string ToString() => $"Nombre : {Nombre}, Correo : {Correo}";
    
}