using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    private GameObject collectable;
    void Update()
    {
        if (gameObject.CompareTag("Player"))
        {
            gameObject.SetActive(false);
        }
    }
}
