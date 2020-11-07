using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace InterfaceSegregation
{
    public class Door : IHaveHealth
    {
        #region Fields and variables
        public float Health { get; set; }

        public float MaxHealth { get; set; }

        #endregion

        #region Public methods

        public void ModifyHealth(int amount)
        {
            Health -= amount;                        
        }

        #endregion

        #region Private methods


        #endregion
    }
}
