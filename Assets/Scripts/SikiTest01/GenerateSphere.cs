using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateSphere : MonoBehaviour
{
    [SerializeField] GameObject spherePre;
    private float randomX;
    private float randomZ;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            randomX = Random.Range(0, 10);
            randomZ = Random.Range(0, 10);
            GameObject go = Instantiate(spherePre,new Vector3(transform.position.x+randomX,0.5f,
               transform.position.z+randomZ),Quaternion.identity);
            go.transform.SetParent(transform);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
