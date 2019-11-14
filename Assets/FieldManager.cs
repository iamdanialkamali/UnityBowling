using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using Mono.Data.Sqlite;
using System.IO;
using UnityEngine.UI;


public class FieldManager : MonoBehaviour
{	
	
	private IDbConnection dbcon;
	private string connection;
	private IDbCommand cmnd;
	public GameObject go;	
	void Start ()
	{
		
		connection = "URI=file:" + Application.dataPath + "\\gameDB.db";
		using (dbcon = new SqliteConnection(connection))
		{
			dbcon.Open();
			
			IDbCommand cmndRead = dbcon.CreateCommand();
			IDataReader reader;
			string query ="SELECT * FROM profile";
			cmndRead.CommandText = query;
			reader = cmndRead.ExecuteReader();
			reader.Read();
			String id = reader[0].ToString();
			String fname = reader[1].ToString();
			String email = reader[2].ToString();
			String userName = reader[3].ToString();
			string imageSprite = reader[3].ToString();

			Debug.Log("id: " + id);
			Debug.Log("Fname: " + fname);
			Debug.Log("Email: " + email);
			Debug.Log("UserName: " + userName);

			InputField[] a = GetComponentsInChildren<InputField>();
			Image[] imageObject = GetComponentsInChildren<Image>();
			Debug.Log("Image: " + imageObject.Length.ToString());
			
			if (a.Length > 2)
			{
//				Debug.Log("FNAME" + a[0].text);
//				Debug.Log("EMAIL" + a[1].text);
//				Debug.Log("USERNAME" + a[2].text);
				
				a[0].text = reader[1].ToString();
				a[1].text = reader[2].ToString();
				a[2].text = reader[3].ToString();
//				Debug.Log("CHAAAAANGED");
//				Debug.Log("FNAME" + a[0].text);
//				Debug.Log("EMAIL" + a[1].text);
//				Debug.Log("USERNAME" + a[2].text);
			}
			dbcon.Close();
			if(imageObject.Length > 2)
			{
				Sprite NewSprite = new Sprite();
				Texture2D SpriteTexture =
				LoadTexture(Application.dataPath + "\\texture");

				Debug.Log(Application.dataPath); 
				imageObject[imageObject.Length - 1].sprite = Sprite.Create(SpriteTexture,
				new Rect(0, 0, SpriteTexture.width, SpriteTexture.height), new Vector2(0, 0), 100.0f);
			}
		}
		
	}
	
	public Texture2D LoadTexture(string FilePath) {
 
		
		Texture2D Tex2D;
		byte[] FileData;
 
		if (File.Exists(FilePath)){
			FileData = File.ReadAllBytes(FilePath);
			Tex2D = new Texture2D(2, 2);          
			if (Tex2D.LoadImage(FileData))          
				return Tex2D;                 
		}  
		return null;                     
	}
	void Update () {
		
	}
}
