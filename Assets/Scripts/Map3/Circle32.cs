using UnityEngine;

public class Circle32 : MonoBehaviour
{
    public Transform center;  // Điểm trung tâm xoay quanh
    public float rotationSpeed = 45f; // Tốc độ xoay (độ mỗi giây)
    public float radius = 5f; // Bán kính của vòng tròn

    private float angle = 180f; // Góc hiện tại (tính từ điểm trung tâm)

    void Update()
    {
        // Tính toán góc mới theo thời gian
        angle += rotationSpeed * Time.deltaTime;

        // Đảm bảo góc không vượt quá 360 độ (quay tròn)
        if (angle >= 360f)
        {
            angle -= 360f;
        }

        // Tính toán vị trí mới của vật cản theo công thức xoay vòng tròn
        float x = center.position.x + Mathf.Cos(angle * Mathf.Deg2Rad) * radius;
        float y = center.position.y + Mathf.Sin(angle * Mathf.Deg2Rad) * radius;

        // Cập nhật vị trí của vật cản
        transform.position = new Vector2(x, y);
    }
}