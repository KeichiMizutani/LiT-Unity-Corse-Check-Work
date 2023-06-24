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
  - 衝突した相手を消すコードを書きましょう。
  - `OnTriggerEnter`もしくは`OnCollisionEnter`を使う。テクテクストライク②を参考
  - ゲームオブジェクトを消すコードは`Destroy( このかっこは中に消したいゲームオブジェクト )`

### 1-2: コンソールに獲得したアイテムの数を表示しよう
<img width="500" alt="スクリーンショット 2023-06-24 16 01 33" src="https://github.com/KeichiMizutani/LiT-Unity-Corse-Check-Work/assets/32954048/adafadc5-c131-4693-b38b-fb092567d7f2">
</br>

- ヒント
  - アイテムを獲得した個数を保存する変数を作って、`Debug.Log`でコンソールに表示しよう。

### 2-1: ジャンプを１回にする
- ヒント
  - int型の整数でジャンプした回数を保存する変数を作ろう
  - `OnCollisionEnter`でPlayerが着地した時にジャンプした回数を0にリセットしよう。
  - ジャンプした回数によってジャンプできるか否かのif文を作って、ジャンプを１回だけできるようにしよう。

### 2-2: 2段ジャンプができるようにする
- ヒント
  - ジャンプの回数を保存する変数とif文でジャンプ回数が0または1回なら...

### 3-1: UIでアイテムの獲得数を表示しよう
<img width="500" alt="スクリーンショット 2023-06-24 16 32 58" src="https://github.com/KeichiMizutani/LiT-Unity-Corse-Check-Work/assets/32954048/8deeeb38-3130-4aba-9256-913dabd44a10">

- ヒント
  - アイテムを獲得した個数を保存する変数を使おう。
  - Canvasを使ってUIを作ろう。
  - UIの教科書を参考に、`Text.text`を使ってUIを更新しよう。

### 3-2: UIでゴールまでの距離を表示しよう
<img width="500" alt="スクリーンショット 2023-06-24 16 33 06" src="https://github.com/KeichiMizutani/LiT-Unity-Corse-Check-Work/assets/32954048/8e4fff86-2c37-4c0b-83fd-ab0d892ebe76">

- ヒント
  - ゴールまでの距離を保存する変数を用意しよう。
  - Canvasを使ってUIを作ろう。
  - UIの教科書を参考に、`Text.text`を使ってUIを更新しよう。



