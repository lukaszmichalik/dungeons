using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelName : MonoBehaviour
{
    public TextMesh textMesh;

    void Start()
    {
        string levelName = SceneManager.GetActiveScene().name;
        textMesh.text = levelName;
    }
}
