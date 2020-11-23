using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSLMod.CSLMapView.Modding.UI
{
    /// <summary>
    /// 多言語化対応
    /// </summary>
    internal class Globalization
    {
        internal const string DEFAULT_LANGUAGE = "en";
        private readonly string[] supportedLanguages = new[] { "en", "ja", "zh", "zh-tw", "fr", "es", "ru", "ko", "de", "nl", "pl", "pt" };
        private Dictionary<string, Dictionary<StringKeys, string>> strings;
        /// <summary>
        /// 文字列のキー
        /// </summary>
        internal enum StringKeys
        {
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

            AddTimestampToFileName,

            AutoExportOnSave
        }
        /// <summary>
        /// 現在の言語
        /// </summary>
        internal string Language { get; set; } = DEFAULT_LANGUAGE;
        /// <summary>
        /// コンストラクタ
        /// </summary>
        internal Globalization()
        {
            strings = new Dictionary<string, Dictionary<StringKeys, string>>();

            strings.Add("en", new Dictionary<StringKeys, string>());
            initEn(strings["en"]);
            strings.Add("ja", new Dictionary<StringKeys, string>());
            initJa(strings["ja"]);
            strings.Add("zh", new Dictionary<StringKeys, string>());
            initZh(strings["zh"]);
            strings.Add("zh-tw", new Dictionary<StringKeys, string>());
            initZh(strings["zh-tw"]);
            strings.Add("fr", new Dictionary<StringKeys, string>());
            initFr(strings["fr"]);
            strings.Add("es", new Dictionary<StringKeys, string>());
            initEs(strings["es"]);
            strings.Add("ru", new Dictionary<StringKeys, string>());
            initRu(strings["ru"]);
            strings.Add("ko", new Dictionary<StringKeys, string>());
            initKo(strings["ko"]);
            strings.Add("de", new Dictionary<StringKeys, string>());
            initDe(strings["de"]);
            strings.Add("nl", new Dictionary<StringKeys, string>());
            initNl(strings["nl"]);
            strings.Add("pl", new Dictionary<StringKeys, string>());
            initPl(strings["pl"]);
            strings.Add("pt", new Dictionary<StringKeys, string>());
            initJa(strings["pt"]);
        }
        private void initJa(Dictionary<StringKeys, string> dic)
        {
            dic.Add(StringKeys.Export, "エクスポート");
            dic.Add(StringKeys.ExportAndRun, "エクスポートしてビューアを起動");
            dic.Add(StringKeys.DescLabelExeOutputPath, "ビューアのパス(自動的にインストールされます)");
            dic.Add(StringKeys.DescLabelCslmapOutputPath, "マップファイル(*.cslmap)の出力先");
            dic.Add(StringKeys.FailedToExportMap, "エクスポートに失敗しました。");
            dic.Add(StringKeys.FailedToCopyFile, "ファイルのコピーに失敗しました。");
            dic.Add(StringKeys.NotInGame, "ゲームを開始してから実行してください。");
            dic.Add(StringKeys.FailedToRunViewer, $"{CSLMapView.VIEWER_EXE}の起動に失敗しました。");
            dic.Add(StringKeys.Compress, ".cslmapファイルの圧縮 (*.cslmap.gzを出力します)");
            dic.Add(StringKeys.AddTimestampToFileName, "ファイル名にタイムスタンプを付与");
            dic.Add(StringKeys.AutoExportOnSave, "ゲームセーブ時に自動エクスポート");
        }
        private void initEn(Dictionary<StringKeys, string> dic)
        {
            dic.Add(StringKeys.Export, "Export");
            dic.Add(StringKeys.ExportAndRun, "Export and Run viewer");
            dic.Add(StringKeys.DescLabelExeOutputPath, "Viewer app path (will be automatically installed)");
            dic.Add(StringKeys.DescLabelCslmapOutputPath, "Map file(*.cslmap) output path");
            dic.Add(StringKeys.FailedToExportMap, "Failed to export map.");
            dic.Add(StringKeys.FailedToCopyFile, "Failed to copy files.");
            dic.Add(StringKeys.NotInGame, "Map is not loaded.");
            dic.Add(StringKeys.FailedToRunViewer, $"Failed to run {CSLMapView.VIEWER_EXE}");
            dic.Add(StringKeys.Compress, "Compress .cslmap (outputs *.cslmap.gz)");
            dic.Add(StringKeys.AddTimestampToFileName, "Add timestamp to file name");
            dic.Add(StringKeys.AutoExportOnSave, "Auto export on saving game");
        }
        private void initZh(Dictionary<StringKeys, string> dic)
        {
            dic.Add(StringKeys.Export, "輸出");
            dic.Add(StringKeys.ExportAndRun, "輸出后開啟");
            dic.Add(StringKeys.DescLabelExeOutputPath, "檢視器程式將會複製到以下路徑");
            dic.Add(StringKeys.DescLabelCslmapOutputPath, "地圖文件（*.cslmap）將會複製到以下路徑");
            dic.Add(StringKeys.FailedToExportMap, "輸出失敗");
            dic.Add(StringKeys.FailedToCopyFile, "複製文件失敗");
            dic.Add(StringKeys.NotInGame, "未開啟任何一個游戲存檔");
            dic.Add(StringKeys.FailedToRunViewer, $"啟動{CSLMapView.VIEWER_EXE}失敗");
            dic.Add(StringKeys.Compress, "壓縮 .cslmap (輸出 *.cslmap.gz)");
            dic.Add(StringKeys.AddTimestampToFileName, "增加時間標記至檔案名");
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
        private void initEs(Dictionary<StringKeys, string> dic)
        {
            dic.Add(StringKeys.Export, "Exportar");
            dic.Add(StringKeys.ExportAndRun, "Exportar y ejecutar CSLMapView");
            dic.Add(StringKeys.DescLabelExeOutputPath, "Ruta a la aplicación CSLMapView (se instalará automáticamente)");
            dic.Add(StringKeys.DescLabelCslmapOutputPath, "Ruta de salida del archivo de mapa (*.cslmap)");
            dic.Add(StringKeys.FailedToExportMap, "No se pudo exportar el mapa.");
            dic.Add(StringKeys.FailedToCopyFile, "No se pudo copiar archivos.");
            dic.Add(StringKeys.NotInGame, "El mapa no está cargado.");
            dic.Add(StringKeys.FailedToRunViewer, $"Fallo al ejecutar {CSLMapView.VIEWER_EXE}");
            dic.Add(StringKeys.Compress, "Comprimir .cslmap (salida *.cslmap.gz)");
            dic.Add(StringKeys.AddTimestampToFileName, "Agregar marca de tiempo al nombre del archivo");
            dic.Add(StringKeys.AutoExportOnSave, "Exportación automática al guardar el juego");
        }
        private void initRu(Dictionary<StringKeys, string> dic)
        {
            dic.Add(StringKeys.Export, "Экспорт");
            dic.Add(StringKeys.ExportAndRun, "Экспорт и запуск CSLMapView");
            dic.Add(StringKeys.DescLabelExeOutputPath, "Папка просмотрщика CSLMapView (устанавливается автоматически)");
            dic.Add(StringKeys.DescLabelCslmapOutputPath, "Папка сохранения файла карты (*.cslmap)");
            dic.Add(StringKeys.FailedToExportMap, "Не удалось экспортировать карту.");
            dic.Add(StringKeys.FailedToCopyFile, "Не удалось скопировать файлы.");
            dic.Add(StringKeys.NotInGame, "Карта не загружена.");
            dic.Add(StringKeys.FailedToRunViewer, $"Не удалось запустить {CSLMapView.VIEWER_EXE}");
            dic.Add(StringKeys.Compress, "Архивировать .cslmap (в *.cslmap.gz)");
            dic.Add(StringKeys.AddTimestampToFileName, "Добавить временную метку в имя файла");
            dic.Add(StringKeys.AutoExportOnSave, "Автоэкспорт при сохранении игры");
        }
        private void initKo(Dictionary<StringKeys, string> dic)
        {
            dic.Add(StringKeys.Export, "내보내기");
            dic.Add(StringKeys.ExportAndRun, "내보내고 뷰어 실행");
            dic.Add(StringKeys.DescLabelExeOutputPath, "뷰어 앱 경로 (자동 설치 경로)");
            dic.Add(StringKeys.DescLabelCslmapOutputPath, "맵 파일(*.cslmap) 출력 경로");
            dic.Add(StringKeys.FailedToExportMap, "맵을 내보내는데 실패했습니다.");
            dic.Add(StringKeys.FailedToCopyFile, "파일을 복사하는데 실패했습니다.");
            dic.Add(StringKeys.NotInGame, "게임을 불러오고 나서 다시 실행해주세요.");
            dic.Add(StringKeys.FailedToRunViewer, $"{CSLMapView.VIEWER_EXE}를 실행하는데 실패했습니다.");
            dic.Add(StringKeys.Compress, ".cslmap 파일을 압축 (출력은 *.cslmap.gz)");
            dic.Add(StringKeys.AddTimestampToFileName, "파일 이름에 타임스태프 추가");
            dic.Add(StringKeys.AutoExportOnSave, "게임 저장시 자동으로 내보내기");

        }
        private void initDe(Dictionary<StringKeys, string> dic)
        {
            dic.Add(StringKeys.Export, "Karte exportieren");
            dic.Add(StringKeys.ExportAndRun, "Exportieren und CSLMapView starten");
            dic.Add(StringKeys.DescLabelExeOutputPath, "Verzeichnis der CSLMapView Anwendung (wird automatisch installiert)");
            dic.Add(StringKeys.DescLabelCslmapOutputPath, "Verzeichnis der Kartendatei (*.cslmap)");
            dic.Add(StringKeys.FailedToExportMap, "Der Export der Karte ist leider fehlgeschlagen.");
            dic.Add(StringKeys.FailedToCopyFile, "Das Kopieren der Dateien ist leider fehlgeschlagen.");
            dic.Add(StringKeys.NotInGame, "Die Karte wurde nicht gefunden.");
            dic.Add(StringKeys.FailedToRunViewer, $"{CSLMapView.VIEWER_EXE} lässt sich nicht starten.");
            dic.Add(StringKeys.Compress, ".cslmap komprimieren (Ausgabe *.cslmap.gz)");
            dic.Add(StringKeys.AddTimestampToFileName, "Datum und Uhrzeit dem Dateinamen hinzufügen");

        }
        private void initNl(Dictionary<StringKeys, string> dic)
        {
            dic.Add(StringKeys.Export, "Kaart exporteren");
            dic.Add(StringKeys.ExportAndRun, "Exporteren en CSLMapView starten");
            dic.Add(StringKeys.DescLabelExeOutputPath, "Directory van de CSLMapView-applicatie (wordt automatisch geïnstalleerd)");
            dic.Add(StringKeys.DescLabelCslmapOutputPath, "Directory van de kaartgegevens (*.cslmap)");
            dic.Add(StringKeys.FailedToExportMap, "De kaart kon niet geëxporteerd worden.");
            dic.Add(StringKeys.FailedToCopyFile, "Het kopiëren van het gegeven is mislukt.");
            dic.Add(StringKeys.NotInGame, "De kaart kon niet gevonden worden.");
            dic.Add(StringKeys.FailedToRunViewer, $"{CSLMapView.VIEWER_EXE} kan niet opstarten.");
            dic.Add(StringKeys.Compress, ".cslmap comprimeren (Opdracht *.cslmap.gz)");
            dic.Add(StringKeys.AddTimestampToFileName, "Datum en tijd aan de bestandsnaam toevoegen");

        }
        private void initPl(Dictionary<StringKeys, string> dic)
        {
            dic.Add(StringKeys.Export, "Eksportuj");
            dic.Add(StringKeys.ExportAndRun, "Eksportuj i Uruchom CSLMapView");
            dic.Add(StringKeys.DescLabelExeOutputPath, "Ścieżka programu CSLMapView (Zostanie automatycznie zainstalowana)");
            dic.Add(StringKeys.DescLabelCslmapOutputPath, "Ścieżka map (Rozszerzenie *.cslmap)");
            dic.Add(StringKeys.FailedToExportMap, "Eksport mapy zakończony niepowodzeniem.");
            dic.Add(StringKeys.FailedToCopyFile, "Kopiowanie plików zakończone niepowodzeniem.");
            dic.Add(StringKeys.NotInGame, "Wejdź do gry by załadować program.");
            dic.Add(StringKeys.FailedToRunViewer, $"Nie udało się uruchomić programu {CSLMapView.VIEWER_EXE} ");
            dic.Add(StringKeys.Compress, "Kompresuj mapy .cslmap (Nazwa po kompresji: *.cslmap.gz)");
            dic.Add(StringKeys.AddTimestampToFileName, "Dodaj sygnaturę czasową do nazwy pliku.");
            dic.Add(StringKeys.AutoExportOnSave, "Eksportuj automatycznie podczas zapisu.");

        }
        private void initPt(Dictionary<StringKeys, string> dic)
        {
            dic.Add(StringKeys.Export, "Exportar");
            dic.Add(StringKeys.ExportAndRun, "Exportar e executar visualizador");
            dic.Add(StringKeys.DescLabelExeOutputPath, "Caminho do aplicativo de visualização (será instalado automaticamente)");
            dic.Add(StringKeys.DescLabelCslmapOutputPath, "Caminho de saída do arquivo de mapa (*.cslmap)");
            dic.Add(StringKeys.FailedToExportMap, "Falha ao exportar mapa.");
            dic.Add(StringKeys.FailedToCopyFile, "Falha ao copiar arquivos.");
            dic.Add(StringKeys.NotInGame, "Mapa não carregado.");
            dic.Add(StringKeys.FailedToRunViewer, $"Falha ao executar {CSLMapView.VIEWER_EXE}");
            dic.Add(StringKeys.Compress, "Comprimir .cslmap (outputs *.cslmap.gz)");
            dic.Add(StringKeys.AddTimestampToFileName, "Adicionar marca de tempo ao nome do arquivo");
            dic.Add(StringKeys.AutoExportOnSave, "Exportação automática ao salvar o jogo");
        }
        /// <summary>
        /// デフォルト言語での文字列を取得します。
        /// </summary>
        /// <param name="key">文字列キー</param>
        /// <returns></returns>
        internal string GetString(StringKeys key)
        {
            return GetString(Language, key);
        }

        /// <summary>
        /// 指定した言語での文字列を取得します。
        /// </summary>
        /// <param name="lang">言語(en,ja)</param>
        /// <param name="key">文字列キー</param>
        /// <returns></returns>
        internal string GetString(string lang, StringKeys key)
        {
            if (!supportedLanguages.Contains(lang))
            {
                lang = DEFAULT_LANGUAGE;
            }
            Dictionary<StringKeys, string> dic = strings[lang];
            if (dic.ContainsKey(key))
            {
                return dic[key];
            }
            else
            {
                if (lang == DEFAULT_LANGUAGE)
                {
                    return null;
                }
                return GetString(DEFAULT_LANGUAGE, key);
            }
        }
    }
}
