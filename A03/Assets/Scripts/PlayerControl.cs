using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {
    public float speed = 10.0f;
    public float jumpSpeed = 300.0f;
    public bool onGround = false;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-speed, 0));
            GetComponent<SpriteRenderer>().flipX = true;
            GetComponent<Animator>().SetTrigger("Run");
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(speed, 0));
            GetComponent<SpriteRenderer>().flipX = false;
            GetComponent<Animator>().SetTrigger("Run");
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            if (onGround)
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpSpeed));
            }
            onGround = false;
        }
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        onGround = true;
        if(collision.gameObject.name=="Enemy1"|| collision.gameObject.name == "Enemy2" ||
            collision.gameObject.name == "Enemy3")
        {
            Destroy(gameObject);
        }
    }
}
