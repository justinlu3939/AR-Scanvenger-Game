using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DestroyOnGrab : MonoBehaviour
{
    private XRGrabInteractable grabInteractable;

    private void Start()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.selectExited.AddListener(OnSelectExit);
    }

    private void OnSelectExit(SelectExitEventArgs args)
    {
        if (gameObject.CompareTag("Meat"))
        {
            ScoreManager.meatCounter++;
            ScoreManager.scoreCounter += 5;
        }
        else if (gameObject.CompareTag("Avocado"))
        {
            ScoreManager.avCounter++;
            ScoreManager.scoreCounter += 5;
        }
        else if (gameObject.CompareTag("Milk"))
        {
            ScoreManager.milkCounter++;
            ScoreManager.scoreCounter += 5;
        }
        else if (gameObject.CompareTag("Soda"))
        {
            ScoreManager.sodaCounter++;
            ScoreManager.scoreCounter += 5;
        }
        else //anything that doesn't have a label to it is a bad object
        {
            ScoreManager.scoreCounter -= 10;
        }
        // Destroy the game object when released
        Destroy(gameObject);
    }
}