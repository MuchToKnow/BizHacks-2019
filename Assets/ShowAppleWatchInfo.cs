using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShowAppleWatchInfo : MonoBehaviour
{
    public  SpriteRenderer appleWatchSprite;
    public MeshRenderer appleWatchDescription;
    public TextMesh thisText;
    public Text cartText;
    public bool hasClicked;

    void Setup()
    {
        appleWatchSprite.enabled = false;
        Debug.Log("SPRITE IS NOW:" + appleWatchSprite.enabled);
    }

    void Update()
    {
        OVRInput.Update();
        if (OVRInput.Get(OVRInput.Button.Any))
        {
            if (!hasClicked)
            {
                Debug.Log("CLICKED VR!");
                appleWatchSprite.enabled = true;
                appleWatchDescription.enabled = true;
                thisText.text = "Add to Cart";
                hasClicked = true;
            }
            else
            {
                cartText.enabled = true;
                thisText.text = "Added!";
            }
        }
    }

    void OnMouseDown()
    {
        if (!hasClicked)
        {
            Debug.Log("CLIKED MOUSE!");
            appleWatchSprite.enabled = true;
            appleWatchDescription.enabled = true;
            thisText.text = "Add to Cart";
            hasClicked = true;
        }
        else {
            cartText.enabled = true;
            thisText.text = "Added!";
        }
    }
}
