using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb2D;
    [SerializeField] float fumpForce = 5f;
    [SerializeField] ForceMode2D forceMode;
    [SerializeField] bool onGround=true;
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        transform.position += new Vector3(x * 10f, 0, 0) * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space) && onGround)
        {
            rb2D.AddForce(Vector2.up * fumpForce, forceMode);
            onGround = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Ground"))
        {
            onGround = true;
        }
    }
}
