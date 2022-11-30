using System.ComponentModel;

namespace QuickMasterRazor.Models
{
    public class Book
    {
        public int Id { get; set; }
        [DisplayName("書名")]
        public string Title { get; set; } = String.Empty;
        [DisplayName("価格")]
        public int Price { get; set; }
        [DisplayName("出版社")]
        public string Publisher { get; set; } = String.Empty;
        [DisplayName("配布サンプル")]
        public bool Sample { get; set; }
    }
}

