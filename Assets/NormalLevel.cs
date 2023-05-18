using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NormalLevel : MonoBehaviour, IDifficulty
{
    [SerializeField] Chest originChrest = new Chest();
    [SerializeField] GoldenChest golden = new GoldenChest();
    [SerializeField] Enemy enemy = new Enemy();
    public Chest createChest()
    {
        var x = Random.Range(-16, -13);
        var y = Random.Range(-2, 0);
        var position = new Vector3(x, y);
        Chest chest = Instantiate(originChrest, position, originChrest.transform.rotation);
        chest.transform.localScale = new Vector3(0.2f, 0.2f);
        return chest;
    }
    public GoldenChest createGoldenChest()
    {
        var x = Random.Range(-16, -13);
        var y = Random.Range(-2, 0);
        var position = new Vector3(x, y);
        GoldenChest goldenChest = Instantiate(golden, position, golden.transform.rotation);
        goldenChest.transform.localScale = new Vector3(0.25f, 0.25f);
        return goldenChest;
    }
    public Enemy createEnemy()
    {
        var x = Random.Range(-16, -13);
        var y = Random.Range(-2, 0);
        var position = new Vector3(x, y);
        Enemy emeryReturn = Instantiate(enemy, position, enemy.transform.rotation);
        emeryReturn.transform.localScale = new Vector3(0.5f, 0.5f);
        return emeryReturn;
    }
    public void Start()
    {
        GoldenChest golden1 = createGoldenChest();
        Enemy enemy1 = createEnemy();
    }
}
