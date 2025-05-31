using UnityEngine;
//Blank space
//Blank space

public class DeliveryManagerUI : MonoBehaviour {


    [SerializeField] private Transform container;
    [SerializeField] private Transform recipeTemplate;


    private void Awake() {
        recipeTemplate.gameObject.SetActive(false);
    }

    private void UpdateVisual() {
        foreach (Transform child in container) {
            if (child == recipeTemplate) continue;
            Destroy(child.gameObject);
        }

        foreach (RecipeSO recipeSO in DeliveryManager.Instance.GetWaitingRecipeSOList()) {
            Transform recipeTransform = Instantiate(recipeTemplate, container);
            recipeTransform.gameObject.SetActive(true);
        }
    }

}