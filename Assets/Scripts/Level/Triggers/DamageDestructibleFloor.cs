﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDestructibleFloor : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("DestructibleFloor"))
        {
            Destroy(collision.gameObject);
        }

    }
}
