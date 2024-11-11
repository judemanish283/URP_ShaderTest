using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.VFX;

public class UIController : MonoBehaviour
{
    [SerializeField] MeshRenderer swordMeshRenderer;
    [SerializeField] Material GlowMaterial, DefaultMaterial;
    [SerializeField] VisualEffect flameEffect;
    [SerializeField] Button ActivateBtn, DeactivateBtn;
    void Start()
    {
        ActivateBtn.onClick.RemoveAllListeners();
        ActivateBtn.onClick.AddListener(() => ActivateFlameSword());
        DeactivateBtn.onClick.RemoveAllListeners();
        DeactivateBtn.onClick.AddListener(() => DeactivateSword());   
    }

    void ActivateFlameSword()
    {
        swordMeshRenderer.material = GlowMaterial;
        flameEffect.enabled = true;
    }

    void DeactivateSword()
    {
        swordMeshRenderer.material = DefaultMaterial;
        flameEffect.enabled = false;
    }
}
