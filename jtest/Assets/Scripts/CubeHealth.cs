using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeHealth : MonoBehaviour
{
    public int Health { get; private set; }
    public bool IsAlive { get; private set; }

	void Start()
    {
        Health = 100;	
	}

    public void Damage(int damage)
    {
        if (damage < 0)
        {
            Debug.LogWarning("Damage can't be less than 0!");
            return;
        }

        Health = (Health - damage) > 0 ? Health -= damage : Health = 0;
        if (Health == 0)
        {
            IsAlive = false;
        }
    }
}
