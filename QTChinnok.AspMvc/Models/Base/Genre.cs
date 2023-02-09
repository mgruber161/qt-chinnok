namespace QTChinnok.AspMvc.Models.Base
{
    public class Genre : VersionModel
    {
        public string? Name { get; set; }

        public static Genre Create(Logic.Models.Base.Genre entity)
        {
            return new Genre { Id = entity.Id, Name = entity.Name };
        }
    }
}
