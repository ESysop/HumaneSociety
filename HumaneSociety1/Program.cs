﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety1
	{
	class Program
		{
		static void Main (string[] args)
			{
			AdoptionDesk getAdoptionDeskMenu = new AdoptionDesk();
			getAdoptionDeskMenu.FirstMenuScreen();
			getAdoptionDeskMenu.MenuChoiceScreen();
			}
		}
	}
