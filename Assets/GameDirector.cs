using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UIを使うので忘れずに追加

public class GameDirector : MonoBehaviour {

	GameObject hpGauge;
    public float damage;

    public GameObject timeGauge;
    public float decreaseTimeSpeed;

    public Text timeText;
    public float MaxTime;
	void Start() {
		this.hpGauge = GameObject.Find("hpGauge");
	}
    private void FixedUpdate()
    {
        DecreaseTime();
    }
    public void DecreaseHp() {
		this.hpGauge.GetComponent<Image> ().fillAmount -= damage;
	}
    public void DecreaseTime(){
        this.timeGauge.GetComponent<Image>().fillAmount -= decreaseTimeSpeed;
        float currentTime = MaxTime * this.timeGauge.GetComponent<Image>().fillAmount;
        timeText.text = currentTime.ToString("F0");
    }

}