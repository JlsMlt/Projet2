using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueDruideBDM : MonoBehaviour
{

    private Text TxtForgeron;

    // Use this for initialization
    void Start()
    {
        TxtForgeron = GameObject.Find("TxtDruideBoutDuMonde").GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "DruideBoutDuMonde")
        {
            TxtForgeron.text = "Gardien du Bout du Monde : 	Tu es arrivé au bout du monde. Tu pensais vraiment que la Terre était ronde ? C'est seulement une théorie du complot ! Il parait que si tu sautes, tu accèderas au domaine des Dieux... ";

        }
    }

    void OnTriggerExit(Collider Col)
    {
        if (Col.gameObject.tag == "DruideBoutDuMonde")
        {
            TxtForgeron.text = "";

        }
    }
}
