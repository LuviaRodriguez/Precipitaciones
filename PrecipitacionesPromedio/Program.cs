using PrecipitacionesPromedio;

Console.WriteLine("Demostración de las precipitaciones de cada mes. \n");

static void Main()
{
    string[] nombresMeses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
    ListaDePrecipitaciones listaDePrecipitaciones = new ListaDePrecipitaciones();
    for (int i = 0; i < 12; i++)
    {
        Console.Write($"Ingrese la precipitación promedio para {nombresMeses[i]}: ");
        double promedio = double.Parse(Console.ReadLine());
        listaDePrecipitaciones.AgregarPrecipitacion(new Precipitacion(i + 1, nombresMeses[i], promedio));

        listaDePrecipitaciones.MostrarResultados();
    }
}