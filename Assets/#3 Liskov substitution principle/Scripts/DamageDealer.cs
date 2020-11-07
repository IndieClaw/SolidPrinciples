using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LiskovPrinciple
{
    public class DamageDealer : MonoBehaviour
    {
        #region Fields and variables
        #endregion

        #region Public methods
        #endregion

        #region Private methods


        void Start()
        {

        }

        void Update()
        {
            if (Input.GetButtonDown("Fire1"))
            {
                DealDamageToAllCharacters();
            }
        }

        void DealDamageToAllCharacters()
        {
            var characterList = FindObjectsOfType<Character>();
            var damageToDeal = 1;

            if (characterList != null && characterList.Length != 0)
            {
                foreach (var character in characterList)
                {
                    character.TakeDamage(damageToDeal);
                }
            }
        }
        #endregion
    }
}
