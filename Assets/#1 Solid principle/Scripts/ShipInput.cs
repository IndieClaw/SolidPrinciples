using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SingleResponsibility
{
    public class ShipInput : MonoBehaviour
    {
        #region Fields and variables
        public float Horizontal { get; private set; }
        public float Vertical { get; private set; }

        public event Action OnFire = delegate { };
        #endregion

        #region Public methods
        #endregion

        #region Private methods

        void Update()
        {
            Horizontal = Input.GetAxis("Horizontal");
            Vertical = Input.GetAxis("Vertical");

            if (Input.GetButtonDown("Fire1"))
            {
                OnFire();
            }


        }

        #endregion
    }
}
