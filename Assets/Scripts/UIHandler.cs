using UnityEngine;
using UnityEngine.UIElements;

public class UIHandler : MonoBehaviour
{
    // provide reference in editor inspector (from step 2)
    public UIDocument UIDocument;
    
    [SerializeField]
    private StartButton mainMenuStartButton;

    public StartButton MainMenuStartButton { get => mainMenuStartButton; set => mainMenuStartButton = value; }

    void Awake()
    {
        var root = UIDocument.rootVisualElement;
        // get ui elements by name
        MainMenuStartButton.StartButtonControl = root.Q<Button>("start-button");

        // add event handler for this class
        MainMenuStartButton.StartButtonControl.clickable.clicked += Button_clicked;

    }

    private void Button_clicked()
    {
        Debug.Log("UIHandler: Start Button Clicked");
    }
}