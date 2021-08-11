using UnityEngine;
using UnityEngine.UIElements;

public class UIHandler : MonoBehaviour
{
    public UIDocument UIDocument;
    
    private Button mainMenuStartButton;

    [SerializeField] private GameEvent startButtonClickEvent;

    public Button MainMenuStartButton { get => mainMenuStartButton; set => mainMenuStartButton = value; }

    void Start()
    {
        var root = UIDocument.rootVisualElement;
        // get ui elements by name
        MainMenuStartButton = root.Q<Button>("start-button");

        // add event handler for this class
        MainMenuStartButton.clickable.clicked += Button_clicked;

    }

    private void Button_clicked()
    {
        startButtonClickEvent.Raise();
    }
}