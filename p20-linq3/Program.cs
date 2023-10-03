List<string> frutas = new() {"pera", "melon", "sandia", "durazno", "platano", "kiwi", "naranja", "jicama", "piña", "papaya",
"limas", "moras", "lichis", "guamuchiles", "chilitos", "pitayas", "maracuya", "xoconostle"};

Console.Clear();
var mfrutas = (from f in frutas where f.StartsWith('m') select f).ToList();
Console.WriteLine("\nFrutas que inician con la letra m " + mfrutas.Count());
mfrutas.ForEach(f => Console.WriteLine(f + " "));

var anfrutas = (from f in frutas where f.Contains("an") select f).ToList();
Console.WriteLine("\nFrutas que contienen con la letra an " + anfrutas.Count());
anfrutas.ForEach(f => Console.WriteLine(f + " "));

var frutasa = (from f in frutas where f.EndsWith("a") select f).ToList();
Console.WriteLine("\nFrutas que terminan con la letra a " + frutasa.Count());
frutasa.ForEach(f => Console.WriteLine(f + " "));

var xz = (from f in frutas where (f.Contains("x") || f.Contains("z")) select f).ToList();
Console.WriteLine("\nFrutas que contienen las letras x y z: " + xz.Count());
xz.ForEach(f=>Console.Write(f + " "));