using System;

namespace api.Models {
    public class Book {
        public int Id { get; set; }

        public string Author { get; set; }

        public string Title { get; set; }

        public string Subtitle { get; set; } = string.Empty;

        public string Series { get; set; } = string.Empty;

        public int SeriesOrdinal { get; set; } = 1;

        public string FilePath { get; set; }
    }
}