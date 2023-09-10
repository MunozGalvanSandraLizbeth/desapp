﻿// Control Bancario

// Probar clase Cuanta Bancaria
CuentaBancaria cuenta = new CuentaBancaria(100);
cuenta.Deposita(200);
Console.WriteLine($"Saldo : {cuenta.Saldo}");
cuenta.Retira(150);
if (cuenta.Retira(1500)) Console.WriteLine("Retiro Exitoso");
else Console.WriteLine("No se puede retirar, saldo insuficiente");
Console.WriteLine($"Saldo : {cuenta.Saldo}");

// Probar Clase Cliente
Cliente cliente01 = new Cliente("Juan Carlos", "jcarlos@gmail.com", cuenta);
cliente01.Cuenta.Deposita(1500);
Console.WriteLine($"\nDatos del Cliente : {cliente01.ToString()}");
Console.WriteLine($"\nSaldo Cuenta      : {cliente01.Cuenta.Saldo}");

Cliente cliente02 = new Cliente("Paola Díaz", "paolad@gmail.com", new CuentaBancaria(450));
Console.WriteLine($"\nDatos del Cliente : {cliente02.ToString()}");
Console.WriteLine($"\nSaldo Cuenta      : {cliente02.Cuenta.Saldo}");

// Probar la Clase Banco
Banco mibanco = new Banco("Banco del Bienestar", "En cas de la Jodida");
mibanco.AgregarCliente(cliente01);
mibanco.AgregarCliente(cliente02);
mibanco.AgregarCliente(new Cliente ("Xochitl", "xochitl@gmail.com", new CuentaBancaria(200)));
mibanco.Clientes[2].Cuenta.Deposita(10000);
Console.WriteLine(mibanco.ToString());
Console.WriteLine($"El Banco tiene : {mibanco.Clientes.Count} clientes");

foreach(Cliente cl in mibanco.Clientes){
    Console.WriteLine($"Cliente : {cl.ToString()}");
    Console.WriteLine($"Saldo   : {cl.Cuenta.Saldo}");
}
