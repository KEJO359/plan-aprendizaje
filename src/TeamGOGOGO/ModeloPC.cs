using System.Data;
using System.Reflection.Metadata.Ecma335;

namespace TeamGOGOGO;

public class ModeloPC
{
    private string Marca;
    public string marca
    {
        get
        {
            return marca;
        }
        set
        {
            if(string.IsNullOrEmpty(marca))
            {
                throw new ArgumentException("marca incorrecta"); 
            }
        }
    }
    private string Modelo;
    public string modelo
    {
        get
        {
            return Modelo;
        }
        set
        {
            if(string.IsNullOrEmpty(modelo))
            {
                throw new ArgumentException("modelo incorrecto"); 
            }
        }
    }
    private int Ram;
    public int ram
    {
        get
        {
            return ram;
        }
        set
        {
            if(ram < 4)
            {
                throw new ArgumentException("Ram incorrecta");
            }
        }
    }
    private string Procesador;
    public string procesador
    {
        get
        {
            return procesador;
        }
        set
        {
            if(string.IsNullOrEmpty(procesador))
            {
                throw new ArgumentException("Procesador incorrecto"); 
            }
        }
    } 
     public ModeloPC  (string marca, string modelo, int ram, string procesador )
    {
        Marca=marca;
        Modelo=modelo;
        Ram=ram;
        Procesador=procesador;
    }
    public void Mostrar ()
    {
        Console.WriteLine(marca);
        Console.WriteLine(modelo);
        Console.WriteLine(ram);
        Console.WriteLine(procesador);
    }

    

}