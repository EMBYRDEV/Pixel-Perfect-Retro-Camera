using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class PixelCamera : MonoBehaviour {
	public int referenceHeight = 180;
	public int pixelsPerUnit = 32;

	private int renderWidth;
	private int renderHeight;
	private int actualWidth;
	private int actualHeight;
	
	private Camera cam;

	void Awake () {
		cam = GetComponent<Camera>();
	}

	void Update() {
		/*
			Orthographic size is half of reference resolution since it is measured
			from center to the top of the screen. We subtract 1 from the reference
			resolution to add a 1px border on the top and bottom to prevent shimmering 
			issue when blitting back to screen.
		*/
		
		renderHeight = referenceHeight - 2;
		cam.orthographicSize = (renderHeight / 2) / (float)pixelsPerUnit;
		
		int scale = Screen.height / renderHeight;
		
		// Height is snapped to the closest whole multiple of reference height.
		actualHeight = (int)(renderHeight * scale);
		
		/*
			Width isn't snapped like height is and will fill the entire width of 
			the monitor using the scale determined by the height. We subtract 2 from
			the render width to add a 1px border to the sides to prevent shimmering 
			issue when blitting back to screen.
		*/
		renderWidth = (int)(Screen.width / scale) - 2;			
		actualWidth = (int)(renderWidth * scale);

		Rect rect = cam.rect;
		
		rect.width = (float)actualWidth / Screen.width;
		rect.height = (float)actualHeight / Screen.height;
		
		rect.x = (1 - rect.width) / 2;
		rect.y = (1 - rect.height) / 2;

		cam.rect = rect;
	}
	
	void OnRenderImage(RenderTexture source, RenderTexture destination) {
		RenderTexture buffer = RenderTexture.GetTemporary(renderWidth, renderHeight, -1);
		
		buffer.filterMode = FilterMode.Point;
		source.filterMode = FilterMode.Point;
		
		Graphics.Blit(source, buffer);
		Graphics.Blit(buffer, destination);
		
		RenderTexture.ReleaseTemporary(buffer);
	}
}