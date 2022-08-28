internal class Program
{
    private static void Main(string[] args)
    { 
	// Alteração realizada por Raphael Rodrigues
        string ano;
        ano = Console.ReadLine();
        int anoInt = Convert.ToInt16(ano);
        if(anoInt > 10 && < 18) {
            Console.WriteLine("Pode votar");
        
        } else if (anoInt >=18 ){   
            Console.WriteLine("Tem que voltar")
        }
            else {
            Console.WriteLine("Nao Pode votar");
        }
    
    }

}
