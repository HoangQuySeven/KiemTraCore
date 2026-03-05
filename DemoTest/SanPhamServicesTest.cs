using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KiemTraCore;
using NUnit.Framework.Constraints;

namespace DemoTest
{
    [TestFixture]
    internal class SanPhamServicesTest
    {
        public SanPhamServices _sps = null;

        [SetUp]

        public void Setup()
        {
            _sps = new SanPhamServices();
        }

        [Test]
        public void TestSPkhongtontai()
        {
            SanPham sp = new SanPham() { MaSanPham = "SP099",Name = "D" ,Gia = 10};

            Assert.IsFalse(_sps.Edit(sp));
        }

        [Test]
        public void ThemGiaAm()
        {
            SanPham sp = new SanPham() { MaSanPham = "SP022", Name = "C", Gia = -10 };

            Assert.IsFalse(_sps.Add(sp));
        }

        [Test]

        
        public void ThemThanhCong()
        {
            SanPham sp = new SanPham() { MaSanPham = "SP01", Name = "B", Gia = 20 };
            Assert.IsTrue(_sps.Add(sp));
        }
        [Test]        
        
        public void TestThemMaTrung()
        {
            SanPham sp = new SanPham() { MaSanPham = "SP001", Name="W", Gia = 50};
            Assert.IsFalse(_sps.Add(sp));
        }

    }
}
