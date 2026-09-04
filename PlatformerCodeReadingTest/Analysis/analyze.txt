LevelController에서 씬이 시작되면 
각종 오브젝트들의 초기화와 등록을 진행한다.

그 이후 런타임중엔 키 입력과 레벨 클리어, 플레이어 사망과 관련된 로직을 담당한다.

플레이어가 사망하면 HandlePlayerDied에서 _playerLife에게 리스폰 매니저의 스폰 포지션을 넘겨줘 플레이어를 리스폰시킨다.

스코어 매니저에서는 CoinCollectable을 Collect할시 AddScore를 하여 점수를 추가한다.

레벨이 클리어 되면 LevelController에서 CompleteLevel을 실행하며 레벨 타이머와 플레이어의 컨트롤을 멈추고 
State를 Cleared로 바꾼뒤 StateChanged에 등록되어있는 함수들에 State를 인자로 넘겨 실행한다.
