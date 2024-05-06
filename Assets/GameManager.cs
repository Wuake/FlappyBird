using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] private GameObject _gameOverlay; 
    [SerializeField] private AudioSource _audioSource;
    // Start is called before the first frame update

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        Time.timeScale = 1f;
    }
    public void GameOver()
    {
        _gameOverlay.SetActive(true);
        Time.timeScale = 0f;
        _audioSource.Stop();
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        if(_audioSource.mute == false)
        {
            _audioSource.Play();
        }

    }
}
