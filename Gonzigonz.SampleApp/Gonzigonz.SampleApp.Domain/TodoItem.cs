﻿namespace Gonzigonz.SampleApp.Domain
{
	public class TodoItem : EntityBase
    {
		public string Name { get; set; }
		public string Details { get; set; }
		public bool IsComplete { get; set; }
	}
}
