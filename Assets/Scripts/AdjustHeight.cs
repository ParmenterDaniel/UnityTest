using UnityEngine;
using UnityEngine.XR;

public class AdjustHeight : MonoBehaviour
{
    public float playerHeight = 1.6f; // Adjust this as needed for your app

    void Start()
    {
        XRDevice.SetTrackingSpaceType(TrackingSpaceType.RoomScale);
    }

    void Update()
    {
        Vector3 position = transform.localPosition;
        position.y = playerHeight;
        transform.localPosition = position;
    }
}
