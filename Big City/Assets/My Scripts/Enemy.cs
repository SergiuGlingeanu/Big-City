﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{

    private NavMeshAgent _npc;
    private Transform _npcTrans;

    private City_Manager cityManager;

    void Start()
    {
        _npc = GetComponent<NavMeshAgent>();
        _npcTrans = GetComponent<Transform>();

        _npc.SetDestination(Random.insideUnitSphere * 100);

        cityManager = GameObject.Find("Game Manager").GetComponent<City_Manager>();
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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            cityManager.enemiesLeft -= 1;
            Destroy(this.gameObject);
        }
    }
}
