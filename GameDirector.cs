using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject hpGage;

    public GameObject gameOver;

    // Start is called before the first frame update
    void Start()
    {
        hpGage = GameObject.Find("HitPointGage");
        gameOver.SetActive(false);
    }

    private void Update()
    {
        if (IsGameOver())
        {
            gameOver.SetActive(true);
        }
    }

    public bool IsGameOver()
    {
        if (hpGage.GetComponent<Image>().fillAmount <= 0.0f)
        {
            return true;
        }

        return false;
    }

    public void DecHP()
    {
        hpGage.GetComponent<Image>().fillAmount -= 0.1f;
    }
}
