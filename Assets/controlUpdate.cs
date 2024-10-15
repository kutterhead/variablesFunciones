using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlUpdate : MonoBehaviour
{
    // Start is called before the first frame update
    public bool convierteDolar = false;//divisa 0
    public bool convierteYen = false;//divisa 1
    public bool convierteBol = false;//divisa 2

    public int indiceDivisa = 0;

    public bool convierte = false;

    public float numero = 0;

    [SerializeField]
    private float resultado = 0;

    string casa = "";



    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {

        //if (convierte)
        //{
        //    if (convierteDolar == true)
        //    {
        //        resultado = convierteADolar(numero);
        //        print(numero + " € son " + resultado + " $");
                
        //    }
        //    else if (convierteYen == true)
        //    {
        //        resultado = convierteAyen(numero);
        //        print(numero + " € son " + resultado + " Y");
        //        convierteYen = false;
        //    }
        //    else if (convierteBol == true)
        //    {
        //        resultado = convierteBolivar(numero);
        //        print(numero + " € son " + resultado + " B");
                
        //    }

        //    convierte = false;
        //    convierteDolar = false;
        //    convierteYen = false;
        //    convierteBol = false;
        //}

        if (convierte)
        {
          
            switch (indiceDivisa)
            {
                    case 0:
                    resultado = convierteADolar(numero);
                    print(numero + " € son " + resultado + " $");
                    break;
                    
                    case 1:
                    resultado = convierteAyen(numero);
                    print(numero + " € son " + resultado + " Y");
                    break;

                    case 2:
                    resultado = convierteBolivar(numero);
                    print(numero + " € son " + resultado + " B");
                    break;

                    default:
                    print("No se ha seleccionado divisa");
                    break;


            }


            convierte = false;
        }
    }


    float convierteADolar(float numero1)//voy a usar un cambio de 0,85€
    {
        float conversion = numero1 * 0.85f;
        return conversion;

    }


    float convierteAyen(float numero1)//voy a usar un cambio de 162.71f
    {
        float conversion = numero1 * 162.71f;
        return conversion;

    }
    float convierteBolivar(float numero1)//voy a usar un cambio de 40,6€
    {
        float conversion = numero1 * 40.6f;
        return conversion;

    }
}
