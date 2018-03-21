using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour {

	public GameObject arrowPrefab;
	public float span;
	float delta = 0;
    public int[] ArrowRange;
    public float ArrowHeight;

	void Update() {
		this.delta += Time.deltaTime;
		if(this.delta > this.span) {
			this.delta = 0;
			GameObject go = Instantiate(arrowPrefab) as GameObject;
            int px = Random.Range(ArrowRange[0],ArrowRange[1]);
            go.transform.position = new Vector3(px, ArrowHeight, 0);
		}
	}
}