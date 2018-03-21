using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    //PlayerStats p;
    PixelPerfectCamera ppc;
    public GameObject followTarget;
    private Vector3 targetPos;
    private float moveSpeed;
    private Camera _camera;

    // Use this for initialization
    void Start () {
        _camera = this.GetComponent<Camera>();
        if(!_camera)
        {
            Debug.Log("No camera");
        }

        

        followTarget = PlayerManager.instance.player;
        //moveSpeed = p.baseSpeed;
    }
	
	// Update is called once per frame
	void Update () {
        if(_camera && followTarget)
        {
            Vector2 newPosition = new Vector2(followTarget.transform.position.x, followTarget.transform.position.y);
            float nextX = Mathf.Round(PixelPerfect.pixelsPerUnit * newPosition.x);
            float nextY = Mathf.Round(PixelPerfect.pixelsPerUnit * newPosition.y);
            _camera.transform.position = new Vector3(nextX / PixelPerfect.pixelsPerUnit, nextY / PixelPerfect.pixelsPerUnit, _camera.transform.position.z);
        }

        //targetPos = new Vector3(followTarget.transform.position.x, followTarget.transform.position.y, transform.position.z);
        //transform.position = targetPos;
    }
}
