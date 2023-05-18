using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDifficulty 
{
    //public IPrototypeChest createPrototype();
    public Chest createChest();
    public GoldenChest createGoldenChest();
    public Enemy createEnemy();
}
