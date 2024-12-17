using bytebank.Modelos.Conta;

namespace bytebank_ATENDIMENTO.bytebank.Util;

public class ListaDeContaCorrentes
{
    private ContaCorrente[] _itens = null;
    private int _proximaPosicao = 0;

    public ListaDeContaCorrentes(int tamanhoInicial = 5)
    {
        _itens = new ContaCorrente[tamanhoInicial];
    }

    public void Adicionar(ContaCorrente conta)
    {
        VerificarCapacidade(_proximaPosicao + 1);
        _itens[_proximaPosicao] = conta;
        Console.WriteLine($"Item adicionado na posicao {_proximaPosicao}");
        _proximaPosicao++;
    }

    private void VerificarCapacidade(int tamanhoNecessario)
    {
        if (_itens.Length >= tamanhoNecessario)
        {
            return;
        }
        Console.WriteLine("Aumentando tamanho da lista....");
        ContaCorrente[] novoArray = new ContaCorrente[tamanhoNecessario];
        Array.Copy(_itens, novoArray, _itens.Length);
        _itens = novoArray;
    }
}