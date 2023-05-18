using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //// Update is called once per frame
    //void Update()
    //{

    //}
    private BoxCollider2D boxCollider;
    private Vector3 moveData  = Vector3.zero; // move delta

    private void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        Debug.Log(boxCollider);
    }
    private void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        
        //Reset MoveDelta
        moveData = new Vector3(x, y, 0);
       
        if (moveData.x > 0)
            transform.localScale = Vector3.one;
        else if (moveData.x < 0)
            transform.localScale = new Vector3(-1, 1, 1);
    }
}
