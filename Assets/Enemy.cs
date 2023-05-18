using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] Enemy enemy;
    private string strEnemy;
    EnemyTypeFactory enemyTypeFactory = new EnemyTypeFactory();
    EnemyType enemyType = new EnemyType();

    [SerializeField] MusicFacade music = new MusicFacade();

    public Enemy()
    {
        this.enemyType = enemyTypeFactory.GetEnemy(-16, -11, 0, 1, 5);
        strEnemy = "I am bad!!!";
    }

    public Enemy clone(Enemy enemyToClone)
    {
        Enemy enemyclone = enemyType.RandomizeEnemy(enemyToClone);
        enemyclone.transform.localScale = new Vector3(0.2f, 0.2f);
        return enemyclone;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log(enemy.strEnemy + " You have damage: -" + enemyType.Damage);
            music.enemyAudio();
        }
    }
}
