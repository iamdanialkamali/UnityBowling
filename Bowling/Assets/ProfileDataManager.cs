using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
//using Mono.Data.Sqlite;
//using System.IO;
using UnityEngine.UI;



public class ProfileDataManager : MonoBehaviour

{	
//	private IDbConnection dbcon;
//	private string connection;
//	private IDbCommand cmnd;
//	
//	public InputField a;
//	private string id = "0";
////	private string fname = String.Empty;
////	private string userName = String.Empty;
////	private string email = String.Empty;
////	private string image = String.Empty;
//	
//	void Start ()
//	{
//
////		InputField[] b = GetComponents<InputField>();
////		Debug.Log("WTFFFFFFFFFFFFFFFFFFFFF:"+b.Length.ToString());
////		connection = "URI=file:" + "C:\\Users\\iamdanialkamali\\Documents\\GameClassTask1\\Assets" + "\\game.db";
////		Debug.Log("id: " + connection);
////
////		dbcon = new SqliteConnection(connection);
////		dbcon.Open();
//
////		IDbCommand cmndRead = dbcon.CreateCommand();
////		IDataReader reader;
////		string query ="SELECT * FROM profile";
////		cmndRead.CommandText = query;
////		reader = cmndRead.ExecuteReader();
////		reader.Read();
////		
////		Debug.Log("id: " + reader[0]);
////		Debug.Log("Fname: " + reader[1]);
////		Debug.Log("Email: " + reader[2]);
////		Debug.Log("UserName: " + reader[3]);
////		Debug.Log("Image: " + reader[4]);
//
////		dbcon.Close();
//
//	}
//
//	public void updateNameValue(String input)
//	{
//		updateDatabase("Fname",a.text);
//	}
//	
//	public void updateEmailValue(String input)
//	{
//		// Insert values in table
//		updateDatabase("Email",a.text);
//
//	}
//	
//	public void updateUserNameValue(String input)
//	{	
//		updateDatabase("UserName",a.text);
//	}
//	
//	public void updateImageAddressValue(String input)
//	{
//		updateDatabase("Image",a.text);
//	}
//
//	public void updateDatabase(String field,String value)
//	{
//		connection = "URI=file:" +Application.dataPath + "\\gameDB.db";
//
//		using (dbcon = new SqliteConnection(connection))
//		{
//			dbcon.Open();
//			
//			if (value == String.Empty)
//			{
//				value = "X";
//			}
//			Debug.Log("field: " + field);
//			Debug.Log("value: " + value);
//		
//	
//			cmnd = dbcon.CreateCommand();
//			cmnd.CommandText = "UPDATE profile SET  " + field +"=\"" + value + "\" where id = 0";
//			Debug.Log("value: " + cmnd.CommandText.ToString());
//
//			cmnd.ExecuteNonQuery();
//
//			
//			dbcon.Close();
//			
//		}
//		
//
//		
//	}
//	
}
		


//		IDbCommand cmndRead = dbcon.CreateCommand();
//		IDataReader reader;
//		string query ="SELECT * FROM profile";
//		cmndRead.CommandText = query;
//		reader = cmndRead.ExecuteReader();
//		reader.Read();
//
//
//		Debug.Log("id: " + reader[0]);
//		Debug.Log("Fname: " + reader[1]);
//		Debug.Log("Email: " + reader[2]);
//		Debug.Log("UserName: " + reader[3]);
//		Debug.Log("Image: " + reader[4]);


//		cmnd = dbcon.CreateCommand();
//		string qCreateTable = "CREATE TABLE IF NOT EXISTS profile (id INTEGER PRIMARY KEY, Fname VARCHAR ,Email VARCHAR ,UserName VARCHAR ,image VARCHAR )";
//		
//		cmnd.CommandText = qCreateTable;
//		cmnd.ExecuteReader();

//		id = reader[0].ToString();
//		fname = reader[1].ToString();
//		email = reader[2].ToString();
//		userName = reader[3].ToString();
//		image = reader[4].ToString();
		
//		Debug.Log("id: " + id);
//		Debug.Log("Fname: " + fname);
//		Debug.Log("Email: " + email);
//		Debug.Log("UserName: " + userName);
//		Debug.Log("Image: " + image);


// Create table
//		cmnd = dbcon.CreateCommand();
//		string qCreateTable = "CREATE TABLE IF NOT EXISTS profile (id INTEGER PRIMARY KEY, Fname VARCHAR ,Email VARCHAR ,UserName VARCHAR ,image VARCHAR )";
//		
//		cmnd.CommandText = qCreateTable;
//		cmnd.ExecuteReader();
