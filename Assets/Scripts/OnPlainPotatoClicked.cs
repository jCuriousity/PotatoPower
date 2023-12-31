using UnityEngine;
using UnityEngine.EventSystems;

public class OnPlainPotatoClicked : MonoBehaviour, IPointerDownHandler
{
    // Start is called before the first frame update
    [SerializeField]
    protected ScoreHandler scoreHandler;
    private SpriteRenderer spriteRenderer;
    [SerializeField]
    private ParticleSystem smoke;
    public AudioClip musicToPlay;
    private AudioSource audioSource;

    private bool isClickable = true;
    private GlobalGameData gameData = GlobalGameData.Instance;
    protected float random = 0;
    public void OnPointerDown(PointerEventData eventData)
    {
        if (!isClickable) return;
        spriteRenderer.enabled = false;
        smoke.Play();
        isClickable = false;

        audioSource = GetComponent<AudioSource>();
        audioSource.clip = musicToPlay;
        audioSource.loop = false;
        audioSource.Play();

        CustomPointerDown();
    }

    public virtual void CustomPointerDown()
    {
        scoreHandler.ScoreChange(gameData.weapon.CalculateScoreChange());

        Time.timeScale = gameData.gameSpeed;

        



    }

    protected virtual void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        smoke = GetComponent<ParticleSystem>();
        smoke.Stop();
        scoreHandler = Object.FindObjectOfType<ScoreHandler>();
        
        
        
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        if (this.transform.position.y < -6)
        {
            Destroy(this.gameObject);

        }

        random = Mathf.Round(Random.Range(1, 100));
    }




}
