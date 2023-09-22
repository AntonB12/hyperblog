var podervolar = new superpoder();
podervolar.nombre ="volar";
podervolar.descripcion="volar y planear en el aire";
podervolar.nivel =nivelpoder.niveldos;

var superfuerza = new superpoder();
superfuerza.nombre ="super fuerza"
superfuerza.nivel = nivelpoder.niveltre;

var superman = new superheroe();
var ironman = new superheroe();

superman.Id =1;
superman.Nombre ="Superman";
superman.identidadsecreta ="clark kent";
superman.ciudad ="metropolis"
superman.puedevolar = true;

list<superpoder> poderesSuperman = new list<superpoder>();
poderesSuperman.Add(podervolar);
poderesSuperman.Add(superfuerza);
superman.superheroe = poderesSuperman;
superman.usarsuperpoderes();

ironman.Id =2;
ironman.Nombre ="iron man";
ironman.identidadsecreta ="tony stark";
ironman.ciudad ="kansas";
ironman.puedevolar = true;
ironman.superpoderes = new []{"armadura", "reactor arc", "propulsores", "rayos laser"}

class superheroe
{
    public int Id;
    public string Nombre;
    public string identidadsecreta;
    public string ciudad;
    public list<superpoder> superpoderes;
    public bool puedevolar;
}

public void usarsuperpoderes()
{
    foreach(var item in superpoderes)
    {
        console.writeline($"{nombre} esta usando el superpoder {item.nombre}!!")
    }
}

class superpoder
{
    public string nombre;
    public string descripcion;
    public int nivelpoder;
}

enum nivelpoder
{
    niveluno;
    niveldos;
    niveltre;
}