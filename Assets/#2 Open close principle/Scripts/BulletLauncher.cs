using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OpenClosePrinciple
{

    public class BulletLauncher : MonoBehaviour, ILauncher
    {
        #region Fields and variables
        [SerializeField] private Bullet bulletPrefab;

        
        #endregion

        #region Public methods
        public void Launch(Weapon weapon)
        {
            var bullet = Instantiate(bulletPrefab, weapon.transform.position, weapon.transform.rotation);
            bullet.Launch(weapon.transform.forward);
        }
        #endregion

        #region Private methods



        #endregion
    }
}
