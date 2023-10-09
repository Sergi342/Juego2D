using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sierra : MonoBehaviour
{
    //variables
    [SerializeField] float giroSierra = 0f;
    [SerializeField] float speed = 0f;

    Rigidbody2D sierra;

    bool Techo = false;
    bool Suelo = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //giro sierra
        transform.Rotate(Vector3.back * Time.deltaTime * giroSierra);
       
        //posicionamiento sierra
        transform.Translate(Vector2.up * Time.deltaTime * speed);
        transform.Translate(Vector2.down * Time.deltaTime * speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if (transform.position.y > 1.64)
        {
            Techo = true;
        }
        else if (transform.position.y < -1.17)
        {
            Techo = false;
        }
        else if (transform.position.y < -1.17)
        {
            Suelo = true;
        }
        else if (transform.position.y > 1.64)
        {
            Suelo = false;
        }
    }
}
