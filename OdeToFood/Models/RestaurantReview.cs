﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Models
{
	public class RestaurantReview
	{
		public int Id { get; set; }
		public int Rating { get; set; }
		public string Body { get; set; }
		public string ReviewerName { get; set; }
		public int RestaurantId { get; set; }
	}
}
