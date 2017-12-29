using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider PlayerInside)
    {
        if (PlayerInside.tag == "Player") ;
        {
            PlayerInside.transform.position = PlayerInside.GetComponent<Player>().CheckPos;
        }

    }
}
