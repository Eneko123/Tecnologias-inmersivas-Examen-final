using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Unity.VisualScripting;

public class PlaneColorPainter : MonoBehaviour
{
    private ARPlaneManager planeManager;
    public Button volverButton;

    void Start()
    {
        planeManager = GetComponent<ARPlaneManager>();
        planeManager.planesChanged += OnPlanosDetectados;
        volverButton.onClick.AddListener(Volver);
    }

    void OnPlanosDetectados(ARPlanesChangedEventArgs args)
    {
        foreach (ARPlane plano in args.added)
            PintarPlano(plano);

        foreach (ARPlane plano in args.updated)
            PintarPlano(plano);
    }

    void PintarPlano(ARPlane plano)
    {
        Renderer r = plano.GetComponentInChildren<Renderer>();
        if (r != null)
            r.material.color = ColorSelector.colorElegido;
    }

    public void Volver()
    {
        SceneManager.LoadScene("Menu");
    }
}
