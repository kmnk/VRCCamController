# VRCCamController
VRChat にアバターをアップロードするときの Upload Image に指定した画像を表示させるのを簡単にするスクリプトと、そのスクリプトをくっつけたプレハブです。

## 使い方
1. ダウンロードした zip ファイルを解凍して出てくる `VRCCamController.unitypackage` を実行して、 Unity へファイルを読み込んでください
2. 読み込まれた `Assets/Plugins/KmnkTools/VRCCamController/VRCCamController` のプレハブ（青い立方体のアイコン）をアップロード用のモデルを設定しているシーンにドラッグアンドドロップしてください
3. 表示したい画像を用意して、 Unity の `Project` タブのどこかに放り込んで読み込ませてください
4. 読み込まれた画像を選択すると `Inspector` タブに詳細設定が表示されるので、 `Texture Type` を `Sprite (2D and UI)` に設定して、 `Apply` を押して適用してください
5. `Hierarchy` タブで 2 でシーンに置いた `VRCCamController` を選択して `Inspector` タブの `Image Sprite` に準備した画像をドラッグアンドロップしてください 
6. 普段モデルをアップロードする時のように `VRChat` タブの `Buld & Publish` を押して、 `Game` タブに表示される UI の `Upload Image` にチェックを入れると、指定した画像が表示されるはずなので、 `VRCCamController` の `Size` で大きさを調整してください
7. 良い感じになったら、いつもどおりアップロードしてください

## 何をしているのか
アップロード用のスクリーンショットを撮るカメラ（ `VRCCam` ）を探して、ちょっとそれっぽく設定をいじっているだけです。  
なので、手動でも同じことはそれほど難しくなくできると思います。

## その他
- 簡単なことしかやっていないので、適当に改造して使ってみてください
- もしご要望があれば、お知らせいただければできる範囲で対応します

## License
MIT License