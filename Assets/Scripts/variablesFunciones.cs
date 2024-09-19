using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.Collections;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class variablesFunciones : MonoBehaviour
{
    // Start is called before the first frame update

    /*
        bool: Almacena un valor lógico(true o false). Tiene un tamaño de 1 bit.

        byte: Almacena un número entero sin signo entre 0 y 255. Tiene un tamaño de 8 bits.

        sbyte: Almacena un número entero con signo entre -128 y 127. Tiene un tamaño de 8 bits.

        short: Almacena un número entero con signo entre -32,768 y 32,767. Tiene un tamaño de 16 bits.

        ushort: Almacena un número entero sin signo entre 0 y 65,535. Tiene un tamaño de 16 bits.

        int: Almacena un número entero con signo entre -2,147,483,648 y 2,147,483,647. Tiene un tamaño de 32 bits.

        uint: Almacena un número entero sin signo entre 0 y 4,294,967,295. Tiene un tamaño de 32 bits.

        long: Almacena un número entero con signo entre -9,223,372,036,854,775,808 y 9,223,372,036,854,775,807. Tiene un tamaño de 64 bits.

        ulong: Almacena un número entero sin signo entre 0 y 18,446,744,073,709,551,615. Tiene un tamaño de 64 bits.

        char: Almacena un carácter Unicode.Tiene un tamaño de 16 bits (2 bytes).

        float: Almacena un número real con precisión simple.Tiene un tamaño de 32 bits.

        double: Almacena un número real con precisión doble.Tiene un tamaño de 64 bits.

        decimal: Almacena un número decimal con precisión fija.Tiene un tamaño de 128 bits.
    */
    public int numeroPublico = 13;


    [SerializeField]
    private int numeroEntero = 0;
    float numeroDecimal = 0.0f;

    byte numeroCorto = 0;
    bool booleano = false;
    char caracter = 'r';
    string cadena = "palabras o frases";

    string cadena2 = "123 Adc";

    
    void Start()
    {

        numeroCorto = 200;
        numeroPublico = 25;//numero int (largo)



        //numeroCorto++;

        //numeroPublico = numeroCorto;
        numeroCorto = (byte)numeroPublico;

        Debug.Log("variable1: "  + numeroCorto  + " variable2: " + numeroPublico);

        //print("Esto es un print");


        //print(booleano);
    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            imprimeHola();
        }
        
    }
   

    void imprimeHola()
    {
        Debug.Log("Hola desde función");
    }
}
