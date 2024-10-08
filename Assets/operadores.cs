using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class operadores : MonoBehaviour
{
    // Start is called before the first frame update
    bool booleano1 = false;
    bool booleano2 = true;

    int numero1 =0;

    char caracter1 = 'A';
    char caracter2 = 'B';

    int numeroGrande = 1000;
    int numeroPeque = 4;



    void Start()
    {
        if (booleano1)
        {

            print("booleano1 ");
        }
        if (numeroGrande != numeroPeque)
        {

            print("Condición verdadera: ");
        }
        else
        {
            print("Condición falsa: ");

        }

        //print(caracter1);
        //print(caracter1.ToString() + ',' + caracter2.ToString());

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            numero1++;


            print("La variable tiene el valor: " + numero1);




        }


        
    }
}
