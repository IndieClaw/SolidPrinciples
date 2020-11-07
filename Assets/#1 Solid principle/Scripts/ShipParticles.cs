using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SingleResponsibility
{
    public class ShipParticles : MonoBehaviour
    {
        #region Fields and variables
        [SerializeField] GameObject thrusterParticles;

        [SerializeField] GameObject deathParticleSyestemPrefab;
        #endregion

        #region Public methods
        #endregion

        #region Private methods
        private void Awake()
        {
            GetComponent<ShipEngine>().ThrustChanged += HandleThrustChanged;
            GetComponent<ShipHealth>().OnDie += HandleShipDeath;
        }

        void Start()
        {

        }

        void Update()
        {

        }


        void HandleThrustChanged(float thrust)
        {
            thrusterParticles.SetActive(thrust > 0);
        }

        void HandleShipDeath()
        {
            Instantiate(deathParticleSyestemPrefab, transform.position, Quaternion.identity);
        }
        #endregion
    }
}
