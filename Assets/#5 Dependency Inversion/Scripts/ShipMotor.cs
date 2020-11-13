using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DependencyInversion
{
    public class ShipMotor
    {
        #region Fields and variables
        readonly IShipInput shipInput;
        readonly Transform transformToMove;
        ShipSettings shipSettings;

        public ShipMotor(IShipInput shipInput, Transform transformToMove, ShipSettings shipSettings)
        {
            this.shipInput = shipInput;
            this.transformToMove = transformToMove;
            this.shipSettings = shipSettings;
        }

        public void Tick()
        {
            {
                transformToMove
                    .Rotate(Vector3.up * shipInput.Rotation * Time.deltaTime * shipSettings.TurnSpeed);
                    
                transformToMove.position += transformToMove.forward
                    * shipInput.Thrust
                    * Time.deltaTime
                    * shipSettings.MoveSpeed;
            }
        }

        #endregion

        #region Public methods


        #endregion

        #region Private methods       

        #endregion
    }
}
