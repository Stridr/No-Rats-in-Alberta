using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject deathscreen;
    public string firstLevel;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            deathscreen.SetActive(true);
            Time.timeScale = 0f;           
        }
    }

    public void Retry()
    {
        SceneManager.LoadScene(firstLevel);
        Time.timeScale = 1f;
    }
}
