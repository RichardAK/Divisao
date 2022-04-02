double numerador, denominador, quociente; 

Console.Write("Digite seu numerador: "); 
numerador = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite seu dominador: ");
denominador = Convert.ToDouble(Console.ReadLine());

if(denominador ==0)
{   
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Não é possivel dividir por zero");    
}

else 
{    
   quociente = numerador/denominador;

   Console.WriteLine($"{numerador:n1} dividido por {denominador:n1} seria {quociente}");
   Console.Beep(); 
}

Console.ResetColor();