using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI score;
    void Update()
    {
        score.text = "Score: " + (int) player.position.z;
    }
}
