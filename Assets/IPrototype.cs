using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPrototype 
{
    public abstract IPrototype clone();
}
