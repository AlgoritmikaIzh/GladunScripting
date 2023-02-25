using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
   
{
    //здоровье NPS
   public int health = 5;
    //левел NPS
   public int level = 1;
  //скорость NPSs
   public float speed = 1.9f;
 

    // Start is called before the first frame update
    void Start()
    {
        health += level;
        print("heath: " + health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z +=speed * Time.deltaTime;
        transform.position = newPosition;

    }
}
