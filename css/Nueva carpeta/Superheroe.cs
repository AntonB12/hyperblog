
using System.Text;

var poderVolar = new Superpoder();
poderVolar.Nombre = "volar";
poderVolar.Descripcion = "volar en el aire";
poderVolar.Nivel = NivelPoder.NivelDos;

var spuerfuerza = new Superpoder();
spuerfuerza.Nombre = "Super Fuerza";
spuerfuerza.Nivel = NivelPoder.nivelTres;

var reactorark = new Superpoder();
reactorark.Nombre = "Reactor Ark";
reactorark.Nivel = NivelPoder.nivelTres;

var unirayo = new Superpoder();
unirayo.Nombre = "Unirayo";
unirayo.Nivel = NivelPoder.NivelDos;


var superman = new Superheroe();
var ironman = new Superheroe();

superman.Id = 1;;
superman.Nombre = "Superman";
superman.IdentidadSecreta = "Clark Kent";
superman.Ciudad = "Metropilos";
superman.Puedevolar = true;

var superman2 = new Superheroe();

superman2.Id = 1;;
superman2.Nombre = "Superman";
superman2.IdentidadSecreta = "Clark Kent";
superman2.Ciudad = "Metropilos";
superman2.Puedevolar = true;

Console.WriteLine(superman == superman2);

SuperheroeRecord superheroeRecord = new (1, "Superman", "Clark Kent");
SuperheroeRecord superheroeRecord2 = new (1, "Superman", "Clark Kent");

Console.WriteLine(superheroeRecord == superheroeRecord2);

//List<Superpoder> poderesSuperman = new List<Superpoder>();
//poderesSuperman.Add(poderVolar);
//poderesSuperman.Add(spuerfuerza);
//superman.Superpoderes = poderesSuperman;
//string resultSuperpoderes = superman.UsarSuperPoderes();
//Console.WriteLine(resultSuperpoderes);

ironman.Id = 2;
ironman.Nombre = "Iron Man";
ironman.IdentidadSecreta ="Tony Stark";
ironman.Ciudad ="kansas";
ironman.Puedevolar = true;

//List<Superpoder> poderesironman = new List<Superpoder>();
//poderesironman.Add(reactorark);
//poderesironman.Add(unirayo);
//ironman.Superpoderes = poderesironman;
//string resul = ironman.UsarSuperPoderes();
//Console.WriteLine(resul);
class Superheroe
{
    public int Id = 1;
    public string Nombre;
    public string IdentidadSecreta;
    public string Ciudad;
    public List<Superpoder> Superpoderes = new List<Superpoder>();
    public bool Puedevolar;

    public Superheroe()
    {
        Id = 1;
        Superpoderes = new List<Superpoder>();
        Puedevolar = false;
    }

    public string UsarSuperPoderes()
    {
        StringBuilder sb = new StringBuilder();
        foreach (var item in Superpoderes)
        {
            sb.AppendLine($"{Nombre} esta usando el superpoder {item.Nombre}!!");
        }
        return sb.ToString();
    }
}

class Superpoder
{
    public string Nombre;
    public string Descripcion;
    public NivelPoder Nivel;

    public Superpoder()
    {
        Nivel = NivelPoder.NivelUno;
    }
}

enum NivelPoder
{
    NivelUno,
    NivelDos,
    nivelTres
}

public record SuperheroeRecord(int Id, String Nombre, String IdentidadSecreta);
