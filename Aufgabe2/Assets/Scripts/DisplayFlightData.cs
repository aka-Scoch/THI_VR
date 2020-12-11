using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayFlightData : MonoBehaviour
{
    public Text textSpeed;
    public Text textHeight;
    public GameObject player;
    public float warningHeight = 40;
    public MaskableGraphic warnImage;
    private FlyJoystick flyJoystick;
    int height;

    public float interval = 1f;
    public float startDelay = 0.5f;
    bool isBlinking = false;

    public AudioSource source;
    public AudioSource gunSound;

    // Start is called before the first frame update
    void Start()
    {
        flyJoystick = player.GetComponent<FlyJoystick>();
        warnImage.enabled = false;
        textHeight.color = Color.green;
        textSpeed.color = Color.green;
        warnImage.enabled = false;
            
    }

    
    public void StartBlink()
    {
        // do not invoke the blink twice - needed if you need to start the blink from an external object
        if (isBlinking)
            return;

        if (warnImage != null)
        {
            if (height < warningHeight)
            {
                isBlinking = true;
                InvokeRepeating("ToggleState", startDelay, interval);

            } else
            {
                warnImage.enabled = false;
            }
        }
    }

    public void ToggleState()
    {
        if (height < warningHeight)
        {
                       
            warnImage.enabled = !warnImage.enabled;
            source.Play();
        }
        else
        {
            warnImage.enabled = false;
        }
        
    }

    



    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            gunSound.Play();
        }

        height =(int) player.transform.position.y;
        textHeight.text = "Alt: " + height + " m";

        int speed = (int) flyJoystick.speed;

        textSpeed.text = "Speed: " + speed + "km/h";

        if (height < warningHeight)
        {
            textHeight.color = Color.red;
            //AudioSource.PlayClipAtPoint(clip, player.transform.position);
            StartBlink();
        } 
        else
        {
            textHeight.color = Color.green;
                
        }
    }
}
