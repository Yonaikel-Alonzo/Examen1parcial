internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        Barco n1 = new Barco ("Tercero A",10,30000);
        n1.imprimir();
        Gps n2= new Gps("8'24'54","9'23'21",18/11/2022,30,09);
        n2.imprimir();
        Capitan n4 = new Capitan("Capitan","Marco",098432123,2339876542,20,20,"M",4500,900);
        n4.imprimir();
        Jefe_flota n5 = new Jefe_flota("jefe de flota", "juan",0984321123,2339876542,23,15,"M",3500,0,50,180);
        n5.imprimir();
        n5.mostra();
        n5.Calcular_bono();
        Marinero n6 = new Marinero("Marinero","Pedro",098432123,2339876542,10,10,"M",900,1750);
        n6.imprimir();
        n6.Calcular_bono();
        Marinero2 n7 = new Marinero2("Marinero","Maria",098432123,2339876542,19,10,"F",900,1750);
        n7.imprimir();
        n7.Calcular_bono();
        Marinero3 n8 = new Marinero3("Marinero","Pedro",098432123,2339876542,21,10,"M",900,1750);
        n8.imprimir();
        n8.Calcular_bono();

        List<Tripulante> listafigura=new List<Tripulante>();
            listafigura.Add(n4);
            listafigura.Add(n5);
            listafigura.Add(n6);
            listafigura.Add(n7);
            listafigura.Add(n8);
            

            foreach(ICalcular_bono item in listafigura)
            {
              
            }


    }
}