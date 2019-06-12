using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour {
    Vector2 newPos;
    float dis = 2f;
    float speed = 0.1f;
    float left = -1.0f;
	// Use this for initialization
	void Start () {
        newPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        newPos.x += speed * left;
        transform.position = newPos;
        dis -= speed;
        if(dis <= 0f)
        {
            dis = 2f;
            left *= -1;
            GetComponent<SpriteRenderer>().flipX = !GetComponent<SpriteRenderer>().flipX;
        }
	}
}
