using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterSploosh : MonoBehaviour {

    public GameObject sploosh;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Instantiate(sploosh, this.transform.position, this.transform.rotation);
    }
}
