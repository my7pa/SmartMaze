using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {

	void Update () 
	{
		//45 degree rotation
		transform.Rotate (new Vector3 (0, 0, 45) * Time.deltaTime);
	}
}
