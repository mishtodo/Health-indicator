using UnityEngine;
using UnityEngine.UI;

public class AddHealthButton : HealthButton
{
    private void OnEnable()
    {
        _button.onClick.AddListener(AddHealth);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(AddHealth);
    }

    public void AddHealth()
    {
        _health.TakeHeal(_healthChangeValue);
    }
}
