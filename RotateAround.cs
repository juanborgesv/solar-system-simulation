using UnityEngine;

public class RotateAround : MonoBehaviour 
{
	public Transform target; // The object to rotate around.
	public float speed;  // Rotation speed.

	void Start ()
	{
		if (target == null) 
		{
			target = this.gameObject.transform;
			Debug.LogWarning ("RotateAround target not specified. Defaulting to parent GameObject");
		}
	}

	// Called once per frame.
	void Update ()
	{
		gameObject.transform.RotateAround(target.position,target.up,speed * Time.deltaTime);
	}
}
