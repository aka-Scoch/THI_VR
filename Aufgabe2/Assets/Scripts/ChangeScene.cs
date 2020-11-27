using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ChangeScene : MonoBehaviour
{
    public GameObject canope;
    public object scene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(this.transform.rotation.y);
        if (this.transform.rotation.y < -0.6)
        {
            //System.Threading.Thread.Sleep(1000);
            SceneManager.LoadScene("cockpit");
        }
    }
}
