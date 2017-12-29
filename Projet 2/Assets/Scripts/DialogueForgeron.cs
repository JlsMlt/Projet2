using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueForgeron : MonoBehaviour {

    private Text TxtForgeron;

    // Use this for initialization
    void Start () {
        TxtForgeron = GameObject.Find("TxtForgeron").GetComponent<Text>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "Forgeron")
        {
            TxtForgeron.text = "Forgeron:  Ton épée et ton bouclier sont prêts, prends les !";
            
        }
    }

    void OnTriggerExit(Collider Col)
    {
        if (Col.gameObject.tag == "Forgeron")
        {
            TxtForgeron.text = "";
            
        }
    }
}
