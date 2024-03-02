namespace stack
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new();
            int menu = 0;

            while (menu != 1)
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1 - Sair do Projeto");
                Console.WriteLine("2 - Verificar se a pilha está vazia");
                Console.WriteLine("3 - Empilhar");
                Console.WriteLine("4 - Desempilhar");
                Console.WriteLine("5 - Tamanho da pilha");
                Console.WriteLine("6 - Mostrar Topo");
                Console.WriteLine("7 - Limpar a pilha");
                Console.WriteLine("-------------------");

                menu = Convert.ToInt32(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Saindo do Projeto. Pressione Enter para encerrar.");
                        break;
                    case 2:
                        StackIsEmpty();
                        break;
                    case 3:
                        StackUp();
                        break;
                    case 4:
                        StackDown();
                        break;
                    case 5:
                        sizeStack();
                        break;
                    case 6:
                        showTopStack();
                        break;
                    case 7:
                        clearStack();
                        break;
                }
            }

            void StackIsEmpty()
            {
                if (stack.Count == 0)
                {
                    Console.WriteLine("Pilha vazia.");
                }
                else
                {
                    Console.WriteLine("Pilha não vazia.");
                }
            }

            void StackUp()
            {
                Console.WriteLine("Digite o seu dado que você deseja empilhar");

                int dado = Convert.ToInt32(Console.ReadLine());
                stack.Push(dado);
            }

            void StackDown()
            {
                if (stack.Count > 0)
                {
                    int temp = stack.Pop();
                    Console.WriteLine(temp);
                }
                else
                {
                    Console.WriteLine("A pilha está vazia.");
                }
            }

            void sizeStack()
            {
                int temp = stack.Count;
                Console.WriteLine(temp);
            }

            void showTopStack()
            {
                if (stack.Count != 0)
                {
                    Console.WriteLine(stack.Peek());
                }
            }

            void clearStack()
            {
                stack.Clear();
                Console.WriteLine("A pilha foi limpa.");
            }
        }
    }
}