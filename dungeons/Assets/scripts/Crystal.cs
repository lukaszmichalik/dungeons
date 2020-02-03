﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crystal : MonoBehaviour
{

    public GameObject particles;

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name != "PlayerKnight")
        {
            return;
        }

        if (leaveCrystals() == 1)
        {
            string levelName = SceneManager.GetActiveScene().name;
            PlayerPrefs.SetInt(levelName + "_finished", 1);
            SceneManager.LoadScene("menu");
        }
        else
        {
            Instantiate(particles, transform.position, Quaternion.identity);
            Destroy(gameObject, 0.1f);
        }
    }

    int leaveCrystals()
    {
        Crystal[] crystals = Component.FindObjectsOfType<Crystal>();
        return crystals.Length;
    }
}
