namespace ManagingANewspaper
{
    
    public class Designer
    {
        static int num = 0;
        public int Id { get; set; }
        public bool IsDesigningAi { get; set; } = true;
        public int WorkerId { get; set; }
        public Worker Worker { get; set; }
      
    }
}
