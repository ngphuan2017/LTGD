using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTH_C3_BT1
{
    class PhanSo
    {
        int tu, mau;
        public PhanSo()
        {
            tu = 0;
            mau = 1;
        }
        public PhanSo(int t, int m)
        {
            tu = t;
            mau = m == 0 ? 1 : m;
        }
        public int Tuso
        {
            get { return tu; }
            set { tu = value; }
        }
        public int Mauso
        {
            get { return mau; }
            set { mau = value; }
        }
        private void Toigian()
        {
            int uc = Lopdungchung.USCLN(Tuso, Mauso);
            if(uc > 0)
            {
                tu /= uc;
                mau /= uc;
            }
        }
        public PhanSo Cong(PhanSo b)
        {
            PhanSo kq = new PhanSo();
            kq.tu = tu * b.mau + mau * b.tu;
            kq.mau = mau * b.mau;
            kq.Toigian();
            return kq;
        }
        public PhanSo Tru(PhanSo b)
        {
            PhanSo kq = new PhanSo();
            kq.tu = tu * b.mau - mau * b.tu;
            kq.mau = mau * b.mau;
            kq.Toigian();
            return kq;
        }
        public PhanSo Nhan(PhanSo b)
        {
            PhanSo kq = new PhanSo();
            kq.tu = tu * b.tu;
            kq.mau = mau * b.mau;
            kq.Toigian();
            return kq;
        }
        public PhanSo Chia(PhanSo b)
        {
            PhanSo kq = new PhanSo();
            kq.tu = tu * b.mau;
            kq.mau = mau * b.tu;
            kq.Toigian();
            return kq;
        }
    }
}
