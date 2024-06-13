using System;
using UnityEngine;

public class LevelTrigger : MonoBehaviour
{
    public GameManager gm;
    private bool _complete;
    private void OnTriggerEnter(Collider other)
    {
        if(_complete)
            return;
        gm.LevelComplete();
        _complete = true;
    }
}
