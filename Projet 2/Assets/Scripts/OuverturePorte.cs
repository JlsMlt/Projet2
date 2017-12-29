using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuverturePorte : MonoBehaviour
{

    public GameObject Pivot1, Porte1, Pivot2, Porte2;
    public int Angle = -90;
    private int AngleActu;
    public bool Ouverture = false;


    void Update()
    {
        if (Ouverture)
        {
            if (AngleActu < Angle)
            {
                AngleActu += 1;
                Porte1.transform.RotateAround(Pivot1.transform.position, Vector3.down, AngleActu * Time.deltaTime);
                Porte2.transform.RotateAround(Pivot2.transform.position, Vector3.up, AngleActu * Time.deltaTime);
            }

        }
        else
        {
            if (AngleActu != 0)
            {
                AngleActu -= 1;
                Porte1.transform.RotateAround(Pivot1.transform.position, -Vector3.down, AngleActu * Time.deltaTime);
                Porte2.transform.RotateAround(Pivot2.transform.position, -Vector3.up, AngleActu * Time.deltaTime);
            }

        }

        if (AngleActu == 0)
        {
            Porte1.transform.rotation = Quaternion.Euler(0, 0, 0);
            Porte2.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }


    void OnTriggerEnter()
    {

        Ouverture = true;
    }

    void OnTriggerExit()
    {

        Ouverture = false;
    }
}
