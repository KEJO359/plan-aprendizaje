namespace TeamGOGOGO;

public class Computadora
{
    private int idComputadora;
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
    private string SistemaOperativo;
    public string sistemaOperativo
    {
        get
        {
            return sistemaOperativo;
        }
        set
        {
            if(string.IsNullOrEmpty(sistemaOperativo))
            {
                throw new ArgumentException("Sistema Operativo incorrecto"); 
            }
        }
    }
    public Laboratorio Laboratorio { get ; set ; }
    public ModeloPC ModeloPc { get ; set ; }   
    public Computadora (int idComputadora,string nombre , string sistemaOperativo, Laboratorio laboratorio ,ModeloPC modelo)
    {
        this.idComputadora=idComputadora;
        Nombre= nombre;
        SistemaOperativo=sistemaOperativo;
        Laboratorio = laboratorio;
        ModeloPc = modelo;

    }

    public void MostrarTodo ()
    {
        Console.WriteLine(Nombre);
        Console.WriteLine(SistemaOperativo);
    }
    

    

}

