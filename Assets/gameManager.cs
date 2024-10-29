using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    

    public int bananas = 0;
    public Transform objetoBanana;//elemento a recolectar

    public Transform limiteIzquierda;
    public Transform limiteDerecha;
    public Transform limiteArriba;
    public Transform limiteAbajo;

    
    // Start is called before the first frame update
    void Start()
    {
        bananas = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void sumaBanana()
    {
        bananas++;
        print("Banana añadida " + bananas);
        StartCoroutine(saltaBanana());
    }

    IEnumerator saltaBanana()
    {
        objetoBanana.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.2f);
        float newX = Random.Range(limiteIzquierda.position.x, limiteDerecha.position.x);
        float newY = Random.Range(limiteAbajo.position.y, limiteArriba.position.y);
        Vector3 lugarNuevoBana = new Vector3(newX, newY, objetoBanana.position.z);
        objetoBanana.position = lugarNuevoBana;
        objetoBanana.gameObject.SetActive(true);
    }
}
