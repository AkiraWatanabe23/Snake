using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class EnemyController : MonoBehaviour
{
    [Tooltip("進行可能先")]
    [SerializeField] private List<Transform> _pos = new();

    private NavMeshAgent _agent = default;

    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        if (_agent.remainingDistance <= _agent.stoppingDistance)
        {
            //設定した地点に着いたら、次の進行先を設定する
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }
}
