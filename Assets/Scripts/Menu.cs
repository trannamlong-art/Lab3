using UnityEngine;
using UnityEngine.UIElements;

public class Menu : MonoBehaviour
{
    private void OnEnable()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        Button Play = root.Q<Button>("Play");
        Play.clicked += () => Loadscene.ChangeToNextScene();
    }
}