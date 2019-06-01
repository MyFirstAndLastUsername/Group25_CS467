using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour {
    public List<GameObject> Objects = new List<GameObject>(6);
    // Use this for initialization
    void Start () {
        float x, y;
        x = -11f; y = -4f;
        float nextObjects = 2f;
        for (int i = 0; i < 12; ++i)
        {
            for (int j = 0; j < 5; ++j)
            {
                int id_object = Random.Range(0, 6);
                Vector3 scale = new Vector3(5f, 5f, 0);
                Instantiate(Objects[id_object], new Vector3(x + nextObjects * i, y + nextObjects * j, 5), Quaternion.identity);
            }
        }   
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
}
