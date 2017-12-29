using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueChef : MonoBehaviour
{

    private Text TxtChef;

    // Use this for initialization
    void Start()
    {
        TxtChef = GameObject.Find("TxtChef").GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "Chef")
        {
            TxtChef.text = "Chef:  J'ai entendu dire que tu partais en quête pour le Druide. Sur ton chemin tu trouveras un camp de Romains, tues les tous et n'oublies pas de libérer nos amis qui ont été faits prisonniers ! Tu peux aller t'équiper d'une épée et d'un bouclier chez le Forgeron. ";

        }
    }

    void OnTriggerExit(Collider Col)
    {
        if (Col.gameObject.tag == "Chef")
        {
            TxtChef.text = "";

        }
    }
}
