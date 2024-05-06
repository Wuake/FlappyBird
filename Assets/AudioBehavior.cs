using UnityEngine;
using UnityEngine.UI;

public class MuteButton : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private Sprite _muteSprite;
    [SerializeField] private Sprite _unmuteSprite;
    [SerializeField] private Image _buttonImage;

    private void Start()
    {
        _buttonImage = GetComponent<Image>();
        UpdateButtonImage();
    }

    public void OnClick()
    {
        _audioSource.mute = !_audioSource.mute;
        UpdateButtonImage();
    }

    private void UpdateButtonImage()
    {
        _buttonImage.sprite = _audioSource.mute ? _muteSprite : _unmuteSprite;
    }
}
