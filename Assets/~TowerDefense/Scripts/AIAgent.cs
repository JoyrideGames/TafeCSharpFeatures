using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.AI;
namespace TowerDefense
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class AIAgent : MonoBehaviour
    {
        public Transform target;

        private NavMeshAgent nav;

        void Awake()
        {
            nav = GetComponent<NavMeshAgent>();
        }

        // Update is called once per frame
        void Update()
        {
            if(target != null)
            {
                nav.SetDestination(target.position);
            }
               
        }
    }
}
