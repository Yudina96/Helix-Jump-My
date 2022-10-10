
using UnityEngine;

public class Finish : MonoBehaviour
{
    public GameObject effect;

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(effect, transform.position, Quaternion.identity);
        if (!collision.collider.TryGetComponent(out Player player)) return;
        player.ReachFinish();
    }
}
