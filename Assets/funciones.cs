using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class funciones : MonoBehaviour
{
    // Start is called before the first frame update
    public int valor1 = 0;
    public string cadenaTrxto = string.Empty;


    

    

    void Start()
    {
        print("KeyCode.A: ");
        print(KeyCode.A);
        //Debug.Log(funcionEntera());
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {

            print("Up");
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("Down");

        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            print("Left");

        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {

            print("Right");
        }

    }


    void funcion1()
    {
        valor1++;
        
       // Debug.Log("Funcion 1 ejecutada.");
    }

    int funcionEntera() {
        valor1++;

        return valor1;
    
    }


    void funcion2() => print("Up");
    void funcion3()
    {
        print("Hola");
    }
}
