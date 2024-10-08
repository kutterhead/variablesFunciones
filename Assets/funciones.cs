using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class funciones : MonoBehaviour
{
    // Start is called before the first frame update
    public int valor1 = 0;
    public string cadenaTrxto = string.Empty;

    float variableFloat1 = 0.0f;
   



    void Start()
    {
        float variableFloat2 = 0.0f;
       


        variableFloat1 = calculaMedia(12f, 13f,out variableFloat2);
        print("valor1: " + variableFloat1);

        print("valor2: " + variableFloat2);

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

    float calculaMedia(float numero1, float numero2, out float valor)
    {
        float resultado = numero1 / numero2;
        valor = resultado * 100;
        return resultado;
    }


    void funcion2() => print("Up");
    void funcion3()
    {
        print("Hola");
    }
}
