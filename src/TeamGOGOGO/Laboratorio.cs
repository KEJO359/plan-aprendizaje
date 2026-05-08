using System.Data.Common;

namespace TeamGOGOGO;

public class Laboratorio
{
    public int IdLaboratorio {get;set;} 
    private string Nombre;
    public string nombre
    {
        get
        {
            return nombre;
        }
        set
        {
            if(string.IsNullOrEmpty(nombre))
            {
                throw new ArgumentException("Nombre incorrecto"); 
            }
        }
    }

    private string Ubicacion;
     public string ubicacion
    {
        get
        {
            return ubicacion;
        }
        set
        {
            if(string.IsNullOrEmpty(ubicacion))
            {
                throw new ArgumentException("ubicación incorrecta"); 
            }
        }
    }

    public Laboratorio (string nombre, string ubicacion, int idLaboratorio)
    {
        Nombre=nombre;
        Ubicacion=ubicacion;
        IdLaboratorio=idLaboratorio;
    }
    public void Mostrar ()
    {
        Console.WriteLine(Nombre);
        Console.WriteLine(Ubicacion);
        Console.WriteLine(IdLaboratorio);
    }

}

