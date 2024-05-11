
namespace fundaments 
{
    public class Chapterfour
    {
        public void capituloQuatro()
        {
                        
            Console.WriteLine("Criando um array definido");

            int[] myInts = new int[3];

            myInts[0] = 100;
            myInts[1] = 200;
            myInts[2] = 300;
            Console.WriteLine("3 elementos com posições 0, 1 e 2");

            Console.WriteLine("Percorrer os elementos:");

            foreach(int percorrerElementos in myInts) {
                Console.WriteLine(percorrerElementos);
            }

            Console.WriteLine("Array sem tamanho definido");

            string[] stringArray = new string[]
                {"1", "2", "3"};


            Console.WriteLine($"Há {stringArray.Length} elementos");
            
            Console.WriteLine();
            Console.WriteLine("Repetição usando array como argumento");
            for(int i = 0; i < stringArray.Length; i++) {
                Console.WriteLine($"Na posição {i}, o elemento é {myInts[i]}");
            }

            Console.WriteLine("Usando funcionalidades da classe Array");
            
            Console.WriteLine();

            string[] strings = {"Tones on Tail", "Bauhaus"};

            Console.WriteLine($"Limpando a strings {strings[0]} e {strings[1]} com o método Array.Clear(busca limpar o array completo, ou seus indexes)");
            
            Array.Clear(strings);

            Console.WriteLine();

            Console.WriteLine($"Array string vazio: {strings[0]} {strings[1]}");

            //PAGE 132
        }

        
    }
}