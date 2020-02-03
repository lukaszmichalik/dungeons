using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelItem : MonoBehaviour
{
    public TextMesh textMesh;
    public GameObject akey;
    public string levelName;

    void Start()
    {
        textMesh.text = levelName;
        if (PlayerPrefs.GetInt(levelName+"_finished", 0) == 0)
        {
            Destroy(akey);
        }
    }

    void OnMouseDown()
    {
        SceneManager.LoadScene(levelName);   
    }
}
