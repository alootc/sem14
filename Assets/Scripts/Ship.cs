using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rb;
    private Vector2 dir;
    public float directionX;


    private AudioSource audioSource;

    public float speed;

    public GameObject prefabBullet;
    public AudioClip clip;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
         float x = Input.GetAxis("Horizontal");
         float y = Input.GetAxis("Vertical");

        dir = new Vector2(x, y); // se mueve ambos ejes

        if (Input.GetKeyDown(KeyCode.Space))
        {
        audioSource.PlayOneShot(clip);
        Instantiate(prefabBullet, transform.position, Quaternion.identity);
        }  
    }

    private void FixedUpdate()
    {
        rb.velocity = dir * speed;

    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Pared")
        {
            directionX = directionX * -1;
        }
    }
}
