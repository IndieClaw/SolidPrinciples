using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SingleResponsibility
{
    [RequireComponent(typeof(ShipInput))]
    public class ShipEngine : MonoBehaviour
    {
        #region Fields and variables 
        [SerializeField] float speed = 30f;

        [SerializeField] float turnSpeed = 5f;

        ShipInput shipInput;

        float lastThrust = float.MinValue;

        public event Action<float> ThrustChanged = delegate { };

        #endregion

        #region Public methods
        #endregion

        #region Private methods

        private void Awake()
        {
            shipInput = GetComponent<ShipInput>();
        }

        void Start()
        {

        }

        void Update()
        {
            if (lastThrust != shipInput.Vertical)
            {
                ThrustChanged(shipInput.Vertical);
            }

            lastThrust = shipInput.Vertical;

            transform.position += Time.deltaTime * shipInput.Vertical * transform.forward * speed;
            transform.Rotate(Vector3.up * shipInput.Horizontal * turnSpeed * Time.deltaTime);
        }

        #endregion
    }
}
