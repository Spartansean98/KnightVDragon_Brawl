using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEngine : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("fucking memes");
        Instantiate(Resources.Load("Dragon"),new Vector3(0,0,-1),Quaternion.identity);
        Instantiate(Resources.Load("Knight"), new Vector3(-4, -3, -1), Quaternion.identity);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
