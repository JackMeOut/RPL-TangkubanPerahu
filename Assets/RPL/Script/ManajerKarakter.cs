using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManajerKarakter : MonoBehaviour {

	[SerializeField] GameObject CanvasPilihKarakter;
	[SerializeField] Text TextSTR,TextINT,TextCHA,TextLCK,TextAllocation;
	[SerializeField] int PointSTR,PointINT,PointCHA,PointLCK,PointAlokasi;
	[SerializeField] int MaxSTR,MaxINT,MaxCHA,MaxLCK,MaxPointAlokasi;
	[SerializeField] GameObject CanvasGaBolehRusak;
	bool LagiMaen = false;
	// Use this for initialization
	void Awake () {
		TextSTR.text = PointSTR.ToString ();
		TextINT.text = PointINT.ToString ();
		TextCHA.text = PointCHA.ToString ();
		TextLCK.text = PointLCK.ToString ();
		TextAllocation.text = PointAlokasi.ToString ();
		//DontDestroyOnLoad(this);
	}
	
	// Update is called once per frame
	void Update () {
		if (LagiMaen) {
			MaenYuk ();
		}
	}
	public void MaenYuk(){
		CanvasPilihKarakter.SetActive (false);
		LagiMaen = true;
	}
	public void StrPlus(){
		if (PointAlokasi > 0) {
			if (PointSTR < MaxSTR) {
				PointSTR += 1;
				PointAlokasi -= 1;
				TextSTR.text = PointSTR.ToString ();
				TextAllocation.text = PointAlokasi.ToString ();
			}
		}
	}
	public void IntPlus(){
		if (PointAlokasi > 0) {
			if (PointINT < MaxINT) {
				PointINT += 1;
				PointAlokasi -= 1;
				TextINT.text = PointINT.ToString ();
				TextAllocation.text = PointAlokasi.ToString ();
			}
		}
	}
	public void ChaPlus(){
		if (PointAlokasi > 0) {
			if (PointCHA < MaxCHA) {
				PointCHA += 1;
				PointAlokasi -= 1;
				TextCHA.text = PointCHA.ToString ();
				TextAllocation.text = PointAlokasi.ToString ();
			}
		}
	}
	public void LckPlus(){
		if (PointAlokasi > 0) {
			if (PointLCK < MaxLCK) {
				PointLCK += 1;
				PointAlokasi -= 1;
				TextLCK.text = PointLCK.ToString ();
				TextAllocation.text = PointAlokasi.ToString ();
			}
		}
	}
	public void StrMinus(){
		if (PointAlokasi < MaxPointAlokasi) {
			if (PointSTR > 1) {
				PointSTR -= 1;
				PointAlokasi += 1;
				TextSTR.text = PointSTR.ToString ();
				TextAllocation.text = PointAlokasi.ToString ();
			}
		}
	}
	public void IntMinus(){
		if (PointAlokasi < MaxPointAlokasi) {
			if (PointINT > 1) {
				PointINT -= 1;
				PointAlokasi += 1;
				TextINT.text = PointINT.ToString ();
				TextAllocation.text = PointAlokasi.ToString ();
			}
		}
	}
	public void ChaMinus(){
		if (PointAlokasi < MaxPointAlokasi) {
			if (PointCHA > 1) {
				PointCHA -= 1;
				PointAlokasi += 1;
				TextCHA.text = PointCHA.ToString ();
				TextAllocation.text = PointAlokasi.ToString ();
			}
		}
	}
	public void LckMinus(){
		if (PointAlokasi < MaxPointAlokasi) {
			if (PointLCK > 1) {
				PointLCK -= 1;
				PointAlokasi += 1;
				TextLCK.text = PointLCK.ToString ();
				TextAllocation.text = PointAlokasi.ToString ();
			}
		}
	}
}
