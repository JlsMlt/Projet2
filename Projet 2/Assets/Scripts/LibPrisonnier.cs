using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LibPrisonnier : MonoBehaviour
{

    //Distance entre le joueur et l'ennemi
    private float Distance;

    // Cible de l'ennemi
    public Transform Target;
    public Transform Target2;

    //Distance de poursuite
    public float chaseRange = 10;

    // Portée des attaques
    public float attackRange = 2.2f;

    // Cooldown des attaques
    public float attackRepeatTime = 1;
    private float attackTime;

    // Montant des dégâts infligés
    public float TheDammage;

    // Agent de navigation
    private UnityEngine.AI.NavMeshAgent agent;

    // Animations de l'ennemi
    private Animation animations;

    // Vie de l'ennemi
    public float enemyHealth;
    private bool isDead = false;

    void Start()
    {
        agent = gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>();
        animations = gameObject.GetComponent<Animation>();
        //attackTime = Time.time;
    }



    void Update()
    {

        if (!isDead)
        {

            // On cherche le joueur en permanence
            Target = GameObject.Find("Player").transform;

            // On calcule la distance entre le joueur et l'ennemi, en fonction de cette distance on effectue diverses actions
            Distance = Vector3.Distance(Target.position, transform.position);

            // Quand l'ennemi est loin = idle
            if (Distance > chaseRange)
            {
                idle();
            }

            if (Distance < chaseRange && Distance > attackRange)
            {
                chase();
            }

        }
    }

    void chase()
    {
            animations.Play("Walk");
            agent.destination = Target2.position;
    }


       
    void idle()
    {
            animations.Play("Walk");
    }




    }
 