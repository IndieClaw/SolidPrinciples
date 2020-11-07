using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LiskovPrinciple
{
    public class FlyingNpc : Character
    {
        #region Fields and variables
        #endregion

        #region Public methods
        public override void TakeDamage(int amount)
        {
            //base.TakeDamage(amount);
        }
        #endregion

        #region Private methods


        void Start()
        {

        }

        void Update()
        {

        }

        #endregion
    }
}
