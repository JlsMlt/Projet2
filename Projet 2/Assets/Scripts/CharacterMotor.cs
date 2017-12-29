using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMotor : MonoBehaviour {

    PlayerInventory playerInv;

    Animation animations;

    public float walkSpeed;
    public float runSpeed;
    public float turnSpeed;

    public float attackCooldown;
    private bool isAttacking;
    private float currentCooldown;
    public float attackRange;
    public GameObject rayHit;

    public string inputFront;
    public string inputBack;
    public string inputLeft;
    public string inputRight;
    

    public Vector3 jumpSpeed;
    CapsuleCollider playerCollider;

    public bool isDead = false;


    void Start () {

        animations = gameObject.GetComponent<Animation>();
        playerCollider = gameObject.GetComponent<CapsuleCollider>();
        playerInv = gameObject.GetComponent<PlayerInventory>();
        rayHit = GameObject.Find("RayHit");
    }
	
	bool IsGrounded()
    {
        return Physics.CheckCapsule(playerCollider.bounds.center, new Vector3(playerCollider.bounds.center.x, playerCollider.bounds.min.y - 0.1f, playerCollider.bounds.center.z), 0.2267609f, layermask: 3);
    }

	void Update () {

        if (!isDead)
        {
            if (Input.GetKey(inputFront) && !Input.GetKey(KeyCode.LeftShift))
            {
                transform.Translate(0, 0, walkSpeed * Time.deltaTime);
                if (!isAttacking)
                {
                    animations.Play("Walk");
                }
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    Attack();
                }
            }

            if (Input.GetKey(inputFront) && Input.GetKey(KeyCode.LeftShift))
            {
                transform.Translate(0, 0, runSpeed * Time.deltaTime);
                if (!isAttacking)
                {
                    animations.Play("Walk");
                }
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    Attack();
                }
            }

            if (Input.GetKey(inputBack))
            {
                transform.Translate(0, 0, -(walkSpeed / 2) * Time.deltaTime);
                if (!isAttacking)
                {
                    animations.Play("Walk");
                }
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    Attack();
                }
            }

            if (Input.GetKey(inputLeft))
            {
                transform.Rotate(0, -turnSpeed * Time.deltaTime, 0);
            }

            if (Input.GetKey(inputRight))
            {
                transform.Rotate(0, turnSpeed * Time.deltaTime, 0);
            }

            if (!Input.GetKey(inputFront) && !Input.GetKey(inputBack))
            {
                if (!isAttacking)
                {
                    animations.Play("Idle");
                }
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    Attack();
                }
            }

            if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
            {
                Vector3 v = gameObject.GetComponent<Rigidbody>().velocity;
                v.y = jumpSpeed.y;

                gameObject.GetComponent<Rigidbody>().velocity = jumpSpeed;
            }
        }

        

        if (isAttacking)
        {
            currentCooldown -= Time.deltaTime;
        }
        if (currentCooldown <= 0)
        {
            currentCooldown = attackCooldown;
            isAttacking = false;
        }
    }

    public void Attack()
    {
        if (!isAttacking)
        {
            animations.Play("Lumbering");

            RaycastHit hit;

            if(Physics.Raycast(rayHit.transform.position, transform.TransformDirection(Vector3.forward), out hit, attackRange))
            {
                Debug.DrawLine(rayHit.transform.position, hit.point, Color.red);

                if (hit.transform.tag == "Ennemy")
                {
                    hit.transform.GetComponent<enemyAi>().ApplyDammage(playerInv.currentDamage);
                } 
            }
            isAttacking = true;
        }
        
        
    }
}
