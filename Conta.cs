namespace projeto_paralelo
{
    public abstract class Conta
    {
        public string ?agencia { get;  private set; }//atributos
        public string ?numero { get; private set; }//atributos

        //formas de definir os argumentos(antiga)
        public double saldo {get; private set;}//atributos

        // Método construtor
        public Conta(string argNumero, string argAgencia){
            setNumero(argNumero);
            setAgencia(argAgencia);
            setSaldo(0);           
        }

        //set e get
        public void setNumero(string argNumero){
            if (argNumero.Length > 4){
                this.numero = argNumero;         
            }       
        }
        
        public void setAgencia(string argAgencia){
            if(argAgencia.Length > 2){
                this.agencia = argAgencia;
            }            
        }
        
        public void setSaldo(double argSaldo){
            this.saldo = argSaldo;
        }  

        //Métodos comuns
        public abstract bool Sacar(double argValor); 

        public bool Depositar(double argValor)
        {
            if(argValor > 0){
                this.saldo = this.saldo + argValor;
                return true;
            }
            else{
                return false;
            }
            
        } 
        
        public string ToString(){
            string texto = "Agencia: " + this.agencia +
                            "\nNro. Conta:" + this.numero +
                            "\nSaldo:" + this.saldo;
            return texto;                    
        }

                  
        /*
        Métodos 
        posuem o modificador de visibilidade(public, private, protected....)
        retorno (boot, string, int, flood, objeto de uma clase, lista, void....)
        nome do método(padrão não é regra, mais é bom seguir....iniciais maiusculas de denotam ação....
        exemplo vervosno infinitivo...Depositar, Sacar, Imprimir, Verificar, Calcular...etc)
        argumentos(são os valores, podem existir ou nao, necessarios para que o método funcione, chamamos de assinatura do método)
        */   


    } 
       
}
   
