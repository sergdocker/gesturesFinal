using UnityEngine;
using System.Collections;

public class Ctap:MonoBehaviour {
	private Mtap mt;

	void Start() {
		mt = this.gameObject.GetComponent<Mtap>();
		genRandom ();
	}
	void Update() {
		if (!mt.gameOver) {
			mt.curTime += Time.deltaTime;
			if(mt.curTime<=mt.times[mt.getCurStage()]) {
				if(mt.tap) {
					calculate();
				}
			} else {
				mt.gameOver = true;
			}
		}
	}

	void calculate() {
		if (mt.curNumber == mt.tapNumber) {
			genRandom ();
			mt.tap = false;
			mt.Lvlup = true;
			mt.curTime = 0;
			if (mt.getCurStage () < 20)
				mt.incCurStage ();
			mt.curScore++;
		} else {
			mt.tap = false;
		}
	}

	void genRandom() {
		int curNumber = Random.Range (0, 3);
		mt.curNumber = curNumber;
		mt.changeCurNumber = true;
	}
}
