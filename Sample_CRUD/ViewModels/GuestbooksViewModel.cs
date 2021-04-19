﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using Sample_CRUD.Models;





namespace Sample_CRUD.ViewModels
{
    public class GuestbooksViewModel
    {
        //搜尋欄位

        [DisplayName("搜尋")]
        public string Search { get;set;}
        public List<Guestbook> DataList { get;set;}




    }
}