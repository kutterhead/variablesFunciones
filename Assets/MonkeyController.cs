using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkeyController : MonoBehaviour
{
    // Start is called before the first frame update

    public gameManager manager;//referencia al script manager
    Vector3 direction;
    float velocidad = 1;
    void Start()
    {
        direction = transform.right;
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(direction*Time.deltaTime * velocidad);
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            direction = transform.up;

        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            direction = -transform.up;

        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

            direction = -transform.right;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            direction = transform.right;

        }

    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    print("He colisionado con muro");
    //}

    

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Limit"))
        {

            print("He colisionado con escenario");
            print("game Over");
            velocidad = 0f;
        }
        else
        {
            print("He colisionado con plátano");

            manager.sumaBanana();
        }
       
    }
}
