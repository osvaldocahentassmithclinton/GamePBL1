using UnityEngine;

public class MeuSprite3 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // O eulerAngles, substitui a rotação atual, então a rotação do Z foi exatamente para 45. Enquanto isso, o transform.rotate somaria 45 com o valor que já tem do eixo Z
        // Então se tivesse 100 a rotação do Z, iria para 145 com o transform.rotate
        transform.eulerAngles = new Vector3(0.0f, 0.0f, 45.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
