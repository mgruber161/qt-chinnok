﻿namespace QTChinnok.MvvMApp.Models
{
    public class Album : ModelObject
    {
        public Album()
        {
        }
        public Album(Logic.Models.App.Album entity)
        {
            Id = entity.Id;
            ArtistId = entity.ArtistId;
            Title = entity.Title;
            ArtistName = entity.Artist?.Name ?? string.Empty;
        }
        public int ArtistId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string ArtistName { get; set; } = string.Empty;
        public override string ToString() => $"{Title} - {ArtistName}";
    }
}
