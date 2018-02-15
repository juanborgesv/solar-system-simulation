using UnityEngine;
using UnityEngine.UI;

public class ChangeLookAtTarget : MonoBehaviour 
{
	private Transform _target;  // Target the camera will look at
	public GameObject _description = null;

	void Awake () 
	{
		_target = this.gameObject.GetComponent<Transform> ();
	}

	void OnMouseDown ()
	{
		LookAtTarget.target = _target;
		UIManager.description = _description;

		Camera.main.fieldOfView = 60 * _target.transform.localScale.x;
	}
}
