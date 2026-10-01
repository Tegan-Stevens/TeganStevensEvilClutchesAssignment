using UnityEngine;

public class FallingFire : MonoBehaviour
{
    public float speed = 5;

    public int points = -100;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(-transform.up * speed * Time.deltaTime);
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }

       
    }
}
