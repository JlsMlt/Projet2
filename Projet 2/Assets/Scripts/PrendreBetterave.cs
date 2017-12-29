using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrendreBetterave : MonoBehaviour
{

    private Text TxtInfo;
    private bool Prendre = false;
    private GameObject GOBetterave;

    // Use this for initialization
    void Start()
    {
        TxtInfo = GameObject.Find("TxtEpée").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && Prendre & GOBetterave != null)
        {
            GOBetterave.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            GOBetterave.transform.position = GameObject.Find("WeaponSlotPelvis").transform.position;
            GOBetterave.gameObject.transform.parent = GameObject.Find("WeaponSlotPelvis").transform;
        }
    }

    void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "Betterave")
        {
            TxtInfo.text = "";
            GOBetterave = Col.gameObject;
            Prendre = true;
        }
    }

    void OnTriggerExit(Collider Col)
    {
        if (Col.gameObject.tag == "Betterave")
        {
            TxtInfo.text = "";
            Prendre = false;
            GOBetterave = null;
        }
    }
}
