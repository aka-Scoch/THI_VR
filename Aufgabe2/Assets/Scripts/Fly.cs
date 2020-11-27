using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    public float speed = 75;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        } 
        else if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(Vector3.back * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.E))
        {
            this.transform.Translate(Vector3.up * speed * Time.deltaTime);
        } 
        else if(Input.GetKey(KeyCode.Q))
        {
            this.transform.Translate(Vector3.down * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(Vector3.down * speed * Time.deltaTime);
        } 
        else if (Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(Vector3.up  * speed * Time.deltaTime);
        }
    }
}
