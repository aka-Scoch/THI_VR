using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    private Text txt;
    // Start is called before the first frame update
    void Start()
    {
        txt = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerController2.score == 10)
        {
            txt.text = "You're da man! \n Score: " + PlayerController2.score;
        } else
        {
            txt.text = "Score: " + PlayerController2.score;
        }
    }
}
