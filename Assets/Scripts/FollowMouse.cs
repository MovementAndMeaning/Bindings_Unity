using UnityEngine;
using System.Collections;

public class FollowMouse : MonoBehaviour {

	public float depth;
	Vector3 mousePos, wantedPos;
	// Use this for initialization
	void Start () {
	
		Screen.showCursor = false;
	}
	
	// Update is called once per frame
	void Update () {
	
		mousePos = Input.mousePosition;
		wantedPos = Camera.main.ScreenToWorldPoint (new Vector3 (mousePos.x, mousePos.y, depth));
		transform.position = wantedPos;
	}
}
