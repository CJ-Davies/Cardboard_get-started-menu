using UnityEngine;
using System.Collections;

public class CirclePosition : MonoBehaviour {

	public float radius;
	public int angle;
	Vector3 headPosition;

	// Use this for initialization
	void Start () {
		// object that this script is attached to is referenced with gameObject

		// camera object reference can be obtained by GameObject.Find("Head")

		headPosition = GameObject.Find("Head").transform.position;

		gameObject.transform.position = headPosition;

		gameObject.transform.Rotate(0, 0, angle);

		//gameObject.transform.position += new Vector3(0f, 0f, radius);

		gameObject.transform.Translate(0f, -(radius), 0f, Space.Self);

	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log(headPosition);


	}
}
