using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Demo : MonoBehaviour
{
    public bool hasClicked;
    public AudioSource welcome;
    public AudioSource appleDemo;
    public GameObject arrow;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Playing welcome");
        welcome.Play();
    }

    // Update is called once per frame
    void Update()
    {
        OVRInput.Update();
        if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
        {
            //Play demo audio
            Debug.Log("Playing appleDemo from vr");
            appleDemo.Play();
            hasClicked = true;
            arrow.SetActive(true);
        }
    }

    void OnMouseDown()
    {
        //Play demo audio
        Debug.Log("Playing appleDemo");
        appleDemo.Play(0);
        hasClicked = true;
    }
}
