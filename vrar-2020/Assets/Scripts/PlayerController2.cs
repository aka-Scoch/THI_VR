using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour {

    private Rigidbody rb = new Rigidbody();
    public float speed;
    public bool keyboard;
    public static int score = -1;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {   if (keyboard == true)
        {
            float moveHoriontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(moveHoriontal, 0f, moveVertical);

            movement = movement * speed;

            rb.AddForce(movement);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            score++;
        }
    }

}
