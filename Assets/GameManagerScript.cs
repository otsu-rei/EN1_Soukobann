using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour {

	public GameObject playerPrefub;
	int[,] map;

	// Start is called before the first frame update
	void Start() {

		map = new int[,] {
			{0, 0, 0, 0, 0, },
			{0, 0, 0, 0, 0, },
			{0, 0, 0, 0, 1, },
		};

		PrintArray();

		for (int y = 0; y < map.GetLength(0); ++y) {
			for (int x = 0; x < map.GetLength(1); ++x) {
				if (map[y, x] == 1) {
					GameObject ins = Instantiate(
						playerPrefub,
						new Vector3(x, y),
						Quaternion.identity
					);
				}
			}
		}
	}

	// Update is called once per frame
	void Update() {
		//if (Input.GetKeyDown(KeyCode.RightArrow)) {
		//	int playerIndex = GetPlayerIndex();

		//	MoveNumber(1, playerIndex, playerIndex + 1);
		//	PrintArray();
		//}

		//if (Input.GetKeyDown(KeyCode.LeftArrow)) {
		//	int playerIndex = GetPlayerIndex();

		//	MoveNumber(1, playerIndex, playerIndex - 1);
		//	PrintArray();
		//}
	}

	/// <summary>
	/// map[]��Log�ɏo��
	/// </summary>
	void PrintArray() {
		string debugLog = "";

		for (int y = 0; y < map.GetLength(0); ++y) {
			for (int x = 0; x < map.GetLength(1); ++x) {
				debugLog += map[y, x].ToString() + ",";
			}

			debugLog += "\n";
		}

		Debug.Log(debugLog);
	}

	///// <summary>
	///// map[]��1������ꏊ��T��
	///// </summary>
	///// <returns>1���������Ԓn�̕ԋp</returns>
	//int GetPlayerIndex() {
	//	for (int i = 0; i < map.Length; ++i) {
	//		if (map[i] == 1) {
	//			return i;
	//		}
	//	}

	//	return -1;
	//}

	//bool MoveNumber(int number, int moveFrom, int moveTo) {
	//	if (moveTo < 0 || moveTo >= map.Length) {
	//		return false;
	//	}

	//	if (map[moveTo] == 2) {
	//		int velocity = moveTo - moveFrom;

	//		bool success = MoveNumber(2, moveFrom, moveTo + velocity);
	//		if (!success) {
	//			return false;
	//		}
	//	}

	//	map[moveTo] = number;
	//	map[moveFrom] = 0;

	//	return true;
	//}
}
