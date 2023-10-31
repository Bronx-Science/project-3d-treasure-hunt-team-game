using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public GameBehavior gameManager;
    public static float speed = 20.0f;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameBehavior>();
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 8, moveVertical);
        rb.AddForce(movement * speed);
    }
    // Collision detection using tag
    void OnCollisionEnter(Collision Other)
    {
        if (Other.gameObject.CompareTag("Pick Up"))
        {
            Other.gameObject.SetActive(false);
            gameManager.Items += 1;
        }
    }
}
