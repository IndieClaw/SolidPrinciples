using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DependencyInversion
{
    public class ControllerInput : IShipInput
    {
        #region Fields and variables
        public float Rotation { get; private set; }


        public float Thrust { get; private set;}

        #endregion

        #region Public methods
        public void ReadInput()
        {
            Rotation = Input.GetAxis("Horizontal");
            Thrust = Input.GetAxis("Vertical");
        }

        #endregion

        #region Private methods

        #endregion


    }
}
