﻿using UnityEngine;
using System.Collections;

public class MouseAim : MonoBehaviour {
	public Transform spine;
	public Transform armedHand;
	public bool lockY = false;
	public float compensationYAngle = 20.0f;
	public float minAngle = 308.0f;
	public float maxAngle = 31.0f;

	void Start()
	{
		if (rigidbody)
			rigidbody.freezeRotation = true;
	}

	public void LateUpdate(){
		Vector3 point = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.
		        farClipPlane));
		if(lockY)
			point.y = spine.position.y;
		Vector3 relativePoint = transform.
			InverseTransformPoint(point.x, point.y, point.z);
		if(relativePoint.z < 0){
			Vector3 inverseZ = transform.InverseTransformPoint(relativePoint.x,relativePoint.y,-relativePoint.z);
			point = inverseZ;
		}
		spine.LookAt(point, Vector3.up);
		Vector3 comp = spine.localEulerAngles;
		comp.y = spine.localEulerAngles.y + compensationYAngle;
		spine.localEulerAngles = comp;
		if(spine.localEulerAngles.y > maxAngle && spine.
		   localEulerAngles.y < minAngle){
			if(Mathf.Abs((spine.localEulerAngles.y - minAngle)) <
			   Mathf.Abs((spine.localEulerAngles.y - maxAngle))){
				Vector3 min = spine.localEulerAngles;
				min.y = minAngle;
				spine.localEulerAngles = min;
			} else {
				Vector3 max = spine.localEulerAngles;
				max.y = maxAngle;
				spine.localEulerAngles = max;
			}
		}


	}

}