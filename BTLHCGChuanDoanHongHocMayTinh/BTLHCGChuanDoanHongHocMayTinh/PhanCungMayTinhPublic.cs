using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLHCGChuanDoanHongHocMayTinh
{
    public class PhanCungMayTinhPublic
    {
        private bool _DenNguon;

        public bool DenNguon
        {
            get { return _DenNguon; }
            set { _DenNguon = value; }
        }
        private bool _ManHinh;

        public bool ManHinh
        {
            get { return _ManHinh; }
            set { _ManHinh = value; }
        }
        private bool _QuatNguon;

        public bool QuatNguon
        {
            get { return _QuatNguon; }
            set { _QuatNguon = value; }
        }
        private bool _HDH;

        public bool HDH
        {
            get { return _HDH; }
            set { _HDH = value; }
        }
        private int _BipBIOS;

        public int BipBIOS
        {
            get { return _BipBIOS; }
            set { _BipBIOS = value; }
        }
        private bool _CapNguon;

        public bool CapNguon
        {
            get { return _CapNguon; }
            set { _CapNguon = value; }
        }
        private bool _CapTinHieu;

        public bool CapTinHieu
        {
            get { return _CapTinHieu; }
            set { _CapTinHieu = value; }
        }
        private bool _NutDieuKhien;

        public bool NutDieuKhien
        {
            get { return _NutDieuKhien; }
            set { _NutDieuKhien = value; }
        }
        private bool _CapDuLieu;

        public bool CapDuLieu
        {
            get { return _CapDuLieu; }
            set { _CapDuLieu = value; }
        }
        private int _Bip;

        public int Bip
        {
            get { return _Bip; }
            set { _Bip = value; }
        }
    }
}
