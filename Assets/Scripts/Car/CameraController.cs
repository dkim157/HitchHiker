using UnityEngine;

public class CameraController : MonoBehaviour
{
     [SerializeField] public Transform vehicle;
     [SerializeField] public Vector3 cameraOffset; 

     void Update()
     {
          // Move the camera to the correct position and rotation relative to the vehicle
          transform.SetPositionAndRotation(vehicle.position + vehicle.TransformDirection(cameraOffset), vehicle.rotation);
     }
}
