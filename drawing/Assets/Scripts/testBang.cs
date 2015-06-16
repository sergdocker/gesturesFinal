using UnityEngine;
using System.Collections;

public class testBang : MonoBehaviour {
	private GameObject ps;
	private bool startTimer = false;
	Vector2 pathStart = new Vector2 (-41.68f, 27.4f);
	Vector2 pathEnd = new Vector2(41.7f, -25.2f);
	Vector2 diffPath = Vector2.zero;

	// Use this for initialization
	void Start () {
		diffPath = new Vector2 (pathEnd.x - pathStart.x,
		                        pathEnd.y - pathStart.y);
		ps = this.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		if (startTimer) {
			if(Input.GetMouseButtonUp(0)) {
				startTimer = false;
			} else {
				Vector2 mouse = new Vector2(Input.mousePosition.x/Screen.width,
				                            (Screen.height - Input.mousePosition.y)/Screen.height);
				ps.transform.localPosition = new Vector3(pathStart.x + mouse.x * diffPath.x,
				                                         pathStart.y + mouse.y * diffPath.y,
				                                         0);
			}
		} else {
			if (Input.GetMouseButtonDown (0)) {
				startTimer = true;
				Vector2 mouse = new Vector2(Input.mousePosition.x/Screen.width,
				                            (Screen.height - Input.mousePosition.y)/Screen.height);
				ps.transform.localPosition = new Vector3(pathStart.x + mouse.x * diffPath.x,
				                                         pathStart.y + mouse.y * diffPath.y,
				                                         0);
			}
		}
	}
}
