﻿#region (c)2019 Annika Ryll
/*
    Image filtering empty dummy filter that just returns the input image
    Copyright (C) 2019 Annika Ryll

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */
#endregion
using System.Collections.Generic;


namespace FilterWrapper.Filters
{
	//default filter that does nothing at all
	class FilterNone : IImageFilter
	{
		List<Setting> settings = new List<Setting>();

		public IEnumerable<Setting> Settings { get { return settings; } }

		public string Info { get { return "no Filter (select one)"; } }

		public string Name { get { return "none"; } }

		public FilterImage Execute(FilterImage input)
		{
			return input;
		}
	}
}
