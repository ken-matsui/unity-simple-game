using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class ToMainSceneScript : UIBehaviour {

	public void ToMain() {
		base.Start();

		// Buttonクリック時、OnClickメソッドを呼び出す
		GetComponent<Button>().onClick.AddListener(OnClick);
	}

	void OnClick()
	{
		// 「GameScene」シーンに遷移する
		SceneManager.LoadScene("Main");
	}
}
