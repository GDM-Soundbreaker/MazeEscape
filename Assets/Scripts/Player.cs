using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    //designer variables
    public float speed = 10;
    public Rigidbody2D physicsBody;
    public string horizontalAxi = "Horizontal";
    public string verticalAxis = "Vertical";

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //get axis input from unity
        float leftRight = Input.GetAxis(horizontalAxi);
        float upDown = Input.GetAxis(verticalAxis);

        //create direction vector from axis input
        Vector2 direction = new Vector2(leftRight, upDown);

        //make direction vector length 1
        direction = direction.normalized;

        //calculate velocity
        Vector2 velocity = direction * speed;

        //give the velocity to the rigidbody
        physicsBody.velocity = velocity;
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //check if the thing we bumped into is an enemy
        if (collision.collider.GetComponent<Enemy>())
        {
            //die
            Destroy(gameObject);
        }
    }

}
