using UnityEngine;

public class MeuScript2 : MonoBehaviour
{
    public string nomeJogador = "Jericho";

    private void Start()
    {
        showMessage(nomeJogador);
    }

    private void Update()
    {
        if (Input.anyKeyDown)
        {
            showMessage(nomeJogador);
        }
    }

    void showMessage(string nome)
    {
        print("Se divirta..." + nome);
    }

}
