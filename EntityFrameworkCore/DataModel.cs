﻿using System;
namespace EntityFrameworkCore
{
	public class Item
	{
		//이름Id -> PK
		public int ItemId { get; set; }
		public int TmeplateId { get; set; }
		public DateTime CreateDate { get; set; }

		//다른 클래스 참조 -> FK (Navigational Property)
		public int OwnerId { get; set; }
		public Player Owner { get; set; }
	}

	//클래스이름 = 테이블 이름 = Player
	public class Player
	{
		//이름id -> PK
		public int PlayerId { get; set; }
		public string name { get; set; }

	}
}

