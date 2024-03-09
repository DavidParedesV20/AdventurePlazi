using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

            public float speed = 4.0f;

private const string horizontal = "Horizontal";
private const string vertical = "Vertical";

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        // s = v*t;

        if(Mathf.Abs(Input.GetAxisRaw(horizontal)) > 0.5f)
        {
            this.transform.Translate(
                new Vector3(Input.GetAxisRaw(horizontal) * speed * Time.deltaTime,0,0));            
        }

        if (Mathf.Abs(Input.GetAxisRaw(vertical)) > 0.5f)
        {
            this.transform.Translate(
                new Vector3(0, Input.GetAxisRaw(vertical) * speed * Time.deltaTime, 0)); //Hasta aquí el personaje se mueve de izquierda a derecha arriba y abajo Clase https://platzi.com/clases/1478-rpg-unity/17591-el-jugador-y-el-movimiento/ //
        }
    }
}