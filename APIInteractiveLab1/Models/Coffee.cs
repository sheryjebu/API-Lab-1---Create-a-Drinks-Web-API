using System;
namespace APIInteractiveLab1.Models
{
	public class Coffee
	{
        public int Id { get; internal set; }
        public string Name { get; internal set; }
        
        public Coffee(int id, string name)
        {
            Name = name;
            Id = id;
        }
    }
}

