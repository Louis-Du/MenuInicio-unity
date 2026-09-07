using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonHoverGlow : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject glow; // Arrastra aquí el objeto Image con el sprite Il_Conf

    void Start()
    {
        if (glow != null)
            glow.SetActive(false);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (glow != null)
            glow.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (glow != null)
            glow.SetActive(false);
    }
}