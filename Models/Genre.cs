﻿using System.ComponentModel.DataAnnotations;

namespace Bookstoret2.Models
{
	public class Genre
	{
		public int Id { get; set; }

		[Display(Name = "Categoria")]
		public string Name{ get; set; }

		//public ICollection<Book> Books { get; set; } = new List<Book>();

        public Genre()
        {
            
        }
		public Genre(int id, string name)
		{
			Id = id;
			Name = name;
		}
	}
}
