using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class splashHandler : MonoBehaviour {

    public float time;

	// Use this for initialization
	void Start () {
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, 0);
        Destroy(this.gameObject, time);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
