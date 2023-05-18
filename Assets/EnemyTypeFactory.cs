using System.Collections.Generic;
using UnityEngine;

public class EnemyTypeFactory : MonoBehaviour
{
    private static List<EnemyType> _types = new List<EnemyType>(){
        new EnemyType(-16, -11, 0, 1, 5), // normal level
        new EnemyType(-12, -10, -2, 0, 15)
    };
    public EnemyTypeFactory() { }
    float rndMinX;
    float rndMinY;
    float rndMaxX;
    float rndMaxY;
    public void Awake()
    {
        rndMinX = Random.Range(-16f, -15f);
        rndMinY = Random.Range(-11f, -12f);
        rndMaxX = Random.Range(-1f, 0f);
        rndMaxY = Random.Range(0f, 1f);
    }

    // Метод для отримання ворога зі спільним станом
    public EnemyType GetEnemy(float minx, float maxx, float miny, float maxy, int damage)
    {
        // Шукаємо серед спільних станів ворога з таким ім'ям
        EnemyType type = _types.Find(s => s.Damage == damage);
        if (type == null)
        {
            // Якщо ворог ще не існує, створюємо його
            float minX = rndMinX;
            float maxX = rndMaxX;
            float minY = rndMinY;
            float maxY = rndMaxY;
            int Damage = 1;
            type = new EnemyType(minX, maxX, minY, maxY, Damage);
            _types.Add(type);
        }
        return type;
    }
}
