using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace InterfaceSegregation
{
    public class AttackProcessor : MonoBehaviour
    {
        #region Fields and variables
        #endregion

        #region Public methods

        public void ProcessMeleeAttack(IHaveStats attacker, IHaveHealth target)
        {
            var damage = CalculateAttackAmount(attacker);
            ProcessAttack(target, damage);
        }

        public int CalculateAttackAmount(IHaveStats attacker)
        {
            return attacker.SRT;
        }

        public void ProcessAttack(IHaveHealth target, int damage)
        {
            target.ModifyHealth(damage);
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
