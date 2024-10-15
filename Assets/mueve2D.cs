using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mueve2D : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Vector3 direccion = new Vector3(1,1,0);
        transform.Translate(direccion * 12);
    }

    // Update is called once per frame
    void Update()
    {
       // transform.Translate(transform.right);
    }
}
