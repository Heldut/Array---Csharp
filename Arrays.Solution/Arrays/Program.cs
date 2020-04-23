using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Exemplo_1();
            //Exemplo_2();
            //Exemplo_3();
            //Exemplo_4();
            //Exemplo_5();
            //Exemplo_6();
            //Exemplo_7();
            //Exemplo_8();
        }

        public static void Exemplo_1()
        {
            Console.WriteLine("###################################################################################");
            Console.WriteLine("##   Primeiro Exemplo - Criando, inicializando e Imprimindo com Foreach e For   ###");
            Console.WriteLine("###################################################################################");

            // Criando um array e inicialiando os elementos
            int[] pins = new int[3];
            pins[0] = 102;
            pins[1] = 25;
            pins[2] = 354;

            // Imprimindo os elementos com foreach
            Console.WriteLine("--- Imrimindo com foreach ---");
            foreach (int item in pins)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");
            
            Console.WriteLine("--- Imrimindo com for ---");
            // Imprimindo os elementos com for
            for (int i = 0; i < pins.Length; i++)
            {
                Console.WriteLine(pins[i]);
            }
            Console.WriteLine("\n");
        }

        public static void Exemplo_2()
        {
            Console.WriteLine("###################################################################################");
            Console.WriteLine("##   Segundo Exemplo - Inicializando o array com valores calculados             ###");
            Console.WriteLine("###################################################################################");

            // Criando um array e inicialiando os elementos com valores calculados
            Random r = new Random();
            int[] pins = new int[3] { r.Next() % 10, r.Next() % 10, r.Next() % 10 };

            // Imprimindo os elementos com foreach
            Console.WriteLine("--- Imrimindo com foreach ---");
            foreach (int item in pins)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");

            Console.WriteLine("--- Imrimindo com for ---");
            // Imprimindo os elementos com for
            for (int i = 0; i < pins.Length; i++)
            {
                Console.WriteLine(pins[i]);
            }
            Console.WriteLine("\n");
        }

        public static void Exemplo_3()
        {
            Console.WriteLine("###################################################################################");
            Console.WriteLine("##   Terceiro Exemplo - Array Tipado                                            ###");
            Console.WriteLine("###################################################################################");

            // Criando um array e inicialiando os elementos com valores calculados

            var names = new[] { new { Nome = "Helio", Idade = 35 },
                                new { Nome = "Cida", Idade = 32 },
                                new { Nome = "Heloísa", Idade = 14 },
                                new { Nome = "Gabriela", Idade = 18 } };

            // Imprimi toda a string
            Console.WriteLine("--- Imrimindo com foreach ---");
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");

            // Imprimi só os elementos
            foreach (var item in names)
            {
                Console.WriteLine(item.Nome + " - " + item.Idade);
            }
            Console.WriteLine("\n");

            // Imprimi toda a string
            Console.WriteLine("--- Imrimindo com for ---");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine("\n");

            // Imprimi só os elementos
            Console.WriteLine("--- Imrimindo com for ---");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Nome: {0}, Idade: {1}", names[i].Nome, names[i].Idade);
            }
            Console.WriteLine("\n");
        }

        public static void Exemplo_4()
        {
            Console.WriteLine("###################################################################################");
            Console.WriteLine("##   Quarto Exemplo - Copiando um array                                         ###");
            Console.WriteLine("###################################################################################");

            // Criando um array e inicialiando os elementos
            int[] pins = new int[3];
            pins[0] = 102;
            pins[1] = 25;
            pins[2] = 354;

            // Criando um novo array e adicionando os valores do anterior no novo
            int[] novoPins = new int[3];
            novoPins = pins;

            // Alterando um elemento do novoPins
            novoPins[0] = 1250;


            // Veja, ao imprimir que o pins está com os mesmos valores do novoPins. Issso acontece porque o array
            // é um tipo-referência.

            Console.WriteLine("--- Imrimindo pins ---");
            // Imprimindo os elementos com for
            for (int i = 0; i < pins.Length; i++)
            {
                Console.WriteLine(pins[i]);
            }
            Console.WriteLine("\n");

            Console.WriteLine("--- Imrimindo novoPins ---");
            // Imprimindo os elementos com for
            for (int i = 0; i < novoPins.Length; i++)
            {
                Console.WriteLine(novoPins[i]);
            }
            Console.WriteLine("\n");

        }

        public static void Exemplo_5()
        {
            Console.WriteLine("###################################################################################");
            Console.WriteLine("##   Quinto Exemplo - Copiando os elementos do array - FOR                      ###");
            Console.WriteLine("###################################################################################");

            // Criando um array e inicialiando os elementos
            int[] pins = new int[3];
            pins[0] = 102;
            pins[1] = 25;
            pins[2] = 354;

            // Criando um novo array com a mesma quantidade de elementos do anterior
            int[] novoPins = new int[pins.Length];

            // Agora copio os elementos utiliando um for
            for (int i = 0; i < pins.Length; i++)
            {
                novoPins[i] = pins[i];
            }

            // Alterando um elemento do novoPins
            novoPins[0] = 1250;

            // Aora sim, ao alterar o valor do novoPins não alteraremos o pins
            
            Console.WriteLine("--- Imrimindo pins ---");
            // Imprimindo os elementos com for
            for (int i = 0; i < pins.Length; i++)
            {
                Console.WriteLine(pins[i]);
            }
            Console.WriteLine("\n");

            Console.WriteLine("--- Imrimindo novoPins ---");
            // Imprimindo os elementos com for
            for (int i = 0; i < novoPins.Length; i++)
            {
                Console.WriteLine(novoPins[i]);
            }
            Console.WriteLine("\n");

        }

        public static void Exemplo_6()
        {
            Console.WriteLine("###################################################################################");
            Console.WriteLine("##   Sexto Exemplo - Copiando os elementos do array  - COPYTO                   ###");
            Console.WriteLine("###################################################################################");

            // Criando um array e inicialiando os elementos
            int[] pins = new int[3];
            pins[0] = 102;
            pins[1] = 25;
            pins[2] = 354;

            // Criando um novo array com a mesma quantidade de elementos do anterior
            int[] novoPins = new int[pins.Length];

            pins.CopyTo(novoPins, 0);


            // Alterando um elemento do novoPins
            novoPins[0] = 1250;

            // Aora sim, ao alterar o valor do novoPins não alteraremos o pins

            Console.WriteLine("--- Imrimindo pins ---");
            // Imprimindo os elementos com for
            for (int i = 0; i < pins.Length; i++)
            {
                Console.WriteLine(pins[i]);
            }
            Console.WriteLine("\n");

            Console.WriteLine("--- Imrimindo novoPins ---");
            // Imprimindo os elementos com for
            for (int i = 0; i < novoPins.Length; i++)
            {
                Console.WriteLine(novoPins[i]);
            }
            Console.WriteLine("\n");

        }

        public static void Exemplo_7()
        {
            Console.WriteLine("###################################################################################");
            Console.WriteLine("##   Sétimo Exemplo - Copiando os elementos do array  - COPY                    ###");
            Console.WriteLine("###################################################################################");

            // Criando um array e inicialiando os elementos
            int[] pins = new int[3];
            pins[0] = 102;
            pins[1] = 25;
            pins[2] = 354;

            // Criando um novo array com a mesma quantidade de elementos do anterior
            int[] novoPins = new int[pins.Length];

            Array.Copy(pins, novoPins, novoPins.Length);

            // Alterando um elemento do novoPins
            novoPins[0] = 1250;

            // Aora sim, ao alterar o valor do novoPins não alteraremos o pins

            Console.WriteLine("--- Imrimindo pins ---");
            // Imprimindo os elementos com for
            for (int i = 0; i < pins.Length; i++)
            {
                Console.WriteLine(pins[i]);
            }
            Console.WriteLine("\n");

            Console.WriteLine("--- Imrimindo novoPins ---");
            // Imprimindo os elementos com for
            for (int i = 0; i < novoPins.Length; i++)
            {
                Console.WriteLine(novoPins[i]);
            }
            Console.WriteLine("\n");

        }

        public static void Exemplo_8()
        {
            Console.WriteLine("###################################################################################");
            Console.WriteLine("##   Oitavo Exemplo - Copiando os elementos do array - CLONE                    ###");
            Console.WriteLine("###################################################################################");

            // Criando um array e inicialiando os elementos
            int[] pins = new int[3];
            pins[0] = 102;
            pins[1] = 25;
            pins[2] = 354;

            // Criando um novo array e copiando com o Clone
            int[] novoPins = (int[])pins.Clone();


            // Alterando um elemento do novoPins
            novoPins[0] = 1250;

            // Aora sim, ao alterar o valor do novoPins não alteraremos o pins

            Console.WriteLine("--- Imrimindo pins ---");
            // Imprimindo os elementos com for
            for (int i = 0; i < pins.Length; i++)
            {
                Console.WriteLine(pins[i]);
            }
            Console.WriteLine("\n");

            Console.WriteLine("--- Imrimindo novoPins ---");
            // Imprimindo os elementos com for
            for (int i = 0; i < novoPins.Length; i++)
            {
                Console.WriteLine(novoPins[i]);
            }
            Console.WriteLine("\n");

        }
    }
}
