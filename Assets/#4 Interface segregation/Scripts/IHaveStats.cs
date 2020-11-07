using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterfaceSegregation
{
    public interface IHaveStats
    {
        int SRT { get; }
        int STA { get; }
        int CON { get; }
        int WIS { get; }
        int INT { get; }
        int CHA { get; }

    }
}
