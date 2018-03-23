using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour {
    
	public GameObject arrowPrefab;
    public GameObject arrowPrefab2;
    GameObject spawnPrefab;
    public float span;
	float delta = 0;
    public int[] ArrowRange;
    public float ArrowHeight;

	void Update() {
		this.delta += Time.deltaTime;
		if(this.delta > this.span) {
			this.delta = 0;
            int RandomNumber;
            RandomNumber = Random.Range(1, 6);
            if(RandomNumber == 1){
                spawnPrefab = arrowPrefab2;
            }
            else{
                spawnPrefab = arrowPrefab;
            }
			GameObject go = Instantiate(spawnPrefab) as GameObject;
            int px = Random.Range(ArrowRange[0],ArrowRange[1]);
            go.transform.position = new Vector3(px, ArrowHeight, 0);
		}
	}
}