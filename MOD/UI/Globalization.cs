using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSLMod.CSLMapView.Modding.UI {
    /// <summary>
    /// 多言語化対応
    /// </summary>
    internal class Globalization {
        internal const string DEFAULT_LANGUAGE = "en";
        private readonly string[] supportedLanguages = new[] { "en","ja" };
        private Dictionary<string,Dictionary<string, string>> strings;
        /// <summary>
        /// 文字列のキー
        /// </summary>
        internal static class Keys {
            /// <summary>
            /// エクスポート
            /// </summary>
            internal const string Export = "Export";
            /// <summary>
            /// エクスポートしてビューアを起動
            /// </summary>
            internal const string ExportAndRun = "ExportAndRun";
            /// <summary>
            /// 説明ラベル1のテキスト
            /// </summary>
            internal const string DescLabel1 = "DescLabel1";
            /// <summary>
            /// エクスポートに失敗しました。
            /// </summary>
            internal const string FailedToExportMap = "FailedToExportMap";
            /// <summary>
            /// ファイルのコピーに失敗しました。
            /// </summary>
            internal const string FailedToCopyFile = "FailedToCopyFile";
            /// <summary>
            /// ゲームを開始してから実行してください。
            /// </summary>
            internal const string NotInGame = "NotInGame";
            /// <summary>
            /// exeの起動に失敗しました。
            /// </summary>
            internal const string FailedToRunViewer = "FailedToRunViewer";

            internal const string Compress = "Compress";
        }
        /// <summary>
        /// 現在の言語
        /// </summary>
        internal string Language { get; set; } = DEFAULT_LANGUAGE;
        /// <summary>
        /// コンストラクタ
        /// </summary>
        internal Globalization( ) {
            strings = new Dictionary<string, Dictionary<string, string>>();
            
            strings.Add( "en", new Dictionary<string, string>() );
            initEn( strings["en"] );
            strings.Add( "ja", new Dictionary<string, string>() );
            initJa( strings["ja"] );
        }
        private void initJa(Dictionary<string,string> dic) {
            dic.Add( Keys.Export, "エクスポート" );
            dic.Add( Keys.ExportAndRun, "エクスポートしてビューアを起動" );
            dic.Add( Keys.DescLabel1, "マップファイル(*.cslmap)とビューアの出力先：" );
            dic.Add( Keys.FailedToExportMap, "エクスポートに失敗しました。" );
            dic.Add( Keys.FailedToCopyFile, "ファイルのコピーに失敗しました。" );
            dic.Add( Keys.NotInGame, "ゲームを開始してから実行してください。" );
            dic.Add( Keys.FailedToRunViewer, $"{CSLMapView.VIEWER_EXE}の起動に失敗しました。" );
            dic.Add( Keys.Compress, ".cslmapファイルの圧縮 (*.cslmap.gzを出力します)" );
        }
        private void initEn(Dictionary<string,string> dic ) {
            dic.Add( Keys.Export, "Export" );
            dic.Add( Keys.ExportAndRun, "Export and Run viewer" );
            dic.Add( Keys.DescLabel1, "Map file(*.cslmap) and the viewer will be copied to" );
            dic.Add( Keys.FailedToExportMap, "Failed to export map." );
            dic.Add( Keys.FailedToCopyFile, "Failed to copy files." );
            dic.Add( Keys.NotInGame, "Map is not loaded." );
            dic.Add( Keys.FailedToRunViewer, $"Failed to run {CSLMapView.VIEWER_EXE}" );
            dic.Add( Keys.Compress, "Compress .cslmap (outputs *.cslmap.gz)" );
        }

        /// <summary>
        /// デフォルト言語での文字列を取得します。
        /// </summary>
        /// <param name="key">文字列キー</param>
        /// <returns></returns>
        internal string GetString(string key ) {
            return GetString( Language, key );
        }

        /// <summary>
        /// 指定した言語での文字列を取得します。
        /// </summary>
        /// <param name="lang">言語(en,ja)</param>
        /// <param name="key">文字列キー</param>
        /// <returns></returns>
        internal string GetString(string lang, string key ) {
            if(!supportedLanguages.Contains( lang )) {
                lang = DEFAULT_LANGUAGE;
            }
            Dictionary<string, string> dic = strings[lang];
            if(dic.ContainsKey( key )) {
                return dic[key];
            }else {
                if( lang == DEFAULT_LANGUAGE) {
                    return null;
                }
                return GetString( DEFAULT_LANGUAGE, key );
            }
        }
    }
}
