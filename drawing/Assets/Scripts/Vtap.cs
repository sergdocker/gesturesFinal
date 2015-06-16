using UnityEngine;
using System.Collections.Generic;

public class Vtap : MonoBehaviour {
	public Mtap mt;

	void OnCustomGesture( PointCloudGesture gesture ) 
	{
		string nameStr = gesture.RecognizedTemplate.name;
		//Debug.Log( "Recognized custom gesture: " + gesture.RecognizedTemplate.name + 
		//          ", match score: " + gesture.MatchScore + 
		 //         ", match distance: " + gesture.MatchDistance );
		switch(nameStr) {
		case "triangle": 
			mt.tapNumber = 0;
			break;
		case "square":
			mt.tapNumber = 1;
			break;
		case "mountain":
			mt.tapNumber = 2;
			break;
		default:
			break;
		}
		mt.tap = true;
	}
}