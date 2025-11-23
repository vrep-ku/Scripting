using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monoBehaviourScript : MonoBehaviour
{
    public float speed = 1.2f;
    public int health = 10;
    public int level = 1;
    // Start is called before the first frame update
    void Start()
    {
        
        //Добавляет к переменной health переменную level
        health += level;
        print("Здоровье:" + health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z +=speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
