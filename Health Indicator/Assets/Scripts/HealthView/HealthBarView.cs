public class HealthBarView : HealthViewSlider
{
    public override void UpdateHealth(int currentHealth)
    {
        _healthSlider.value = currentHealth;
    }
}