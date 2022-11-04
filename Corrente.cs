namespace projeto_paralelo
{
    public class Corrente: Conta
    {        
        public double limite { get; private set; }

        public Corrente(string argAgencia, string argNumero, double argLimite) : base(argAgencia, argNumero)
        {
            setLimite(argLimite);
        }


        public void setLimite(double argLimite){
            if (argLimite > 100){
                this.limite = argLimite;
            }
            else
                this.limite = 0;
        }

        public override bool Sacar(double argValor)
        {
            if((argValor <= (base.saldo + this.limite)))
            {
                base.setSaldo(base.saldo - argValor);
                return true;
            }
            else{
                return false;
            }
        }

        public string ToString(){
            string texto = base.ToString();
            texto += "Agencia:" + this.agencia +
                            "\nNro. Conta:" + this.numero +
                            "\nSaldo: " + this.saldo;
            return texto;                    
        }
    }
}