using UnityEngine;

public class ReduceHealthButton : MonoBehaviour
{
    [SerializeField] int _damageValue = 10;
    [SerializeField] Health _health;
    [SerializeField] HealthTextView _healthTextView;
    [SerializeField] HealthBarView _healthBarView;
    [SerializeField] HealthBarSmoothView _healthBarSmoothView;

    public void ReduceHealth()
    {
        _health.TakeDamage(_damageValue);
        _healthTextView.UpdateHealth();
        _healthBarSmoothView.UpdateHealth();
        _healthBarView.UpdateHealth();
    }
}
