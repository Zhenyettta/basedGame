using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.AI;

public class ZombieController : MonoBehaviour
{
    private NavMeshAgent agent = null;
    [SerializeField] private Transform target;

    public int max_health;
    private int current_health;
    public int damage;


    PlayerController pcr = new PlayerController();

    private void Start()
    {
        GetReferences();
        current_health = max_health;
   

    }
    private void Update()
    {
        MoveToTarget();
        DealDamage();
    }
    private void MoveToTarget()
    {
        agent.SetDestination(target.position);
        if (Vector3.Distance(target.position, transform.position) <= 0.5)
        {
            RotateToTarget();
        }
    }
    private void RotateToTarget()
    {
        Vector3 dir = target.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(dir, Vector3.up);
        transform.rotation = rotation;
    }
    private void GetReferences()
    {
        agent = GetComponent<NavMeshAgent>();

    }

    public void TakeDamage(int damage)
    {
        current_health -= damage;
        //sound

        if (current_health < 0)
        {
            print("Zombie's DEAD");
            Destroy(transform.root.gameObject);
        }
    }


    public float attackRate = 2f;
    float nextAttackTime = 0f;

    public void DealDamage()
    {
        if (Vector3.Distance(target.position, transform.position) <= 2)
        {
            if (attackRate >= nextAttackTime)
            {
                pcr.TakeDamageFromEnemy(20);
                nextAttackTime = Time.deltaTime * 5f;
            }
            else
            {
                nextAttackTime -= Time.deltaTime; /* if nextAttackTime is greater than the attackRate, subtract one from nextAttackTime. this only happens once per second because you use Time.deltaTime */
            }

        }
    }
}
