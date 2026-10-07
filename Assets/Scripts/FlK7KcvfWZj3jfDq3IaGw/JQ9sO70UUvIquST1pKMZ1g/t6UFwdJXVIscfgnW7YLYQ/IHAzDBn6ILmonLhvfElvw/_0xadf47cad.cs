using UnityEngine;
using UnityEngine.UI;

public class _0xadf47cad : MonoBehaviour
{
    public int EndTutorialPanelIndex = 1;
    private void Start()
    {
        if (this.NextTutorialButton != null)
        {
            if (this.IsTutorialEndPanel)
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x7ed5945d.Instance._0xdfd1f132(this.EndTutorialPanelIndex));
                this.NextTutorialButton.onClick.AddListener(() => _0x940c8b68.Instance._0x56ca3645());
            }
            else
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x7ed5945d.Instance._0xdfd1f132(this.NextTutorialPanelIndex));
            }
        }

        if (this.TutorialEndButton != null)
        {
            this.TutorialEndButton.onClick.AddListener(() => _0x7ed5945d.Instance._0xdfd1f132(this.EndTutorialPanelIndex));
            this.TutorialEndButton.onClick.AddListener(() => _0x940c8b68.Instance._0x56ca3645());
        }
    }

    public int NextTutorialPanelIndex;
    public Button NextTutorialButton;
    public Button TutorialEndButton;
    public bool IsTutorialEndPanel;
}