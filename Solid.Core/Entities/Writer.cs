using System;

namespace ManagingANewspaper
{
    public enum TypeWriter { CHILDREN=1,TEEN,ADULT};
    public class Writer
    {

        static int num = 0;
        public int Id { get; set; }
        public TypeWriter TWriter { get; set; } = TypeWriter.CHILDREN;
        public int WorkerId { get; set; }
        public Worker Worker { get; set; }
        
    }
}
