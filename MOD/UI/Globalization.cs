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
        private readonly string[] supportedLanguages = new[] { "en", "ja", "zh", "zh-tw", "fr" };
        private Dictionary<string, Dictionary<StringKeys, string>> strings;
        /// <summary>
        /// 文字列のキー
        /// </summary>
        internal enum StringKeys {
            /// <summary>
            /// エクスポート
            /// </summary>
            Export,
            /// <summary>
            /// エクスポートしてビューアを起動
            /// </summary>
            ExportAndRun,
            /// <summary>
            /// 説明ラベル1のテキスト
            /// </summary>
            DescLabelExeOutputPath,
            DescLabelCslmapOutputPath,
            /// <summary>
            /// エクスポートに失敗しました。
            /// </summary>
            FailedToExportMap,
            /// <summary>
            /// ファイルのコピーに失敗しました。
            /// </summary>
            FailedToCopyFile,
            /// <summary>
            /// ゲームを開始してから実行してください。
            /// </summary>
            NotInGame,
            /// <summary>
            /// exeの起動に失敗しました。
            /// </summary>
            FailedToRunViewer,

            Compress,

            AddTimestampToFileName
        }
        /// <summary>
        /// 現在の言語
        /// </summary>
        internal string Language { get; set; } = DEFAULT_LANGUAGE;
        /// <summary>
        /// コンストラクタ
        /// </summary>
        internal Globalization() {
            strings = new Dictionary<string, Dictionary<StringKeys, string>>();

            strings.Add( "en", new Dictionary<StringKeys, string>() );
            initEn( strings["en"] );
            strings.Add( "ja", new Dictionary<StringKeys, string>() );
            initJa( strings["ja"] );
            strings.Add( "zh", new Dictionary<StringKeys, string>() );
            initZh( strings["zh"] );
            strings.Add( "zh-tw", new Dictionary<StringKeys, string>() );
            initZh( strings["zh-tw"] );
            strings.Add("fr", new Dictionary<StringKeys, string>());
            initFr(strings["fr"]);
        }
        private void initJa( Dictionary<StringKeys, string> dic ) {
            dic.Add( StringKeys.Export, "エクスポート" );
            dic.Add( StringKeys.ExportAndRun, "エクスポートしてビューアを起動" );
            dic.Add( StringKeys.DescLabelExeOutputPath, "ビューアのパス(自動的にインストールされます)" );
            dic.Add( StringKeys.DescLabelCslmapOutputPath, "マップファイル(*.cslmap)の出力先" );
            dic.Add( StringKeys.FailedToExportMap, "エクスポートに失敗しました。" );
            dic.Add( StringKeys.FailedToCopyFile, "ファイルのコピーに失敗しました。" );
            dic.Add( StringKeys.NotInGame, "ゲームを開始してから実行してください。" );
            dic.Add( StringKeys.FailedToRunViewer, $"{CSLMapView.VIEWER_EXE}の起動に失敗しました。" );
            dic.Add( StringKeys.Compress, ".cslmapファイルの圧縮 (*.cslmap.gzを出力します)" );
            dic.Add( StringKeys.AddTimestampToFileName, "ファイル名にタイムスタンプを付与" );
        }
        private void initEn( Dictionary<StringKeys, string> dic ) {
            dic.Add( StringKeys.Export, "Export" );
            dic.Add( StringKeys.ExportAndRun, "Export and Run viewer" );
            dic.Add( StringKeys.DescLabelExeOutputPath, "Viewer app path (will be automatically installed)" );
            dic.Add( StringKeys.DescLabelCslmapOutputPath, "Map file(*.cslmap) output path" );
            dic.Add( StringKeys.FailedToExportMap, "Failed to export map." );
            dic.Add( StringKeys.FailedToCopyFile, "Failed to copy files." );
            dic.Add( StringKeys.NotInGame, "Map is not loaded." );
            dic.Add( StringKeys.FailedToRunViewer, $"Failed to run {CSLMapView.VIEWER_EXE}" );
            dic.Add( StringKeys.Compress, "Compress .cslmap (outputs *.cslmap.gz)" );
            dic.Add( StringKeys.AddTimestampToFileName, "Add timestamp to file name" );
        }
        private void initZh( Dictionary<StringKeys, string> dic ) {
            dic.Add( StringKeys.Export, "輸出" );
            dic.Add( StringKeys.ExportAndRun, "輸出后開啟" );
            dic.Add( StringKeys.DescLabelExeOutputPath, "檢視器程式將會複製到以下路徑" );
            dic.Add( StringKeys.DescLabelCslmapOutputPath, "地圖文件（*.cslmap）將會複製到以下路徑" );
            dic.Add( StringKeys.FailedToExportMap, "輸出失敗" );
            dic.Add( StringKeys.FailedToCopyFile, "複製文件失敗" );
            dic.Add( StringKeys.NotInGame, "未開啟任何一個游戲存檔" );
            dic.Add( StringKeys.FailedToRunViewer, $"啟動{CSLMapView.VIEWER_EXE}失敗" );
            dic.Add( StringKeys.Compress, "壓縮 .cslmap (輸出 *.cslmap.gz)" );
        }
        private void initFr(Dictionary<StringKeys, string> dic)
        {
            dic.Add(StringKeys.Export, "Exporter");
            dic.Add(StringKeys.ExportAndRun, "Exporter et lancer CSLMapView");
            dic.Add(StringKeys.DescLabelExeOutputPath, "Chemin vers l'application CSLMapView (sera installé automatiquement)");
            dic.Add(StringKeys.DescLabelCslmapOutputPath, "Chemin de sortie du fichier de la carte (*.cslmap)");
            dic.Add(StringKeys.FailedToExportMap, "L'export de la carte a échoué.");
            dic.Add(StringKeys.FailedToCopyFile, "La copie des fichiers a échoué.");
            dic.Add(StringKeys.NotInGame, "Carte introuvable.");
            dic.Add(StringKeys.FailedToRunViewer, $"Le lancement de {CSLMapView.VIEWER_EXE} a échoué.");
            dic.Add(StringKeys.Compress, "Compresser .cslmap (sortie *.cslmap.gz)");
            dic.Add(StringKeys.AddTimestampToFileName, "Ajouter un timestamp au nom du fichier");
        }
        /// <summary>
        /// デフォルト言語での文字列を取得します。
        /// </summary>
        /// <param name="key">文字列キー</param>
        /// <returns></returns>
        internal string GetString( StringKeys key ) {
            return GetString( Language, key );
        }

        /// <summary>
        /// 指定した言語での文字列を取得します。
        /// </summary>
        /// <param name="lang">言語(en,ja)</param>
        /// <param name="key">文字列キー</param>
        /// <returns></returns>
        internal string GetString( string lang, StringKeys key ) {
            if( !supportedLanguages.Contains( lang ) ) {
                lang = DEFAULT_LANGUAGE;
            }
            Dictionary<StringKeys, string> dic = strings[lang];
            if( dic.ContainsKey( key ) ) {
                return dic[key];
            } else {
                if( lang == DEFAULT_LANGUAGE ) {
                    return null;
                }
                return GetString( DEFAULT_LANGUAGE, key );
            }
        }
    }
}
