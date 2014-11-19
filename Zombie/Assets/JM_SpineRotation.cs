using UnityEngine;
using System.Collections;

public class JM_SpineRotation : MonoBehaviour {
	
	public float horizontalSpeed; //this is how fast the character turns when the mouse is moved

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void LateUpdate ()
	{
		float h = horizontalSpeed * Input.GetAxis("Mouse X"); //Custom rotation for the main characters weird spine alignment
		transform.Rotate(-h, 0, 0);

	}
}

