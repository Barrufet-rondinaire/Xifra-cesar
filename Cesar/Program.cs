namespace Cesar;

class Program
{
    static void Main(string[] args)
    {
        var abecedari = "ABCÇDEFGHIJKLMNOPQRSTUVWXYZ";
        try
        {
            using var writer = new StreamWriter("resultat.txt");
            using var reader = new StreamReader("fitxe.txt");
            while (!reader.EndOfStream)
            {
                // var linia = reader.ReadLine();
                //foreach (var lletra in linia)
                // {

                // }
                var lletra = (char)reader.Read();
                var lletraMajuscula = Char.ToUpper(lletra);
                var posicio = abecedari.IndexOf(lletraMajuscula);
                char novaLletra = ' ';
                if (posicio == -1)
                {
                    novaLletra = lletra;
                }
                else
                {
                    posicio = (posicio + 4) % abecedari.Length;
                    novaLletra = abecedari[posicio];
                }

                writer.Write(novaLletra);
            }

            ;
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("El archivo no existe");
        }
        catch(Exception e)
    }
}