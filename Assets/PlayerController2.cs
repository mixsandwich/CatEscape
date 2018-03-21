using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour {

    [SerializeField]
    Vector3 Transition;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetButtonDown("Horizontal")){
            transform.Translate(Transition * Input.GetAxisRaw("Horizontal"));
        }
	}
}
