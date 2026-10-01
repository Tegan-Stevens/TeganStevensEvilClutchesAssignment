using UnityEngine;

public class DropperMovement : MonoBehaviour
{
    public float speed = 5;
    public bool goingRight = true;

    private float fireFallTimer = 3;

    private float fireFallWait = 0;

    public GameObject fireFall;
    // Update is called once per frame
    void Update()
    {
        fireFallTimer += Time.deltaTime;
        transform.Translate(transform.right * speed * Time.deltaTime);
        if (transform.position.x > 4.5f && goingRight == true)
        {
            goingRight = false;
            speed *= -1;
        }
        if (transform.position.x < -7.5f && goingRight == false)
        {
            goingRight = true;
            speed *= -1;
        }

        if (fireFallTimer > fireFallWait)
        {
            Instantiate(fireFall, transform.position, Quaternion.identity);
            fireFallTimer = 0;
            fireFallWait = Random.Range(1.5f, 2.5f);
        }
    }
}
