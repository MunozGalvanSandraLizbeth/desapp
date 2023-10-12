List<Estudiante> estudiantes = new List<Estudiante>();
estudiantes.Add(new Estudiante("1234","Juan Perez","Principal 123","Zacatecas",'H',21,true,new List<float>{97,92,81,60}));
estudiantes.Add(new Estudiante("5469","Maria Apale","Parque 56","Fresnillo",'M',18,true,new List<float>{100,70,83,77}));
estudiantes.Add(new Estudiante("9944","Pedro Castro","Briones 90","Sombrerete",'H',20,false,new List<float>{93,90,95,90}));
estudiantes.Add(new Estudiante("1029","Xochitl Escobedo","Dolores 1","Jerez",'M',24,true,new List<float>{78,84,80,85}));
estudiantes.Add(new Estudiante("6574","William Garcia","Flores 99","Zacatecas",'H',19,false,new List<float>{99,100,95,97}));
estudiantes.Add(new Estudiante("4839","Sucrette Ibarra","Hijos 33","Sombrerete",'M',22,false,new List<float>{69,89,70,70}));
estudiantes.Add(new Estudiante("2436","Erick Kuri","Juárez 22","Fresnillo",'H',21,true,new List<float>{100,100,95,98}));
estudiantes.Add(new Estudiante("8763","Sandra Muñoz","Lirios 11","Sombrerete",'M',21,true,new List<float>{87,95,95,100}));

Console.WriteLine("\nTodos los estudiantes en el Grupo:");
estudiantes.ForEach(e=>Console.WriteLine(e));

string mun = "Zacatecas";
var estmun = (from e in estudiantes where e.Municipio == mun select e).ToList();
Console.WriteLine($"Estudiantes que son de {mun} - {estmun.Count()}");
estmun.ForEach(e=>Console.WriteLine(e));

float prom = 80f;
var estprom = (from e in estudiantes where e.Califs.Average() >= prom orderby e.Nombre select e).ToList();
Console.WriteLine($"\nEstudiantes con promedio >= {prom} - {estprom.Count()}");
estprom.ForEach(e=>Console.WriteLine(e));

var estprom1 = (from e in estudiantes select $"Nombre = {e.Nombre,-18} - Prom = {e.Califs.Average(),5:n2} Becado = {e.Becado}").ToList();
Console.WriteLine($"\nLista de alumnos y promedios:");
estprom1.ForEach(e=>Console.WriteLine(e));

Console.WriteLine("\n\nSubtotales:");
//var pedades = (from e in estudiantes select e.Edad).Average();
var pedades = estudiantes.Average(e=>e.Edad);
Console.WriteLine($"Promedio de edades = {pedades:n2}");
//var pcalifs = (from e in estudiantes select e.Califs.Average()).Average();
var pcalifs = estudiantes.Average(e=>e.Califs.Average());
Console.WriteLine($"Promedio de promedios = {pcalifs:n2}");
//var totm = (from e in estudiantes where e.Sexo=='M' select e).Count();
//var totm = (from e in estudiantes where e.Sexo=='M' select e).Count();
var totm = estudiantes.Count(e=>e.Sexo=='M');
Console.WriteLine($"Total de Mujeres = {totm}");
//var toth = (from e in estudiantes where e.Sexo=='H' select e).Count();
var toth = estudiantes.Count(e=>e.Sexo=='H');
Console.WriteLine($"Total de Hombres = {toth}");

//var totb = (from e in estudiantes where e.Becado select e).Count();
var totb = estudiantes.Count(e=>e.Becado);
Console.WriteLine($"Total de Becados = {totb}");
//var totnb = (from e in estudiantes where !e.Becado select e).Count();
var totnb = estudiantes.Count(e=>!e.Becado);
Console.WriteLine($"Total de No Beados = {totnb}");

//var totmb = (from e in estudiantes where e.Becado && e.Sexo=='M' select e).Count();
var totmb = estudiantes.Count(e=>e.Becado && e.Sexo=='M');
Console.WriteLine($"Total de Mujeres Becadas = {totmb}");

//var gpoest = from e in estudiantes group e by e.Municipio;
var gpoest = estudiantes.GroupBy(e=>e.Municipio);
Console.WriteLine("\nEstudiantes agrupados por municipio: ");
foreach (var gpo in gpoest)
{
    Console.WriteLine($"\n {gpo.Key} : {gpo.Count()}");
    foreach (var est in gpo)
    {
        Console.WriteLine(est);
    }
}
