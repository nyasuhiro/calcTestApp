# Xamarin.Formsで電卓アプリ作成メモ
* Xamarin.Formsで何か作ってみたい。  
なんとなく簡単そうだと思った電卓アプリを作ることを試みる。  
ここにいろいろトラブった際のメモをのこす。(READMEとは...)  

* markdownにも慣れるために、いろいろ試行錯誤しながらメモメモ
markdownの基本的な記述は下記を参照にしました。  
<http://yuji-ueda.hatenadiary.jp/entry/2014/05/03/002659>

### Xamarin.Formプロジェクト新規作成！

* Xamarin.Formsのプロジェクトを作成し、画面に文字列を表示させるだけのアプリを作成することから始める。  
<http://dev.classmethod.jp/smartphone/xamarin-forms-page/>

* 試しにiOSシミュレータでビルドしたらいきなりエラー発生。  
↓エラー内容
> /Library/Frameworks/Mono.framework/External/xbuild/Xamarin/iOS/Xamarin.iOS.Common.targets: Error: Error executing task Codesign: Required property 'SigningKey' not set. (calcTestApp.iOS)  

  色々ググったら、どうやらXcodeのアップデート後に、signin identitiesとやらをしないといけないらしい。
  <http://qiita.com/ryohee/items/dd76fc389335e06a605b>

* 設定後にビルドを実行したところ、無事にビルド成功。  
とりあえず第一歩は踏み出せたかな。。。

* ページ遷移のサンプルアプリまで作成。  
  次はボタンを配置して、クリックしたら値をとってくるのを目標にしようかな。

### 数字ボタン配置！
* １〜９のボタンを配置して、押したボタンの値を下に表示することに成功
* GridLayoutなるものは下記リンクで勉強
<http://dev.classmethod.jp/smartphone/xamarin-forms-layout/>  
<http://iscene.jimdo.com/2016/06/08/xamarin-froms-grid/>

* Fontのサイズとかはここ
<https://developer.xamarin.com/guides/xamarin-forms/user-interface/text/fonts/>

* 次は演算処理かなあ


### 演算ボタン作成！
* 足し算、引き算、掛け算、割り算ができるようになりました。
