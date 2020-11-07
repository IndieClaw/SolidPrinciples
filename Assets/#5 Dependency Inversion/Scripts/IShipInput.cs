using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DependencyInversion
{
    public interface IShipInput
    {
        void ReadInput();
        float Rotation { get; }
        float Thrust { get; }
    }
}
