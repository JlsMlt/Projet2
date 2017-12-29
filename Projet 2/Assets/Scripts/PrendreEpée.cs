using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrendreEpée : MonoBehaviour {

    private Text TxtInfo;
    private bool Prendre = false;
    private GameObject GOEpée;

	// Use this for initialization
	void Start () {
        TxtInfo = GameObject.Find("TxtEpée").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.E) && Prendre & GOEpée!=null)
        {
            GOEpée.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            GOEpée.transform.position = GameObject.Find("WeaponSlot").transform.position;
            GOEpée.gameObject.transform.parent = GameObject.Find("WeaponSlot").transform;
        }
	}

    void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag=="Epée")
        {
            TxtInfo.text = "";
            GOEpée = Col.gameObject;
            Prendre = true;
        }
    }

    void OnTriggerExit(Collider Col)
    {
        if (Col.gameObject.tag == "Epée")
        {
            TxtInfo.text = "";
            Prendre = false;
            GOEpée = null;
        }
    }
}
