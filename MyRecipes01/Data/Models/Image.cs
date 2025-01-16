namespace MyRecipes01.Data.Models
{
    public class Image
    {
        public Image()
        {
            this.Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }
        public int RecipeId { get; set; }
        public virtual Recipe Recipe { get; set; }
        public string Extension { get; set; }
    }
}
