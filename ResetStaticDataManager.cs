using UnityEngine;
//Blank space
//Blank space

public class ResetStaticDataManager : MonoBehaviour {


    private void Awake() {
        CuttingCounter.ResetStaticData();
        BaseCounter.ResetStaticData();
        TrashCounter.ResetStaticData();
    }

}