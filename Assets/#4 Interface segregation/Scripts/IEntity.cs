using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterfaceSegregation
{
    public interface IEntity : IHaveHealth, IHaveStats
    {

    }
}
