using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    float spawn = 1.0f;
    float delta = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("GameDirector").GetComponent<GameDirector>().IsGameOver())
        {
            return;
        }

        delta += Time.deltaTime;
        if (delta > spawn)
        {
            delta = 0;
            GameObject p = Instantiate(arrowPrefab);
            int px = Random.Range(-6, 7);

            p.transform.position = new Vector3(px, 7);
        }
    }
}
