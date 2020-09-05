using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Congrats : MonoBehaviour {
    public GameObject UiObject;
    public GameObject flower2trigger;

	// Use this for initialization
	void Start () {
        UiObject.SetActive(false);
	}


// Used as my trigger
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            UiObject.SetActive(true);
        }

    }

    // Update is called once per frame
    void Update () {
		
	}

    void OnTriggerExit2D(Collider2D other)
    {
        UiObject.SetActive(false);
        /*if(UiObject.SetActive == false){
        Destroy(flower2trigger);
            } */
    }


} //end of class Congrats
