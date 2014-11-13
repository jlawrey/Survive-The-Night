using UnityEngine;
using System.Collections;

public class SwitchCamera : MonoBehaviour {
	
	public Camera camera1;
	public Camera camera2;
	
	void Start () {
		camera1.enabled = true; 
		camera2.enabled = false; 
	}
	
	void Update () {
		if (Input.GetKeyDown("2"))
		{
			camera1.enabled = false;
			camera2.enabled = true;
		}
		if (Input.GetKeyDown("1"))
		{
			camera1.enabled = true;
			camera2.enabled = false;
		}
	}
}