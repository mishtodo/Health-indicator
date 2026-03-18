using UnityEngine;

public class AddHealthButton : MonoBehaviour
{
    [SerializeField] int _healValue = 20;
    [SerializeField] Health _health;
    [SerializeField] HealthTextView _healthTextView;
    [SerializeField] HealthBarView _healthBarView;
    [SerializeField] HealthBarSmoothView _healthBarSmoothView;

    public void AddHealth()
    {
        _health.Heal(_healValue);
    }
}
