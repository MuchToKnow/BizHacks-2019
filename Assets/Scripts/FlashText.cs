using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FlashText : MonoBehaviour
{
    TextMesh textObject;

    void Start()
    {
        textObject = this.GetComponent<TextMesh>();

        StartCoroutine(BlinkText());
    }

    public IEnumerator BlinkText(){
        while(true){
            textObject.color = Color.blue;
            yield return new WaitForSeconds(1f);
            textObject.color = Color.white;
            yield return new WaitForSeconds(1f);
        }
    }
}
