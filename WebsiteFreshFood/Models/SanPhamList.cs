﻿namespace WebsiteFreshFood.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class SanPhamList
    {
        public List<SanPham> SanPhams { get; set; }

        public string totalCount { get; set; }

    }
}