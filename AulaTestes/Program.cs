
string mensagem = "";

try
{
    string produtoSelecionado;

    List<string> listaMercado = new List<string>()
    {
        "Tomate",
        "Cebola",
        "Coca-Cola",
        "Batata",
        "Vinho",
        "Pilha",
        "Suca de Uva",
        "Água",
        "Chocolate",
        "Mel"
    };

    Console.WriteLine("Digite o produto que gostaria de comprar: ");

    produtoSelecionado = Console.ReadLine()!;


    bool validaProduto = listaMercado.Where(l => l.Equals(produtoSelecionado)).Any();

    if (validaProduto)
    {
        Console.WriteLine("Pode comprar o produto " + produtoSelecionado + " pois ele está disponivel ");
    }
    else
    {
        Console.WriteLine(" O produto " + produtoSelecionado + " não está disponivel ");
    }

    Console.WriteLine("Os produtos disponiveis são: ");

    foreach (string produto in listaMercado.OrderBy(lista => lista))
    {
        Console.WriteLine(produto);
    }

    mensagem = "Obrigado por ter utilizado o sistema do mescado. E boas comprar!";

}
catch (Exception ex)
{

    mensagem = "Aconteceu o seguinte prolema: " + ex.Message;
}
finally
{
    Console.WriteLine(mensagem);
}