namespace Section01 {
    internal class Program {
        static void Main(string[] args) {

            var books = Books.GetBooks();

            //①本の平均金額を表示
            Console.WriteLine((int)books.Average(x => x.Price));

            //②ほんのページ合計を表示
            Console.WriteLine((int)books.Sum(x => x.Price));

            //③金額の安い書籍名
            var bookmin = books.Where(x => x.Price == books.Min(b => b.Price)).First();
            Console.WriteLine(bookmin.Title + "：" + bookmin.Price);

            //④ページが多い書籍名とページ数を表示
            books.Where(x => x.Pages == books
                        .Max(b => b.Pages)).ToList()
                        .ForEach(x => Console.WriteLine($"{x.Title} : {x.Pages}ページ"));


            //⑤タイトルに「物語」が含まれている書籍名をすべて表示
            var titles = books.Where(book => book.Title.Contains("物語"));
            foreach (var item in titles) {
                Console.WriteLine(item.Title);
            }
            
        }
    }
}
