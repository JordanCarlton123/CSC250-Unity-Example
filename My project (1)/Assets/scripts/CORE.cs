using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class COREScript : MonoBehaviour
{
    public Transform enemy;
    public Transform spawnPoint;

    public static void display()
    {
        print("Woot");
    }

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(enemy, spawnPoint.position, Quaternion.idnentity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
