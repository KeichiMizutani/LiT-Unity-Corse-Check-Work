# LiT-Unity-Corse-Check-Work
Life is Tech! School にて、Unityコースのチェックワークとして用意したリポジトリです。
### ルール
制限時間30分</br>
教科書、Google等で調べるのOK</br>
5分悩んでも解決できなかったらメンターに質問OK</br>
○-2などは応用になるので飛ばしてOK（できるところから始めよう）</br>
[ここ](https://drive.google.com/file/d/1IEe9Jx5k2KDEtQsYIjfOIFVm5xpep5qt/view?usp=sharing)から素材をダウンロード

### 操作方法
移動：WASD</br>
ジャンプ：スペース

### 1-1: 黄色のアイテムを獲得できるようにしよう
<img width="500" alt="スクリーンショット 2023-06-24 14 42 29" src="https://github.com/KeichiMizutani/LiT-Unity-Corse-Check-Work/assets/32954048/146c50c2-4940-48d6-b034-ce777d1b700f">
</br>

- ヒント
  - `OnTriggerEnter`テクテクストライク②参考
  - ゲームオブジェクトを消すコードは`Destroy( このかっこは中に消したいゲームオブジェクト )`

### 1-2: コンソールに獲得したアイテムの数を表示しよう
<img width="500" alt="スクリーンショット 2023-06-24 16 01 33" src="https://github.com/KeichiMizutani/LiT-Unity-Corse-Check-Work/assets/32954048/adafadc5-c131-4693-b38b-fb092567d7f2">
</br>

- ヒント
  - scoreを管理する変数を作る
  - `Debug.Log`

### 2-1: ジャンプを１回にする
- ヒント
  - `OnCollisionEnter`
  - bool型の変数でif文を作る

### 2-2: 2段ジャンプができるようにする
- ヒント
  - ジャンプの回数を保存する変数を作る

### 3-1: UIでアイテムの獲得数を表示しよう
<img width="500" alt="スクリーンショット 2023-06-24 16 32 58" src="https://github.com/KeichiMizutani/LiT-Unity-Corse-Check-Work/assets/32954048/8deeeb38-3130-4aba-9256-913dabd44a10">

- ヒント
  - アイテムを獲得した回数を保存する変数を作る

### 3-2: UIでゴールまでの距離を表示しよう
<img width="500" alt="スクリーンショット 2023-06-24 16 33 06" src="https://github.com/KeichiMizutani/LiT-Unity-Corse-Check-Work/assets/32954048/8e4fff86-2c37-4c0b-83fd-ab0d892ebe76">



