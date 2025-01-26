using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble_Spawner : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> bubbleReference;

    private GameObject spawnedBubble;

    public GameObject bubble1;

    [SerializeField]
    private Transform pos1, pos2, pos3, pos4;

    public float minSpeed;
    public float maxSpeed;

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

            randomIndex = Random.Range(0, bubbleReference.Count);
            randomPos = Random.Range(0, 4);

            spawnedBubble = Instantiate(bubbleReference[randomIndex]); // creates copy of game object
            spawnedBubble.tag = "Bubble clone";

            // pos 1
            if (randomPos == 0)
            {
                spawnedBubble.transform.position = pos1.position;
                spawnedBubble.GetComponent<Dream_Bubble>().speed = Random.Range(minSpeed, maxSpeed);

            }
            else if (randomPos == 1)
            {
                //pos 2
                spawnedBubble.transform.position = pos2.position;
                spawnedBubble.GetComponent<Dream_Bubble>().speed = Random.Range(minSpeed, maxSpeed);
            }
            else if (randomPos == 2)
            {
                //pos 3
                spawnedBubble.transform.position = pos3.position;
                spawnedBubble.GetComponent<Dream_Bubble>().speed = Random.Range(minSpeed, maxSpeed);
            }
            else if (randomPos == 3)
            {
                //pos 4
                spawnedBubble.transform.position = pos4.position;
                spawnedBubble.GetComponent<Dream_Bubble>().speed = Random.Range(minSpeed, maxSpeed);
            }

        } // while loop
    }

    // checks if bubbleReference array is empty => Instantiates bubble object when empty
    private void AddBubbleReference()
    {   
        // empty array case
        if (bubbleReference.Count == 0)
        {
            Instantiate(bubble1, new Vector3(0, 0, 0), Quaternion.identity);
            //bubbleReference.Add(bubble1);
        }
    }
    

    // Update is called once per frame
    void Update()
    {
        AddBubbleReference();
        
    }

    // if object is spawned bubble (bubble clone) we destroy it


} // class
