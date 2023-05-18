using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour, IPrototype
{
    //GameObject obg;
    public SpriteRenderer spriteRender;
    public Sprite spriteOpen;
    [SerializeField] float minx;
    [SerializeField] float maxx;
    [SerializeField] float miny;
    [SerializeField] float maxy;
    [SerializeField] Chest chest;
    public int point = 5;
    [SerializeField] MusicFacade music = new MusicFacade();

    public Chest() { point = 5; maxx = -11f; minx = -16f; miny = -2f; maxy = 0; }
    public Chest(Chest prototype)
    {
        this.point = prototype.point;
    }

    public IPrototype clone()
    {
        //chest = new Chest();
        var x = Random.Range(minx, maxx);
        var y = Random.Range(miny, maxy);
        var position = new Vector3(x, y);
        Chest chest2 = Instantiate(this, position, this.transform.rotation);
        chest2.transform.localScale = new Vector3(0.2f, 0.2f);
        return (IPrototype)chest2;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Chest"))
        {
            Debug.Log($"You open chest! Treasure: " + point);
            if (Input.GetKey(KeyCode.Space))
            {
                Chest copyChest = (Chest)chest.clone();
            }
            spriteRender.sprite = spriteOpen;
            music.chestOpenAudio();
        }
    }
}
