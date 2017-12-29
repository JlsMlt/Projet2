using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {

    public int code;
    float disableTimer = 0;



    private void Update()
    {
        if (disableTimer > 0)
            disableTimer -= Time.deltaTime;
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Player" && disableTimer<=0)
        {

            foreach(Teleport tp in FindObjectsOfType<Teleport>())
            {
                if (tp.code==code && tp != this)
                {
                    tp.disableTimer = 5;
                    Vector3 position = tp.gameObject.transform.position;
                    position.y += 2;
                    collider.gameObject.transform.position=position;
                }
            }
        }
    }
    
        
    }


