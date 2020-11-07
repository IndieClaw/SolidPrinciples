using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace InterfaceSegregation
{
    public interface IHaveHealth
    {
        float Health { get; }
        float MaxHealth { get; }
        void ModifyHealth(int amount);

    }
}
