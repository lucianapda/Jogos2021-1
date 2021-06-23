using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider Slider;

    public void SetMaxHealth(float maxHealth)
    {
        if (maxHealth < 0)
            maxHealth = 0;

        Slider.maxValue = maxHealth;
    }

    public void SetHeath(float health)
    {
        if (health < 0)
            health = 0;
        else if (health > 100)
            health = 100;

        Slider.value = health;
    }

    public float CurrentHealth => Slider.value;
}
