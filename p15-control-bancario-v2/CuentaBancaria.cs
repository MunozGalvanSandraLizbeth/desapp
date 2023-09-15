public class CuentaBancaria{
    public double Saldo {get; set;}  
    public CuentaBancaria (double cantidad) => Saldo = cantidad;
    public void Deposita (double cantidad) => Saldo += cantidad;

    public virtual bool Retira(double cantidad) { // Este metodo va a poder ser sobrecargado en la clase derivada (virtual)
        if(Saldo>=cantidad){
            Saldo -= cantidad;
            return true;
        } else return false;
    }
}