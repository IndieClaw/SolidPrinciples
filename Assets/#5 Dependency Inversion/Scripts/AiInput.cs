using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DependencyInversion
{
    public class AiInput : IShipInput
    {
        #region Fields and variables
        public float Rotation { get; private set; }


        public float Thrust { get; private set; }

        #endregion

        #region Public methods
        public void ReadInput()
        {
            Rotation = Random.Range(-1f, 1f);
            Thrust = Random.Range(0, 1f);
        }

        #endregion

        #region Private methods

        #endregion


    }
}
