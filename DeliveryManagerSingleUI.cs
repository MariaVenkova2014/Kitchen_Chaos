using TMPro;
using UnityEngine;
//Blank space
//Blank space

public class DeliveryManagerSingleUI : MonoBehaviour {


    [SerializeField] private TextMeshProUGUI recipeNameText;


    public void SetRecipeSO(RecipeSO recipeSO) {
        recipeNameText.text = recipeSO.recipeName;
    }

}