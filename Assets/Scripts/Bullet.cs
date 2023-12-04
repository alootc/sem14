using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;

    private AudioSource audioSource;

    public float force;
    public AudioClip clipExplosion; 

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();

        rb.velocity = Vector2.up * force;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Limites")
        {
            Destroy(this.gameObject);
        }

        if (collision.gameObject.tag == "Enemigo")
        {
            Destroy(collision.gameObject);

            audioSource.Play();
            rb.velocity = Vector2.zero;
            anim.SetBool("iscollision", true);
            Destroy(this.gameObject, 0.5f);

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
