using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Vstages : MonoBehaviour {
	public Sprite[] sprites;
	public Image img;
	public Slider sld;
	public Text txt;
	public ParticleSystem ps;
	public Text score;
	public Text scoreGameOver;
	public GameObject HUD;
	public GameObject GameOver;
	private Mtap mt;

	void Awake() {
		ps.Stop();
	}
	void Start () {
		mt = this.gameObject.GetComponent<Mtap>();
	}
	// Update is called once per frame
	void Update () {
		if (!mt.gameOver) {
			if(mt.again&&!mt.startAgain) {
				mt.startAgain = true;
				mt.again = false;
				HUD.SetActive(true);
				GameOver.SetActive(false);
				score.text = mt.curScore.ToString();
			} else {
				if(mt.changeCurNumber) {
					img.sprite = sprites[mt.curNumber];
					mt.changeCurNumber = false;
				}
				if (mt.Lvlup) {
					ps.Play();
					score.text = mt.curScore.ToString();
					mt.Lvlup = false;
				}
				sld.value = mt.curTime / mt.times[mt.getCurStage()];
				txt.text = mt.curTime.ToString() + "s";
			}
		} else if(!mt.gameOverStart){
			mt.gameOverStart = true;
			HUD.SetActive(false);
			GameOver.SetActive(true);
			scoreGameOver.text = mt.curScore.ToString();
		}
	}
}
