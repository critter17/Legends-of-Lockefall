using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CameraMode {  GameplayMode, CinemaMode };

public class CameraController : MonoBehaviour {
    public GameObject followTarget;
    private Vector3 targetPos;
    private float moveSpeed;
    private Camera _camera;
    public CameraMode cameraMode;
    public float deadzoneWidth;
    public float deadzoneHeight;

    // Use this for initialization
    void Start () {
        _camera = GetComponent<Camera>();
        if(!_camera)
        {
            Debug.Log("No camera");
        }

        Debug.Log("player is being followed... maybe");
        followTarget = GameManager.instance.playerManager.player;
    }

    private void OnEnable()
    {
        
    }

    // Update is called once per frame
    void LateUpdate () {
        if(_camera && followTarget)
        {
            Vector2 newPosition = new Vector2(followTarget.transform.position.x, followTarget.transform.position.y);
            int nextX = Mathf.RoundToInt(PixelPerfect.pixelsPerUnit * newPosition.x);
            int nextY = Mathf.RoundToInt(PixelPerfect.pixelsPerUnit * newPosition.y);
            _camera.transform.position = new Vector3(nextX / PixelPerfect.pixelsPerUnit, nextY / PixelPerfect.pixelsPerUnit, _camera.transform.position.z);
        }
    }
}
