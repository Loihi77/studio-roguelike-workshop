using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;

public class Entity : MonoBehaviour
{
    private void Start()
    {
        CurrentHealth = stats.MaxHealth;
    }
    [Serializable]
    public class EntityStats
    {
        public float MovementSpeed;
        public float MaxHealth;
    }
    public void TakeDamage(float damage)
    {
        CurrentHealth -= Mathf.Ceil(damage);
        if (CurrentHealth <= 0)
        {
            Die();
        }
    }
    private void Die()
    {
        dead = true;
        Destroy(gameObject);
    }
    [NonSerialized]
    public float CurrentHealth;
    bool dead = false;

    public EntityStats stats;
}