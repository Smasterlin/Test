using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float h;
    float y;
    float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");
        transform.Translate(Vector3.forward *y* speed * Time.deltaTime);
        transform.Translate(Vector3.right *h* speed * Time.deltaTime);

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("×¥µ½ÁË");
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Wall"))
        {
            transform.position = new Vector3(55.7f,0.5f,0);
        }
    }
}
