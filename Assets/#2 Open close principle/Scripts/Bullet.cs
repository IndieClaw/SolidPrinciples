using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OpenClosePrinciple
{

    public class Bullet : MonoBehaviour
    {
        #region Fields and variables
        Rigidbody rb;
        [SerializeField] float bulletSpeed;
        #endregion

        #region Public methods
        public void Launch(Vector3 direction)
        {
            rb.AddForce(direction * bulletSpeed, ForceMode.Impulse);
        }
        #endregion

        #region Private methods
        private void Awake()
        {
            rb = GetComponent<Rigidbody>();
        }

        #endregion

    }
}
