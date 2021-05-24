using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletspawn : MonoBehaviour
{
    public GameObject bulletObj;
    public GameObject enemyobject;
    public float bulletspeed;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("AsteroidGeneration", 1f, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            BulletMovement(Vector3.forward);
        }
    }
    private void BulletMovement(Vector3 direction)
    {
        GameObject bulletGeneratedRef = Instantiate(bulletObj);
        bulletGeneratedRef.transform.position = transform.position;
        Rigidbody rb = bulletGeneratedRef.GetComponent<Rigidbody>();
        Camera camera = GetComponentInChildren<Camera>();
        rb.velocity = camera.transform.rotation * Vector3.forward * bulletspeed;
    }
    void AsteroidGeneration()
    {
        int z = Random.Range(3, 6);
        int x = Random.Range(-4, 4);
        Instantiate(enemyobject, transform.position + new Vector3(x, 0, z), transform.rotation);
    }

}
