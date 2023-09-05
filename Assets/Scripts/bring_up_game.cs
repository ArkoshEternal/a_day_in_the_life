using UnityEngine;
using UnityEngine.UI;

public class ScreenSwitcher : MonoBehaviour
{
    public GameObject mini_map;
    public GameObject game_screen;
    public Button switchButton;
    public bool is_game_screen_active;

    private void Start()
    {
        // Initialize game screen to be off 
        switchButton.onClick.AddListener(ToggleScreens);
        game_screen.SetActive(false); 
        is_game_screen_active = false; 

        // Attach the button click event to the ToggleScreens method
        
    }

    private void ToggleScreens()
    {
        // Toggle the visibility of the screens
        is_game_screen_active = !is_game_screen_active;

        // Toggle the y position based on the active state
        if (is_game_screen_active)
        {
            game_screen.SetActive(true);
            // method to move the minimap
            mini_map.transform.position = new Vector3(-4.47f, 2.49f, 0f); 
           
        }
        else
        {
            game_screen.SetActive(false); 
            // method to move the mini-map back
            mini_map.transform.position = new Vector3(4.59f, -1.73f, 0); 
        }
    }

}
