namespace Exercise01 {
    public class Program {
        static void Main(string[] args) {
            //歌データを入れるリストオブジェクトを生成
            var songs = new List<Song>();
            //曲の登録出力
            Console.WriteLine("***** 曲の登録 *****");
            //何件入力があるかわからないので無限ループ
            while (true) {
                //曲名を出力
                Console.Write("曲名：");
                //入力された曲名を取得
                string title = Console.ReadLine();
                //endが入力されたら登録終了
                if (title.Equals("end", StringComparison.OrdinalIgnoreCase))
                    break;
                //アーティスト名出力 
                Console.Write("アーティスト名：");
                //入力されたアーティスト名を取得
                string artistName = Console.ReadLine();
                //演奏時間秒を出力
                Console.Write("演奏時間（秒）：");
                //入力された演奏時間を取得
                int length = int.Parse(Console.ReadLine());
                //Songインスタンスを生成
                var song = new Song() {
                    Title = title,
                    ArtistName = artistName,
                    Length = length
                };
                //歌データを入れるリストオブジェクトへ登録
                songs.Add(song);
                Console.WriteLine(); // 改行
            }

            // 入力が終わったら一覧を表示
            PrintSongs(songs.ToArray());
        }

        private static void PrintSongs(Song[] songs) {
            foreach (var song in songs) {
                var time = TimeSpan.FromSeconds(song.Length);
                Console.WriteLine($"{song.Title}, {song.ArtistName}, {time.Minutes}:{time.Seconds:00}");
            }
        }
    }
}