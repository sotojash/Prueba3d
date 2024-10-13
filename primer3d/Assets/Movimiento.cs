using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float velocidad = 5f;
    Rigidbody cuerpoRigido;

    // Start is called before the first frame update
    void Start()
    {
        cuerpoRigido = GetComponent<Rigidbody>();

    }


    // Update is called once per frame
    void Update()
    {
        float moverVertical = Input.GetAxis("Vertical");
        float moverHorizontal = Input.GetAxis("Horizontal");

        Vector3 movimiento = new Vector3(moverHorizontal, 0f, moverVertical);
        cuerpoRigido.AddForce(movimiento * velocidad);
    }
}
