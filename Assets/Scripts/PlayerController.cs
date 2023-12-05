using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    float speed = 15.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); // 리지드바디 컴포넌트를 PlayerController컴포넌트로 드래그앤 드롭으로 직접 할당하지 않고 코드로 할당하여 해결
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxisRaw("Horizontal");
        float zInput = Input.GetAxisRaw("Vertical");

        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);

       rb.velocity = newVelocity;
    }

    public void Die()
    {
        gameObject.SetActive(false); //오브젝트를 없애는게 아닌 비활성화

        GameManager manager = FindObjectOfType<GameManager>();
        manager.EndGame();
    }
}
