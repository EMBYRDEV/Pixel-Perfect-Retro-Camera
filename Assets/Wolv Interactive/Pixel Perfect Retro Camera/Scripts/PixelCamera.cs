using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class PixelCamera : MonoBehaviour {
	public int referenceHeight = 180;

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
			Orthographic size is half of reverence resolution since it is measured
			from center to the top of the screen. We subtract 1 from the reference
			resolution to prevent a bug that causes horizontal shimering when the
			reference height is an exact multiple of sme common resolutions.
			
			For example 180 is a perfect multiple of 720 and causes issues when 
			rendering at 1280x720. Same issue present at 1920x1080. Oddle enough 
			this can be solved by increasing the horizontal resolution enough
			even though the issue should only be tied to the verticle resolution...
			
			I may revisit this in the future but for now we get some artsy *cinematic*
			black bars on the top and bottom and it seems to fix the issue; at least 
			as long as people stick to sane values... they could just ruin everything 
			again by setting scale to something like 181.
		*/
		cam.orthographicSize = (referenceHeight - 1) / 2;
		
		renderHeight = (int)(cam.orthographicSize * 2);
		int scale = Screen.height / renderHeight;
		
		// Height is snapped to the closest whole multiple of reference height.
		actualHeight = (int)(renderHeight * scale);
		
		// Width isn't locked to the pixel grid and will fill the entire width of the monitor.
		renderWidth = (int)(Screen.width / scale);			
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