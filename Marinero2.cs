class Marinero2:Tripulante,ICalcular_bono
{
          public Marinero2 ( string Nombre1, string Nombre, double telefono , double Cedula, double  edad , double Tiempo_empresa, string sexo, double Sueldo_base,double bono):base(Nombre1, Nombre, telefono, Cedula, edad, Tiempo_empresa, sexo, Sueldo_base, bono)
    {
 
    }
    public void Calcular_bono()
    {
        double sueldo_total;

        sueldo_total = (Sueldo_base + bono);
        Console.WriteLine("Sueldo total :"+sueldo_total);
    }
    
}