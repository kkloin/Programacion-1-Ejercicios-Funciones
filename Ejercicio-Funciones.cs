class Ejercicio_Funciones
{
    static void Main(string[] args)
    {
        int _aBisisesto;

        Console.WriteLine("Ingrese un año: ");
        // _aBisisesto = Convert.ToInt32(Console.ReadLine()); 
        // Esto es un friendly reminder pa' mi de que tengo que aprender fijarme bien cuando declaro variables :)

        var _aConsola = Console.ReadLine();
        if(!Int32.TryParse(_aConsola, out _aBisisesto))
        {
            Console.WriteLine("Lo que usted introdujo no tiene el formato solicitado. El programa se cerrará.");
            return;
        }

        if (_aBisisesto < 1000 || _aBisisesto > 9999)
        {
            Console.WriteLine("Lo que usted introdujo no es un año válido. El programa se cerrará.");
            return;
        }

        if (EsBisiesto(_aBisisesto))
            Console.WriteLine(_aBisisesto + " es un año bisiesto.");
        else
            Console.WriteLine(_aBisisesto + " no es un año bisiesto.");

    }
    static bool EsBisiesto(int _aBisisesto)
    {
            if (_aBisisesto % 4 == 0 || _aBisisesto % 100 == 0 || _aBisisesto % 400 == 0)
        return true;
    else
        return false;
    }

}