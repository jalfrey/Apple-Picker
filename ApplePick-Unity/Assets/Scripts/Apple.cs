/*
 * Created by: Jason Alfrey
 * Created date: 1/31/2022
 * Last edited by: Jason Alfrey
 * Last edited date: 1/31/2022
 * 
 * Description: Apple despawn logic 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public static float bottomY = -20f;
 
    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < bottomY)
        {
            Destroy(this.gameObject);

            GameObject gm = GameObject.Find("GameManager");
            ApplePicker aScript = Camera.main.GetComponent<ApplePicker>();
            aScript.AppleDestroyed();
        }
    }
}
