using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManeger : MonoBehaviour
{
    private int playScore;
    public int successScore;
    public TextMeshProUGUI playerScoreTMP;
    public TextMeshProUGUI beginGameTMP;
    public TextMeshProUGUI endGameTMP;
    private float startTime;
    public float delay = 5f;

    public Boolean flag;
    public AudioClip successCollect;
    public AudioClip ganeSuccess;

    public TextMeshProUGUI achieve1;
    public TextMeshProUGUI achieve2;
    // Start is called before the first frame update
    void Start()
    {
        playScore = 0;
        flag = false;
        
        playerScoreTMP.text = "Score: 0";
        beginGameTMP.alignment = TextAlignmentOptions.Center;
        beginGameTMP.text = "Press Shift to get speed\nPress Space to jump\nPlease get " + successScore + " score!";
        endGameTMP.enabled = false;
        endGameTMP.alignment = TextAlignmentOptions.Center;
        endGameTMP.text = "YOU WIN";
        startTime = Time.time;
        
        achieve1.alignment = TextAlignmentOptions.Center;
        achieve2.alignment = TextAlignmentOptions.Center;
        achieve1.enabled = false;
        achieve2.enabled = false;
        achieve1.text = "My fate is decided by me, no by heaven";
        achieve2.text = "Debt-ridden person";
        
    }

    private void Update()
    {
        if (Time.time - startTime > delay)
        {
            beginGameTMP.enabled = false;
        }

        if (playScore > successScore && !flag)
        {
            endGameTMP.enabled = true;
            AudioSource.PlayClipAtPoint(ganeSuccess, transform.position);
            flag = true;
        }

        if (playScore < -9999 && !flag)
        {
            achieve2.enabled = true;
            flag = true;
        }
    }

    public bool trigger211Once = false;
    public bool trigger985Once = false;
    public bool triggerminus750Once = false;
    public bool triggerminus1500nce = false;
    
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("achieve1") && !flag)
        {
            achieve1.enabled = true;
            flag = true;
        }
        if (collider.CompareTag("scnu"))
        {
            AudioSource.PlayClipAtPoint(successCollect, transform.position);
            playScore += 211;
            playerScoreTMP.text = "Score: " + playScore;
            Destroy(collider.gameObject);
            if (playScore >= 211 && !trigger211Once)
            {
                trigger211Once = true;
                GameMgr.Instance.ShowCele();
            }
        }
        else if (collider.CompareTag("zhongda"))
        {
            AudioSource.PlayClipAtPoint(successCollect, transform.position);
            playScore += 985;
            playerScoreTMP.text = "Score: " + playScore;
            Destroy(collider.gameObject);
            if (playScore >= 985 && !trigger985Once)
            {
                trigger985Once = true;
                GameMgr.Instance.ShowCele();
            }
        }
        else if (collider.CompareTag("qinghua"))
        {
            AudioSource.PlayClipAtPoint(successCollect, transform.position);
            playScore -= 750;
            playerScoreTMP.text = "Score: " + playScore;
            Destroy(collider.gameObject);
            if (playScore <= -750 && !triggerminus750Once)
            {
                triggerminus750Once = true;
                GameMgr.Instance.ShowCele();
            }
        }
        else if (collider.CompareTag("beida"))
        {
            AudioSource.PlayClipAtPoint(successCollect, transform.position);
            playScore -= 750;
            playerScoreTMP.text = "Score: " + playScore;
            Destroy(collider.gameObject);
            if (playScore <= -1500 && !triggerminus1500nce)
            {
                triggerminus1500nce = true;
                GameMgr.Instance.ShowCele();
            }
        }
    }
}
