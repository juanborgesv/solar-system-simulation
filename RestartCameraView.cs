using UnityEngine;

public class RestartCameraView : MonoBehaviour {

    public GameObject _camera;

    void OnMouseDown()
    {
        if (_camera != null)
        {
            Debug.Log("Click!");
            LookAtTarget.target = null;
            _camera.transform.position = new Vector3(0, 5, -27);
            _camera.transform.rotation = new Quaternion(0, 0, 0, 0);
        }
    }
}
