using UnityEngine;

public class MeuSprite4 : MonoBehaviour
{
    public float velocidade = 5.0f;

    void Update()
    {
        float x = Input.GetAxis("Horizontal") * velocidade * Time.deltaTime;
        float y = Input.GetAxis("Vertical") * velocidade * Time.deltaTime;

        transform.Translate(x, y, 0.0f);

        if (Input.GetButtonDown("Fire1"))
        {
            print("Get Button Down");
        }
        else if (Input.GetButton("Fire1"))
        {
            print("Get Button");
            transform.Rotate(0.0f, 0.0f, velocidade * Time.deltaTime);
        }
        else if (Input.GetButtonUp("Fire1"))
        {
            print("Get Button Up");
        }

        if (Input.GetButtonDown("Fire2"))
        {
            transform.eulerAngles = Vector3.zero;
            transform.position = Vector3.zero;
        }

    }
}
