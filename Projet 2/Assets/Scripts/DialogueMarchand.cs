using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueMarchand : MonoBehaviour
{

    private Text TxtMarchand;

    // Use this for initialization
    void Start()
    {
        TxtMarchand = GameObject.Find("TxtMarchand").GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "Marchand")
        {
            TxtMarchand.text = "Marchand:  Tu m'as l'air mal en point, prends donc quelques légumes ! ";

        }
    }

    void OnTriggerExit(Collider Col)
    {
        if (Col.gameObject.tag == "Marchand")
        {
            TxtMarchand.text = "";

        }
    }
}
