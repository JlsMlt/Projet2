using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrendreLégume : MonoBehaviour
{

    private Text TxtInfo;
    private bool Prendre = false;
    private GameObject GOLégume;

    // Use this for initialization
    void Start()
    {
        TxtInfo = GameObject.Find("TxtEpée").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && Prendre & GOLégume != null)
        {
            GOLégume.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            GOLégume.transform.position = GameObject.Find("WeaponSlotPelvis").transform.position;
            GOLégume.gameObject.transform.parent = GameObject.Find("WeaponSlotPelvis").transform;
        }
    }

    void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "Légume")
        {
            TxtInfo.text = "";
            GOLégume = Col.gameObject;
            Prendre = true;
        }
    }

    void OnTriggerExit(Collider Col)
    {
        if (Col.gameObject.tag == "Légume")
        {
            TxtInfo.text = "";
            Prendre = false;
            GOLégume = null;
        }
    }
}
