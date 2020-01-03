using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

	private GameModel _gameModel = new GameModel();
	private BallModel _ballModel = new BallModel();
	private BallPresenter _ballPresenter ;
	public GameConfig gameConfig;
	private CylinderManager _cylinderManager;
	public GameObject gameCamera;
	public GameObject mainCamera;

	void Start()
	{

		GameObject ball = GameObject.Find("Ball");
		_ballModel.setup(ball);
		_ballPresenter = ball.GetComponent<BallPresenter>();
		_ballPresenter.setup(_ballModel);
		_cylinderManager = GameObject.Find("Cylinders").GetComponent<CylinderManager>();


	}

	void Update()
	{
		stopManager();
		if (_ballPresenter.isFalling())
		{
			_cylinderManager.countFellDowns();
			_ballPresenter.resetPosition();
			
		}

		if (_cylinderManager.isFinish())
		{
			GameObject cv = Instantiate(gameConfig.cylinderPrefab);
			_cylinderManager = cv.GetComponent<CylinderManager>();

		}

	}

	void stopManager()
	{
		if (Input.GetKeyDown(KeyCode.Q))
		{
			if (_gameModel.isStoped())
			{
				gameCamera.SetActive(true);
				mainCamera.SetActive(false);
				_gameModel.stopGame();
			}
			else
			{
				gameCamera.SetActive(false);
				mainCamera.SetActive(true);
				_gameModel.resumeGame();

			}
		}
	}
}
	


