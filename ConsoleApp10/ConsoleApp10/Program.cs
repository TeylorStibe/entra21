using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {

            int[][] a;
            GeraBD b = new GeraBD();
            a = b.GeraMatriz();

            bool fim = false;
            int c = 0;
            int d = 0;
            int e = 0;
            int f = 0;

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write(a[i][j] + "| ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    if (a[i][j] == 1)
                    {
                        c++;
                    }
                    else if (a[i][j] == 2)
                    {
                        d++;
                    }
                    else if (a[i][j] == 3)
                    {
                        e++;
                    }
                    else if (a[i][j] == 4)
                    {
                        f++;
                    }
                }
            }

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    if (i < 10)
                    {
                        if (c > 0)
                        {
                            a[i][j] = 1;
                            c--;
                        }
                        else
                        {
                            a[i][j] = 0;
                        }
                    }

                    else if (i >= 10 && i < 20)
                    {
                        if (d > 0)
                        {
                            a[i][j] = 2;
                            d--;
                        }
                        else
                        {
                            a[i][j] = 0;
                        }

                    }
                    else if (i >= 20 && i < 30)
                    {
                        if (e > 0)
                        {
                            a[i][j] = 3;
                            e--;
                        }
                        else
                        {
                            a[i][j] = 0;
                        }
                    }

                    else if (i >= 30 && i < 40)
                    {
                        if (f > 0)
                        {
                            a[i][j] = 4;
                            f--;
                        }
                        else
                        {
                            a[i][j] = 0;
                        }
                    }
                }
            }

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0}  -> ", (i + 1));
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write(a[i][j] + "|");
                }
                Console.WriteLine();
                if (i == 9 || i == 19 || i == 29 || i == 39)
                {
                    Console.WriteLine("+-------------------------------------------------------------------------------------+");
                }
            }
            Console.WriteLine();

            while (fim != true)
            {
                Console.WriteLine("Menu: ");
                Console.WriteLine();
                Console.WriteLine("1 -> Adicionar um produto\n2 -> Retirar um produto\n3 -> Ver o estoque\n4 -> Fechar programa");

                int escolha = Convert.ToInt32(Console.In.ReadLine());

                switch (escolha)
                {
                    case 1:

                        bool g = false;
                        Console.WriteLine();
                        Console.WriteLine("Cada número representa uma categoria. Confira a baixo: ");
                        Console.WriteLine();
                        Console.WriteLine("1 -> Alimento\n2 -> higiene Pessoal\n3 -> Limpeza\n4 -> Utensílios\n");
                        Console.WriteLine("\nOBS: O produto será adicionado na primeira posição livre de cada categoria...\n0 representa Gaveta vazia");
                        Console.WriteLine("\nO que deseja adicionar?");
                        escolha = Convert.ToInt32(Console.ReadLine());

                        if (escolha == 1)
                        {
                            for (int i = 0; i < 10; i++)
                            {
                                for (int j = 0; j < a[i].Length; j++)
                                {
                                    if (a[i][j] == 0)
                                    {
                                        a[i][j] = 1;
                                        g = true;
                                        break;
                                    }
                                }
                                if (g == true)
                                {
                                    break;
                                }
                            }
                        }

                        else if (escolha == 2)
                        {
                            for (int i = 10; i < 20; i++)
                            {
                                for (int j = 0; j < a[i].Length; j++)
                                {
                                    if (a[i][j] == 0)
                                    {
                                        a[i][j] = 2;
                                        g = true;
                                        break;
                                    }
                                }
                                if (g == true)
                                {
                                    break;
                                }
                            }
                        }

                        else if (escolha == 3)
                        {
                            for (int i = 20; i < 30; i++)
                            {
                                for (int j = 0; j < a[i].Length; j++)
                                {
                                    if (a[i][j] == 0)
                                    {
                                        a[i][j] = 3;
                                        g = true;
                                        break;
                                    }
                                }
                                if (g == true)
                                {
                                    break;
                                }
                            }
                        }

                        else if (escolha == 4)
                        {
                            for (int i = 30; i < 40; i++)
                            {
                                for (int j = 0; j < a[i].Length; j++)
                                {
                                    if (a[i][j] == 0)
                                    {
                                        a[i][j] = 4;
                                        g = true;
                                        break;
                                    }
                                }
                                if (g == true)
                                {
                                    break;
                                }
                            }
                        }

                        break;

                    case 2:

                        Console.WriteLine();
                        Console.WriteLine("1º - Este é o seu estoque:");
                        Console.WriteLine();
                        for (int i = 0; i < a.Length; i++)
                        {
                            Console.Write("{0}  -> ", (i + 1));

                            for (int j = 0; j < a[i].Length; j++)
                            {
                                Console.Write(a[i][j] + "|");
                            }
                            Console.WriteLine();
                            if (i == 9 || i == 19 || i == 29 || i == 39)
                            {
                                Console.WriteLine("+-------------------------------------------------------------------------------------+");
                            }
                        }

                        Console.WriteLine("Insira o ídice que deseja retirar");
                        int x = Convert.ToInt32(Console.In.ReadLine());
                        int y = Convert.ToInt32(Console.In.ReadLine());
                        if (a[x - 1][y - 1] != 0)
                        {
                            a[x - 1][y - 1] = 0;
                            Console.WriteLine("Item retirado.");
                        }
                        else
                        {
                            Console.WriteLine("Esta gaveta esta vazia");
                        }

                        break;

                    case 3:
                        Console.WriteLine("Este é o seu estoque:");

                        for (int i = 0; i < a.Length; i++)
                        {
                            Console.Write("{0}  -> ", (i + 1));

                            for (int j = 0; j < a[i].Length; j++)
                            {
                                Console.Write(a[i][j] + "|");
                            }
                            Console.WriteLine();
                            if (i == 9 || i == 19 || i == 29 || i == 39)
                            {
                                Console.WriteLine("+-------------------------------------------------------------------------------------+");
                            }
                        }
                        break;

                    case 4:

                        fim = true;
                        Console.WriteLine();
                        Console.WriteLine("Obrigado por usar este programa!\nVolte sempre! :)");
                        
                        break;

                    default:

                        Console.WriteLine();
                        Console.WriteLine("Número inválido!\nOlhe o menu novamente...\n");

                        break;
                }
            }
        }
    }
}





