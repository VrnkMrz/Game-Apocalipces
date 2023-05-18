using UnityEngine;

public class EnemyDecorator : BaseDecorator
{
    [SerializeField] GameObject poison;
    [SerializeField] float x_pos;
    [SerializeField] float y_pos;

    bool bonus_exist = false;

    public EnemyDecorator () { }
    public override void GiveBonus()
    {
        var position = new Vector3(x_pos, y_pos);
        Quaternion rotation = Quaternion.Euler(0, 0, 0);
        Instantiate(poison, position, rotation);
        poison.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("ui button");
        Debug.Log("You are poisoned!");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (bonus_exist == true) return;
        if (collision.gameObject.CompareTag("Enemy"))
        {
            GiveBonus();
            bonus_exist = true;
        }
    }
}