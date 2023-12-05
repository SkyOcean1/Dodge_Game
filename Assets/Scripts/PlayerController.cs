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
        rb = GetComponent<Rigidbody>(); // ������ٵ� ������Ʈ�� PlayerController������Ʈ�� �巡�׾� ������� ���� �Ҵ����� �ʰ� �ڵ�� �Ҵ��Ͽ� �ذ�
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
        gameObject.SetActive(false); //������Ʈ�� ���ִ°� �ƴ� ��Ȱ��ȭ

        GameManager manager = FindObjectOfType<GameManager>();
        manager.EndGame();
    }
}
