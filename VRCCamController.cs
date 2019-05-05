using UnityEngine;

public class VRCCamController : MonoBehaviour
{

	[SerializeField]
	private Sprite imageSprite;

	[SerializeField]
	[Range(.1f, 10f)]
	private float size = 5f;

	private Transform vrcCamTransform;

	private Camera vrcCam;

	static readonly string vrcCamName = "/VRCCam";

	void SetupCamera()
	{
	}

	void Update()
	{
		if (vrcCamTransform == null)
		{
			var t = transform.Find(vrcCamName);
			vrcCamTransform = t;
			if (t != null)
			{
				transform.SetParent(t);
				transform.localPosition = new Vector3(0f, 0f, 100f);
				transform.localRotation = Quaternion.identity;

				t.localPosition = new Vector3(0f, 0f, -100f);

				vrcCam = t.GetComponent<Camera>();
				vrcCam.orthographic = true;
			}
		}
		else
		{
			vrcCam.orthographicSize = size;
		}
	}

	void Awake()
	{
		var spriteRenderer = gameObject.AddComponent<SpriteRenderer>();	
		spriteRenderer.sprite = imageSprite;
	}

}
