using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrendreRadis : MonoBehaviour
{

    private Text TxtInfo;
    private bool Prendre = false;
    private GameObject GORadis;

    // Use this for initialization
    void Start()
    {
        TxtInfo = GameObject.Find("TxtEpée").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && Prendre & GORadis != null)
        {
            GORadis.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            GORadis.transform.position = GameObject.Find("WeaponSlotPelvis").transform.position;
            GORadis.gameObject.transform.parent = GameObject.Find("WeaponSlotPelvis").transform;
        }
    }

    void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "Radis")
        {
            TxtInfo.text = "";
            GORadis = Col.gameObject;
            Prendre = true;
        }
    }

    void OnTriggerExit(Collider Col)
    {
        if (Col.gameObject.tag == "Radis")
        {
            TxtInfo.text = "";
            Prendre = false;
            GORadis = null;
        }
    }
}
