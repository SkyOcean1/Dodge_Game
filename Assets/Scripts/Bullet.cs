using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Bullet : MonoBehaviour

{
    float speed = 10f;
    Rigidbody bullet_rb;

// Start is called before the first frame update
void Start()
    {
        bullet_rb = GetComponent<Rigidbody>();
        bullet_rb.velocity = transform.forward * speed; //transform은 transform = GetComponent<Transform>(); 의미가 내재되어있음

        Destroy(gameObject, 6f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerController playerController = other.gameObject.GetComponent<PlayerController>();
            if (playerController != null)
            {
                playerController.Die();
            }
        }
        if (other.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }
}
