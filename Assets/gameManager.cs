using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public int bananas = 0;
    public Transform objetoBanana;//elemento a recolectar

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
        print("Banana añadida");

    }


}
