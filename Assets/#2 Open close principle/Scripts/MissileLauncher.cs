using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OpenClosePrinciple
{

    public class MissileLauncher : MonoBehaviour, ILauncher
    {
        #region Fields and variables
        [SerializeField] Missile missilePrefab;

        
        #endregion

        #region Public methods
        public void Launch(Weapon weapon)
        {
            var target = GameObject.FindGameObjectWithTag("MissileTarget").transform;
            var missile = Instantiate(missilePrefab, weapon.transform.position, Quaternion.identity);
            missile.SetTarget(target);
        }
        #endregion

        #region Private methods

        #endregion

    }
}
