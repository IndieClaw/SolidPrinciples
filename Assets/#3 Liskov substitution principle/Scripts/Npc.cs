using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LiskovPrinciple
{
    public class Npc : Character
    {
        #region Fields and variables
        #endregion

        #region Public methods
        public override void TakeDamage(int amount)
        {
            base.TakeDamage(amount * 5);
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
