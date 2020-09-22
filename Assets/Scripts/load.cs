using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class load : MonoBehaviour
{
    public GameObject capsule;
    public GameObject coin;

    void Start()
    {
        Instantiate(capsule, new Vector3(3, 1, -4), Quaternion.identity);
        Instantiate(capsule, new Vector3(-4, 1, -4), Quaternion.identity);
        Instantiate(capsule, new Vector3(22, 1, 4), Quaternion.identity);
        Instantiate(capsule, new Vector3(29, 1, 4), Quaternion.identity);

        Instantiate(coin, new Vector3(22, 1, -5), Quaternion.identity);
        Instantiate(coin, new Vector3(29, 1, -5), Quaternion.identity);
        Instantiate(coin, new Vector3(4, 1, 4), Quaternion.identity);
        Instantiate(coin, new Vector3(-4, 1, 4), Quaternion.identity);
    }

}
