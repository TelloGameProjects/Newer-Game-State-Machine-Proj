using System;
using UnityEngine;
using Unity​Engine.UIElements;


public class UIHandler : MonoBehaviour
{
    // provide reference in editor inspector (from step 2)
    public UIDocument UIDocument;
    Button menuButton;
    Action onMenuButtonClick;

    public Action OnButtonClick { get => onMenuButtonClick; set => onMenuButtonClick = value; }

    void Start()
    {
        var root = UIDocument.rootVisualElement;
        // get ui elements by name
        menuButton = root.Q<Button>("start-button");

        // add event handler
        menuButton.clickable.clicked += ButtonClicked;
    }

    private void ButtonClicked()
    {
        OnButtonClick?.Invoke();
    }
}