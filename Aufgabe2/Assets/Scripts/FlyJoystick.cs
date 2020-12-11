using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyJoystick : MonoBehaviour
{
    public float speed = 75;
    public float speedAmplifier = 10;
    public float rotationSpeed = 20;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputPitch = Input.GetAxis("Pitch");
        float inputYawn = Input.GetAxis("Yawn");
        float inputRoll = Input.GetAxis("Roll");
        speed = Input.GetAxis("Throttle") * speedAmplifier;

        Vector3 angle = new Vector3(inputPitch, inputYawn, inputRoll);

        this.transform.Rotate(angle* rotationSpeed * Time.deltaTime);


        this.transform.Translate(Vector3.forward * Time.deltaTime * speed);

    }
}
