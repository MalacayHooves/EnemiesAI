﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Ziggurat
{
    public class UnitController : MonoBehaviour
    {
        [SerializeField] private int _health;
        [SerializeField] [Range(1, 50)] private float _speed = 2f;
        [SerializeField] private int _lowDamage;
        [SerializeField] private int _strongDamage;
        [SerializeField] [Range(0, 1)] private float _missChance;
        [SerializeField] [Range(0, 1)] private float _doubleDamageChance;
        [SerializeField] [Range(0, 1)] private float _lowToStrongAttackRatio;


        private Vector3 _targetPoint = Vector3.zero;
        private UnitColor _color;

        private NavMeshAgent _navMeshAgent;

        private void Awake()
        {
            _navMeshAgent = GetComponent<NavMeshAgent>();
        }

        private void Start()
        {
            _navMeshAgent.speed = _speed;
            MoveTo(_targetPoint);
        }

        private void MoveTo(Vector3 targetPoint)
        {
            //transform.position = Vector3.MoveTowards(transform.position, targetPoint, _speed);
            _navMeshAgent.destination = targetPoint;
        }


    }
}
