using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble_Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] bubbleReference;

    private GameObject spawnedBubble;

    [SerializeField]
    private Transform pos1, pos2;

    private int randomIndex;
    private int randomPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnBubbles());
    }

    IEnumerator SpawnBubbles()
    {
        while (true) {
            yield return new WaitForSeconds(Random.Range(1, 5));

            randomIndex = Random.Range(0, bubbleReference.Length);
            randomPos = Random.Range(0, 2);

            spawnedBubble = Instantiate(bubbleReference[randomIndex]); // creates copy of game object

            // pos 1
            if (randomPos == 0)
            {
                spawnedBubble.transform.position = pos1.position;
                spawnedBubble.GetComponent<Dream_Bubble>().speed = Random.Range(4, 10);

            }
            else
            {
                //pos 2
                spawnedBubble.transform.position = pos2.position;
                spawnedBubble.GetComponent<Dream_Bubble>().speed = Random.Range(4, 10);
            }
        } // while loop
    }



    // Update is called once per frame
    /*void Update()
    {
        
    }
    */


} // class
