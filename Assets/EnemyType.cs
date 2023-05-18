using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyType : MonoBehaviour
{
    [SerializeField] public float MinX;
    [SerializeField] public float MaxX;
    [SerializeField] public float MinY;
    [SerializeField] public float MaxY;
    [SerializeField] public int Damage;
    public EnemyType() { }
    public EnemyType(float minX, float maxX, float minY, float maxY, int damage)
    {
        MinX = minX;
        MaxX = maxX;
        MinY = minY;
        MaxY = maxY;
        Damage = damage;
    }
    public Enemy RandomizeEnemy(Enemy enemyToCopy)
    {
        var x = Random.Range(MinX, MaxX);
        var y = Random.Range(MinY, MaxY);
        var position = new Vector3(x, y);
        return Instantiate(enemyToCopy, position, this.transform.rotation);
    }
}
