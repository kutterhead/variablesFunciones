using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrays2 : MonoBehaviour
{
    // Start is called before the first frame update

    public int numero = 0;
    public int[] numeros;


    public int filas = 3;
    public int columnas = 3;
    public int valor = 0;

    [SerializeField]
    public int[,] matriz = new int[3,3];//la primera posición son filas la segunda columnas

    void Start()
    {
        matriz = new int[filas, columnas];
        //valor = 0;


        for (int j = 0; j < filas; j++)
        {


            for (int i = 0; i < columnas; i++)
            {
                
                
                matriz[i, j] = valor;



                valor++;
                Debug.Log(matriz[i, j]);

            }
        }



        //for (int i = 0; i < numeros.Length; i++)
        //{
        //    numeros[i] = i;
        //    Debug.Log(numeros[i]);

        //}

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
