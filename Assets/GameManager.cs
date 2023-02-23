using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public UnityEvent OnLevelCompleted;
    private PlayerMovements _playerMovements;
    private float yPrositionTreshold = -4f;

    public KeyCode restartKey = KeyCode.R;

    // Start is called before the first frame update
    void Start()
    {
        _playerMovements = FindObjectOfType<PlayerMovements>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(restartKey))
        {
            GameOver();
        }
    }


    private void FixedUpdate()
    {
        if (_playerMovements.rigidbody.position.y < yPrositionTreshold)
        {
            GameOver();
        }
    }

    private void GameOver()
    {
        print("Game over!");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


    public void CompleteLevel()
    {
        OnLevelCompleted?.Invoke();
        print("Won!");
    }
}
