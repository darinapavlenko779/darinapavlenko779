using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x02ec34ee : MonoBehaviour
{
    public bool IsLoadCurrentScene;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public Button Button;
    public int LoadSceneId;
    private void Start()
    {
        if (this.IsLoadCurrentScene)
            this.Button.onClick.AddListener(() =>
            {
                _0x940c8b68.Instance.LoadSceneByIndex(SceneManager.GetActiveScene().buildIndex);
            });
        else
            this.Button.onClick.AddListener(() => _0x940c8b68.Instance.LoadSceneByIndex(this.LoadSceneId));
    }
}