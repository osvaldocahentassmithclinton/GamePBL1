using UnityEngine;

public class MeuScript1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    
    
    void Start()
    {
        showMessage();
        /*Perceba como não retorna nada*/
        goodMorning();
        /*Isso acontece, pois a função goodMorning() passou a valer pelo valor "Bom dia!", que foi o que retornou, então eu posso usar em funções como o print:*/
        print("Resultado da função:");
        print(goodMorning());
        /*Também pode ser usado para operações de lógica e cálculo e podem ser atribuídos valores obrigatórios para sua execução*/
        int soma = somar(10, 5);
        print(soma);
        print(somar(10, 5));
    }

    void showMessage()
    {
        print("Olá Mundo");
    }

    string goodMorning()
    {
        
        return "Bom dia!";
        
    }

    int somar(int valor1, int valor2)
    {

        return valor1 + valor2;

    }

}
