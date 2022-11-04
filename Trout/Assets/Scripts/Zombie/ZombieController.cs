using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieController : MonoBehaviour
{
    private NavMeshAgent agent = null;
    [SerializeField] private Transform target;

    private void Start()
    {
        GetReferences();

    }
    private void Update()
    {
        MoveToTarget();
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
}