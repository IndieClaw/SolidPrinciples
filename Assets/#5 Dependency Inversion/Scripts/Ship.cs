using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DependencyInversion
{
    public class Ship : MonoBehaviour
    {
        #region Fields and variables
        [SerializeField] private ShipSettings shipSettings;
        #endregion

        #region Public methods
        IShipInput shipInput;
        ShipMotor shipMotor;
        #endregion

        #region Private methods
        private void Awake()
        {
            shipInput = shipSettings.UseAi
            ? new AiInput() as IShipInput
            : new ControllerInput();

            shipMotor = new ShipMotor(shipInput, transform, shipSettings);

        }

        void Start()
        {

        }

        void Update()
        {
            shipInput.ReadInput();
            shipMotor.Tick();
        }

        #endregion
    }
}
