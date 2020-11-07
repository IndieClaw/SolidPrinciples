using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace InterfaceSegregation
{
    public class Npc : IEntity
    {
        #region Fields and variables
        public int SRT => strenght;

        public int STA => stamina;

        public int CON => constitution;

        public int WIS => wisdom;

        public int INT => intelligence;

        public int CHA => charisma;

        public float Health => health;

        public float MaxHealth => maxHealth;

        [SerializeField] int strenght = 10;
        [SerializeField] int stamina = 10;
        [SerializeField] int constitution = 10;
        [SerializeField] int wisdom = 10;
        [SerializeField] int intelligence = 10;
        [SerializeField] int charisma = 10;
        [SerializeField] int health = 0;
        [SerializeField] int maxHealth = 100;
        #endregion

        #region Public methods
        #endregion

        #region Private methods


        void Start()
        {
            health = maxHealth;
        }

        void Update()
        {

        }

        public void ModifyHealth(int amount)
        {
            health -= amount;
        }

        #endregion
    }
}
