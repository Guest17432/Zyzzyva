using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour {

    public float speed;
    
    Rigidbody2D rBody;

    // Use this for initialization
    void Start () {
        rBody = this.GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        float moveHorizontal = 0;
        float moveVertical = 0;

        #region Move
        if (Input.GetKey(KeyCode.W))
        {
            moveVertical = speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveVertical = speed * -1;
        }

        if (Input.GetKey(KeyCode.D))
        {
            moveHorizontal = speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveHorizontal = speed * -1;
        }

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        rBody.velocity = movement * speed;
        #endregion

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.transform.Rotate(Vector3.forward * -90);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.transform.Rotate(Vector3.forward * 90);
            
        }

    }
}
