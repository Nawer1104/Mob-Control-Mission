using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public GameObject targetPoint;
    public float speed;
    private Rigidbody2D rigidbody;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = targetPoint.transform.position - transform.position;

        rigidbody.MovePosition((Vector2)transform.position + (direction * speed * Time.deltaTime));
    }

    private void FixedUpdate()
    {

    }
}
