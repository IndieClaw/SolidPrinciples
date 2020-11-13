using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SingleResponsibility
{
    public class ProjectileLauncher : MonoBehaviour
    {
        #region Fields and variables
        [SerializeField] Rigidbody projectile;

        [SerializeField] Transform weaponMountPoint;

        [SerializeField] float fireForce = 300f;
        #endregion

        #region Public methods
        #endregion

        #region Private methods


        private void Awake()
        {
            GetComponent<ShipInput>().OnFire += HandleFire;
        }
        void HandleFire()
        {
            var spawnProjectile = Instantiate(
                projectile,
                weaponMountPoint.position,
                weaponMountPoint.rotation);

            spawnProjectile.AddForce(spawnProjectile.transform.forward * fireForce);

        }

        #endregion
    }
}
