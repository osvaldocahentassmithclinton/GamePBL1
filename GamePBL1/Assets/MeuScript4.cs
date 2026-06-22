using UnityEngine;
using System.Collections;

public class MeuScript4 : MonoBehaviour
{

    int paresGerados = 0;

    Coroutine coroutine;

    void Start()
    {
        coroutine = StartCoroutine(GerarNumeros());        
    }

    IEnumerator GerarNumeros()
    {
        while(paresGerados<3)
        {
            int numero = Random.Range(0, 100);
            
            Debug.Log("Número gerado: " + numero);

            if (numero%2 == 0)
            {
                paresGerados++;
                Debug.Log("Quantidade de pares gerados: " + paresGerados);
            }

            yield return new WaitForSeconds(3.0f);

        }

        Debug.Log("3 pares foram gerados. Corrotina encerrada.");
        StopCoroutine(coroutine);

    }    

 
}
