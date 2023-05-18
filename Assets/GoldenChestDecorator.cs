using UnityEngine;

public class GoldenChestDecorator : BaseDecorator
{
    //private IPrototype wrapee;
    [SerializeField] GameObject sword;
        [SerializeField] float x_pos;
    [SerializeField] float y_pos;
    bool bonus_exist = false;

    public GoldenChestDecorator() { }
    public override void GiveBonus()
    {
        var position = new Vector3(x_pos, y_pos);
        Quaternion rotation = Quaternion.Euler(0, 0, 90);
        Instantiate(sword, position, rotation);
        sword.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("ui button");
        Debug.Log("You get SWORD!");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (bonus_exist == true) return;
        if (collision.gameObject.CompareTag("GoldChest"))
        {
            GiveBonus();
            bonus_exist = true;
        }
    }
}