using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public event System.Action<float> OnHealthChange;
    private float _health = 1f;
    public void ApplyDamage(float damage = 0.2f)
    {
        _health -= damage;
        if (OnHealthChange != null)
        {
            OnHealthChange.Invoke(damage);
        }
    }
    public void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.tag == "lava") ApplyDamage();
    }
    public void Again()
    {
        SceneManager.LoadScene("DemoScene");
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
