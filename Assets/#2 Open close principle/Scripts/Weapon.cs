using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OpenClosePrinciple
{
    public class Weapon : MonoBehaviour
    {
        #region Fields and variables

        private ILauncher launcher;
        [SerializeField] float fireRefreshsRate = 1f;

        float nextFireTime;
        #endregion

        #region Public methods
        #endregion

        #region Private methods
        private void Awake()
        {
            launcher = GetComponent<ILauncher>();
        }

        void Start()
        {

        }

        void Update()
        {
            if (CanFire() && Input.GetButtonDown("Fire1"))
            {
                FireWeapon();
            }
        }

        bool CanFire()
        {
            return Time.time >= nextFireTime;
        }

        void FireWeapon()
        {
            nextFireTime = Time.time + fireRefreshsRate;
            launcher.Launch(this);
        }

        #endregion
    }
}
