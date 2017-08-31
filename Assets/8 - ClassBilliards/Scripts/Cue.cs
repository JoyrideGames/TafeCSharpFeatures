using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Billiards
{

    public class Cue : MonoBehaviour
    {

        public Ball targetBall; //Target ball selected (which is generally the cue ball)
        public float minPower = 0f; // The min power which maps to the distance
        public float maxPower = 20f; //The max power which maps to the distance
        public float maxDistance = 5f; //The maximum distance in units the cue can be dragged back

        private float hitPower; // The final calculated hit power to fire the ball
        private Vector3 aimDirection; // The aim direction the ball should fire
        private Vector3 prevMousePos; // The mouse position obtained when left-clicking
        private Ray mouseRay; // The ray of the mouse

        //Helps visualize the mouse ray and direction of fire
        private void OnDrawGizmos()
        {
            Gizmos.DrawLine(mouseRay.origin, mouseRay.origin + mouseRay.direction * 1000f);
            Gizmos.color = Color.blue;
            Gizmos.DrawLine(targetBall.transform.position, targetBall.transform.position + aimDirection * hitPower);
        }

        // Rotates the cue to whatever the mouse is pointing (using raycast)
        void Aim()
        {
            //Calculate mouse ray before performing raycast
            mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            //Raycast Hit container for th e hit information
            RaycastHit hit;
            // Perform the Raycast
            if (Physics.Raycast(mouseRay, out hit))
            {
                //Obtain direction from the cue's position to the raycast's hit point
                Vector3 dir = hit.point - transform.position;
                // Convert direction to angle in degrees
                float angle = Mathf.Atan2(dir.x, dir.z) * Mathf.Rad2Deg;
                //Rotate towards that angle
                transform.rotation = Quaternion.AngleAxis(angle, Vector3.up);
                //Position cue to the balls position
                transform.position = targetBall.transform.position;
            }
        }

        //Deactivates the cue
        public void Deactivate()
        {
            gameObject.SetActive(false);
        }

        //Activates the cue
        public void Activate()
        {
            Aim();
            gameObject.SetActive(true);
        }

        //Allows you to drag the cue back and calculates power dealt to the ball
        void Drag()
        {
            //Stores target ball's position in small variable
            Vector3 targetPos = targetBall.transform.position;
            //Get mouse position in world units
            Vector3 currMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //Calculate distance from previous mouse position to the current mouse position
            float distance = Vector3.Distance(prevMousePos, currMousePos);
            //Clamp the distance between 0 - maxDistance
            distance = Mathf.Clamp(distance, 0, maxDistance);
            float distPercentage = distance / maxDistance;
            hitPower = Mathf.Lerp(minPower, maxPower, distPercentage);
            transform.position = targetPos - transform.forward * distance;
            aimDirection = (targetPos - transform.position).normalized;

                ////////PUSH TO GIT!!!!!!!!
        }

        void Fire()
        {
            targetBall.Hit(aimDirection, hitPower);
            Deactivate();
        }

        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                prevMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }
            if (Input.GetMouseButton(0))
            {
                Drag();
            }
            else
            {
                Aim();
            }
            if (Input.GetMouseButtonUp(0))
            {
                Fire();
            }

            
        }
    }
}

