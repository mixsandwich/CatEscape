using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class random : MonoBehaviour {
    
    int RandomNumber;
    public int maxNumber;

	// Use this for initialization
	void Start () {
        RandomNumber = Random.Range(1, maxNumber);
        Debug.Log(RandomNumber);

        //if(RandomNumber % 10 == 0){
        //    Debug.Log("Sレア");
        //}
        //else if(RandomNumber % 4 == 0){
        //    Debug.Log("レア");
        //}
        //else {
        //    Debug.Log("ノーマル");
        //}


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
