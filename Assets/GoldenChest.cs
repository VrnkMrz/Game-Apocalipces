using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldenChest : MonoBehaviour, IPrototype
{
    [SerializeField] float minx;
    [SerializeField] float maxx;
    [SerializeField] float miny;
    [SerializeField] float maxy;
    //GamePlayChest gamePlay;
    [SerializeField] GoldenChest goldenChest;
    public SpriteRenderer spriteRenderChest;
    public Sprite spriteOpenChest;
    public int point = 15;
    [SerializeField] MusicFacade music = new MusicFacade();

    public GoldenChest() { point = 15; maxx = -11f; minx = -16f; miny = -2f; maxy = 0; }
    public GoldenChest(GoldenChest prototype)
    {
        this.point = prototype.point;
    }

    public IPrototype clone()
    {
        var x = Random.Range(minx, maxx);
        var y = Random.Range(miny, maxy);
        var position = new Vector3(x, y);
        GoldenChest chest = Instantiate(this, position, this.transform.rotation);
        chest.transform.localScale = new Vector3(0.2f, 0.2f);
        return chest;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("GoldChest"))
        {
            Debug.Log("You open GOLDEN chest! Treasure: " + point);
            if (Input.GetKey(KeyCode.Space))
            {
                GoldenChest copyGolden = (GoldenChest)goldenChest.clone();
            }
            music.chestOpenAudio();
        }
    }
}
