using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public enum Entities
{
    DEFENCIVE,
    ATTAKING,
    HYBRIDE
}

[RequireComponent(typeof(NavMeshAgent))]

public class EntityController : MonoBehaviour
{
    [SerializeField]
    private float hitpoint = 100f;

    [SerializeField]
    private int manaCost = 3;

    [SerializeField]
    private float attackDistance = 1f;

    private NavMeshAgent agent;

    [SerializeField]
    private Transform target;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        agent.SetDestination(target.position);
    }
}