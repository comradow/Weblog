﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.DTOs.Posts
{
	public class CreatePostDTO
	{
		public bool IsDelete { get; set; }
		public int UserId { get; set; }
		public int CategoryId { get; set; }
		public int? SubCategoryId { get; set; }
		public string Title { get; set; }
		public string Slug { get; set; }
		public string Description { get; set; }
		public IFormFile Photo1 { get; set; }
		public IFormFile Photo2 { get; set; }
	}
}
