using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    int count = 5;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform translate for movement
        //transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime,0,0);

        //movement using the physics engine/ rigidbody
        GetComponent<Rigidbody2D>().AddForce(Vector2.right * Input.GetAxis("Horizontal") * speed);

        if(transform.position.y < -14)
        {
            SceneManager.LoadScene(0);
        }


    }
}
