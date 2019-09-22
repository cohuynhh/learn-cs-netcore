using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ef02.Models
{
    public partial class itgroupContext : DbContext
    {
        public itgroupContext()
        {
        }

        public itgroupContext(DbContextOptions<itgroupContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AclPermissions> AclPermissions { get; set; }
        public virtual DbSet<AclResorces> AclResorces { get; set; }
        public virtual DbSet<ContractStates> ContractStates { get; set; }
        public virtual DbSet<ContractType> ContractType { get; set; }
        public virtual DbSet<CskhKhachhang> CskhKhachhang { get; set; }
        public virtual DbSet<CskhProcesscskh> CskhProcesscskh { get; set; }
        public virtual DbSet<InPhieuchi> InPhieuchi { get; set; }
        public virtual DbSet<InPhieuxuat> InPhieuxuat { get; set; }
        public virtual DbSet<KtCcdc> KtCcdc { get; set; }
        public virtual DbSet<KtCcdcPhanbo> KtCcdcPhanbo { get; set; }
        public virtual DbSet<KtKetoanmay> KtKetoanmay { get; set; }
        public virtual DbSet<MArticles> MArticles { get; set; }
        public virtual DbSet<MBangluong> MBangluong { get; set; }
        public virtual DbSet<MBaocaoVatlieu> MBaocaoVatlieu { get; set; }
        public virtual DbSet<MChamcong> MChamcong { get; set; }
        public virtual DbSet<MChat> MChat { get; set; }
        public virtual DbSet<MChatid> MChatid { get; set; }
        public virtual DbSet<MCongno> MCongno { get; set; }
        public virtual DbSet<MDoitac> MDoitac { get; set; }
        public virtual DbSet<MDonvitinh> MDonvitinh { get; set; }
        public virtual DbSet<MEmail> MEmail { get; set; }
        public virtual DbSet<MEvent> MEvent { get; set; }
        public virtual DbSet<MFiledata> MFiledata { get; set; }
        public virtual DbSet<MGhichu> MGhichu { get; set; }
        public virtual DbSet<MHangsanxuat> MHangsanxuat { get; set; }
        public virtual DbSet<MHopdong> MHopdong { get; set; }
        public virtual DbSet<MHopdongNghiemthu> MHopdongNghiemthu { get; set; }
        public virtual DbSet<MInnerfolder> MInnerfolder { get; set; }
        public virtual DbSet<MKehoachchithanhtoan> MKehoachchithanhtoan { get; set; }
        public virtual DbSet<MKhachhang> MKhachhang { get; set; }
        public virtual DbSet<MKho> MKho { get; set; }
        public virtual DbSet<MKhoXuong> MKhoXuong { get; set; }
        public virtual DbSet<MKhomove> MKhomove { get; set; }
        public virtual DbSet<MMailsAcount> MMailsAcount { get; set; }
        public virtual DbSet<MMgs> MMgs { get; set; }
        public virtual DbSet<MModule> MModule { get; set; }
        public virtual DbSet<MModules> MModules { get; set; }
        public virtual DbSet<MNhacnhohd> MNhacnhohd { get; set; }
        public virtual DbSet<MNhapxuatItem> MNhapxuatItem { get; set; }
        public virtual DbSet<MNhapxuatItemXuong> MNhapxuatItemXuong { get; set; }
        public virtual DbSet<MNhapxuatPhieudenghi> MNhapxuatPhieudenghi { get; set; }
        public virtual DbSet<MNhapxuatPhieudenghiXuong> MNhapxuatPhieudenghiXuong { get; set; }
        public virtual DbSet<MNhatkythicong> MNhatkythicong { get; set; }
        public virtual DbSet<MPhanloaithietbiphukien> MPhanloaithietbiphukien { get; set; }
        public virtual DbSet<MProjectPhotos> MProjectPhotos { get; set; }
        public virtual DbSet<MSotaikhoan> MSotaikhoan { get; set; }
        public virtual DbSet<MSystem> MSystem { get; set; }
        public virtual DbSet<MThumucfile> MThumucfile { get; set; }
        public virtual DbSet<MVanban> MVanban { get; set; }
        public virtual DbSet<MVanbanFolder> MVanbanFolder { get; set; }
        public virtual DbSet<Nhanvienit> Nhanvienit { get; set; }
        public virtual DbSet<NhomChinh> NhomChinh { get; set; }
        public virtual DbSet<NhomPhu> NhomPhu { get; set; }
        public virtual DbSet<Phieuchi> Phieuchi { get; set; }
        public virtual DbSet<Phongban> Phongban { get; set; }
        public virtual DbSet<Sanpham> Sanpham { get; set; }
        public virtual DbSet<ThuchiGoiy> ThuchiGoiy { get; set; }
        public virtual DbSet<Tinhtrangnhanvien> Tinhtrangnhanvien { get; set; }
        public virtual DbSet<Tuvantinhgia> Tuvantinhgia { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=124.158.4.69,1433; Initial Catalog=itgroup;Persist Security Info=True;User ID=sa;Password=Daoxuanthu1975@");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<AclPermissions>(entity =>
            {
                entity.HasOne(d => d.ResourceNavigation)
                    .WithMany(p => p.AclPermissions)
                    .HasForeignKey(d => d.Resource)
                    .HasConstraintName("FK_AclPermissions_AclResorces");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AclPermissions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_AclPermissions_nhanvienit");
            });

            modelBuilder.Entity<AclResorces>(entity =>
            {
                entity.Property(e => e.Resource).ValueGeneratedNever();
            });

            modelBuilder.Entity<ContractStates>(entity =>
            {
                entity.HasIndex(e => e.Code)
                    .HasName("IX_contract_states")
                    .IsUnique();

                entity.Property(e => e.Label).HasDefaultValueSql("('Trang thai HD')");
            });

            modelBuilder.Entity<ContractType>(entity =>
            {
                entity.HasIndex(e => e.Code)
                    .HasName("u_code_contract_tyle")
                    .IsUnique();

                entity.Property(e => e.Label).HasDefaultValueSql("(N'LOAI HOP DONG')");
            });

            modelBuilder.Entity<CskhKhachhang>(entity =>
            {
                entity.Property(e => e.Active).HasDefaultValueSql("((0))");

                entity.Property(e => e.Addr).HasDefaultValueSql("('')");

                entity.Property(e => e.CountMucquantam).HasDefaultValueSql("((0))");

                entity.Property(e => e.CountMucquantamCskh).HasDefaultValueSql("((0))");

                entity.Property(e => e.Datecreate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email).HasDefaultValueSql("('')");

                entity.Property(e => e.Gender).HasDefaultValueSql("((1))");

                entity.Property(e => e.Idlink).HasDefaultValueSql("((0))");

                entity.Property(e => e.Lastupdate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Lock).HasDefaultValueSql("((0))");

                entity.Property(e => e.Logs).HasDefaultValueSql("('')");

                entity.Property(e => e.MgsCskh).HasDefaultValueSql("('')");

                entity.Property(e => e.MgsKinhdoanh).HasDefaultValueSql("('')");

                entity.Property(e => e.MgsMgs).HasDefaultValueSql("('')");

                entity.Property(e => e.Mucquantam).HasDefaultValueSql("((0))");

                entity.Property(e => e.MucquantamCskh).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasDefaultValueSql("(N'Customer Name')");

                entity.Property(e => e.Notefull).HasDefaultValueSql("('')");

                entity.Property(e => e.Phone).HasDefaultValueSql("('')");

                entity.Property(e => e.Province).HasDefaultValueSql("('')");

                entity.Property(e => e.Purpose).HasDefaultValueSql("('')");

                entity.Property(e => e.Search).HasDefaultValueSql("('')");

                entity.Property(e => e.Soure).HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<CskhProcesscskh>(entity =>
            {
                entity.Property(e => e.Datecreate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ghichu).HasDefaultValueSql("('')");

                entity.Property(e => e.Iskinhdoanh).HasDefaultValueSql("((0))");

                entity.Property(e => e.Lock).HasDefaultValueSql("((0))");

                entity.Property(e => e.Quantam).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<KtCcdc>(entity =>
            {
                entity.Property(e => e.Conlai).HasDefaultValueSql("((0))");

                entity.Property(e => e.Consudung).HasDefaultValueSql("((1))");

                entity.Property(e => e.Idkho).HasDefaultValueSql("((0))");

                entity.Property(e => e.Idphieunhap).HasDefaultValueSql("((0))");

                entity.Property(e => e.Idvl).HasDefaultValueSql("((0))");

                entity.Property(e => e.Kydaphanbo).HasDefaultValueSql("((0))");

                entity.Property(e => e.Lock).HasDefaultValueSql("((0))");

                entity.Property(e => e.Maccdc)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ngayduavaosudung).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ngayphanbocuoi).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nguoilap).HasDefaultValueSql("((0))");

                entity.Property(e => e.Nguyengia).HasDefaultValueSql("((0))");

                entity.Property(e => e.Nvsd).HasDefaultValueSql("((0))");

                entity.Property(e => e.NvsdTen).HasDefaultValueSql("('')");

                entity.Property(e => e.Sophieunhap).HasDefaultValueSql("('')");

                entity.Property(e => e.Sothangphanbo).HasDefaultValueSql("((24))");

                entity.Property(e => e.Tenccdc).HasDefaultValueSql("('')");

                entity.Property(e => e.Tkpb).IsUnicode(false);

                entity.Property(e => e.Tongphanbo).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<KtCcdcPhanbo>(entity =>
            {
                entity.Property(e => e.Active).HasDefaultValueSql("((0))");

                entity.Property(e => e.Idccdc).HasDefaultValueSql("((0))");

                entity.Property(e => e.Lock).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ngayphanbo).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Sotien).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<KtKetoanmay>(entity =>
            {
                entity.HasIndex(e => e.Co)
                    .HasName("_dta_index_kt_ketoanmay_8_1514687055__K10");

                entity.HasIndex(e => new { e.Id, e.Idphieuthuchi })
                    .HasName("_dta_index_kt_ketoanmay_8_1284710536__K17_1");

                entity.HasIndex(e => new { e.Iddoitac, e.Ngayghiso })
                    .HasName("_dta_index_kt_ketoanmay_8_1284710536__K7_K4");

                entity.HasIndex(e => new { e.Idkhachhang, e.No, e.Co })
                    .HasName("_dta_index_kt_ketoanmay_8_1284710536__K5_K11_K10");

                entity.HasIndex(e => new { e.Sotien, e.Iddoitac, e.Co })
                    .HasName("_dta_index_kt_ketoanmay_8_1284710536__K7_K10_12");

                entity.HasIndex(e => new { e.Sotien, e.Idphieunhap, e.Kieu })
                    .HasName("_dta_index_kt_ketoanmay_8_1284710536__K19_K15_12");

                entity.HasIndex(e => new { e.Sotien, e.No, e.Iddoitac })
                    .HasName("_dta_index_kt_ketoanmay_8_1284710536__K11_K7_12");

                entity.HasIndex(e => new { e.Sotien, e.Iddoitac, e.Idhopdong, e.Co })
                    .HasName("_dta_index_kt_ketoanmay_8_1284710536__K7_K16_K10_12");

                entity.HasIndex(e => new { e.Sotien, e.Idkhachhang, e.Co, e.Id })
                    .HasName("_dta_index_kt_ketoanmay_8_1284710536__K5_K10_K1_12");

                entity.HasIndex(e => new { e.Sotien, e.Ngayghiso, e.Idphieunhap, e.Kieu })
                    .HasName("_dta_index_kt_ketoanmay_8_1284710536__K4_K19_K15_12");

                entity.HasIndex(e => new { e.Sotien, e.No, e.Idkhachhang, e.Id })
                    .HasName("_dta_index_kt_ketoanmay_8_1284710536__K11_K5_K1_12");

                entity.HasIndex(e => new { e.Sotien, e.Iddoitac, e.Idphieunhap, e.Kieu, e.Id })
                    .HasName("_dta_index_kt_ketoanmay_8_1284710536__K7_K19_K15_K1_12");

                entity.HasIndex(e => new { e.Sotien, e.Iddoitac, e.Idhopdong, e.Idkhachhang, e.Co, e.Id })
                    .HasName("_dta_index_kt_ketoanmay_8_1284710536__K7_K16_K5_K10_K1_12");

                entity.HasIndex(e => new { e.Sotien, e.Iddoitac, e.Idhopdong, e.No, e.Idkhachhang, e.Id })
                    .HasName("_dta_index_kt_ketoanmay_8_1284710536__K7_K16_K11_K5_K1_12");

                entity.HasIndex(e => new { e.Sotien, e.Iddoitac, e.Kieu, e.Idhopdong, e.No, e.Id })
                    .HasName("_dta_index_kt_ketoanmay_8_1284710536__K7_K15_K16_K11_K1_12");

                entity.HasIndex(e => new { e.No, e.Sotien, e.Iddoitac, e.Kieu, e.Idhopdong, e.Co, e.Id })
                    .HasName("_dta_index_kt_ketoanmay_8_1284710536__K7_K15_K16_K10_K1_11_12");

                entity.HasIndex(e => new { e.Thang, e.Nam, e.Idkhachhang, e.Tenkh, e.Idphieunhap, e.Iditemphieunhap, e.Usercreate, e.Islink, e.Lock, e.Kieu, e.Idhopdong, e.Idphieuthuchi, e.Idsanpham, e.Iddoitac, e.Tendt, e.Diengiai, e.Co, e.No, e.Sotien, e.Ngayghiso, e.Id })
                    .HasName("_dta_index_kt_ketoanmay_selectdefault");

                entity.Property(e => e.Co)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Diengiai).HasDefaultValueSql("('')");

                entity.Property(e => e.Iddoitac).HasDefaultValueSql("((0))");

                entity.Property(e => e.Idhopdong).HasDefaultValueSql("((0))");

                entity.Property(e => e.Iditemphieunhap).HasDefaultValueSql("((0))");

                entity.Property(e => e.Idkhachhang).HasDefaultValueSql("((0))");

                entity.Property(e => e.Idphieunhap).HasDefaultValueSql("((0))");

                entity.Property(e => e.Idphieuthuchi).HasDefaultValueSql("((0))");

                entity.Property(e => e.Idsanpham).HasDefaultValueSql("((0))");

                entity.Property(e => e.Islink).HasDefaultValueSql("((0))");

                entity.Property(e => e.Kieu).HasDefaultValueSql("((0))");

                entity.Property(e => e.Lock).HasDefaultValueSql("((0))");

                entity.Property(e => e.Nam).HasDefaultValueSql("(datepart(year,getdate()))");

                entity.Property(e => e.Ngayghiso).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.No)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Objectlink).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sotien).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tendt).HasDefaultValueSql("('')");

                entity.Property(e => e.Tenkh).HasDefaultValueSql("('')");

                entity.Property(e => e.Thang).HasDefaultValueSql("(datepart(month,getdate()))");

                entity.Property(e => e.Usercreate).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<MArticles>(entity =>
            {
                entity.Property(e => e.Idcate).HasDefaultValueSql("((0))");

                entity.Property(e => e.Nd).HasDefaultValueSql("(N'Noi dung Article')");

                entity.Property(e => e.Ngay).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Title).HasDefaultValueSql("(N'Tieu de Articles')");
            });

            modelBuilder.Entity<MBangluong>(entity =>
            {
                entity.Property(e => e.Cong).HasDefaultValueSql("((0))");

                entity.Property(e => e.Lock).HasDefaultValueSql("((0))");

                entity.Property(e => e.Thuong).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MBaocaoVatlieu>(entity =>
            {
                entity.HasIndex(e => e.Hopdong);

                entity.HasIndex(e => e.Kieu);

                entity.HasIndex(e => new { e.Id, e.Idvatlieu, e.Soluong, e.Ton, e.Nhap, e.Xuat, e.Lock, e.Hopdong, e.Kieu })
                    .HasName("_dta_index_m_baocao_vatlieu_7_499271517__K7_K8_1_2_3_4_5_9_10");

                entity.HasIndex(e => new { e.Id, e.Idvatlieu, e.Soluong, e.Ton, e.Nhap, e.Xuat, e.Lock, e.Ghichu, e.Hopdong, e.Kieu })
                    .HasName("_dta_index_m_baocao_vatlieu_7_499271517__K7_K8_1_2_3_4_5_9_10_11");

                entity.Property(e => e.Idvatlieu).HasDefaultValueSql("((0))");

                entity.Property(e => e.Kieu).HasDefaultValueSql("((0))");

                entity.Property(e => e.Lock).HasDefaultValueSql("((0))");

                entity.Property(e => e.Nhap).HasDefaultValueSql("((0))");

                entity.Property(e => e.Soluong).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ton).HasDefaultValueSql("((0))");

                entity.Property(e => e.Xuat).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MChamcong>(entity =>
            {
                entity.Property(e => e.Chieu).HasDefaultValueSql("((0))");

                entity.Property(e => e.Lock).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sang).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MChat>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("IX_m_chat");

                entity.HasIndex(e => new { e.Haveread, e.Userreceive, e.Chatid, e.Usersend })
                    .HasName("_dta_index_m_chat_8_1370353004__K7_K9_K8_K2");

                entity.HasIndex(e => new { e.Id, e.Usersend, e.Message, e.Haveread, e.Userreceive, e.Username, e.Chatid, e.Datesend })
                    .HasName("_dta_index_m_chat_7_1370353004__K8_K4D_1_2_5_7_9_10");

                entity.HasIndex(e => new { e.Id, e.Usersend, e.Message, e.Userreceive, e.Username, e.Haveread, e.Chatid, e.Datesend })
                    .HasName("_dta_index_m_chat_7_1370353004__K7_K8_K4_1_2_5_9_10");

                entity.Property(e => e.Datesend).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Haveread).HasDefaultValueSql("((0))");

                entity.Property(e => e.Kieu).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MCongno>(entity =>
            {
                entity.HasIndex(e => e.Doitac);

                entity.HasIndex(e => e.Idphieuthuchi);

                entity.HasIndex(e => e.Lock)
                    .HasName("_dta_index_m_congno_7_1431676148__K8");

                entity.HasIndex(e => new { e.Idphieuthuchi, e.Doitac, e.Id })
                    .HasName("_dta_index_m_congno_checksoquy");

                entity.HasIndex(e => new { e.Id, e.Sotien, e.Phatsinhtang, e.Hide, e.Lock, e.Idphieuthuchi, e.Tonquy, e.Noidung, e.Doitac, e.Ngay })
                    .HasName("_dta_index_m_congno_checktrungphieu1");

                entity.HasIndex(e => new { e.Sotien, e.Phatsinhtang, e.Hide, e.Lock, e.Idphieuthuchi, e.Tonquy, e.Noidung, e.Doitac, e.Id, e.Ngay })
                    .HasName("_dta_index_m_congno_getlistphieucongngo");

                entity.Property(e => e.Datecreate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Hide).HasDefaultValueSql("((0))");

                entity.Property(e => e.Iddonhang).HasDefaultValueSql("((0))");

                entity.Property(e => e.Idhopdong).HasDefaultValueSql("((0))");

                entity.Property(e => e.Idnguoitao).HasDefaultValueSql("((0))");

                entity.Property(e => e.Idphieuthuchi).HasDefaultValueSql("((0))");

                entity.Property(e => e.Lock).HasDefaultValueSql("((0))");

                entity.Property(e => e.Nguoitao).HasDefaultValueSql("(N'Người tạo')");

                entity.Property(e => e.Nhom).HasDefaultValueSql("((1000000))");

                entity.Property(e => e.Noidung).HasDefaultValueSql("('')");

                entity.Property(e => e.Phatsinhtang).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sotien).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MDoitac>(entity =>
            {
                entity.HasIndex(e => new { e.Shortname, e.Id })
                    .HasName("_dta_index_m_doitac_7_980198542__K1_16");

                entity.HasIndex(e => new { e.Ten, e.Shortname, e.Ngay, e.Id })
                    .HasName("_dta_index_m_doitac_8_980198542__K1_15_16_18");

                entity.HasIndex(e => new { e.Id, e.Lock, e.Ten, e.Shortname, e.Search, e.Congno })
                    .HasName("_dta_index_m_doitac_8_980198542__K14D_1_13_15_16_17");

                entity.Property(e => e.Congno).HasDefaultValueSql("((0))");

                entity.Property(e => e.Dienthoai).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Fax).IsUnicode(false);

                entity.Property(e => e.Gpkd).IsUnicode(false);

                entity.Property(e => e.Lock).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mst).IsUnicode(false);

                entity.Property(e => e.Ngay).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nguoitao).HasDefaultValueSql("((1))");

                entity.Property(e => e.Shortname).HasDefaultValueSql("(N'Ten viet tat')");

                entity.Property(e => e.Web).IsUnicode(false);
            });

            modelBuilder.Entity<MDonvitinh>(entity =>
            {
                entity.Property(e => e.Tendv).HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<MEmail>(entity =>
            {
                entity.HasIndex(e => e.Frommail)
                    .HasName("frommail");

                entity.HasIndex(e => e.Mail)
                    .HasName("mail");

                entity.HasIndex(e => e.Ngay)
                    .HasName("ngay");

                entity.HasIndex(e => e.Tomail)
                    .HasName("tomail");

                entity.HasIndex(e => new { e.Id, e.Frommail, e.Chude, e.Ten, e.Issend, e.Mail, e.Ngay })
                    .HasName("_dta_index_m_email_8_1675332528__K3_K5D_1_2_6_7_9");

                entity.Property(e => e.Ngay).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MEvent>(entity =>
            {
                entity.HasIndex(e => e.Accept)
                    .HasName("accept");

                entity.HasIndex(e => e.Finished)
                    .HasName("finished");

                entity.HasIndex(e => e.Idthamkhao)
                    .HasName("idthamkhao");

                entity.HasIndex(e => e.Kieu)
                    .HasName("kieu");

                entity.HasIndex(e => e.Ngaytao)
                    .HasName("ngaytao");

                entity.HasIndex(e => e.Nguoinhan)
                    .HasName("nguoinhan");

                entity.HasIndex(e => e.Nguoitao)
                    .HasName("nguoitao");

                entity.HasIndex(e => new { e.Idthamkhao, e.Nguoinhan })
                    .HasName("_get_user_work_on_hopdong2");

                entity.HasIndex(e => new { e.Nguoitao, e.Nguoinhan })
                    .HasName("_dta_index_m_event_7_878626173__K2_K9");

                entity.HasIndex(e => new { e.Nguoinhan, e.Id, e.Idthamkhao })
                    .HasName("_get_user_work_on_hopdong");

                entity.HasIndex(e => new { e.Id, e.Name, e.Nguoinhan, e.Nguoitao, e.Accept, e.Finished, e.Ngaytao })
                    .HasName("_dta_index_m_event_congvieccanhan");

                entity.HasIndex(e => new { e.Name, e.Nguoitao, e.Id, e.Nguoinhan, e.Accept, e.Finished, e.Ngaytao })
                    .HasName("_dta_index_m_event_7_878626173__K2_K1_K9_K11_K14_K3_17");

                entity.HasIndex(e => new { e.Name, e.Idthamkhao, e.Id, e.Nguoinhan, e.Nguoitao, e.Accept, e.Finished, e.Ngaytao })
                    .HasName("_load_list_giao_viec_onhd");

                entity.Property(e => e.Accept).HasDefaultValueSql("((0))");

                entity.Property(e => e.Complete).HasDefaultValueSql("((0))");

                entity.Property(e => e.Dateaccept).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dateacceptance).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Datecreate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Datefinish).HasDefaultValueSql("(dateadd(hour,(4),getdate()))");

                entity.Property(e => e.Datestart).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Diem).HasDefaultValueSql("((0))");

                entity.Property(e => e.Finished).HasDefaultValueSql("((0))");

                entity.Property(e => e.Idthamkhao).HasDefaultValueSql("((-1))");

                entity.Property(e => e.Kieu).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mota).HasDefaultValueSql("('')");

                entity.HasOne(d => d.NguoinhanNavigation)
                    .WithMany(p => p.MEventNguoinhanNavigation)
                    .HasForeignKey(d => d.Nguoinhan)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<MFiledata>(entity =>
            {
                entity.HasIndex(e => new { e.Hopdong, e.Idsubfolder })
                    .HasName("_dta_index_m_filedata_filllistfolder");

                entity.HasIndex(e => new { e.Documenttype, e.Isimg, e.Id })
                    .HasName("_dta_index_m_filedata_selectallid_img");

                entity.HasIndex(e => new { e.Name, e.Lastupdate, e.Allcoment, e.Filetype, e.Hopdong, e.Documenttype, e.Soluongcoment, e.Id, e.Nhanvien })
                    .HasName("_dta_index_m_filedata_file_listcomment");

                entity.HasIndex(e => new { e.Id, e.Lastcomment, e.Idstyle, e.Idxdkt, e.Name, e.Uploader, e.Filetype, e.Idroom, e.Groupfile, e.Ngay })
                    .HasName("_dta_index_m_filedata_fillbyroom");

                entity.HasIndex(e => new { e.Id, e.Ngay, e.Groupfile, e.Lastcomment, e.Idxdkt, e.Name, e.Uploader, e.Filetype, e.Idstyle, e.Idroom })
                    .HasName("_dta_index_m_filedata_fillbystyleandroom");

                entity.HasIndex(e => new { e.Id, e.Lastcomment, e.Idroom, e.Idstyle, e.Idxdkt, e.Name, e.Uploader, e.Filetype, e.Idproject, e.Groupfile, e.Ngay })
                    .HasName("_dta_index_m_filedata_fillbyproject");

                entity.HasIndex(e => new { e.Id, e.Lastcomment, e.Idroom, e.Idstyle, e.Idxdkt, e.Name, e.Uploader, e.Filetype, e.Hopdong, e.Documenttype, e.Groupfile, e.Ngay })
                    .HasName("_dta_index_m_filedata_fillbydir");

                entity.HasIndex(e => new { e.Id, e.Hopdong, e.Lastcomment, e.Idroom, e.Idstyle, e.Idxdkt, e.Name, e.Uploader, e.Filetype, e.Documenttype, e.Idsubfolder, e.Groupfile, e.Ngay })
                    .HasName("_dta_index_m_filedata_in_view");

                entity.HasIndex(e => new { e.Groupfile, e.Lastcomment, e.Idroom, e.Idstyle, e.Idxdkt, e.Idsubfolder, e.Name, e.Sizefile, e.Uploader, e.Filetype, e.Hopdong, e.Documenttype, e.Id, e.Ngay })
                    .HasName("_dta_index_m_filedata_fillfilehopdong");

                entity.HasIndex(e => new { e.Groupfile, e.Lastcomment, e.Idroom, e.Idstyle, e.Idxdkt, e.Name, e.Sizefile, e.Uploader, e.Filetype, e.Hopdong, e.Documenttype, e.Objectid, e.Id, e.Ngay })
                    .HasName("_dta_index_m_filedata_8_1166627199__K8_K10_K55_K1_K16_17_19_24_25_37_39_43_44_49");

                entity.HasIndex(e => new { e.Id, e.Lastcomment, e.Idroom, e.Idstyle, e.Idxdkt, e.Name, e.Sizefile, e.Uploader, e.Filetype, e.Hopdong, e.Documenttype, e.Idsubfolder, e.Groupfile, e.Ngay })
                    .HasName("_dta_index_m_filedata_fillfilehopdong2");

                entity.Property(e => e.Allcoment).HasDefaultValueSql("(N'')");

                entity.Property(e => e.Desp).HasDefaultValueSql("('')");

                entity.Property(e => e.Documenttype).HasDefaultValueSql("((0))");

                entity.Property(e => e.Filetype).HasDefaultValueSql("(N'jpg')");

                entity.Property(e => e.Groupfile).HasDefaultValueSql("((0))");

                entity.Property(e => e.Hopdong).HasDefaultValueSql("((0))");

                entity.Property(e => e.Idmail).HasDefaultValueSql("((-1))");

                entity.Property(e => e.Idproject).HasDefaultValueSql("((-1))");

                entity.Property(e => e.Idroom).HasDefaultValueSql("((0))");

                entity.Property(e => e.Idstyle).HasDefaultValueSql("((0))");

                entity.Property(e => e.Idsubfolder).HasDefaultValueSql("((27))");

                entity.Property(e => e.Idurl).HasDefaultValueSql("((-1))");

                entity.Property(e => e.Idxdkt).HasDefaultValueSql("((0))");

                entity.Property(e => e.Isimg).HasDefaultValueSql("((0))");

                entity.Property(e => e.Lastupdate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Lock).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasDefaultValueSql("(N'FileName')");

                entity.Property(e => e.Ngay).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Numberdownload).HasDefaultValueSql("((0))");

                entity.Property(e => e.Objectid).HasDefaultValueSql("((0))");

                entity.Property(e => e.Path).HasDefaultValueSql("(N'-')");

                entity.Property(e => e.Sizefile).HasDefaultValueSql("((0))");

                entity.Property(e => e.Soluongcoment).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tenkhach).HasDefaultValueSql("('')");

                entity.Property(e => e.Uploader).HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<MGhichu>(entity =>
            {
                entity.HasIndex(e => e.Active)
                    .HasName("active");

                entity.HasIndex(e => e.Idevent)
                    .HasName("idevent");

                entity.HasIndex(e => e.Idhopdong)
                    .HasName("idhopdong");

                entity.HasIndex(e => e.Kieu)
                    .HasName("kieu");

                entity.HasIndex(e => e.Kieunhacviec)
                    .HasName("kieunhacviec");

                entity.HasIndex(e => e.Nhanvien)
                    .HasName("nhanvien");

                entity.HasIndex(e => new { e.Active, e.Nhanvien })
                    .HasName("_dta_index_m_ghichu_7_2086226194__K4_K3");

                entity.HasIndex(e => new { e.Idevent, e.Ngaynhacghichu, e.Ten, e.Idhopdong })
                    .HasName("_dta_index_m_ghichu_8_2086226194__K5_6_9_10");

                entity.HasIndex(e => new { e.Id, e.Kieu, e.Ten, e.Nhanvien, e.Active, e.Ngaynhacghichu })
                    .HasName("_dta_index_m_ghichu_8_2086226194__K3_K4_K9_1_7_10");

                entity.HasIndex(e => new { e.Kieu, e.Ten, e.Nhanvien, e.Active, e.Id, e.Ngaynhacghichu })
                    .HasName("_dta_index_m_ghichu_8_2086226194__K3_K4_K1_K9_7_10");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.Idevent).HasDefaultValueSql("((-1))");

                entity.Property(e => e.Idhopdong).HasDefaultValueSql("((-1))");

                entity.Property(e => e.Kieu).HasDefaultValueSql("((0))");

                entity.Property(e => e.Kieunhacviec).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ngaycapnhatghichu).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ngaynhacghichu).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ngaytaoghichu).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nhanvien).HasDefaultValueSql("((0))");

                entity.Property(e => e.Search).HasDefaultValueSql("(N'')");

                entity.HasOne(d => d.NhanvienNavigation)
                    .WithMany(p => p.MGhichu)
                    .HasForeignKey(d => d.Nhanvien)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_m_ghichu_nhanvienit");
            });

            modelBuilder.Entity<MHangsanxuat>(entity =>
            {
                entity.Property(e => e.Lock).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MHopdong>(entity =>
            {
                entity.HasIndex(e => e.Datestart)
                    .HasName("_dta_index_m_hopdong_7_1585081586__K36");

                entity.HasIndex(e => e.Khachhang)
                    .HasName("_dta_index_m_hopdong_forselect_khachhang");

                entity.HasIndex(e => new { e.Tenhd, e.Id })
                    .HasName("_dta_index_m_hopdong_7_1957582012__K1_37");

                entity.HasIndex(e => new { e.Id, e.Khachhang, e.Loaihd, e.Songaycon, e.Pin, e.Tenhd, e.CodeContract, e.Search, e.Capnhatcuoi, e.Fullcheck, e.Tinhtranghopdong, e.Datestart })
                    .HasName("_dta_index_m_hopdong_8_16424777__K7_K36D_1_3_9_28_32_33_34_35_51_63");

                entity.HasIndex(e => new { e.Khachhang, e.Search, e.Datestart, e.Capnhatcuoi, e.Id, e.Loaihd, e.Fullcheck, e.Pin, e.Tenhd, e.CodeContract, e.Tinhtranghopdong, e.Songaycon })
                    .HasName("_dta_index_m_hopdong_8_16424777__K1_K9_K63_K32_K33_K34_K7_K28_3_35_36_51");

                entity.HasIndex(e => new { e.Khachhang, e.Search, e.Datestart, e.Capnhatcuoi, e.Loaihd, e.Id, e.Fullcheck, e.Pin, e.Tenhd, e.CodeContract, e.Tinhtranghopdong, e.Songaycon })
                    .HasName("_dta_index_m_hopdong_8_16424777__K9_K1_K63_K32_K33_K34_K7_K28_3_35_36_51");

                entity.HasIndex(e => new { e.Id, e.Khachhang, e.Giatrihopdong, e.Tinhtranghopdong, e.Loaihd, e.Datefinish, e.Chutri, e.MoneyTongthu, e.MoneyConlai, e.Khachhangs, e.Workers, e.Complete, e.Completestring, e.Songaycon, e.Tenhd, e.Datestart })
                    .HasName("_dta_index_m_hopdong_7_1585081586__K36_1_3_6_7_9_28_33_37_38_39_41_42_43_45_46");

                entity.Property(e => e.Capnhatcuoi).HasDefaultValueSql("('')");

                entity.Property(e => e.Chietkhau).HasDefaultValueSql("((0))");

                entity.Property(e => e.Chutri).HasDefaultValueSql("((1))");

                entity.Property(e => e.Complete).HasDefaultValueSql("((0))");

                entity.Property(e => e.Completelogs).HasDefaultValueSql("('')");

                entity.Property(e => e.Completepredicbydate).HasDefaultValueSql("((0))");

                entity.Property(e => e.Completestring).HasDefaultValueSql("('Trang thai Hoan Thanh?')");

                entity.Property(e => e.Datecreate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Datefinish).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Datestart).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Donvithicong).HasDefaultValueSql("((6))");

                entity.Property(e => e.Fullcheck).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ghichucongno).HasDefaultValueSql("('')");

                entity.Property(e => e.Giahan).HasDefaultValueSql("((0))");

                entity.Property(e => e.Khachhangs).HasDefaultValueSql("(N'Cap nhat ten khach')");

                entity.Property(e => e.Khoa).HasDefaultValueSql("((0))");

                entity.Property(e => e.Loaihd).HasDefaultValueSql("((0))");

                entity.Property(e => e.Lock).HasDefaultValueSql("((0))");

                entity.Property(e => e.Logs).HasDefaultValueSql("('')");

                entity.Property(e => e.MoneyConlai).HasDefaultValueSql("((0))");

                entity.Property(e => e.MoneyTongchi).HasDefaultValueSql("((0))");

                entity.Property(e => e.MoneyTongthu).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ngaycapnhatcuoi).HasDefaultValueSql("((0))");

                entity.Property(e => e.Parent).HasDefaultValueSql("((0))");

                entity.Property(e => e.Phathopdong).HasDefaultValueSql("((0))");

                entity.Property(e => e.Phatsinh).HasDefaultValueSql("((0))");

                entity.Property(e => e.Pin).HasDefaultValueSql("((0))");

                entity.Property(e => e.Search).HasDefaultValueSql("('')");

                entity.Property(e => e.Songaycon).HasDefaultValueSql("((0))");

                entity.Property(e => e.TcThicongKhoa).HasDefaultValueSql("((0))");

                entity.Property(e => e.TcThicongNgaycapnhat).HasDefaultValueSql("((0))");

                entity.Property(e => e.TcThicongNgayketthuc).HasDefaultValueSql("((0))");

                entity.Property(e => e.TcThicongNoidung).HasDefaultValueSql("(N'0')");

                entity.Property(e => e.TcThicongValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.TcVatlieuKhoa).HasDefaultValueSql("((0))");

                entity.Property(e => e.TcVatlieuNgaycapnhat).HasDefaultValueSql("((0))");

                entity.Property(e => e.TcVatlieuNgayketthuc).HasDefaultValueSql("((0))");

                entity.Property(e => e.TcVatlieuValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tongphieuthu).HasDefaultValueSql("((0))");

                entity.Property(e => e.VatlieuCanchiPk).HasDefaultValueSql("((0))");

                entity.Property(e => e.VatlieuCanchiVl).HasDefaultValueSql("((0))");

                entity.Property(e => e.VatlieuChiphi).HasDefaultValueSql("((0))");

                entity.Property(e => e.VatlieuChiphiDutoantong).HasDefaultValueSql("((0))");

                entity.Property(e => e.VatlieuChiphiPhukienthietbi).HasDefaultValueSql("((0))");

                entity.Property(e => e.VatlieuChiphiVatlieu).HasDefaultValueSql("((0))");

                entity.Property(e => e.VatlieuThieuVp).HasDefaultValueSql("((0))");

                entity.Property(e => e.VatlieuThieuX).HasDefaultValueSql("((0))");

                entity.Property(e => e.VatlieuYeucauVp).HasDefaultValueSql("((0))");

                entity.Property(e => e.VatlieuYeucauX).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.KhachhangNavigation)
                    .WithMany(p => p.MHopdong)
                    .HasForeignKey(d => d.Khachhang)
                    .HasConstraintName("FK_m_hopdong_m_khachhang");

                entity.HasOne(d => d.LoaihdNavigation)
                    .WithMany(p => p.MHopdong)
                    .HasPrincipalKey(p => p.Code)
                    .HasForeignKey(d => d.Loaihd)
                    .HasConstraintName("FK_m_hopdong_contract_type");

                entity.HasOne(d => d.TinhtranghopdongNavigation)
                    .WithMany(p => p.MHopdong)
                    .HasPrincipalKey(p => p.Code)
                    .HasForeignKey(d => d.Tinhtranghopdong)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_m_hopdong_contract_states");

                entity.HasOne(d => d.UserCreateNavigation)
                    .WithMany(p => p.MHopdong)
                    .HasForeignKey(d => d.UserCreate)
                    .HasConstraintName("FK_m_hopdong_nhanvienit_user_create");
            });

            modelBuilder.Entity<MHopdongNghiemthu>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.HopdongId)
                    .HasName("_dta_index_m_hopdong_nghiemthu_c_8_671344563__K5")
                    .ForSqlServerIsClustered();

                entity.Property(e => e.Active).HasDefaultValueSql("((0))");

                entity.Property(e => e.Diengiai).HasDefaultValueSql("('')");

                entity.Property(e => e.FileId).HasDefaultValueSql("((0))");

                entity.Property(e => e.HopdongId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Kieu).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ngay).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Sotien).HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<MInnerfolder>(entity =>
            {
                entity.Property(e => e.Idhopdong).HasDefaultValueSql("((0))");

                entity.Property(e => e.Namef).HasDefaultValueSql("(N'New Folder')");
            });

            modelBuilder.Entity<MKehoachchithanhtoan>(entity =>
            {
                entity.Property(e => e.Idnguoiduocchi).HasDefaultValueSql("((-1))");

                entity.Property(e => e.Idthamkhao).HasDefaultValueSql("((-1))");

                entity.Property(e => e.Kieuthamkhao).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tongtien).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MKhachhang>(entity =>
            {
                entity.HasIndex(e => e.Email)
                    .HasName("email");

                entity.HasIndex(e => e.Iddoitac)
                    .HasName("_dta_index_m_khachhang_7_1499152386__K11");

                entity.HasIndex(e => e.Search)
                    .HasName("search");

                entity.HasIndex(e => e.Searchname)
                    .HasName("_dta_index_m_khachhang_seachkh");

                entity.HasIndex(e => new { e.Hoten, e.Id })
                    .HasName("_dta_index_m_khachhang_getlistphieuthu");

                entity.HasIndex(e => new { e.Hoten, e.Dienthoai, e.Diachi, e.Id })
                    .HasName("_dta_index_m_khachhang_7_1499152386__K1_13_14_16");

                entity.HasIndex(e => new { e.Loai, e.Hoten, e.Iddoitac, e.Id })
                    .HasName("_dta_index_m_khachhang_8_1499152386__K11_K1_8_13");

                entity.Property(e => e.Diachi).HasDefaultValueSql("(N'Nhập địa chỉ khách hàng?')");

                entity.Property(e => e.Dienthoai).HasDefaultValueSql("(N'Nhập số điện thoại?')");

                entity.Property(e => e.Email).HasDefaultValueSql("(N'Địa chỉ email?')");

                entity.Property(e => e.Ghichu).HasDefaultValueSql("('')");

                entity.Property(e => e.Hoten).HasDefaultValueSql("(N'Tên Khách')");

                entity.Property(e => e.Iddoitac).HasDefaultValueSql("((0))");

                entity.Property(e => e.Idlink).HasDefaultValueSql("((0))");

                entity.Property(e => e.Loai).HasDefaultValueSql("((0))");

                entity.Property(e => e.Lock).HasDefaultValueSql("((0))");

                entity.Property(e => e.Nams).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ngayden).HasDefaultValueSql("((1))");

                entity.Property(e => e.Ngays).HasDefaultValueSql("((0))");

                entity.Property(e => e.Nhanviencapnhat).HasDefaultValueSql("((-1))");

                entity.Property(e => e.Thangs).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MKho>(entity =>
            {
                entity.HasIndex(e => e.Idsp)
                    .HasName("m_kho")
                    .IsUnique();

                entity.HasIndex(e => new { e.Idsp, e.Id, e.Soluong })
                    .HasName("_dta_index_m_kho_7_1486628339__K2_K1_K3");

                entity.HasIndex(e => new { e.Id, e.Khodungcuvp, e.Khodungcux, e.Idsp })
                    .HasName("_dta_index_m_kho_8_1486628339__K1_K11_K10_K2");

                entity.HasIndex(e => new { e.Id, e.Tong, e.Khovp, e.Khox, e.Khodungcux, e.Khodungcuvp, e.Idsp, e.Soluong })
                    .HasName("_dta_index_m_kho_8_1486628339__K2_K3_1_7_8_9_10_11");

                entity.Property(e => e.Idsp).HasDefaultValueSql("((-1))");

                entity.Property(e => e.Khodungcuvp).HasDefaultValueSql("((0))");

                entity.Property(e => e.Khodungcux).HasDefaultValueSql("((0))");

                entity.Property(e => e.Khovp).HasDefaultValueSql("((0))");

                entity.Property(e => e.Khox).HasDefaultValueSql("((0))");

                entity.Property(e => e.Lock).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ngaycapnhat).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Soluong).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tong).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MKhoXuong>(entity =>
            {
                entity.HasIndex(e => e.Idsp)
                    .HasName("IDsp")
                    .IsUnique();

                entity.HasIndex(e => new { e.Idsp, e.Id, e.Soluong })
                    .HasName("_dta_index_m_kho_xuong_7_580197117__K2_K1_K3");

                entity.Property(e => e.Idsp).HasDefaultValueSql("((-1))");

                entity.Property(e => e.Khodungcuvp).HasDefaultValueSql("((0))");

                entity.Property(e => e.Khodungcux).HasDefaultValueSql("((0))");

                entity.Property(e => e.Khovp).HasDefaultValueSql("((0))");

                entity.Property(e => e.Khox).HasDefaultValueSql("((0))");

                entity.Property(e => e.Lock).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ngaycapnhat).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Soluong).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tong).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MKhomove>(entity =>
            {
                entity.Property(e => e.Ngay).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nv).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MMailsAcount>(entity =>
            {
                entity.Property(e => e.Account)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('abc@bepxinh.vn')");

                entity.Property(e => e.Pass)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('new@#$(8)')");
            });

            modelBuilder.Entity<MMgs>(entity =>
            {
                entity.HasIndex(e => e.Dadoc);

                entity.HasIndex(e => e.Ngaygio)
                    .HasName("ngaygio");

                entity.HasIndex(e => e.Nhanvien);

                entity.HasIndex(e => new { e.Dadoc, e.Nguoigui, e.Noidung, e.Kieuthongbao, e.Nhanvien, e.Id })
                    .HasName("_dta_index_m_mgs_7_184211318__K7_K2_K1_3_5_9");

                entity.HasIndex(e => new { e.Id, e.Dadoc, e.Nguoigui, e.Kieuthongbao, e.Noidung, e.Nhanvien, e.Ngaygio })
                    .HasName("_dta_index_m_mgs_7_184211318__K2_K4D_1_3_5_7_9");

                entity.HasIndex(e => new { e.Id, e.Nguoigui, e.Kieuthongbao, e.Noidung, e.Nhanvien, e.Dadoc, e.Ngaygio })
                    .HasName("_dta_index_m_mgs_7_184211318__K2_K3_K4D_1_5_7_9");

                entity.HasIndex(e => new { e.Nguoigui, e.Kieuthongbao, e.Noidung, e.Nhanvien, e.Dadoc, e.Id, e.Ngaygio })
                    .HasName("_getmgs_readnews");

                entity.Property(e => e.Dadoc).HasDefaultValueSql("((0))");

                entity.Property(e => e.Detailid).HasDefaultValueSql("((0))");

                entity.Property(e => e.Idthamkhao).HasDefaultValueSql("((-1))");

                entity.Property(e => e.Kieuthongbao).HasDefaultValueSql("((-1))");

                entity.Property(e => e.Ngaygio).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nguoigui).HasDefaultValueSql("((-1))");

                entity.HasOne(d => d.NhanvienNavigation)
                    .WithMany(p => p.MMgsNhanvienNavigation)
                    .HasForeignKey(d => d.Nhanvien)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<MModule>(entity =>
            {
                entity.Property(e => e.Idmodule).HasDefaultValueSql("((-1))");
            });

            modelBuilder.Entity<MModules>(entity =>
            {
                entity.Property(e => e.Img).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MNhacnhohd>(entity =>
            {
                entity.HasIndex(e => new { e.Kieu, e.Hopdong, e.Nhanvien })
                    .HasName("_dta_index_m_nhacnhohd_selectuser_thaoluanfilehopdong");

                entity.HasIndex(e => new { e.Id, e.Noidung, e.Hopdong, e.Kieu, e.Nhanvien, e.Ngaygui })
                    .HasName("_dta_index_m_nhacnhohd_thaoluantronghopdongload");

                entity.HasIndex(e => new { e.Noidung, e.Hopdong, e.Kieu, e.Id, e.Nhanvien, e.Ngay })
                    .HasName("_dta_index_m_nhacnhohd_comment_filehd");

                entity.Property(e => e.Kieu).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ngay).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ngaygui).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MNhapxuatItem>(entity =>
            {
                entity.HasIndex(e => new { e.Sodexuat, e.Idsanpham, e.Denghi })
                    .HasName("_dta_index_m_nhapxuat_item_7_1566628624__K12_K8_2");

                entity.HasIndex(e => new { e.Sodexuat, e.Gia, e.Chietkhau, e.Lock, e.Huy, e.Ghichu, e.Denghi, e.Id, e.Idsanpham })
                    .HasName("_dta_index_m_nhapxuat_item_8_1566628624__K8_K1_K12_2_10_11_16_17_18");

                entity.Property(e => e.Chietkhau).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ghichu).HasDefaultValueSql("('')");

                entity.Property(e => e.Huy).HasDefaultValueSql("((0))");

                entity.Property(e => e.Lock).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sodexuat).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MNhapxuatItemXuong>(entity =>
            {
                entity.HasIndex(e => new { e.Sodexuat, e.Denghi, e.Idsanpham })
                    .HasName("_dta_index_m_nhapxuat_item_xuong_7_612197231__K4_K7_2");

                entity.HasIndex(e => new { e.Sodexuat, e.Idsanpham, e.Denghi })
                    .HasName("_dta_index_m_nhapxuat_item_xuong_7_612197231__K7_K4_2");

                entity.Property(e => e.Chietkhau).HasDefaultValueSql("((0))");

                entity.Property(e => e.Huy).HasDefaultValueSql("((0))");

                entity.Property(e => e.Idthamkhao).HasDefaultValueSql("((-1))");

                entity.Property(e => e.Lock).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sodexuat).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vaophieunhap).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MNhapxuatPhieudenghi>(entity =>
            {
                entity.HasIndex(e => e.Hopdong)
                    .HasName("_dta_index_m_nhapxuat_phieudenghi_7_955150448__K13");

                entity.HasIndex(e => e.Thihanh)
                    .HasName("_dta_index_m_nhapxuat_phieudenghi_7_955150448__K15");

                entity.HasIndex(e => new { e.Hopdong, e.Lock })
                    .HasName("_dta_index_m_nhapxuat_phieudenghi_7_955150448__K13_K12");

                entity.HasIndex(e => new { e.Lock, e.Hopdong })
                    .HasName("_dta_index_m_nhapxuat_phieudenghi_7_955150448__K12_K13");

                entity.HasIndex(e => new { e.Hopdong, e.Tieude, e.Nhap, e.Ngaydexuat, e.Id })
                    .HasName("_dta_index_m_nhapxuat_phieudenghi_7_955150448__K20_K5_K1_13_29");

                entity.HasIndex(e => new { e.Lock, e.Tieude, e.Id, e.Nhap, e.Ngaydexuat })
                    .HasName("_dta_index_m_nhapxuat_phieudenghi_7_955150448__K1_K20_K5_12_29");

                entity.HasIndex(e => new { e.Lock, e.Tieude, e.Hopdong, e.Nhap, e.Id, e.Ngaydexuat })
                    .HasName("_dta_index_m_nhapxuat_phieudenghi_7_955150448__K13_K20_K1_K5_12_29");

                entity.HasIndex(e => new { e.Id, e.Lock, e.So, e.Tieude, e.Search, e.Ngaydexuat1, e.Nhap })
                    .HasName("_dta_index_m_nhapxuat_phieudenghi_searchphieuthuchi");

                entity.HasIndex(e => new { e.Id, e.Nhap, e.So, e.Tieude, e.Search, e.Lock, e.Ngaydexuat })
                    .HasName("_dta_index_m_nhapxuat_phieudenghi_7_955150448__K12_K5D_1_20_21_29_37");

                entity.HasIndex(e => new { e.Id, e.So, e.Tieude, e.Search, e.Nhap, e.Lock, e.Ngaydexuat })
                    .HasName("_dta_index_m_nhapxuat_phieudenghi_7_955150448__K20_K12_K5_1_21_29_37");

                entity.HasIndex(e => new { e.Nhap, e.So, e.Tieude, e.Search, e.Lock, e.Ngaydexuat1, e.Id })
                    .HasName("_dta_index_m_nhapxuat_phieudenghi_8_955150448__K12_K44D_K1D_20_21_29_37");

                entity.HasIndex(e => new { e.Nhap, e.So, e.Tieude, e.Search, e.Hopdong, e.Id, e.Lock, e.Ngaydexuat })
                    .HasName("_dta_index_m_nhapxuat_phieudenghi_7_955150448__K13_K1_K12_K5_20_21_29_37");

                entity.HasIndex(e => new { e.Nhap, e.So, e.Tieude, e.Search, e.Hopdong, e.Id, e.Lock, e.Ngaydexuat1 })
                    .HasName("_dta_index_m_nhapxuat_phieudenghi_8_955150448__K13_K1_K12_K44_20_21_29_37");

                entity.HasIndex(e => new { e.Nhap, e.So, e.Tieude, e.Search, e.Kho, e.Lock, e.Ngaydexuat1, e.Id })
                    .HasName("_dta_index_m_nhapxuat_phieudenghi_8_955150448__K12_K44D_K1D_20_21_29_37_49");

                entity.HasIndex(e => new { e.Id, e.Nhap, e.So, e.Tieude, e.Search, e.Kho, e.Khachhang, e.Lock, e.Ngaydexuat1 })
                    .HasName("_dta_index_m_nhapxuat_phieudenghi_8_955150448__K14_K12_K44_1_20_21_29_37_49");

                entity.HasIndex(e => new { e.So, e.Tieude, e.Search, e.Kho, e.Hopdong, e.Nhap, e.Id, e.Lock, e.Ngaydexuat1 })
                    .HasName("_dta_index_m_nhapxuat_phieudenghi_8_955150448__K13_K20_K1_K12_K44_21_29_37_49");

                entity.Property(e => e.Chiphivanchuyen).HasDefaultValueSql("((0))");

                entity.Property(e => e.Co)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Diadiemgiao).HasDefaultValueSql("(N'Kho BX 16')");

                entity.Property(e => e.Iddoitac).HasDefaultValueSql("((0))");

                entity.Property(e => e.Kho).HasDefaultValueSql("((0))");

                entity.Property(e => e.Lock).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ngaydexuat1).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ngayketthuc1).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nguoilapphieu).HasDefaultValueSql("((-1))");

                entity.Property(e => e.Nhap).HasDefaultValueSql("((1))");

                entity.Property(e => e.No)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.So).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tendt).HasDefaultValueSql("(N'Không có nhà cung cấp')");

                entity.Property(e => e.Thanhtoan).HasDefaultValueSql("(N'CK')");

                entity.Property(e => e.Thihanh).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tongtien).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tongtienchietkhau).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tongtiensauchietkhau).HasDefaultValueSql("((0))");

                entity.Property(e => e.XoaHuydonhang).HasDefaultValueSql("((0))");

                entity.Property(e => e.XoaXacnhan).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MNhapxuatPhieudenghiXuong>(entity =>
            {
                entity.HasIndex(e => e.Lock)
                    .HasName("_dta_index_m_nhapxuat_phieudenghi_xuong_7_628197288__K12");

                entity.HasIndex(e => new { e.Lock, e.Tieude, e.Nhap, e.Id, e.Ngaydexuat })
                    .HasName("_dta_index_m_nhapxuat_phieudenghi_xuong_7_628197288__K20_K1_K5_12_29");

                entity.HasIndex(e => new { e.Lock, e.Tieude, e.Hopdong, e.Nhap, e.Id, e.Ngaydexuat })
                    .HasName("_dta_index_m_nhapxuat_phieudenghi_xuong_7_628197288__K13_K20_K1_K5_12_29");

                entity.HasIndex(e => new { e.Id, e.Nhap, e.So, e.Tieude, e.Search, e.Lock, e.Ngaydexuat })
                    .HasName("_dta_index_m_nhapxuat_phieudenghi_xuong_7_628197288__K12_K5D_1_20_21_29_37");

                entity.HasIndex(e => new { e.Id, e.Nhap, e.So, e.Tieude, e.Search, e.Lock, e.Ngaydexuat1 })
                    .HasName("_dta_index_m_nhapxuat_phieudenghi_xuong_8_628197288__K12_K44D_1_20_21_29_37");

                entity.HasIndex(e => new { e.So, e.Tieude, e.Search, e.Nhap, e.Id, e.Lock, e.Ngaydexuat })
                    .HasName("_dta_index_m_nhapxuat_phieudenghi_xuong_7_628197288__K20_K1_K12_K5_21_29_37");

                entity.HasIndex(e => new { e.So, e.Tieude, e.Search, e.Nhap, e.Lock, e.Ngaydexuat1, e.Id })
                    .HasName("_dta_index_m_nhapxuat_phieudenghi_xuong_8_628197288__K20_K12_K44_K1_21_29_37");

                entity.HasIndex(e => new { e.Nhap, e.So, e.Tieude, e.Search, e.Hopdong, e.Id, e.Lock, e.Ngaydexuat })
                    .HasName("_dta_index_m_nhapxuat_phieudenghi_xuong_7_628197288__K13_K1_K12_K5_20_21_29_37");

                entity.HasIndex(e => new { e.Nhap, e.So, e.Tieude, e.Search, e.Hopdong, e.Id, e.Lock, e.Ngaydexuat1 })
                    .HasName("_dta_index_m_nhapxuat_phieudenghi_xuong_8_628197288__K13_K1_K12_K44_20_21_29_37");

                entity.Property(e => e.Chiphivanchuyen).HasDefaultValueSql("((0))");

                entity.Property(e => e.Co)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Diadiemgiao).HasDefaultValueSql("(N'Kho BX 16')");

                entity.Property(e => e.Iddoitac).HasDefaultValueSql("((0))");

                entity.Property(e => e.Kho).HasDefaultValueSql("((0))");

                entity.Property(e => e.Lock).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ngaydexuat1).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ngayketthuc1).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nguoilapphieu).HasDefaultValueSql("((-1))");

                entity.Property(e => e.Nhap).HasDefaultValueSql("((1))");

                entity.Property(e => e.No)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.So).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tendt).HasDefaultValueSql("(N'Không có nhà cung cấp')");

                entity.Property(e => e.Thanhtoan).HasDefaultValueSql("(N'CK')");

                entity.Property(e => e.Thihanh).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tongtien).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tongtienchietkhau).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tongtiensauchietkhau).HasDefaultValueSql("((0))");

                entity.Property(e => e.XoaHuydonhang).HasDefaultValueSql("((0))");

                entity.Property(e => e.XoaXacnhan).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MNhatkythicong>(entity =>
            {
                entity.HasIndex(e => e.Idhopdong)
                    .HasName("_dta_index_m_nhatkythicong_7_1367050189__K5");

                entity.HasIndex(e => new { e.Noidung, e.Id, e.Idhopdong })
                    .HasName("_dta_index_m_nhatkythicong_7_1367050189__K1_K5_6");

                entity.HasIndex(e => new { e.Id, e.Iduser, e.Idhopdong, e.Ngay })
                    .HasName("_dta_index_m_nhatkythicong_7_1367050189__K5_K2D_1_4");

                entity.Property(e => e.Iduser).HasDefaultValueSql("((0))");

                entity.Property(e => e.Logs).HasDefaultValueSql("(N'!')");

                entity.Property(e => e.Ngay).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MProjectPhotos>(entity =>
            {
                entity.HasIndex(e => e.Checked)
                    .HasName("checked");

                entity.HasIndex(e => e.Ten)
                    .HasName("ten");

                entity.HasIndex(e => e.Url1)
                    .HasName("url1");

                entity.Property(e => e.Checked).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ten).HasDefaultValueSql("(N'Name Project')");

                entity.Property(e => e.Url1).HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<MSotaikhoan>(entity =>
            {
                entity.HasKey(e => e.So)
                    .HasName("PK_m_sotaikhoan_1");

                entity.Property(e => e.So)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cap).HasDefaultValueSql("((1))");

                entity.Property(e => e.Diengiai).HasDefaultValueSql("('')");

                entity.Property(e => e.Diengiailoai).HasDefaultValueSql("(N'Chi phí sản xuất kinh doanh')");

                entity.Property(e => e.Loai).HasDefaultValueSql("((6))");

                entity.Property(e => e.Socha)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<MSystem>(entity =>
            {
                entity.Property(e => e.Lastupdateonline).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MThumucfile>(entity =>
            {
                entity.Property(e => e.Idparent).HasDefaultValueSql("((-1))");

                entity.Property(e => e.Numchild).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MVanban>(entity =>
            {
                entity.Property(e => e.Lock).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ngay).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Nhanvienit>(entity =>
            {
                entity.HasIndex(e => e.Lastonline)
                    .HasName("lastonline");

                entity.HasIndex(e => e.Online)
                    .HasName("online");

                entity.HasIndex(e => new { e.FullName, e.Id })
                    .HasName("_for_get_thaoluan");

                entity.HasIndex(e => new { e.Hoten, e.Id })
                    .HasName("_get_comment_on_hopdong2");

                entity.HasIndex(e => new { e.Id, e.Online, e.FullName, e.Bophan, e.Loai })
                    .HasName("_dta_index_nhanvienit_7_75147313__K17_K13_1_22_83");

                entity.Property(e => e.Ahdemail).IsUnicode(false);

                entity.Property(e => e.CountImNotread).HasDefaultValueSql("((0))");

                entity.Property(e => e.Countmsg).HasDefaultValueSql("((0))");

                entity.Property(e => e.Countnotemgs).HasDefaultValueSql("((0))");

                entity.Property(e => e.Iplogs)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Lastonline).HasDefaultValueSql("((0))");

                entity.Property(e => e.Lasttimeonline).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Lock).HasDefaultValueSql("((0))");

                entity.Property(e => e.Luongphucap).HasDefaultValueSql("((0))");

                entity.Property(e => e.Luongtrachnhiem).HasDefaultValueSql("((0))");

                entity.Property(e => e.Motacongviec).HasDefaultValueSql("(N'<ahd></ahd>')");

                entity.Property(e => e.Mucluong).HasDefaultValueSql("((0))");

                entity.Property(e => e.Online).HasDefaultValueSql("((0))");

                entity.Property(e => e.PerIscongtacvienIt).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Phieuchi>(entity =>
            {
                entity.HasIndex(e => e.Co)
                    .HasName("co");

                entity.HasIndex(e => e.Hopdong)
                    .HasName("hopdong");

                entity.HasIndex(e => e.Kieuphieu)
                    .HasName("kieuphieu");

                entity.HasIndex(e => e.MDaxacnhan)
                    .HasName("m_daxacnhan");

                entity.HasIndex(e => e.MNhanvienlap)
                    .HasName("m_nhanvienlap");

                entity.HasIndex(e => e.Nguoinhan)
                    .HasName("nguoinhan");

                entity.HasIndex(e => e.No)
                    .HasName("no");

                entity.HasIndex(e => e.Phanloai)
                    .HasName("phanloai");

                entity.HasIndex(e => e.So)
                    .HasName("so");

                entity.HasIndex(e => new { e.MDaxacnhan, e.Hopdong })
                    .HasName("_dta_index_phieuchi_7_270624007__K10_K16");

                entity.HasIndex(e => new { e.Hopdong, e.MDaxacnhan, e.Id })
                    .HasName("_dta_index_phieuchi_7_270624007__K16_K10_K1");

                entity.HasIndex(e => new { e.Ngays, e.Thangs, e.Nams })
                    .HasName("NonClusteredIndex-20130228-154242");

                entity.HasIndex(e => new { e.Sotien, e.Hopdong, e.Kieuphieu, e.Id })
                    .HasName("_dta_index_phieuchi_thuchihopdong");

                entity.HasIndex(e => new { e.Sotien, e.Hopdong, e.Kieuphieu, e.Co, e.Id })
                    .HasName("_dta_index_phieuchi_8_1981201165__K8_K9_K13_K1_16");

                entity.HasIndex(e => new { e.Co, e.Sotien, e.Hopdong, e.Kieuphieu, e.No, e.Id })
                    .HasName("_dta_index_phieuchi_8_1981201165__K8_K9_K14_K1_13_16");

                entity.HasIndex(e => new { e.Id, e.So, e.MNhanvienlap, e.MDaxacnhan, e.Hopdong, e.Kieuphieu, e.Sotien, e.Nguoinhan, e.NgaylapNew })
                    .HasName("_dta_index_phieuchi_8_35743608__K9_K28_1_3_4_5_10_11_18");

                entity.HasIndex(e => new { e.So, e.MNhanvienlap, e.MDaxacnhan, e.Hopdong, e.Kieuphieu, e.Sotien, e.Id, e.Nguoinhan, e.NgaylapNew })
                    .HasName("_dta_index_phieuchi_8_35743608__K1_K9_K28_3_4_5_10_11_18");

                entity.HasIndex(e => new { e.MNhanvienlap, e.Hopdong, e.Sotien, e.Lydo, e.Nguoinhan, e.Id, e.No, e.Co, e.Idlink, e.NgaychiNew })
                    .HasName("_dta_index_phieuchi_8_1317843114__K7_K1_K14_K13_K17_K24_4_8_16_22");

                entity.HasIndex(e => new { e.So, e.MNhanvienlap, e.MDaxacnhan, e.Hopdong, e.Kieuphieu, e.Sotien, e.Phanloai, e.Nguoinhan, e.Id, e.NgaylapNew })
                    .HasName("_dta_index_phieuchi_8_35743608__K17_K9_K1_K28_3_4_5_10_11_18");

                entity.HasIndex(e => new { e.Id, e.So, e.MNhanvienlap, e.MDaxacnhan, e.Hopdong, e.Kieuphieu, e.Sotien, e.No, e.Nguoinhan, e.Idlink, e.Phanloai, e.NgaylapNew })
                    .HasName("_dta_index_phieuchi_8_35743608__K16_K9_K19_K17_K28_1_3_4_5_10_11_18");

                entity.HasIndex(e => new { e.So, e.MNhanvienlap, e.MDaxacnhan, e.Hopdong, e.Kieuphieu, e.Sotien, e.Co, e.Nguoinhan, e.Id, e.Idlink, e.Phanloai, e.NgaylapNew })
                    .HasName("_dta_index_phieuchi_8_35743608__K15_K9_K1_K19_K17_K28_3_4_5_10_11_18");

                entity.Property(e => e.Co)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Hopdong).HasDefaultValueSql("((0))");

                entity.Property(e => e.Idlink).HasDefaultValueSql("((0))");

                entity.Property(e => e.Kemtheo).HasDefaultValueSql("('')");

                entity.Property(e => e.Kieuphieu).HasDefaultValueSql("((0))");

                entity.Property(e => e.Loaikhoanchi).HasDefaultValueSql("((0))");

                entity.Property(e => e.Logchange).HasDefaultValueSql("('')");

                entity.Property(e => e.Lydo).HasDefaultValueSql("('')");

                entity.Property(e => e.MDaxacnhan).HasDefaultValueSql("((0))");

                entity.Property(e => e.MGhichu).HasDefaultValueSql("('')");

                entity.Property(e => e.Nams).HasDefaultValueSql("((0))");

                entity.Property(e => e.NgaychiNew).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ngayduyet).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NgaylapNew).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ngays).HasDefaultValueSql("((0))");

                entity.Property(e => e.Nguoiduyet).HasDefaultValueSql("((1))");

                entity.Property(e => e.No)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Phanloai).HasDefaultValueSql("(N'')");

                entity.Property(e => e.Quyenso).HasDefaultValueSql("((3))");

                entity.Property(e => e.Search).HasDefaultValueSql("('')");

                entity.Property(e => e.Sotien).HasDefaultValueSql("((0))");

                entity.Property(e => e.Thangs).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ton).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Sanpham>(entity =>
            {
                entity.HasIndex(e => e.Haydung);

                entity.HasIndex(e => e.Lasselect)
                    .HasName("IX_Sanpham_lastsec");

                entity.HasIndex(e => e.Ma)
                    .HasName("MA");

                entity.HasIndex(e => e.Ngaycapnhat);

                entity.HasIndex(e => e.Nhom)
                    .HasName("IX_Sanpham_nhom");

                entity.HasIndex(e => e.Search)
                    .HasName("search");

                entity.HasIndex(e => e.Tungnhap);

                entity.HasIndex(e => new { e.Hang, e.Id, e.Nhom })
                    .HasName("_dta_index_Sanpham_7_381836084__K4_K1_K3");

                entity.HasIndex(e => new { e.Search, e.Ma, e.Ten, e.Id })
                    .HasName("_dta_index_Sanpham_8_381836084__K1_24_25_27");

                entity.HasIndex(e => new { e.Search, e.Ma, e.Ten, e.Phanloai, e.Id })
                    .HasName("_dta_index_Sanpham_7_381836084__K8_K1_24_25_27");

                entity.HasIndex(e => new { e.Hang, e.Dv, e.Ma, e.Ten, e.Id, e.Phanloai })
                    .HasName("_dta_index_Sanpham_for_selectondonhang");

                entity.HasIndex(e => new { e.Id, e.Dongia, e.Tungnhap, e.Kiem, e.IdBx, e.Search, e.Ma, e.Ten, e.Nhom })
                    .HasName("_search_sanpham");

                entity.HasIndex(e => new { e.Dongia, e.Kiem, e.IdBx, e.Ma, e.Ten, e.Nhom, e.Id, e.Haydung, e.Tungnhap, e.Ngaycapnhat })
                    .HasName("_dta_index_Sanpham_7_324196205__K6_K1_K18_K17_K15_13_19_21_30_32");

                entity.HasIndex(e => new { e.Id, e.Dongia, e.Kiem, e.IdBx, e.Ma, e.Ten, e.Nhom, e.Haydung, e.Tungnhap, e.Ngaycapnhat })
                    .HasName("_dta_index_Sanpham_7_324196205__K6_K18_K17_K15_1_13_19_21_30_32");

                entity.Property(e => e.Banle).HasDefaultValueSql("((1))");

                entity.Property(e => e.CActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.CBrief).HasDefaultValueSql("('')");

                entity.Property(e => e.Chietkhau).HasDefaultValueSql("((0))");

                entity.Property(e => e.Dongia).HasDefaultValueSql("((0))");

                entity.Property(e => e.Dv).HasDefaultValueSql("((0))");

                entity.Property(e => e.Hang).HasDefaultValueSql("((0))");

                entity.Property(e => e.Haydung).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdBx).HasDefaultValueSql("((0))");

                entity.Property(e => e.Kiem).HasDefaultValueSql("((0))");

                entity.Property(e => e.Lasselect).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Lock).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ma).HasDefaultValueSql("('')");

                entity.Property(e => e.Metades).HasDefaultValueSql("('')");

                entity.Property(e => e.Metakeywords).HasDefaultValueSql("('')");

                entity.Property(e => e.Metatitle).HasDefaultValueSql("('')");

                entity.Property(e => e.Mota).HasDefaultValueSql("('')");

                entity.Property(e => e.Ngaycapnhat).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nhanvien).HasDefaultValueSql("((0))");

                entity.Property(e => e.Nhom).HasDefaultValueSql("((0))");

                entity.Property(e => e.Phanloai).HasDefaultValueSql("((0))");

                entity.Property(e => e.Quocgia).HasDefaultValueSql("('')");

                entity.Property(e => e.Search).HasDefaultValueSql("('')");

                entity.Property(e => e.Searchluu).HasDefaultValueSql("('')");

                entity.Property(e => e.Sizepic).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ten).HasDefaultValueSql("('')");

                entity.Property(e => e.Tungnhap).HasDefaultValueSql("((0))");

                entity.Property(e => e.UrlBx).HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ThuchiGoiy>(entity =>
            {
                entity.Property(e => e.So).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Tuvantinhgia>(entity =>
            {
                entity.Property(e => e.Ghichu).HasDefaultValueSql("(N'.')");

                entity.Property(e => e.Lienhelai).HasDefaultValueSql("((0))");

                entity.Property(e => e.Phanloai).HasDefaultValueSql("((1))");

                entity.Property(e => e.State).HasDefaultValueSql("((0))");
            });
        }
    }
}
