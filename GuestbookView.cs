using GaryGuestbook.Models;
using GaryGuestbook.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace GaryGuestbook.ViewModels
{
    public class GuestbookView
    {
        /// <summary>
        /// 搜尋欄位
        /// </summary>
        [DisplayName("搜尋:")]
        public string Search { get; set; }

        /// <summary>
        /// 顯示Guestbooks的List
        /// </summary>
        public List<Guestbooks> DataList { get; set; }

        /// <summary>
        /// 分頁內容
        /// </summary>
        public ForPaging Paging { get; set; }
    }
}