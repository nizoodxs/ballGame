using UnityEngine;
using System.Collections;

public class coinController : MonoBehaviour {


	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3(15, 45, 30) * Time.deltaTime);
	}
}
