using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IControl
{
    public float Speed { get; set; }
    public float Jump { get; set; }
    public float MaxSpeed { get; set; } 
}
