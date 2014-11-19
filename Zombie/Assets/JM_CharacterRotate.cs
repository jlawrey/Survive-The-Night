using UnityEngine;
using System.Collections;

public class JM_CharacterRotate : MonoBehaviour {

	public float horizontalSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		float h = horizontalSpeed * Input.GetAxis("Mouse X"); 
		transform.Rotate(0, h, 0);

	}
}
