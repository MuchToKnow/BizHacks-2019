using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ArrowScript : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        OVRInput.Update();
        if(OVRInput.Get(OVRInput.Button.Back))
        {
            SceneManager.LoadScene("BizHacks");
        }
    }

    void OnMouseDown()
    {
        SceneManager.LoadScene("BizHacks");
    }
}
