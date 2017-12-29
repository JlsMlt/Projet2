using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueDruide : MonoBehaviour
{

    private Text TxtDruide;

    // Use this for initialization
    void Start()
    {
        TxtDruide = GameObject.Find("TxtDruide").GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "Druide")
        {
            TxtDruide.text = "Druide:   Catastrophe !  Un certain Aristote dit partout où il passe que la Terre serait ronde...  La rumeur se répend dans le village !  Il faut absolument que tu apportes la preuve que la Terre est plate !  Marche jusqu'au bout du monde, mais avant passe voir le Chef. Il voudrait de parler.";

        }
    }

    void OnTriggerExit(Collider Col)
    {
        if (Col.gameObject.tag == "Druide")
        {
            TxtDruide.text = "";

        }
    }
}
