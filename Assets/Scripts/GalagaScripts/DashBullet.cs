using UnityEngine;

public class DashBullet : MonoBehaviour
{
    public float speed = 6f;

    public bool rightSide;
    // Update is called once per frame

    void Start()
    {
        if (transform.position.x > 0)
        {
            rightSide = true;
        }

        if (transform.position.x < 0)
        {
            rightSide = false;
        }
    }
    void Update()
    {
        if (rightSide == true)
        {
            transform.Translate(-transform.right * speed * Time.deltaTime);
        }

        if (rightSide == false)
        {
            transform.Translate(transform.right * speed * Time.deltaTime);
        }

        if (transform.position.x < -9)
        {
            Destroy(gameObject);
        }

        if (transform.position.x > 9)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("GalagaPlayer"))
        {
            Destroy(gameObject);
        }
    }
}
