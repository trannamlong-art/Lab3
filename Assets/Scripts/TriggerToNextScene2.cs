using UnityEngine;

public class TriggerToNextScene2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("player") && Player3.totalpoint == 0)
        {
            // Gọi phương thức chuyển sang scene tiếp theo
            Loadscene.ChangeToNextScene();
        }
        
    }
}
