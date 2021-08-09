using UnityEngine;
using Unity​Engine.UIElements;


public class UIHandler : MonoBehaviour
{
    // provide reference in editor inspector (from step 2)
    public UIDocument UIDocument;
    Button button;
    Label label;
    TextField textField;
    void Start()
    {
        var root = UIDocument.rootVisualElement;
        // get ui elements by name
        button = root.Q<Button>("start-button");

        // add event handler
        button.clickable.clicked += Button_clicked;
    }

    private void Button_clicked()
    {
        Debug.Log("Start Button Clicked");
        gameObject.SetActive(false);
    }
}