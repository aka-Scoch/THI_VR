using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkangle : MonoBehaviour
{
    public GameObject canope; 
    float y_ref = 0;
    float y_cur = 0;
    float diff;
    int i = 1;
    bool open = false;
    // Start is called before the first frame update
    void Start()
    {
        y_ref = this.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        y_cur = this.transform.position.y;
        diff = y_cur - y_ref;
        Debug.Log (diff);
        Debug.Log (canope.transform.rotation.y);

        if (diff > 0.05 && !open)
        {
            canope.transform.Rotate(0, -140, 0);
            open = true;
            
        }
    }
}
