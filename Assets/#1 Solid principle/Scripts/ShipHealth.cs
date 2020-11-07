using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SingleResponsibility
{
    public class ShipHealth : MonoBehaviour
    {
        #region Fields and variables
        [SerializeField] int maxHealth = 100;

        [SerializeField] int health;

        public event Action OnDie = delegate { };
        #endregion

        #region Public methods
        #endregion

        #region Private methods

        private void Awake()
        {
            health = maxHealth;
        }
        void Start()
        {

        }

        void Update()
        {

        }

        private void OnCollisionEnter(Collision other)
        {
            var projectile = other.collider.GetComponent<Projectile>();
            if (projectile != null)
            {
                TakeDamage(projectile.damage);
            }
        }

        void TakeDamage(int damage)
        {
            health -= damage;
            if (health <= 0)
            {
                Die();
            }
        }

        void Die()
        {
            OnDie();
            Destroy(gameObject);
        }
        #endregion
    }
}
