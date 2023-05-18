using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BaseDecorator : MonoBehaviour, IPrototype
{
    private IPrototype wrapee;

    public BaseDecorator(){}

    public BaseDecorator(IPrototype wrapee){
        this.wrapee = wrapee;
    }
    public IPrototype clone(){
        return wrapee;
    }
    public virtual void GiveBonus(){}
}