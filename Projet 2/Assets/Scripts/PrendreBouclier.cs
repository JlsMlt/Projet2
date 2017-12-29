using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrendreBouclier : MonoBehaviour
{

    private Text TxtInfo;
    private bool Prendre = false;
    private GameObject GOBouclier;

    // Use this for initialization
    void Start()
    {
        TxtInfo = GameObject.Find("TxtEpée").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && Prendre & GOBouclier != null)
        {
            GOBouclier.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            GOBouclier.transform.position = GameObject.Find("ShieldBow_Slot").transform.position;
            GOBouclier.gameObject.transform.parent = GameObject.Find("ShieldBow_Slot").transform;
        }
    }

    void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "Bouclier")
        {
            TxtInfo.text = "";
            GOBouclier = Col.gameObject;
            Prendre = true;
        }
    }

    void OnTriggerExit(Collider Col)
    {
        if (Col.gameObject.tag == "Bouclier")
        {
            TxtInfo.text = "";
            Prendre = false;
            GOBouclier = null;
        }
    }
}
