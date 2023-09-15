﻿// Control Bancario V2
Banco mibanco = new Banco("Banco de los Pobres SA de CV", "La Pasadita 201");

mibanco.AgregarCliente(new Cliente("Carlos Fuentes", "cfuentes@gmail.com", new List<CuentaBancaria>{
    new CuentaDeAhorro(1500,0.10), new CuentaDeAhorro(2500,0.20), new CuentaDeCheques(6500,500)
}));

mibanco.AgregarCliente(new Cliente("Juan de la Fuente", "juanfuente@gmail.com", new List<CuentaBancaria>{
    new CuentaDeCheques(2500,500)
}));

mibanco.AgregarCliente(new Cliente("Rene Mayorga", "renemayorga@gmail.com", new List<CuentaBancaria>()));
mibanco.Clientes[2].AgregarCuenta(new CuentaDeCheques(16500,1500));
mibanco.Clientes[2].AgregarCuenta(new CuentaDeAhorro(116500,0.4));

mibanco.AgregarCliente(new Cliente("Jose Perez", "jperez@gmail.com", new List<CuentaBancaria>()));
mibanco.Clientes[3].AgregarCuenta(new CuentaDeAhorro(12500,0.30));

mibanco.Clientes[2].Cuentas[1].Retira(110000);
mibanco.Clientes[1].Cuentas[0].Deposita(110000);

Console.Clear();
Console.WriteLine($"Reporte de clientes del banco {mibanco.ToString()}");
Console.WriteLine($"El banco tiene {mibanco.Clientes.Count}clientes\n");
foreach(Cliente cte in mibanco.Clientes){
    Console.WriteLine($"Cliente : {cte.ToString()}, tiene {cte.Cuentas.Count} cuentas");
    foreach(CuentaBancaria cta in cte.Cuentas){
        Console.Write((cta is CuentaDeCheques)? "Cuenta de Cheques" : "Cuenta de Ahorro");
        if(cta is CuentaDeAhorro) (cta as CuentaDeAhorro).CalcularInteres();
        Console.WriteLine($", con un saldo de {cta.Saldo}");
    }
}
