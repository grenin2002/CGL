using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySelfDestruct : MonoBehaviour
{
    [SerializeField] float deathTime = 5f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, deathTime);
    }
}
