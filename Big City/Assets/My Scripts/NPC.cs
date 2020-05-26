using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPC : MonoBehaviour
{

    private NavMeshAgent _npc;
    private Transform _npcTrans;

    void Start()
    {
        _npc = GetComponent<NavMeshAgent>();
        _npcTrans = GetComponent<Transform>();

        _npc.SetDestination(Random.insideUnitSphere * 100);
    }

    private void Update()
    {
        if(Vector3.Distance(_npcTrans.position, _npc.destination) < 3)
        {
            SetNewDestination();
        }
    }

    private void SetNewDestination()
    {
        _npc.SetDestination(Random.insideUnitSphere * 100);
    }
}
