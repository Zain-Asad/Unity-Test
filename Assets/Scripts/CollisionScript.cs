using System;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision obj)
    {
        if (string.Equals(obj.collider.tag, "Obstacle"))
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
