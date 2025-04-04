using UnityEngine;
using UnityEngine.SceneManagement;

public class Loadscene : MonoBehaviour
{
    // Hàm để chuyển sang scene tiếp theo
    public static void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    // Hàm tự động chuyển sang scene kế tiếp
    public static void ChangeToNextScene()
    {
        // Lấy index của scene hiện tại và cộng thêm 1 để chuyển đến scene kế tiếp
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;

        // Kiểm tra nếu có scene kế tiếp thì chuyển đến
        if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
        else
        {
            Debug.Log("No more scenes available");
        }
    }
}