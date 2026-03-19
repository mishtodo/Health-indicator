public class DamageButton : HealthButton
{
    private void OnEnable()
    {
        _button.onClick.AddListener(ReduceHealth);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(ReduceHealth);
    }

    public void ReduceHealth()
    {
        _health.TakeDamage(_healthChangeValue);
    }
}