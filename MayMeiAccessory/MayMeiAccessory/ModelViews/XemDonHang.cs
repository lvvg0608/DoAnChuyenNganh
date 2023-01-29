using System;
using System.Collections.Generic;
using MayMeiAccessory.Models;

namespace MayMeiAccessory.ModelViews
{
    public class XemDonHang
    {
        public Order DonHang { get; set; }
        public List<OrderDetail> ChiTietDonHang { get; set; }
    }
}
