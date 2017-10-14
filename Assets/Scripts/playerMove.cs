using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour {

    public float speed;
    private int state;
    private string direction = "up";
    
    Rigidbody2D rBody;

    // Use this for initialization
    void Start () {
        rBody = this.GetComponent<Rigidbody2D>();
        state = 0;
    }
	
	// Update is called once per frame
	void Update () {
        #region Move
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        //transform.position = new Vector2(this.transform.position.x , this.transform.position.y);

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);


        rBody.velocity = movement * speed;
        #endregion

        #region rotation

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (state == 1)
            {
                //if facing downwards
                this.transform.Rotate(0f, 0f, -180);
            }
            if (state == 2)
            {
                //if facing to the left
                this.transform.Rotate(0f, 0f, -90);
            }
            if (state == 3)
            {
                //if facing to the right
                this.transform.Rotate(0f, 0f, 90);
            }
            state = 0;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (state == 0)
            {
                //if facing upwards
                this.transform.Rotate(0f, 0f, 180);
            }
            if (state == 2)
            {
                //if facing to the left
                this.transform.Rotate(0f, 0f, 90);
            }
            if (state == 3)
            {
                //if facing to the right
                this.transform.Rotate(0f, 0f, -90);
            }
            state = 1;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (state == 0)
            {
                //if facing upwards
                this.transform.Rotate(0f, 0f, 90);
            }
            if (state == 1)
            {
                //if facing downwards
                this.transform.Rotate(0f, 0f, -90);
            }
            if (state == 3)
            {
                //if facing to the right
                this.transform.Rotate(0f, 0f, 180);
            }
            state = 2;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (state == 0)
            {
                //if facing upwards
                this.transform.Rotate(0f, 0f, -90);
            }
            if (state == 1)
            {
                //if facing downwards
                this.transform.Rotate(0f, 0f, 90);
            }
            if (state == 2)
            {
                //if facing to the left
                this.transform.Rotate(0f, 0f, 180);
            }
            state = 3;
        }
        #endregion
        


    }
}
