using UnityEngine;
using System.Collections;

public class Mtap: MonoBehaviour {
	public bool tap = false;
	public int tapNumber;
	public int curNumber;
	public float beginTime = 60;
	public float numberForFunction = 1.2265f;
	public int maxStages = 20;
	public float curTime;
	public float[] times;
	public bool gameOver = false;
	public bool gameOverStart = false;
	public bool again = false;
	public bool startAgain = false;
	public bool changeCurNumber = false;
	public bool Lvlup = false;
	public int curScore = 0;
	private int curStage = 0;

	void Start() {
		times = new float[maxStages+1];
		string timeString = "";
		for (int i=0; i<=maxStages; i++) {
			times[i] = - Mathf.Pow(numberForFunction,i) + beginTime;
			timeString += times[i].ToString() + " ";
		}
		//Debug.Log (timeString);
	}
	public int getCurStage() {
		return curStage;
	}

	public void incCurStage() {
		curStage++;
	}
	
	public void resetStage() {
		curStage = 0;
	}

	public void Again() {
		if (gameOver && gameOverStart) {
			again = true;
			startAgain = false;
			gameOver = false;
			gameOverStart = false;
			tap = false;
			changeCurNumber = false;
			Lvlup = false;
			curScore = 0;
			curStage = 0;
		}
	}
}