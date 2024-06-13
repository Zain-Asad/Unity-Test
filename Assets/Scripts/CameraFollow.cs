using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform plr;
    public Vector3 pos;
    void Update()
    {
        transform.position = plr.position + pos;
    }
}
