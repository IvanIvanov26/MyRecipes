using static System.Net.Mime.MediaTypeNames;

namespace MyRecipes01.Data.Models
{
    public class Recipe
    {
        public Recipe()
        {
            this.Images = new HashSet<Image>();
            this.Ingredients = new HashSet<RecipeIngredient>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Instructions { get; set; }
        public TimeSpan PreparationTime { get; set; }
        public TimeSpan CookingTime { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<RecipeIngredient> Ingredients { get; set; }

    }
}
