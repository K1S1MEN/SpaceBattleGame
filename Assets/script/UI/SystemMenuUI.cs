using UnityEngine;
using UnityEngine.EventSystems;
public class SystemMenuUI : MonoBehaviour
{
    [SerializeField] GameObject SystemUI;
    private bool flag = false;
    private void OnMouseEnter()
    {

        Debug.Log("a");
        if (flag)
        {
            SystemUI.SetActive(false);
            flag = false;
        }
        else
        {
            SystemUI.SetActive(true);
            flag = true;
        }

    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        
    }
}
