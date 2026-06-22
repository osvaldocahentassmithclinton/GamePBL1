using UnityEngine;
using System.Collections;

public class MeuSprite1 : MonoBehaviour
{

    Coroutine coroutine;

    [SerializeField] Vector2 coordenada;

    private void Start()
    {
        //A variável "coordenada" tem o valor da posição inicial, poderia também ser o scale ou o rotation por exemplo
        coordenada = transform.position;

        //Trocar a posição a cada 3 segundos
        coroutine = StartCoroutine(TrocaPosicao());


    }

    void Update()
    {

        // - Vai printar o transform no console
        /*print(transform);
        // - Da de printar separadamente também
        /*print(transform.position);*/
        /*print(transform.rotation);*/
        /*print(transform.localScale);*/

        // - Se você chamar a corotina aqui, você vai chamar várias vezes, então ela vai ficar meio que teletransportando de um lado pro outro muito rapidamente
        /*StartCoroutine(TrocaPosicao());*/

    }

    //A cada 3 segundos vai multiplicar o x do transform.position por -1, invertendo a posição dele no eixo x
    IEnumerator TrocaPosicao()
    {
        yield return new WaitForSeconds(3.0f);
        transform.position = new Vector2(transform.position.x * -1, 0.0f);

    }


}
