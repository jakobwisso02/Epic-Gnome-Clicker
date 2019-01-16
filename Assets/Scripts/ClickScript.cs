using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ClickScript : MonoBehaviour
{
    public static float score = 0;
    public Text scoreText;
    public AudioSource gnome;


    public void FixedUpdate()
    {
        scoreText.text = score.ToString();

        print("Score" + score);
    }

    public void GnomeClick()
    {
        score++;

        gnome.Play();

        scoreText.text = score.ToString();
    }

}
