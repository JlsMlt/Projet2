using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueDieu : MonoBehaviour
{

    private Text TxtForgeron;

    // Use this for initialization
    void Start()
    {
        TxtForgeron = GameObject.Find("TxtDieu").GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "Dieu")
        {
            TxtForgeron.text = "Dieu : 	... ";

        }
    }

    void OnTriggerExit(Collider Col)
    {
        if (Col.gameObject.tag == "Dieu")
        {
            TxtForgeron.text = "";

        }
    }
}
