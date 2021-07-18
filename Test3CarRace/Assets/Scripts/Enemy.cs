using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Enemy : MonoBehaviour
{
    private NavMeshAgent _agent;
    [SerializeField] private GameObject _targets;
    [SerializeField] private List<ParticleSystem> _smoke;
    private float _angle;
    

    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    private void FixedUpdate()
    {
        _agent.destination = _targets.transform.position;
        if(Mathf.Abs( _angle-transform.rotation.y)>0.001f)
        {
            foreach (ParticleSystem i in _smoke)
            {
                i.Play();
            }

        }
        else
        {
            foreach (ParticleSystem i in _smoke)
            {
                i.Stop();
            }

        }
        _angle = transform.rotation.y;

    }
}
