using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OpenClosePrinciple
{

    public class Missile : MonoBehaviour
    {
        #region Fields and variables
          
        [SerializeField] float speed = 5f;
        [SerializeField] float turnSpeed = 5f;

        Rigidbody rb;

        Transform target;

        Quaternion targetRotation;
        #endregion

        #region Public methods
        public void SetTarget(Transform t)
        {
            target = t;
        }
        #endregion

        #region Private methods
        private void Awake()
        {
            rb = GetComponent<Rigidbody>();
        }

        private void FixedUpdate()
        {
            if (target != null)
            {
                // For the rotation to work the Missile has to have the object as a child
                // and the child must be rotated so that the front is facing the Z axis
                rb.velocity = transform.forward * speed;
                targetRotation = Quaternion.LookRotation(target.position - transform.position);
                rb.MoveRotation(Quaternion.RotateTowards(transform.rotation, targetRotation, turnSpeed));
            }
        }

        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag("MissileTarget"))
            {
                target = null;
                Destroy(gameObject);
            }
        }

        #endregion

    }
}
