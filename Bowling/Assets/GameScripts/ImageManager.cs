using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using UnityEngine;
using System.IO;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
public class ImageManager : MonoBehaviour {
	

	// Use this for initialization
	void Start () {
		
	}
	
	public void openfile()
	{
		Debug.Log("open FIle");

//		Texture2D texture = Selection.activeObject as Texture2D;
//		Texture2D texture  = new Texture2D();
//		if (texture == null)
//		{
//			EditorUtility.DisplayDialog("Select Texture", "You must select a texture first!", "OK");
//			return;
//		}
		Image[] b = GetComponents<Image>();
		Debug.Log("Images Lenght"+b.Length);
		string path = EditorUtility.OpenFilePanel("Overwrite with png", "", "png");
		if (path.Length != 0)
		{
//			Sprite a = LoadNewSprite(path);
//			b[0].sprite = a;
//			SaveTextureToFile(a.texture, "texture");
//			Debug.Log(a.ToString());
			
		}

		
//		b[0].sprite = a;
	}
//	public Sprite LoadNewSprite(string FilePath, float PixelsPerUnit = 100.0f) {
   
		// Load a PNG or JPG image from disk to a Texture2D, assign this texture to a new sprite and return its reference
     
//		Sprite NewSprite = new Sprite();
//		Texture2D SpriteTexture = LoadTexture(FilePath);
//		NewSprite = Sprite.Create(SpriteTexture, new Rect(0, 0, SpriteTexture.width, SpriteTexture.height),new Vector2(0,0), PixelsPerUnit);
//		return NewSprite;
//		return new Sprite();
//	}
	public Texture2D LoadTexture(string FilePath) {
 
		
		Texture2D Tex2D;
		byte[] FileData;
 
		if (File.Exists(FilePath)){
			FileData = File.ReadAllBytes(FilePath);
			Tex2D = new Texture2D(2, 2);           // Create new "empty" texture
			if (Tex2D.LoadImage(FileData))           // Load the imagedata into the texture (size is set automatically)
				return Tex2D;                 // If data = readable -> return texture
		}  
		return null;                     // Return null if load failed
	}
	
	void SaveTextureToFile( Texture2D texture , String fileName)
	{	
		
		var bytes= texture.EncodeToPNG();
		string path = Application.dataPath + "/" + fileName;
		var file = File.Open(path, FileMode.OpenOrCreate);
		var binary= new BinaryWriter(file);
		binary.Write(bytes);
		file.Close();
	}
	// Update is called once per frame
	void Update () {
		
	}
}
