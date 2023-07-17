//Carlos Mencias

using Logica.Program;

//Validado para marca como: Chevrolet.
//Validado para modelos como: Sail, Sedan y Aveo.
//Validado para carros del año desde el 2015 en adelante hasta el 2023.
//Validado para 4 puertas.
//Validado para una carga de 100Kg maximo.


try
{
    var Carro1 = new Automovil()
    {
        Marca = "Chevrolet",
        Modelo = "Sedan",
        Anio = 2015,
        Puertas = 4,
    };

    var Carro2 = new Camioneta()
    {
        Marca = "Chevrolet",
        Modelo = "Aveo",
        Anio = 2023,
        Carga = 100,
    };

    Vehiculo[] vehiculos = new Vehiculo[]
    {
        Carro1, Carro2
    };

    foreach (Vehiculo vehiculo in vehiculos)
    {
        Console.WriteLine(vehiculo);
    }
}
catch (Exception ex)
{

    Console.WriteLine($"Existio un error: {ex.Message}");
}