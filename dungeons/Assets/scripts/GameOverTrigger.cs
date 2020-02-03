using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "PlayerKnight")
        {
            string levelName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(levelName);
        }
    }
}
