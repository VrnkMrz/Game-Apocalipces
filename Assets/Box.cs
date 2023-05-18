using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour, IPrototype
{
    [SerializeField] float minx;
    [SerializeField] float maxx;
    [SerializeField] float miny;
    [SerializeField] float maxy;
    public int point = 1;
    [SerializeField] MusicFacade music = new MusicFacade();

    public Box(Box prototype)
    {
        this.point = prototype.point;
    }

    public IPrototype clone()
    {
        var x = Random.Range(minx, maxx);
        var y = Random.Range(miny, maxy);
        var position = new Vector3(x, y);
        Box box = Instantiate(this, position, this.transform.rotation);
        box.transform.localScale = new Vector3(0.2f, 0.2f);
        box.point = 5;
        return (IPrototype)box;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Box"))
        {
            Debug.Log($"You open box! Treasure: " + point);
            music.boxOpenAudio();
        }
    }
}
