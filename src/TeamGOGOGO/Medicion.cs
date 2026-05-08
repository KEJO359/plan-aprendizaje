namespace TeamGOGOGO;

public class Medicion
{
    private int Cpu ;
    public int cpu
    {
        get
        {
            return cpu;
        }
        set
        {
            if (Cpu < 0 || Cpu > 100)
            {
                throw new ArgumentException("CPU debe estar entre 0 y 100 de uso");
            }
            else
            {
                cpu = value;
            }
        }
    } 
    private double Ram;
    public double ram
    {
        get
        {
            return ram;
        }
        set
        {
            if (Ram < 0 || Ram > 100)
            {
                throw new ArgumentException("Ram debe estar entre 0 y 100 de uso");
            }
            else
            {
                ram = value;
            }
        }

    }
    private int Temperatura;
    public int temperatura
    {
        get
        {
            return temperatura;
        }
        set
        {
            if (Temperatura >= 0 )
            {
                ram = value;
            }
            else
            {
                throw new ArgumentException("Temperatura debe ser mayor o igual a 0"); 
            }
        }

    }
    private bool Conectada; 
    public bool conectada
    {
        get
        {
            return conectada;
        }
        set
        {
            if (conectada)
            {
                conectada = value;
        
                Console.WriteLine("Esta Encendido");
            }
            else
            {
                throw new ArgumentException("Esta Apagado"); 
            }
        }

    }

    private string Fecha;
    public string fecha
    {
        get
        {
            return fecha;
        }
        set
        {
            if(string.IsNullOrEmpty(fecha))
            {
                throw new ArgumentException("Fecha incorrecta"); 
            }
        }
    }
         



    public Medicion(int cpu, double ram, int temperatura, bool conectada, string fecha)
    {
        if (cpu < 0 || cpu > 100)
            throw new ArgumentException("CPU debe estar entre 0 y 100");

        if (ram < 0 || ram > 100)
            throw new ArgumentException("RAM debe estar entre 0 y 100");
                                                                                                    
        if (temperatura <= 0)
            throw new ArgumentException("La temperatura no puede ser negativa");

        Cpu = cpu;
        Ram = ram;
        Temperatura = temperatura;
        Conectada = conectada;
        Fecha = fecha;
    }
}
