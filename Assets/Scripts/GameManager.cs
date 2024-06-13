using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    private bool _gameOver;
    public GameObject completeUI;
    public Rigidbody player;
    public void GameOver()
    {
        if (_gameOver) return;
        _gameOver = true;
        FindObjectOfType<Scoring>().enabled = false;
        FindObjectOfType<Movement>().enabled = false;
        StartCoroutine(Restart());
        player.AddForce(0, 300,-100000);
    }
    public void LevelComplete()
    {
        completeUI.SetActive(true);
        StartCoroutine(Restart());
    }
    private IEnumerator Restart()
    {
        yield return new WaitForSecondsRealtime(3);
        SceneManager.LoadScene("SampleScene");
        _gameOver = false;
        
    }

    
}
