using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractiveCube : MonoBehaviour
{
    public Color miColor;

    private void Awake()
    {
        ColorSelector colorSelector = FindObjectOfType<ColorSelector>();
        if (colorSelector != null && colorSelector.botonPanel != null)
        {
            colorSelector.cargarEscenaButton.onClick.AddListener(IrASiguienteEscena);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("MainCamera"))
        {
            ColorSelector.colorElegido = miColor;
            ColorSelector colorSelector = FindObjectOfType<ColorSelector>();
            if (colorSelector != null && colorSelector.botonPanel != null)
            {
                colorSelector.botonPanel.SetActive(true);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("MainCamera"))
        {
            ColorSelector colorSelector = FindObjectOfType<ColorSelector>();
            if (colorSelector != null && colorSelector.botonPanel != null)
            {
                colorSelector.botonPanel.SetActive(false);
            }
        }
    }

    public void IrASiguienteEscena()
    {
        SceneManager.LoadScene("Planos");
    }
}
