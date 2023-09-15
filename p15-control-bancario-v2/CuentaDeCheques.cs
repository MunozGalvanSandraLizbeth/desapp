public class CuentaDeCheques : CuentaBancaria{
    public double Sobregiro {get; set; }
    public CuentaDeCheques(double saldo, double sobregiro) : base(saldo) => Sobregiro = sobregiro;
    public override bool Retira(double cantidad){
        double requerida = cantidad - Saldo;
        if(Sobregiro < requerida) return false;
        else {
            Saldo = 0.0f;
            Sobregiro -= requerida;
        }
        return true;
    }
}