using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;

    public void takeDamage(int damage)
    {
        health -= damage;
        print("damage");
    }
}
