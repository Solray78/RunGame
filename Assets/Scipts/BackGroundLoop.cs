using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundLoop: MonoBehaviour
{
    private float width;
    private void Awake()
    {
        BoxCollider2D backroundCollider = GetComponent<BoxCollider2D>();
        width = backroundCollider.size.x;
    }
    void Update()
    {
        if(transform.position.x <= -width)
        {
            Reposition();
        }
    }

    private void Reposition()
    {
        Vector2 offset = new Vector2(width * 2f, 0);
        transform.position = (Vector2)transform.position + offset;
    }
}
