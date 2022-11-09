using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieController : MonoBehaviour
{
    private NavMeshAgent agent = null;
    [SerializeField] private Transform target;

    public int max_health;
    private int current_health;
    public int damage;

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

    public void DealDamage()
    {
        if (Vector3.Distance(target.position, transform.position) <= 2)
        {
            print("Hit");
        }
    }
}
