﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolisenRSS.Utilities
{
	public class PostClientErrorEventArgs : EventArgs
	{
		public string Message { get; set; }
		public Exception Exception { get; set; }
	}
}
