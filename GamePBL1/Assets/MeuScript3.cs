using UnityEngine;
//Biblioteca para usar Corotinas
using System.Collections;

public class MeuScript3 : MonoBehaviour
{

    public int n = 0;

    private void Start()
    {
        StartCoroutine(Contar());
    }

    IEnumerator Contar()
    {
        //Aguarde e retorne - espere por 2 segundos
        yield return new WaitForSeconds(2.0f);
        //A cada 2 segundos vai acontecer o n++, se o n++ fosse colocado antes, a primeira soma seria instantânea
        n++;
        // Ele vai ficar executando sem parar, pois está chamando a si mesmo no final
        StartCoroutine(Contar());
    }

}
