namespace WebAPI.Models
{
    /// <summary>
    /// The name.
    /// </summary>
    public class Name
    {
        public string First { get; set; }

        public string Last { get; set; }

        public string Middle { get; set; }

        public string Title { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", this.Title, this.First, this.Last);
        }
    }
}