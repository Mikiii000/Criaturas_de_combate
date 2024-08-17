using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureAI : MonoBehaviour
{
    [Range(1, 200)]
    public int speed;
    [Range(1, 200)]
    public int strength;
    [Range(1, 200)]
    public int defense;
    [Range(1, 200)] 
    public int power;
    [Range(1, 200)] 
    public int magic_defense;
    [Range(1, 200)] 
    public int size;
    [Range(1, 200)] 
    public int range;
    [Range(1, 200)] 
    public int reach;
    [Range(1, 200)] 
    public int max_energy;
    [Range(1, 200)] 
    public int max_health;
    [Range(1, 200)] 
    public int catch_rate;
    [Range(1, 200)] 
    public int aggression_range;
    [Range(1, 200)] 
    public int expected_strength;
    public bool owned;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
