﻿using System.Collections.Generic;
using System.IO;
using ServicesClassLibrary.Base;
using Shared.Base;

namespace ServicesClassLibrary.Service {
	public class PictureService : IReadableList<Picture> {

		public List<Picture> GetList() {
			//List<Picture> pictureList = new PictureMapperService().ConvertToList(PicturesFileToStringArray);
			var pictureList = new List<Picture>();
			return pictureList;
		}

		//for mapper
		//static string Pictures_Path = @"C:\Users\nikolas\Documents\learning.nikolas\Search_Engine_Assignment\pictures_csv.txt";
		//string[] PicturesFileToStringArray { get => File.ReadAllLines(Pictures_Path); }
	}
}
