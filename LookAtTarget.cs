using UnityEngine;

public class LookAtTarget : MonoBehaviour 
{
	static public Transform target;

	void Awake () 
	{
		if (target == null) 
		{
			target = this.gameObject.transform;
			Debug.Log ("LookAtTarget target not specified. Defaulting to parent GameObject.");
		}
	}

	void Update () 
	{
		if (target)
			this.gameObject.transform.LookAt (target);
	}
}
