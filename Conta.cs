namespace Projeto01
{
    public class Conta
    {
      private string numero;

      private double saldo;

     private string dono;

     private double limite;

     private void Deposita(double valor){
         saldo = saldo + valor;
     }
    public void Saque(double valor){
        
        saldo = saldo - valor;
    }

    public void setNumero(string numero){
        this.numero = numero;
    }

        public string getSaldo(){
            return "R$" +this.saldo+ ",00";
        }
    public double Limite{
        get{
            return limite;
        }
        set{
            limite = value;
        }
    }

    public string Dono{ get; set;} 


    }
}