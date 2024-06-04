using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("GameDirector").GetComponent<GameDirector>().IsGameOver())
        {
            Destroy(gameObject);
        }
    }

    public void OnClickButtonL()
    {
        transform.Translate(-3, 0, 0);
    }

    public void OnClickButtonR()
    {
        transform.Translate(3, 0, 0);
    }
}
