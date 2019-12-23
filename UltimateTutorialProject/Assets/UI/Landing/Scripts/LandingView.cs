using UnityEngine;
using UnityEngine.UIElements;
using Unity.UIElements.Runtime;

namespace com.stansassets.ut
{
    public class LandingView : MonoBehaviour
    {
        [SerializeField] private PanelRenderer m_PanelRenderer = null;

        private void Start()
        {
            Debug.Log("Start");
            var root = m_PanelRenderer.panel.visualTree;
            root.Query<Button>().ForEach(button =>
            {
                Debug.Log(button);
            });
        }
    }
}


