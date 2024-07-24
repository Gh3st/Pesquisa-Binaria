int[] array = { 1, 5, 17, 23, 26, 51};
int resultado = 0;
int item = 0;
Console.Write("Digite o item: ");
item = int.Parse(Console.ReadLine());
resultado = Pesquisa_binaria(array, item);
if (resultado >= 0)
{
    Console.WriteLine("A posição do item {0} é {1}",item,resultado);
}
else Console.WriteLine("Item não encontrado");
static int Pesquisa_binaria(int[] lista, int item)
{
    int baixo = 0;
    int alto = lista.Length-1;
    int meio = 0;
    int chute = 0;
    while(baixo <= alto)
    {
        meio = (alto + baixo) / 2;
        chute = lista[meio];
        if (chute == item)
            return meio;
        else if (chute > item)
            alto = meio - 1;
        else
            baixo = meio + 1;
    }
    return -1;
}