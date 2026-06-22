using UnityEngine;

public class MeuSprite2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector2(-6.0f, -3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        // Usando o Time.deltaTime, o objeto vai se mover 1 unidade por Segundo. Caso eu só colocasse o 1.0f, sem o Time.deltaTime, ia se mover 1 unidade por frame,
        // Daí dependendo do Frame Rate (fps) do computador da pessoa, ia ficar mais rapido ou mais devagar
        transform.Translate(1.0f * Time.deltaTime, 1.0f * Time.deltaTime, 0.0f);
    }
}
