using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//LITJSON
//JSON JavaScript Object Notation
// using for invintory in diploma (well not, but a good ducttape soloution)

namespace ArraysTwo
{

    public class TurretS : MonoBehaviour
    {

        public Transform target;

        private WeaponS currentWeapon;

    

        // Use this for initialization
        void Start()
        {
            currentWeapon = GetComponentInChildren<WeaponS>();
            currentWeapon.SetTarget(target);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}