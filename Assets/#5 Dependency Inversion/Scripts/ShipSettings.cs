using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DependencyInversion
{
    [CreateAssetMenu(menuName = "Ship/Settings", fileName = "ShipData")]
    public class ShipSettings : ScriptableObject
    {
        [SerializeField] float turnSpeed = 25f;
        [SerializeField] float moveSpeed = 10f;
        [SerializeField] bool useAi;

        public float TurnSpeed { get => turnSpeed; }
        public float MoveSpeed { get => moveSpeed; }
        public bool UseAi { get => useAi; }
    }
}
