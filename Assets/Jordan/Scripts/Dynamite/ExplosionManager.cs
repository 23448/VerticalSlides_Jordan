using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionManager : MonoBehaviour
{
    //Making the radius of explosion
    public float explosionRadius = 5.0f;
    public float DetnonationTime = 5.0f;
    public float upForce = 5.0f;
    public GameObject bomb;
    public Vector3 ExplosionDistance;
    public GameObject ParticleSystem;
    public Texture2D ChunkRemover;
    // Use this for initialization
    private void Start()
    {
        ParticleSystem.SetActive(false);
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        DetnonationTime -= Time.deltaTime;
        Dentonate();
    }


    private void Dentonate()
    {

        Collider2D[] colliders = Physics2D.OverlapCircleAll(bomb.transform.position, explosionRadius);
        if (bomb != null)
        {


            if (DetnonationTime < 0)
            {
                ParticleSystem.transform.position = this.transform.position;
                ParticleSystem.SetActive(true);
                Destroy(bomb);
                foreach (Collider2D hit in colliders)
                {


                    Rigidbody2D rb = hit.GetComponent<Rigidbody2D>();

                    if (rb != null && rb != GetComponent<Rigidbody2D>())
                    {
                        rb.AddForce(rb.transform.position + ExplosionDistance * upForce, ForceMode2D.Force);
                    }
                    if (rb.tag == "ground")
                    {
                        
                    }
                }

            }
        }
    }

}
