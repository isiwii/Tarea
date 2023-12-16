using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStatus : MonoBehaviour, IDamageble
{
    public static int health = 5;
    public int maxHealth = 5;

    public int coins = 0;
    public int stars = 0;
    private CharacterController Haru;




    public Transform respawnPoint; // Specific respawn point for the player

    private Vector3 initialPosition; // Initial position of the player

    private void Start()
    {
        if(PlayerData.Load)
        {
            Debug.Log("Please work");
           CoinCollected.coins = PlayerPrefs.GetInt("coins");
          BoxCollected.Boxes = PlayerPrefs.GetInt("boxes");
            PlayerData.Load = false;
        }
        initialPosition = transform.position; // Save the initial position as a respawn point
        Haru = gameObject.GetComponent<CharacterController>();
    }

    public void AddDamage(int damage)
    {
        health -= Mathf.Max(damage, 0);

        if (IsDead())
        {
            Respawn();
        }
    }

    public bool IsDead()
    {
        return health <= 0;
    }

    public void Heal(int heal)
    {
        health += Mathf.Max(heal, 0);
        health = Mathf.Min(health, maxHealth);
    }

    // Method to respawn the player at the specified respawn point or initial position
    private void Respawn()
    {
        if (respawnPoint != null)
        {
            Haru.enabled = false;
            transform.position = respawnPoint.position; // Respawn at the specified point
            Haru.enabled = true;
        }
        else
        {
            transform.position = initialPosition; // If no respawn point set, go to initial position
        }

        health = maxHealth; // Reset health upon respawn
    }
}

public interface IDamageble
{
    void AddDamage(int damage);
    void Heal(int heal);
    bool IsDead();
}
