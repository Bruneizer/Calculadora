int Calculadora()
{
    Console.WriteLine("Ingrese un numero");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese el segundo numero");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese operacion");
    string operacion = Console.ReadLine();
    int resultado;

    switch (operacion)
    {
        case "+":
            resultado = a + b;
            Console.WriteLine($"El resultado de la suma es {resultado}");
            break;
        case "-":
            resultado = a - b;
            Console.WriteLine($"El resultado de la resta es {resultado}");
            break;
        case "*":
            resultado = a * b;
            Console.WriteLine($"El resultado de la multiplicacion es {resultado}");
            break;
        case "/":
            resultado = a / b;
            Console.WriteLine($"El resultado de la divicion es {resultado}");
            break;
    }
 
        //Console.WriteLine($"El resultado es {sumar}");
    
  
        //Console.WriteLine($"El resultado es {restar}");
    
    
        //Console.WriteLine($"El resultado es {dividir}");
  
        //Console.WriteLine($"El resultado es {multiplicacion}");
    
}










