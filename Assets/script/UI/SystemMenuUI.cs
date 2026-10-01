using UnityEngine;
using UnityEngine.EventSystems;

public class ImageHover : MonoBehaviour
{
    [SerializeField] GameObject systemUI;
    bool flag = false;
    public void OpenUI()
    {
        if (flag)
        {
            systemUI.SetActive(false);
            flag = false;
        }
        else
        {
            systemUI.SetActive(true);
            flag = true;
        }
    }
}