/*
 * Created by: Jason Alfrey
 * Created date: 1/31/2022
 * Last edited by: Jason Alfrey
 * Last edited date: 1/31/2022
 * 
 * Description: Controls tree movement and apple spawning.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    public GameObject applePrefab;
    public float speed = 10f;
    public float leftAndRightEdge = 25.35f;
    public float chanceToChangeDirections = 0.02f;
    public float secondsBetweenAppleDrops = 1f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DropApple", 2f);
    }
    void DropApple()
    {
        GameObject apple = Instantiate<GameObject>(applePrefab);
        apple.transform.position = transform.position;
        Invoke("DropApple", secondsBetweenAppleDrops);
    }

    // Update is called once per frame
    void Update()
    {
        // Create movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);
        }
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed);
        } else if(Random.value < chanceToChangeDirections)
        {
            speed *= -1;
        }
}
    private void FixedUpdate()
    {
        // Create movo
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);
        }
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed);
        }
        else if (Random.value < chanceToChangeDirections)
        {
            speed *= -1;
        }
    }
}
