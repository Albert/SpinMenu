using UnityEngine;
using System.Collections;

public class SpinToMouse : MonoBehaviour {
	Vector3 lastMousePosition;
	void Start () {
	}
	
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			lastMousePosition = Input.mousePosition;
		}

		//freeRotate ();
		constrainedRotate();

	}

	void freeRotate() {
		if (Input.GetMouseButton (0)) {
			Vector3 deltaVector = Input.mousePosition - lastMousePosition;
			Vector3 rotationAxis = Vector3.Cross(deltaVector, Vector3.forward);
			transform.RotateAround (transform.position, rotationAxis, deltaVector.magnitude);
			lastMousePosition = Input.mousePosition;
		}
	}

	void constrainedRotate() {
		if (Input.GetMouseButton (0)) {
			Vector3 deltaVector = Input.mousePosition - lastMousePosition;
			deltaVector.x = 0;
			Vector3 rotationAxis = Vector3.Cross(deltaVector, Vector3.forward);
			transform.RotateAround (transform.position, rotationAxis, deltaVector.magnitude);
			lastMousePosition = Input.mousePosition;
		}
	}
}