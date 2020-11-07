using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace LiskovPrinciple
{
    public class Character : MonoBehaviour
    {
        #region Fields and variables
        [SerializeField] int maxHealth = 100;
        int currentHealth;

        [SerializeField] TextMeshProUGUI  currentHealthText;

        #endregion

        #region Public methods
        public virtual void TakeDamage(int amount)
        {
            currentHealth -= amount;
            currentHealthText.text = currentHealth.ToString();
        }
        #endregion

        #region Private methods

        private void Awake()
        {
            currentHealth = maxHealth;
            currentHealthText.text = currentHealth.ToString();
        }

        #endregion
    }
}
