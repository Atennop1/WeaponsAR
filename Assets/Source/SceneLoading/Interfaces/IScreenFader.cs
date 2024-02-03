using Cysharp.Threading.Tasks;

namespace WeaponsAR.SceneLoading
{
    public interface IScreenFader
    {
        UniTask StartFadeIn();
        UniTask StartFadeOut();
    }
}