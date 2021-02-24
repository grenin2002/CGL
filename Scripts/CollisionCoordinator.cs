using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionCoordinator : MonoBehaviour
{
   [Tooltip("In seconds")] [SerializeField] GameObject deathFX;
   [Tooltip("FX prefab on player")] [SerializeField] float levelLoadDelay = 1f;

    void OnTriggerEnter(Collider other)
    {
        StartDeathSequence();
        deathFX.SetActive(true);
        Invoke("ReloadScene", levelLoadDelay);
    }

    private void StartDeathSequence()
    {
        SendMessage("OnPlayerDeath");
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
