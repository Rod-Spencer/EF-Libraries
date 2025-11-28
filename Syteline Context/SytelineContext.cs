using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace SpenSoft.EF.Syteline;

public partial class SytelineContext : DbContext
{
    public SytelineContext()
    {
    }

    public SytelineContext(DbContextOptions<SytelineContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Contact_Info> ContactInfos { get; set; }

    public virtual DbSet<Co> Cos { get; set; }

    public virtual DbSet<Coitem> Coitems { get; set; }

    public virtual DbSet<ConnectionInformation> ConnectionInformations { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<Custaddr> Custaddrs { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<FsConfig> FsConfigs { get; set; }

    public virtual DbSet<FsConsumer> FsConsumers { get; set; }

    public virtual DbSet<FsCustomer> FsCustomers { get; set; }

    public virtual DbSet<FsIncident> FsIncidents { get; set; }

    public virtual DbSet<FsItem> FsItems { get; set; }

    public virtual DbSet<FsItemWarr> FsItemWarrs { get; set; }

    public virtual DbSet<FsOperCode> FsOperCodes { get; set; }

    public virtual DbSet<FsPartner> FsPartners { get; set; }

    public virtual DbSet<FsPriorCode> FsPriorCodes { get; set; }

    public virtual DbSet<FsRegion> FsRegions { get; set; }

    public virtual DbSet<FsResGen> FsResGens { get; set; }

    public virtual DbSet<FsResSpec> FsResSpecs { get; set; }

    public virtual DbSet<FsSro> FsSros { get; set; }

    public virtual DbSet<FsSroLine> FsSroLines { get; set; }

    public virtual DbSet<FsSroLineMatl> FsSroLineMatls { get; set; }

    public virtual DbSet<FsSroMatl> FsSroMatls { get; set; }

    public virtual DbSet<FsSroOper> FsSroOpers { get; set; }

    public virtual DbSet<FsSroStat> FsSroStats { get; set; }

    public virtual DbSet<FsSroType> FsSroTypes { get; set; }

    public virtual DbSet<FsStatCode> FsStatCodes { get; set; }

    public virtual DbSet<FsUnit> FsUnits { get; set; }

    public virtual DbSet<FsUnitStatCode> FsUnitStatCodes { get; set; }

    public virtual DbSet<FsUnitWarr> FsUnitWarrs { get; set; }

    public virtual DbSet<FsWarrCode> FsWarrCodes { get; set; }

    public virtual DbSet<Item> Items { get; set; }

    public virtual DbSet<NoteHeader> NoteHeaders { get; set; }

    public virtual DbSet<NoteType> NoteTypes { get; set; }

    public virtual DbSet<ObjectNote> ObjectNotes { get; set; }

    public virtual DbSet<ObjectType> ObjectTypes { get; set; }

    public virtual DbSet<Pricecode> Pricecodes { get; set; }

    public virtual DbSet<SegEndUserChannel> SegEndUserChannels { get; set; }

    public virtual DbSet<SegFsSrolineRecTest> SegFsSrolineRecTests { get; set; }

    public virtual DbSet<SegFsUnitWarrHist> SegFsUnitWarrHists { get; set; }

    public virtual DbSet<SegSalesRegionGroup> SegSalesRegionGroups { get; set; }

    public virtual DbSet<SegSartPicture> SegSartPictures { get; set; }

    public virtual DbSet<Serial> Serials { get; set; }

    public virtual DbSet<Site> Sites { get; set; }

    public virtual DbSet<SpecificNote> SpecificNotes { get; set; }

    public virtual DbSet<SystemNote> SystemNotes { get; set; }

    public virtual DbSet<UM> UMs { get; set; }

    public virtual DbSet<UserDefinedField> UserDefinedFields { get; set; }

    public virtual DbSet<UserDefinedType> UserDefinedTypes { get; set; }

    public virtual DbSet<UserDefinedTypeValue> UserDefinedTypeValues { get; set; }

    public virtual DbSet<UserNote> UserNotes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var jsonSetting = new ConfigurationBuilder().AddJsonFile("appsettings-EF-Syteline.json").Build();

        var connectionString = jsonSetting.GetConnectionString("SytelineContext");
        optionsBuilder.UseSqlServer(connectionString);
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Prevent EF from mapping TechnicianName to a column
        modelBuilder.Entity<FsSro>().Ignore(e => e.TechnicianName);

        modelBuilder.Entity<Contact_Info>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.RefNum).HasMaxLength(10);
            entity.Property(e => e.RefSeq).HasColumnType("int");
            entity.Property(e => e.Name).HasMaxLength(60);
            entity.Property(e => e.Contact).HasMaxLength(60);
            entity.Property(e => e.Address1).HasMaxLength(100);
            entity.Property(e => e.Address2).HasMaxLength(100);
            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.State).HasMaxLength(60);
            entity.Property(e => e.Zip).HasMaxLength(60);
            entity.Property(e => e.County).HasMaxLength(60);
            entity.Property(e => e.Country).HasMaxLength(60);
            entity.Property(e => e.Phone).HasMaxLength(25);
            entity.Property(e => e.Email).HasMaxLength(255);
        });


        modelBuilder.Entity<Co>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("co");

            entity.Property(e => e.AckStat)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("ack_stat");
            entity.Property(e => e.ApplyToInvNum)
                .HasMaxLength(12)
                .HasColumnName("apply_to_inv_num");
            entity.Property(e => e.ApsPullUp).HasColumnName("aps_pull_up");
            entity.Property(e => e.Charfld1)
                .HasMaxLength(20)
                .HasColumnName("charfld1");
            entity.Property(e => e.Charfld2)
                .HasMaxLength(20)
                .HasColumnName("charfld2");
            entity.Property(e => e.Charfld3)
                .HasMaxLength(20)
                .HasColumnName("charfld3");
            entity.Property(e => e.CloseDate)
                .HasColumnType("datetime")
                .HasColumnName("close_date");
            entity.Property(e => e.CoNum)
                .HasMaxLength(10)
                .HasColumnName("co_num");
            entity.Property(e => e.ConfigId)
                .HasMaxLength(12)
                .HasColumnName("config_id");
            entity.Property(e => e.Consignment).HasColumnName("consignment");
            entity.Property(e => e.Consolidate).HasColumnName("consolidate");
            entity.Property(e => e.Contact)
                .HasMaxLength(30)
                .HasColumnName("contact");
            entity.Property(e => e.ConvertType)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("convert_type");
            entity.Property(e => e.Cost)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("cost");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.CreditHold).HasColumnName("credit_hold");
            entity.Property(e => e.CreditHoldDate)
                .HasColumnType("datetime")
                .HasColumnName("credit_hold_date");
            entity.Property(e => e.CreditHoldReason)
                .HasMaxLength(3)
                .HasColumnName("credit_hold_reason");
            entity.Property(e => e.CreditHoldUser)
                .HasMaxLength(3)
                .HasColumnName("credit_hold_user");
            entity.Property(e => e.CustNum)
                .HasMaxLength(7)
                .HasColumnName("cust_num");
            entity.Property(e => e.CustPo)
                .HasMaxLength(22)
                .HasColumnName("cust_po");
            entity.Property(e => e.CustSeq).HasColumnName("cust_seq");
            entity.Property(e => e.Datefld)
                .HasColumnType("datetime")
                .HasColumnName("datefld");
            entity.Property(e => e.DaysShippedAfterDueDateTolerance).HasColumnName("days_shipped_after_due_date_tolerance");
            entity.Property(e => e.DaysShippedBeforeDueDateTolerance).HasColumnName("days_shipped_before_due_date_tolerance");
            entity.Property(e => e.Decifld1)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld1");
            entity.Property(e => e.Decifld2)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld2");
            entity.Property(e => e.Decifld3)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld3");
            entity.Property(e => e.Delterm)
                .HasMaxLength(4)
                .HasColumnName("delterm");
            entity.Property(e => e.Disc)
                .HasColumnType("decimal(7, 4)")
                .HasColumnName("disc");
            entity.Property(e => e.DiscAmount)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("disc_amount");
            entity.Property(e => e.DiscountType)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("discount_type");
            entity.Property(e => e.EdiOrder).HasColumnName("edi_order");
            entity.Property(e => e.EdiType)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("edi_type");
            entity.Property(e => e.EffDate)
                .HasColumnType("datetime")
                .HasColumnName("eff_date");
            entity.Property(e => e.Einvoice).HasColumnName("einvoice");
            entity.Property(e => e.EndUserType)
                .HasMaxLength(6)
                .HasColumnName("end_user_type");
            entity.Property(e => e.EstNum)
                .HasMaxLength(10)
                .HasColumnName("est_num");
            entity.Property(e => e.ExchRate)
                .HasColumnType("decimal(12, 7)")
                .HasColumnName("exch_rate");
            entity.Property(e => e.ExpDate)
                .HasColumnType("datetime")
                .HasColumnName("exp_date");
            entity.Property(e => e.ExportType)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("export_type");
            entity.Property(e => e.ExternalConfirmationRef)
                .HasMaxLength(80)
                .HasColumnName("external_confirmation_ref");
            entity.Property(e => e.FixedRate).HasColumnName("fixed_rate");
            entity.Property(e => e.FovhdCostT)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("fovhd_cost_t");
            entity.Property(e => e.Freight)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("freight");
            entity.Property(e => e.FreightT)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("freight_t");
            entity.Property(e => e.FrtTaxCode1)
                .HasMaxLength(6)
                .HasColumnName("frt_tax_code1");
            entity.Property(e => e.FrtTaxCode2)
                .HasMaxLength(6)
                .HasColumnName("frt_tax_code2");
            entity.Property(e => e.IncludeTaxInPrice).HasColumnName("include_tax_in_price");
            entity.Property(e => e.InvFreq)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("inv_freq");
            entity.Property(e => e.Invoiced).HasColumnName("invoiced");
            entity.Property(e => e.IsExternal).HasColumnName("is_external");
            entity.Property(e => e.LbrCostT)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("lbr_cost_t");
            entity.Property(e => e.LcrNum)
                .HasMaxLength(20)
                .HasColumnName("lcr_num");
            entity.Property(e => e.LeadId)
                .HasMaxLength(10)
                .HasColumnName("lead_id");
            entity.Property(e => e.Logifld).HasColumnName("logifld");
            entity.Property(e => e.MChargesT)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("m_charges_t");
            entity.Property(e => e.MatlCostT)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("matl_cost_t");
            entity.Property(e => e.MiscCharges)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("misc_charges");
            entity.Property(e => e.MscTaxCode1)
                .HasMaxLength(6)
                .HasColumnName("msc_tax_code1");
            entity.Property(e => e.MscTaxCode2)
                .HasMaxLength(6)
                .HasColumnName("msc_tax_code2");
            entity.Property(e => e.OppId)
                .HasMaxLength(10)
                .HasColumnName("opp_id");
            entity.Property(e => e.OrderDate)
                .HasColumnType("datetime")
                .HasColumnName("order_date");
            entity.Property(e => e.OrderSource)
                .HasMaxLength(8)
                .HasColumnName("order_source");
            entity.Property(e => e.OrigSite)
                .HasMaxLength(8)
                .HasColumnName("orig_site");
            entity.Property(e => e.OutCostT)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("out_cost_t");
            entity.Property(e => e.Phone)
                .HasMaxLength(25)
                .HasColumnName("phone");
            entity.Property(e => e.PrepaidAmt)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("prepaid_amt");
            entity.Property(e => e.PrepaidT)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("prepaid_t");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("price");
            entity.Property(e => e.Pricecode)
                .HasMaxLength(3)
                .HasColumnName("pricecode");
            entity.Property(e => e.Priority).HasColumnName("priority");
            entity.Property(e => e.ProcessInd)
                .HasMaxLength(1)
                .HasColumnName("process_ind");
            entity.Property(e => e.ProjectedDate)
                .HasColumnType("datetime")
                .HasColumnName("projected_date");
            entity.Property(e => e.ProspectId)
                .HasMaxLength(7)
                .HasColumnName("prospect_id");
            entity.Property(e => e.QtyPackages).HasColumnName("qty_packages");
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.SalesTax)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("sales_tax");
            entity.Property(e => e.SalesTax2)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("sales_tax_2");
            entity.Property(e => e.SalesTaxT)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("sales_tax_t");
            entity.Property(e => e.SalesTaxT2)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("sales_tax_t2");
            entity.Property(e => e.ShipCode)
                .HasMaxLength(4)
                .HasColumnName("ship_code");
            entity.Property(e => e.ShipEarly).HasColumnName("ship_early");
            entity.Property(e => e.ShipPartial).HasColumnName("ship_partial");
            entity.Property(e => e.ShippedOverOrderedQtyTolerance)
                .HasColumnType("decimal(7, 4)")
                .HasColumnName("shipped_over_ordered_qty_tolerance");
            entity.Property(e => e.ShippedUnderOrderedQtyTolerance)
                .HasColumnType("decimal(7, 4)")
                .HasColumnName("shipped_under_ordered_qty_tolerance");
            entity.Property(e => e.Slsman)
                .HasMaxLength(8)
                .HasColumnName("slsman");
            entity.Property(e => e.Stat)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("stat");
            entity.Property(e => e.Summarize).HasColumnName("summarize");
            entity.Property(e => e.SyncReqd).HasColumnName("sync_reqd");
            entity.Property(e => e.TakenBy)
                .HasMaxLength(15)
                .HasColumnName("taken_by");
            entity.Property(e => e.TaxCode1)
                .HasMaxLength(6)
                .HasColumnName("tax_code1");
            entity.Property(e => e.TaxCode2)
                .HasMaxLength(6)
                .HasColumnName("tax_code2");
            entity.Property(e => e.TermsCode)
                .HasMaxLength(3)
                .HasColumnName("terms_code");
            entity.Property(e => e.TransNat)
                .HasMaxLength(2)
                .HasColumnName("trans_nat");
            entity.Property(e => e.TransNat2)
                .HasMaxLength(2)
                .HasColumnName("trans_nat_2");
            entity.Property(e => e.Type)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("type");
            entity.Property(e => e.UfSegCoDirectSale).HasColumnName("Uf_SEG_CO_DirectSale");
            entity.Property(e => e.UfSegCoPrepayAmt)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("Uf_Seg_Co_PrepayAmt");
            entity.Property(e => e.UfSegCoPrepayRef)
                .HasMaxLength(40)
                .HasColumnName("Uf_Seg_Co_PrepayRef");
            entity.Property(e => e.UfSegCoShopifyOrdNum)
                .HasMaxLength(20)
                .HasColumnName("Uf_SEG_CO_ShopifyOrdNum");
            entity.Property(e => e.UfSegCustOrdLangKitType)
                .HasMaxLength(30)
                .HasColumnName("Uf_SEG_CUST_ORD_LANG_KIT_TYPE");
            entity.Property(e => e.UfSegDealerNum)
                .HasMaxLength(7)
                .HasColumnName("Uf_SEG_DealerNum");
            entity.Property(e => e.UfSegDealerSeq).HasColumnName("Uf_SEG_DealerSeq");
            entity.Property(e => e.UpdatedBy).HasMaxLength(30);
            entity.Property(e => e.UseExchRate).HasColumnName("use_exch_rate");
            entity.Property(e => e.VovhdCostT)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("vovhd_cost_t");
            entity.Property(e => e.Weight)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("weight");
            entity.Property(e => e.Whse)
                .HasMaxLength(4)
                .HasColumnName("whse");
        });

        modelBuilder.Entity<Coitem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("coitem");

            entity.Property(e => e.Bol).HasColumnName("bol");
            entity.Property(e => e.BrkQty1)
                .HasColumnType("decimal(19, 8)")
                .HasColumnName("brk_qty##1");
            entity.Property(e => e.BrkQty2)
                .HasColumnType("decimal(19, 8)")
                .HasColumnName("brk_qty##2");
            entity.Property(e => e.BrkQty3)
                .HasColumnType("decimal(19, 8)")
                .HasColumnName("brk_qty##3");
            entity.Property(e => e.BrkQty4)
                .HasColumnType("decimal(19, 8)")
                .HasColumnName("brk_qty##4");
            entity.Property(e => e.BrkQty5)
                .HasColumnType("decimal(19, 8)")
                .HasColumnName("brk_qty##5");
            entity.Property(e => e.CgsTotal)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("cgs_total");
            entity.Property(e => e.CgsTotalFovhd)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("cgs_total_fovhd");
            entity.Property(e => e.CgsTotalLbr)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("cgs_total_lbr");
            entity.Property(e => e.CgsTotalMatl)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("cgs_total_matl");
            entity.Property(e => e.CgsTotalOut)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("cgs_total_out");
            entity.Property(e => e.CgsTotalVovhd)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("cgs_total_vovhd");
            entity.Property(e => e.CoCustNum)
                .HasMaxLength(7)
                .HasColumnName("co_cust_num");
            entity.Property(e => e.CoLine).HasColumnName("co_line");
            entity.Property(e => e.CoNum)
                .HasMaxLength(10)
                .HasColumnName("co_num");
            entity.Property(e => e.CoOrigSite)
                .HasMaxLength(8)
                .HasColumnName("co_orig_site");
            entity.Property(e => e.CoRelease).HasColumnName("co_release");
            entity.Property(e => e.CommCode)
                .HasMaxLength(12)
                .HasColumnName("comm_code");
            entity.Property(e => e.ConfigId)
                .HasMaxLength(12)
                .HasColumnName("config_id");
            entity.Property(e => e.ConsNum).HasColumnName("cons_num");
            entity.Property(e => e.Consolidate).HasColumnName("consolidate");
            entity.Property(e => e.Cost)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("cost");
            entity.Property(e => e.CostConv)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("cost_conv");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.CustItem)
                .HasMaxLength(30)
                .HasColumnName("cust_item");
            entity.Property(e => e.CustNum)
                .HasMaxLength(7)
                .HasColumnName("cust_num");
            entity.Property(e => e.CustPo)
                .HasMaxLength(22)
                .HasColumnName("cust_po");
            entity.Property(e => e.CustSeq).HasColumnName("cust_seq");
            entity.Property(e => e.DaysShippedAfterDueDateTolerance).HasColumnName("days_shipped_after_due_date_tolerance");
            entity.Property(e => e.DaysShippedBeforeDueDateTolerance).HasColumnName("days_shipped_before_due_date_tolerance");
            entity.Property(e => e.Delterm)
                .HasMaxLength(4)
                .HasColumnName("delterm");
            entity.Property(e => e.Description)
                .HasMaxLength(40)
                .HasColumnName("description");
            entity.Property(e => e.Disc)
                .HasColumnType("decimal(4, 1)")
                .HasColumnName("disc");
            entity.Property(e => e.DueDate)
                .HasColumnType("datetime")
                .HasColumnName("due_date");
            entity.Property(e => e.DueDateDay)
                .HasColumnType("datetime")
                .HasColumnName("due_date_day");
            entity.Property(e => e.EcCode)
                .HasMaxLength(2)
                .HasColumnName("ec_code");
            entity.Property(e => e.ExportValue)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("export_value");
            entity.Property(e => e.ExternalReservationRef)
                .HasMaxLength(80)
                .HasColumnName("external_reservation_ref");
            entity.Property(e => e.FeatStr)
                .HasMaxLength(40)
                .HasColumnName("feat_str");
            entity.Property(e => e.FovhdCost)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("fovhd_cost");
            entity.Property(e => e.FovhdCostConv)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("fovhd_cost_conv");
            entity.Property(e => e.FsIncNum)
                .HasMaxLength(10)
                .HasColumnName("fs_inc_num");
            entity.Property(e => e.InvFreq)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("inv_freq");
            entity.Property(e => e.InvoiceHold).HasColumnName("invoice_hold");
            entity.Property(e => e.Item)
                .HasMaxLength(30)
                .HasColumnName("item");
            entity.Property(e => e.LbrCost)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("lbr_cost");
            entity.Property(e => e.LbrCostConv)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("lbr_cost_conv");
            entity.Property(e => e.ManufacturerId)
                .HasMaxLength(7)
                .HasColumnName("manufacturer_id");
            entity.Property(e => e.ManufacturerItem)
                .HasMaxLength(30)
                .HasColumnName("manufacturer_item");
            entity.Property(e => e.MatlCost)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("matl_cost");
            entity.Property(e => e.MatlCostConv)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("matl_cost_conv");
            entity.Property(e => e.NonInvAcct)
                .HasMaxLength(12)
                .HasColumnName("non_inv_acct");
            entity.Property(e => e.NonInvAcctUnit1)
                .HasMaxLength(4)
                .HasColumnName("non_inv_acct_unit1");
            entity.Property(e => e.NonInvAcctUnit2)
                .HasMaxLength(4)
                .HasColumnName("non_inv_acct_unit2");
            entity.Property(e => e.NonInvAcctUnit3)
                .HasMaxLength(4)
                .HasColumnName("non_inv_acct_unit3");
            entity.Property(e => e.NonInvAcctUnit4)
                .HasMaxLength(4)
                .HasColumnName("non_inv_acct_unit4");
            entity.Property(e => e.Origin)
                .HasMaxLength(2)
                .HasColumnName("origin");
            entity.Property(e => e.OutCost)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("out_cost");
            entity.Property(e => e.OutCostConv)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("out_cost_conv");
            entity.Property(e => e.Packed).HasColumnName("packed");
            entity.Property(e => e.PickDate)
                .HasColumnType("datetime")
                .HasColumnName("pick_date");
            entity.Property(e => e.PrgBillApp)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("prg_bill_app");
            entity.Property(e => e.PrgBillTot)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("prg_bill_tot");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("price");
            entity.Property(e => e.PriceConv)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("price_conv");
            entity.Property(e => e.Pricecode)
                .HasMaxLength(3)
                .HasColumnName("pricecode");
            entity.Property(e => e.PrintKitComponents).HasColumnName("print_kit_components");
            entity.Property(e => e.Priority).HasColumnName("priority");
            entity.Property(e => e.ProcessInd)
                .HasMaxLength(1)
                .HasColumnName("process_ind");
            entity.Property(e => e.ProjectedDate)
                .HasColumnType("datetime")
                .HasColumnName("projected_date");
            entity.Property(e => e.PromiseDate)
                .HasColumnType("datetime")
                .HasColumnName("promise_date");
            entity.Property(e => e.QtyInvoiced)
                .HasColumnType("decimal(19, 8)")
                .HasColumnName("qty_invoiced");
            entity.Property(e => e.QtyOrdered)
                .HasColumnType("decimal(19, 8)")
                .HasColumnName("qty_ordered");
            entity.Property(e => e.QtyOrderedConv)
                .HasColumnType("decimal(19, 8)")
                .HasColumnName("qty_ordered_conv");
            entity.Property(e => e.QtyPacked)
                .HasColumnType("decimal(19, 8)")
                .HasColumnName("qty_packed");
            entity.Property(e => e.QtyReady)
                .HasColumnType("decimal(19, 8)")
                .HasColumnName("qty_ready");
            entity.Property(e => e.QtyReturned)
                .HasColumnType("decimal(19, 8)")
                .HasColumnName("qty_returned");
            entity.Property(e => e.QtyRsvd)
                .HasColumnType("decimal(19, 8)")
                .HasColumnName("qty_rsvd");
            entity.Property(e => e.QtyShipped)
                .HasColumnType("decimal(19, 8)")
                .HasColumnName("qty_shipped");
            entity.Property(e => e.RcptRqmt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("rcpt_rqmt");
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.RefLineSuf).HasColumnName("ref_line_suf");
            entity.Property(e => e.RefNum)
                .HasMaxLength(10)
                .HasColumnName("ref_num");
            entity.Property(e => e.RefRelease).HasColumnName("ref_release");
            entity.Property(e => e.RefType)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("ref_type");
            entity.Property(e => e.ReleaseDate)
                .HasColumnType("datetime")
                .HasColumnName("release_date");
            entity.Property(e => e.Reprice).HasColumnName("reprice");
            entity.Property(e => e.RmaLine).HasColumnName("rma_line");
            entity.Property(e => e.RmaNum)
                .HasMaxLength(10)
                .HasColumnName("rma_num");
            entity.Property(e => e.ShipDate)
                .HasColumnType("datetime")
                .HasColumnName("ship_date");
            entity.Property(e => e.ShipSite)
                .HasMaxLength(8)
                .HasColumnName("ship_site");
            entity.Property(e => e.ShippedOverOrderedQtyTolerance)
                .HasColumnType("decimal(7, 4)")
                .HasColumnName("shipped_over_ordered_qty_tolerance");
            entity.Property(e => e.ShippedUnderOrderedQtyTolerance)
                .HasColumnType("decimal(7, 4)")
                .HasColumnName("shipped_under_ordered_qty_tolerance");
            entity.Property(e => e.Stat)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("stat");
            entity.Property(e => e.Summarize).HasColumnName("summarize");
            entity.Property(e => e.SupplQtyConvFactor)
                .HasColumnType("decimal(18, 10)")
                .HasColumnName("suppl_qty_conv_factor");
            entity.Property(e => e.SyncReqd).HasColumnName("sync_reqd");
            entity.Property(e => e.TaxCode1)
                .HasMaxLength(6)
                .HasColumnName("tax_code1");
            entity.Property(e => e.TaxCode2)
                .HasMaxLength(6)
                .HasColumnName("tax_code2");
            entity.Property(e => e.TransNat)
                .HasMaxLength(2)
                .HasColumnName("trans_nat");
            entity.Property(e => e.TransNat2)
                .HasMaxLength(2)
                .HasColumnName("trans_nat_2");
            entity.Property(e => e.Transport)
                .HasMaxLength(3)
                .HasColumnName("transport");
            entity.Property(e => e.UM)
                .HasMaxLength(3)
                .HasColumnName("u_m");
            entity.Property(e => e.UfSegColCustCareStatus)
                .HasMaxLength(15)
                .HasColumnName("Uf_SEG_COL_CUST_CARE_STATUS");
            entity.Property(e => e.UfSegColFinStatus)
                .HasMaxLength(15)
                .HasColumnName("Uf_SEG_COL_FIN_STATUS");
            entity.Property(e => e.UfSegColLineType)
                .HasMaxLength(15)
                .HasColumnName("Uf_SEG_COL_LINE_TYPE");
            entity.Property(e => e.UfTermsCode)
                .HasMaxLength(3)
                .HasColumnName("uf_terms_code");
            entity.Property(e => e.UnitWeight)
                .HasColumnType("decimal(11, 3)")
                .HasColumnName("unit_weight");
            entity.Property(e => e.UpdatedBy).HasMaxLength(30);
            entity.Property(e => e.VovhdCost)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("vovhd_cost");
            entity.Property(e => e.VovhdCostConv)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("vovhd_cost_conv");
            entity.Property(e => e.Whse)
                .HasMaxLength(4)
                .HasColumnName("whse");
            entity.Property(e => e.WksBasis)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("wks_basis");
            entity.Property(e => e.WksValue)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("wks_value");
        });

        modelBuilder.Entity<ConnectionInformation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ConnectionInformation");

            entity.Property(e => e.ConnectionId).HasColumnName("ConnectionID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.CreationContext).HasMaxLength(255);
            entity.Property(e => e.ImpersonatingUserName).HasMaxLength(30);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.SessionSpec).HasMaxLength(1000);
            entity.Property(e => e.UpdatedBy).HasMaxLength(30);
            entity.Property(e => e.UserName).HasMaxLength(128);
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("country");

            entity.Property(e => e.Country1)
                .HasMaxLength(30)
                .HasColumnName("country");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.EcCode)
                .HasMaxLength(2)
                .HasColumnName("ec_code");
            entity.Property(e => e.ExpDocReqd).HasColumnName("exp_doc_reqd");
            entity.Property(e => e.IsoCountryCode)
                .HasMaxLength(2)
                .HasColumnName("iso_country_code");
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.SegRegion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("_SEG_Region");
            entity.Property(e => e.SsdEcCode)
                .HasMaxLength(2)
                .HasColumnName("ssd_ec_code");
            entity.Property(e => e.UpdatedBy).HasMaxLength(30);
        });

        modelBuilder.Entity<Custaddr>(entity =>
        {
            entity.HasKey(e => e.RowPointer);
            entity.ToTable("custaddr");

            entity.Property(e => e.Addr1)
                .HasMaxLength(50)
                .HasColumnName("addr##1");
            entity.Property(e => e.Addr2)
                .HasMaxLength(50)
                .HasColumnName("addr##2");
            entity.Property(e => e.Addr3)
                .HasMaxLength(50)
                .HasColumnName("addr##3");
            entity.Property(e => e.Addr4)
                .HasMaxLength(50)
                .HasColumnName("addr##4");
            entity.Property(e => e.AmtOverInvAmt)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("amt_over_inv_amt");
            entity.Property(e => e.BalMethod)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("bal_method");
            entity.Property(e => e.BillToEmail)
                .HasMaxLength(60)
                .HasColumnName("bill_to_email");
            entity.Property(e => e.City)
                .HasMaxLength(30)
                .HasColumnName("city");
            entity.Property(e => e.CorpAddress).HasColumnName("corp_address");
            entity.Property(e => e.CorpCred).HasColumnName("corp_cred");
            entity.Property(e => e.CorpCust)
                .HasMaxLength(7)
                .HasColumnName("corp_cust");
            entity.Property(e => e.Country)
                .HasMaxLength(30)
                .HasColumnName("country");
            entity.Property(e => e.County)
                .HasMaxLength(30)
                .HasColumnName("county");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.CreditHold).HasColumnName("credit_hold");
            entity.Property(e => e.CreditHoldDate)
                .HasColumnType("datetime")
                .HasColumnName("credit_hold_date");
            entity.Property(e => e.CreditHoldReason)
                .HasMaxLength(3)
                .HasColumnName("credit_hold_reason");
            entity.Property(e => e.CreditHoldUser)
                .HasMaxLength(3)
                .HasColumnName("credit_hold_user");
            entity.Property(e => e.CreditLimit)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("credit_limit");
            entity.Property(e => e.CurrCode)
                .HasMaxLength(3)
                .HasColumnName("curr_code");
            entity.Property(e => e.CustNum)
                .HasMaxLength(7)
                .HasColumnName("cust_num");
            entity.Property(e => e.CustSeq).HasColumnName("cust_seq");
            entity.Property(e => e.DaysOverInvDueDate).HasColumnName("days_over_inv_due_date");
            entity.Property(e => e.ExternalEmailAddr)
                .HasMaxLength(60)
                .HasColumnName("external_email_addr");
            entity.Property(e => e.FaxNum)
                .HasMaxLength(25)
                .HasColumnName("fax_num");
            entity.Property(e => e.InternalEmailAddr)
                .HasMaxLength(60)
                .HasColumnName("internal_email_addr");
            entity.Property(e => e.InternetUrl)
                .HasMaxLength(150)
                .HasColumnName("internet_url");
            entity.Property(e => e.Name)
                .HasMaxLength(60)
                .HasColumnName("name");
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.ShipToEmail)
                .HasMaxLength(60)
                .HasColumnName("ship_to_email");
            entity.Property(e => e.State)
                .HasMaxLength(5)
                .HasColumnName("state");
            entity.Property(e => e.TelexNum)
                .HasMaxLength(25)
                .HasColumnName("telex_num");
            entity.Property(e => e.UpdatedBy).HasMaxLength(30);
            entity.Property(e => e.Zip)
                .HasMaxLength(10)
                .HasColumnName("zip");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.RowPointer).HasName("PK__Customer__219964B1B679EAEE");

            entity.ToTable("Customer");

            entity.Property(e => e.RowPointer)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ROW_POINTER");
            entity.Property(e => e.ActiveForDataIntegration).HasColumnName("ACTIVE_FOR_DATA_INTEGRATION");
            entity.Property(e => e.ApsPullUp).HasColumnName("APS_PULL_UP");
            entity.Property(e => e.AvgBalOs)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("AVG_BAL_OS");
            entity.Property(e => e.AvgDaysOs).HasColumnName("AVG_DAYS_OS");
            entity.Property(e => e.BankCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("BANK_CODE");
            entity.Property(e => e.BranchId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("BRANCH_ID");
            entity.Property(e => e.CalcDate)
                .HasColumnType("datetime")
                .HasColumnName("CALC_DATE");
            entity.Property(e => e.Charfld1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CHARFLD1");
            entity.Property(e => e.Charfld2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CHARFLD2");
            entity.Property(e => e.Charfld3)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CHARFLD3");
            entity.Property(e => e.CompanyRevenue)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("COMPANY_REVENUE");
            entity.Property(e => e.Consolidate).HasColumnName("CONSOLIDATE");
            entity.Property(e => e.ConstructiveSalePricePct)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("CONSTRUCTIVE_SALE_PRICE_PCT");
            entity.Property(e => e.Contact1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CONTACT##1");
            entity.Property(e => e.Contact2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CONTACT##2");
            entity.Property(e => e.Contact3)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CONTACT##3");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CrmGuid).HasColumnName("CRM_GUID");
            entity.Property(e => e.CustBank)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CUST_BANK");
            entity.Property(e => e.CustNum)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("CUST_NUM");
            entity.Property(e => e.CustSeq).HasColumnName("CUST_SEQ");
            entity.Property(e => e.CustType)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("CUST_TYPE");
            entity.Property(e => e.CustomerEmailAddr)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("CUSTOMER_EMAIL_ADDR");
            entity.Property(e => e.Datefld)
                .HasColumnType("datetime")
                .HasColumnName("DATEFLD");
            entity.Property(e => e.DaysShippedAfterDueDateTolerance).HasColumnName("DAYS_SHIPPED_AFTER_DUE_DATE_TOLERANCE");
            entity.Property(e => e.DaysShippedBeforeDueDateTolerance).HasColumnName("DAYS_SHIPPED_BEFORE_DUE_DATE_TOLERANCE");
            entity.Property(e => e.Decifld1)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("DECIFLD1");
            entity.Property(e => e.Decifld2)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("DECIFLD2");
            entity.Property(e => e.Decifld3)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("DECIFLD3");
            entity.Property(e => e.DefaultShipTo).HasColumnName("DEFAULT_SHIP_TO");
            entity.Property(e => e.Delterm)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("DELTERM");
            entity.Property(e => e.DiscLstYr)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("DISC_LST_YR");
            entity.Property(e => e.DiscYtd)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("DISC_YTD");
            entity.Property(e => e.DoInvoice)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DO_INVOICE");
            entity.Property(e => e.DraftPrintFlag).HasColumnName("DRAFT_PRINT_FLAG");
            entity.Property(e => e.EdiCust).HasColumnName("EDI_CUST");
            entity.Property(e => e.Einvoice).HasColumnName("EINVOICE");
            entity.Property(e => e.EndUserType)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("END_USER_TYPE");
            entity.Property(e => e.ExportType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EXPORT_TYPE");
            entity.Property(e => e.FinChg).HasColumnName("FIN_CHG");
            entity.Property(e => e.HistDaysOs).HasColumnName("HIST_DAYS_OS");
            entity.Property(e => e.InWorkflow).HasColumnName("IN_WORKFLOW");
            entity.Property(e => e.IncludeOrdersInTaxRpt).HasColumnName("INCLUDE_ORDERS_IN_TAX_RPT");
            entity.Property(e => e.IncludeTaxInPrice).HasColumnName("INCLUDE_TAX_IN_PRICE");
            entity.Property(e => e.InvCategory)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("INV_CATEGORY");
            entity.Property(e => e.InvFreq)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("INV_FREQ");
            entity.Property(e => e.LangCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("LANG_CODE");
            entity.Property(e => e.LargDaysOs).HasColumnName("LARG_DAYS_OS");
            entity.Property(e => e.LargeBalOs)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("LARGE_BAL_OS");
            entity.Property(e => e.LastBalOs)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("LAST_BAL_OS");
            entity.Property(e => e.LastDaysOs).HasColumnName("LAST_DAYS_OS");
            entity.Property(e => e.LastFinChg)
                .HasColumnType("datetime")
                .HasColumnName("LAST_FIN_CHG");
            entity.Property(e => e.LastInv)
                .HasColumnType("datetime")
                .HasColumnName("LAST_INV");
            entity.Property(e => e.LastPaid)
                .HasColumnType("datetime")
                .HasColumnName("LAST_PAID");
            entity.Property(e => e.LcrReqd).HasColumnName("LCR_REQD");
            entity.Property(e => e.Logifld).HasColumnName("LOGIFLD");
            entity.Property(e => e.NoteExistsFlag).HasColumnName("NOTE_EXISTS_FLAG");
            entity.Property(e => e.NumInvoices).HasColumnName("NUM_INVOICES");
            entity.Property(e => e.NumPeriods).HasColumnName("NUM_PERIODS");
            entity.Property(e => e.NumberOfEmployees).HasColumnName("NUMBER_OF_EMPLOYEES");
            entity.Property(e => e.OnePackInv).HasColumnName("ONE_PACK_INV");
            entity.Property(e => e.OrderBal)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("ORDER_BAL");
            entity.Property(e => e.PayDay).HasColumnName("PAY_DAY");
            entity.Property(e => e.PayDayEndTime1)
                .HasColumnType("datetime")
                .HasColumnName("PAY_DAY_END_TIME##1");
            entity.Property(e => e.PayDayEndTime2)
                .HasColumnType("datetime")
                .HasColumnName("PAY_DAY_END_TIME##2");
            entity.Property(e => e.PayDayStartTime1)
                .HasColumnType("datetime")
                .HasColumnName("PAY_DAY_START_TIME##1");
            entity.Property(e => e.PayDayStartTime2)
                .HasColumnType("datetime")
                .HasColumnName("PAY_DAY_START_TIME##2");
            entity.Property(e => e.PayType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PAY_TYPE");
            entity.Property(e => e.Phone1)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PHONE##1");
            entity.Property(e => e.Phone2)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PHONE##2");
            entity.Property(e => e.Phone3)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PHONE##3");
            entity.Property(e => e.PostedBal)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("POSTED_BAL");
            entity.Property(e => e.Pricecode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("PRICECODE");
            entity.Property(e => e.PrintPackInv).HasColumnName("PRINT_PACK_INV");
            entity.Property(e => e.ProcessInd)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PROCESS_IND");
            entity.Property(e => e.RcvInternalEmail).HasColumnName("RCV_INTERNAL_EMAIL");
            entity.Property(e => e.RecordDate)
                .HasColumnType("datetime")
                .HasColumnName("RECORD_DATE");
            entity.Property(e => e.RevisionDay).HasColumnName("REVISION_DAY");
            entity.Property(e => e.RevisionDayEndTime1)
                .HasColumnType("datetime")
                .HasColumnName("REVISION_DAY_END_TIME##1");
            entity.Property(e => e.RevisionDayEndTime2)
                .HasColumnType("datetime")
                .HasColumnName("REVISION_DAY_END_TIME##2");
            entity.Property(e => e.RevisionDayStartTime1)
                .HasColumnType("datetime")
                .HasColumnName("REVISION_DAY_START_TIME##1");
            entity.Property(e => e.RevisionDayStartTime2)
                .HasColumnType("datetime")
                .HasColumnName("REVISION_DAY_START_TIME##2");
            entity.Property(e => e.SalesLstYr)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("SALES_LST_YR");
            entity.Property(e => e.SalesPtd)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("SALES_PTD");
            entity.Property(e => e.SalesTeamId)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("SALES_TEAM_ID");
            entity.Property(e => e.SalesYtd)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("SALES_YTD");
            entity.Property(e => e.SendCustomerEmail).HasColumnName("SEND_CUSTOMER_EMAIL");
            entity.Property(e => e.ShipCode)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("SHIP_CODE");
            entity.Property(e => e.ShipEarly).HasColumnName("SHIP_EARLY");
            entity.Property(e => e.ShipPartial).HasColumnName("SHIP_PARTIAL");
            entity.Property(e => e.ShipSite)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("SHIP_SITE");
            entity.Property(e => e.ShippedOverOrderedQtyTolerance)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("SHIPPED_OVER_ORDERED_QTY_TOLERANCE");
            entity.Property(e => e.ShippedUnderOrderedQtyTolerance)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("SHIPPED_UNDER_ORDERED_QTY_TOLERANCE");
            entity.Property(e => e.ShowInDropDownList).HasColumnName("SHOW_IN_DROP_DOWN_LIST");
            entity.Property(e => e.ShowInShipToDropDownList).HasColumnName("SHOW_IN_SHIP_TO_DROP_DOWN_LIST");
            entity.Property(e => e.SicCode)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("SIC_CODE");
            entity.Property(e => e.Slsman)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("SLSMAN");
            entity.Property(e => e.StateCycle)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STATE_CYCLE");
            entity.Property(e => e.Summarize).HasColumnName("SUMMARIZE");
            entity.Property(e => e.TaxCode1)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("TAX_CODE1");
            entity.Property(e => e.TaxCode2)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("TAX_CODE2");
            entity.Property(e => e.TaxRegNum1)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("TAX_REG_NUM1");
            entity.Property(e => e.TaxRegNum2)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("TAX_REG_NUM2");
            entity.Property(e => e.TermsCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("TERMS_CODE");
            entity.Property(e => e.TerritoryCode)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TERRITORY_CODE");
            entity.Property(e => e.TransNat)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TRANS_NAT");
            entity.Property(e => e.TransNat2)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TRANS_NAT_2");
            entity.Property(e => e.UfSegCustLangKitType)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("UF_SEG_CUST_LANG_KIT_TYPE");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("UPDATED_BY");
            entity.Property(e => e.UseExchRate).HasColumnName("USE_EXCH_RATE");
            entity.Property(e => e.UseRevisionPayDays).HasColumnName("USE_REVISION_PAY_DAYS");
            entity.Property(e => e.VrtxGeocode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VRTX_GEOCODE");
            entity.Property(e => e.Whse)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("WHSE");
        });

        modelBuilder.Entity<FsConfig>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("fs_config");

            entity.Property(e => e.Charfld1)
                .HasMaxLength(20)
                .HasColumnName("charfld1");
            entity.Property(e => e.Charfld2)
                .HasMaxLength(20)
                .HasColumnName("charfld2");
            entity.Property(e => e.Charfld3)
                .HasMaxLength(20)
                .HasColumnName("charfld3");
            entity.Property(e => e.CompId).HasColumnName("comp_id");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.CustItem)
                .HasMaxLength(30)
                .HasColumnName("cust_item");
            entity.Property(e => e.Datefld)
                .HasColumnType("datetime")
                .HasColumnName("datefld");
            entity.Property(e => e.Decifld1)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld1");
            entity.Property(e => e.Decifld2)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld2");
            entity.Property(e => e.Decifld3)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld3");
            entity.Property(e => e.Description)
                .HasMaxLength(40)
                .HasColumnName("description");
            entity.Property(e => e.InsSroLine).HasColumnName("ins_sro_line");
            entity.Property(e => e.InsSroNum)
                .HasMaxLength(10)
                .HasColumnName("ins_sro_num");
            entity.Property(e => e.InsSroOper).HasColumnName("ins_sro_oper");
            entity.Property(e => e.InsTransNum).HasColumnName("ins_trans_num");
            entity.Property(e => e.InstallDate)
                .HasColumnType("datetime")
                .HasColumnName("install_date");
            entity.Property(e => e.Item)
                .HasMaxLength(30)
                .HasColumnName("item");
            entity.Property(e => e.Logifld).HasColumnName("logifld");
            entity.Property(e => e.Lot)
                .HasMaxLength(15)
                .HasColumnName("lot");
            entity.Property(e => e.ParentId).HasColumnName("parent_id");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(19, 8)")
                .HasColumnName("qty");
            entity.Property(e => e.Reason)
                .HasMaxLength(3)
                .HasColumnName("reason");
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.RemSroLine).HasColumnName("rem_sro_line");
            entity.Property(e => e.RemSroNum)
                .HasMaxLength(10)
                .HasColumnName("rem_sro_num");
            entity.Property(e => e.RemSroOper).HasColumnName("rem_sro_oper");
            entity.Property(e => e.RemTransNum).HasColumnName("rem_trans_num");
            entity.Property(e => e.RemoveDate)
                .HasColumnType("datetime")
                .HasColumnName("remove_date");
            entity.Property(e => e.Revision)
                .HasMaxLength(8)
                .HasColumnName("revision");
            entity.Property(e => e.SerNum)
                .HasMaxLength(30)
                .HasColumnName("ser_num");
            entity.Property(e => e.UM)
                .HasMaxLength(3)
                .HasColumnName("u_m");
            entity.Property(e => e.UpdatedBy).HasMaxLength(30);
        });

        modelBuilder.Entity<FsConsumer>(entity =>
        {
            entity.HasKey(e => e.RowPointer).HasName("PK__fs_consu__30A54D4496DEB7AF");

            entity.ToTable("fs_consumer");

            entity.Property(e => e.RowPointer).ValueGeneratedNever();
            entity.Property(e => e.Addr1)
                .HasMaxLength(50)
                .HasColumnName("addr##1");
            entity.Property(e => e.Addr2)
                .HasMaxLength(50)
                .HasColumnName("addr##2");
            entity.Property(e => e.Addr3)
                .HasMaxLength(50)
                .HasColumnName("addr##3");
            entity.Property(e => e.Addr4)
                .HasMaxLength(50)
                .HasColumnName("addr##4");
            entity.Property(e => e.Charfld1)
                .HasMaxLength(20)
                .HasColumnName("charfld1");
            entity.Property(e => e.Charfld2)
                .HasMaxLength(20)
                .HasColumnName("charfld2");
            entity.Property(e => e.Charfld3)
                .HasMaxLength(20)
                .HasColumnName("charfld3");
            entity.Property(e => e.City)
                .HasMaxLength(30)
                .HasColumnName("city");
            entity.Property(e => e.Contact1)
                .HasMaxLength(30)
                .HasColumnName("contact##1");
            entity.Property(e => e.Contact2)
                .HasMaxLength(30)
                .HasColumnName("contact##2");
            entity.Property(e => e.Contact3)
                .HasMaxLength(30)
                .HasColumnName("contact##3");
            entity.Property(e => e.Country)
                .HasMaxLength(30)
                .HasColumnName("country");
            entity.Property(e => e.County)
                .HasMaxLength(30)
                .HasColumnName("county");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.CustNum)
                .HasMaxLength(7)
                .HasColumnName("cust_num");
            entity.Property(e => e.CustSeq).HasColumnName("cust_seq");
            entity.Property(e => e.Datefld)
                .HasColumnType("datetime")
                .HasColumnName("datefld");
            entity.Property(e => e.Decifld1)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld1");
            entity.Property(e => e.Decifld2)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld2");
            entity.Property(e => e.Decifld3)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld3");
            entity.Property(e => e.DriversLicense)
                .HasMaxLength(30)
                .HasColumnName("drivers_license");
            entity.Property(e => e.Email1)
                .HasMaxLength(60)
                .HasColumnName("email##1");
            entity.Property(e => e.Email2)
                .HasMaxLength(60)
                .HasColumnName("email##2");
            entity.Property(e => e.Email3)
                .HasMaxLength(60)
                .HasColumnName("email##3");
            entity.Property(e => e.FaxNum)
                .HasMaxLength(25)
                .HasColumnName("fax_num");
            entity.Property(e => e.Logifld).HasColumnName("logifld");
            entity.Property(e => e.Name)
                .HasMaxLength(60)
                .HasColumnName("name");
            entity.Property(e => e.Phone1)
                .HasMaxLength(25)
                .HasColumnName("phone##1");
            entity.Property(e => e.Phone2)
                .HasMaxLength(25)
                .HasColumnName("phone##2");
            entity.Property(e => e.Phone3)
                .HasMaxLength(25)
                .HasColumnName("phone##3");
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.Ssn)
                .HasMaxLength(11)
                .HasColumnName("ssn");
            entity.Property(e => e.State)
                .HasMaxLength(5)
                .HasColumnName("state");
            entity.Property(e => e.UfSegConsumerType).HasColumnName("Uf_SEG_Consumer_Type");
            entity.Property(e => e.UfSegIsFavorite).HasColumnName("Uf_SEG_Is_Favorite");
            entity.Property(e => e.UpdatedBy).HasMaxLength(30);
            entity.Property(e => e.UsrNum)
                .HasMaxLength(7)
                .HasColumnName("usr_num");
            entity.Property(e => e.UsrSeq).HasColumnName("usr_seq");
            entity.Property(e => e.Zip)
                .HasMaxLength(10)
                .HasColumnName("zip");
        });

        modelBuilder.Entity<FsCustomer>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("fs_customer");

            entity.Property(e => e.ApplyOpenDeposits).HasColumnName("apply_open_deposits");
            entity.Property(e => e.BillMgr)
                .HasMaxLength(10)
                .HasColumnName("bill_mgr");
            entity.Property(e => e.Charfld1)
                .HasMaxLength(20)
                .HasColumnName("charfld1");
            entity.Property(e => e.Charfld2)
                .HasMaxLength(20)
                .HasColumnName("charfld2");
            entity.Property(e => e.Charfld3)
                .HasMaxLength(20)
                .HasColumnName("charfld3");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.CustNum)
                .HasMaxLength(7)
                .HasColumnName("cust_num");
            entity.Property(e => e.CustSeq).HasColumnName("cust_seq");
            entity.Property(e => e.Datefld)
                .HasColumnType("datetime")
                .HasColumnName("datefld");
            entity.Property(e => e.Decifld1)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld1");
            entity.Property(e => e.Decifld2)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld2");
            entity.Property(e => e.Decifld3)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld3");
            entity.Property(e => e.DepositApplied)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("deposit_applied");
            entity.Property(e => e.DepositReceived)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("deposit_received");
            entity.Property(e => e.DepositReq).HasColumnName("deposit_req");
            entity.Property(e => e.DepositSroRec)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("deposit_sro_rec");
            entity.Property(e => e.DepositSroTotal)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("deposit_sro_total");
            entity.Property(e => e.Directions).HasColumnName("directions");
            entity.Property(e => e.ExclWaiverCharge).HasColumnName("excl_waiver_charge");
            entity.Property(e => e.Logifld).HasColumnName("logifld");
            entity.Property(e => e.PartnerId)
                .HasMaxLength(10)
                .HasColumnName("partner_id");
            entity.Property(e => e.Password)
                .HasMaxLength(30)
                .HasColumnName("password");
            entity.Property(e => e.PosCash).HasColumnName("pos_cash");
            entity.Property(e => e.PosCheck).HasColumnName("pos_check");
            entity.Property(e => e.PosCreditCard).HasColumnName("pos_credit_card");
            entity.Property(e => e.PosOnAcct).HasColumnName("pos_on_acct");
            entity.Property(e => e.Pricecode)
                .HasMaxLength(3)
                .HasColumnName("pricecode");
            entity.Property(e => e.PriorCode)
                .HasMaxLength(10)
                .HasColumnName("prior_code");
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.Region)
                .HasMaxLength(10)
                .HasColumnName("region");
            entity.Property(e => e.ReimbMethod)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("reimb_method");
            entity.Property(e => e.ServType)
                .HasMaxLength(3)
                .HasColumnName("serv_type");
            entity.Property(e => e.ShipCode)
                .HasMaxLength(4)
                .HasColumnName("ship_code");
            entity.Property(e => e.TermsCode)
                .HasMaxLength(3)
                .HasColumnName("terms_code");
            entity.Property(e => e.UpdatedBy).HasMaxLength(30);
            entity.Property(e => e.VendNum)
                .HasMaxLength(7)
                .HasColumnName("vend_num");
            entity.Property(e => e.WaiverExpiration)
                .HasColumnType("datetime")
                .HasColumnName("waiver_expiration");
        });

        modelBuilder.Entity<FsIncident>(entity =>
        {
            entity.HasKey(e => e.RowPointer).HasName("PK__fs_incid__30A54D4480100942");

            entity.ToTable("fs_incident");

            entity.Property(e => e.RowPointer).ValueGeneratedNever();
            entity.Property(e => e.AwaitingParts).HasColumnName("awaiting_parts");
            entity.Property(e => e.Charfld1)
                .HasMaxLength(20)
                .HasColumnName("charfld1");
            entity.Property(e => e.Charfld2)
                .HasMaxLength(20)
                .HasColumnName("charfld2");
            entity.Property(e => e.Charfld3)
                .HasMaxLength(20)
                .HasColumnName("charfld3");
            entity.Property(e => e.CloseDate)
                .HasColumnType("datetime")
                .HasColumnName("close_date");
            entity.Property(e => e.Contact)
                .HasMaxLength(30)
                .HasColumnName("contact");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.CustItem)
                .HasMaxLength(30)
                .HasColumnName("cust_item");
            entity.Property(e => e.CustNum)
                .HasMaxLength(7)
                .HasColumnName("cust_num");
            entity.Property(e => e.CustSeq).HasColumnName("cust_seq");
            entity.Property(e => e.Datefld)
                .HasColumnType("datetime")
                .HasColumnName("datefld");
            entity.Property(e => e.Decifld1)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld1");
            entity.Property(e => e.Decifld2)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld2");
            entity.Property(e => e.Decifld3)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld3");
            entity.Property(e => e.Dept)
                .HasMaxLength(6)
                .HasColumnName("dept");
            entity.Property(e => e.Description)
                .HasMaxLength(40)
                .HasColumnName("description");
            entity.Property(e => e.DriversLicense)
                .HasMaxLength(30)
                .HasColumnName("drivers_license");
            entity.Property(e => e.DueDate)
                .HasColumnType("datetime")
                .HasColumnName("due_date");
            entity.Property(e => e.Duration)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("duration");
            entity.Property(e => e.DurationUnits)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("duration_units");
            entity.Property(e => e.Email)
                .HasMaxLength(60)
                .HasColumnName("email");
            entity.Property(e => e.EstimatedTimeRemaining)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("estimated_time_remaining");
            entity.Property(e => e.EstimatedTimeRemainingUnits)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("estimated_time_remaining_units");
            entity.Property(e => e.FaxNum)
                .HasMaxLength(25)
                .HasColumnName("fax_num");
            entity.Property(e => e.FollowupComplete).HasColumnName("followup_complete");
            entity.Property(e => e.FollowupDate)
                .HasColumnType("datetime")
                .HasColumnName("followup_date");
            entity.Property(e => e.IncClosed).HasColumnName("inc_closed");
            entity.Property(e => e.IncDate)
                .HasColumnType("datetime")
                .HasColumnName("inc_date");
            entity.Property(e => e.IncNum)
                .HasMaxLength(10)
                .HasColumnName("inc_num");
            entity.Property(e => e.Item)
                .HasMaxLength(30)
                .HasColumnName("item");
            entity.Property(e => e.KnowNum).HasColumnName("know_num");
            entity.Property(e => e.LastEscal)
                .HasColumnType("datetime")
                .HasColumnName("last_escal");
            entity.Property(e => e.Logifld).HasColumnName("logifld");
            entity.Property(e => e.MatlQty)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("matl_qty");
            entity.Property(e => e.MatlQtyConv)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("matl_qty_conv");
            entity.Property(e => e.MeterAmt).HasColumnName("meter_amt");
            entity.Property(e => e.MeterDate)
                .HasColumnType("datetime")
                .HasColumnName("meter_date");
            entity.Property(e => e.Owner)
                .HasMaxLength(10)
                .HasColumnName("owner");
            entity.Property(e => e.PagerAddr)
                .HasMaxLength(60)
                .HasColumnName("pager_addr");
            entity.Property(e => e.Phone)
                .HasMaxLength(25)
                .HasColumnName("phone");
            entity.Property(e => e.Phone2)
                .HasMaxLength(25)
                .HasColumnName("phone2");
            entity.Property(e => e.PriorCode)
                .HasMaxLength(10)
                .HasColumnName("prior_code");
            entity.Property(e => e.PriorInc)
                .HasMaxLength(10)
                .HasColumnName("prior_inc");
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.RefLineSuf).HasColumnName("ref_line_suf");
            entity.Property(e => e.RefNum)
                .HasMaxLength(10)
                .HasColumnName("ref_num");
            entity.Property(e => e.RefRelease).HasColumnName("ref_release");
            entity.Property(e => e.RefSite)
                .HasMaxLength(8)
                .HasColumnName("ref_site");
            entity.Property(e => e.RefType)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("ref_type");
            entity.Property(e => e.Region)
                .HasMaxLength(10)
                .HasColumnName("region");
            entity.Property(e => e.RemoteId)
                .HasMaxLength(30)
                .HasColumnName("remote_id");
            entity.Property(e => e.SerNum)
                .HasMaxLength(30)
                .HasColumnName("ser_num");
            entity.Property(e => e.Site)
                .HasMaxLength(8)
                .HasColumnName("site");
            entity.Property(e => e.Ssn)
                .HasMaxLength(11)
                .HasColumnName("ssn");
            entity.Property(e => e.Ssr)
                .HasMaxLength(10)
                .HasColumnName("ssr");
            entity.Property(e => e.StatCode)
                .HasMaxLength(10)
                .HasColumnName("stat_code");
            entity.Property(e => e.ToSchedule).HasColumnName("To_Schedule");
            entity.Property(e => e.TxtMsgAddr)
                .HasMaxLength(60)
                .HasColumnName("txt_msg_addr");
            entity.Property(e => e.UM)
                .HasMaxLength(3)
                .HasColumnName("u_m");
            entity.Property(e => e.UfMsmBool1).HasColumnName("UF_MSM_bool1");
            entity.Property(e => e.UfMsmBool2).HasColumnName("UF_MSM_bool2");
            entity.Property(e => e.UfMsmDeci1)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("UF_MSM_deci1");
            entity.Property(e => e.UfMsmDeci2)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("UF_MSM_deci2");
            entity.Property(e => e.UfMsmDt1)
                .HasColumnType("datetime")
                .HasColumnName("UF_MSM_dt1");
            entity.Property(e => e.UfMsmDt2)
                .HasColumnType("datetime")
                .HasColumnName("UF_MSM_dt2");
            entity.Property(e => e.UfMsmInt1).HasColumnName("UF_MSM_int1");
            entity.Property(e => e.UfMsmInt2).HasColumnName("UF_MSM_int2");
            entity.Property(e => e.UfMsmStr1)
                .HasMaxLength(30)
                .HasColumnName("UF_MSM_Str1");
            entity.Property(e => e.UfMsmStr2)
                .HasMaxLength(50)
                .HasColumnName("UF_MSM_Str2");
            entity.Property(e => e.UpdatedBy).HasMaxLength(30);
            entity.Property(e => e.UsrNum)
                .HasMaxLength(7)
                .HasColumnName("usr_num");
            entity.Property(e => e.UsrSeq).HasColumnName("usr_seq");
            entity.Property(e => e.WarningDate)
                .HasColumnType("datetime")
                .HasColumnName("warning_date");
            entity.Property(e => e.WebEntered).HasColumnName("web_entered");
            entity.Property(e => e.WebView).HasColumnName("web_view");
            entity.Property(e => e.WorkSite)
                .HasMaxLength(8)
                .HasColumnName("work_site");
        });

        modelBuilder.Entity<FsItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("fs_item");

            entity.Property(e => e.CalibDays).HasColumnName("calib_days");
            entity.Property(e => e.CalibFirst).HasColumnName("calib_first");
            entity.Property(e => e.CalibFlag).HasColumnName("calib_flag");
            entity.Property(e => e.Charfld1)
                .HasMaxLength(20)
                .HasColumnName("charfld1");
            entity.Property(e => e.Charfld2)
                .HasMaxLength(20)
                .HasColumnName("charfld2");
            entity.Property(e => e.Charfld3)
                .HasMaxLength(20)
                .HasColumnName("charfld3");
            entity.Property(e => e.ContPriceBasis)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("cont_price_basis");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.Datefld)
                .HasColumnType("datetime")
                .HasColumnName("datefld");
            entity.Property(e => e.Decifld1)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld1");
            entity.Property(e => e.Decifld2)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld2");
            entity.Property(e => e.Decifld3)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld3");
            entity.Property(e => e.DrpItem).HasColumnName("drp_item");
            entity.Property(e => e.DurationDays).HasColumnName("duration_days");
            entity.Property(e => e.DurationHrs).HasColumnName("duration_hrs");
            entity.Property(e => e.ExcludeFromCtp).HasColumnName("exclude_from_ctp");
            entity.Property(e => e.FsConsumable).HasColumnName("fs_consumable");
            entity.Property(e => e.FsDaysSupply).HasColumnName("fs_days_supply");
            entity.Property(e => e.FsOrderMax)
                .HasColumnType("decimal(19, 8)")
                .HasColumnName("fs_order_max");
            entity.Property(e => e.FsOrderMin)
                .HasColumnType("decimal(19, 8)")
                .HasColumnName("fs_order_min");
            entity.Property(e => e.FsOrderMult)
                .HasColumnType("decimal(19, 8)")
                .HasColumnName("fs_order_mult");
            entity.Property(e => e.FsPMTCode)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("fs_p_m_t_code");
            entity.Property(e => e.FsSupplyWhse)
                .HasMaxLength(4)
                .HasColumnName("fs_supply_whse");
            entity.Property(e => e.FsTrackable).HasColumnName("fs_trackable");
            entity.Property(e => e.FsVendNum)
                .HasMaxLength(7)
                .HasColumnName("fs_vend_num");
            entity.Property(e => e.InclForecast).HasColumnName("incl_forecast");
            entity.Property(e => e.InclInCfg).HasColumnName("incl_in_cfg");
            entity.Property(e => e.InclWaiverCharge).HasColumnName("incl_waiver_charge");
            entity.Property(e => e.InsDays).HasColumnName("ins_days");
            entity.Property(e => e.InsFirst).HasColumnName("ins_first");
            entity.Property(e => e.InsFlag).HasColumnName("ins_flag");
            entity.Property(e => e.Item)
                .HasMaxLength(30)
                .HasColumnName("item");
            entity.Property(e => e.Logifld).HasColumnName("logifld");
            entity.Property(e => e.MeterLabel)
                .HasMaxLength(12)
                .HasColumnName("meter_label");
            entity.Property(e => e.PmDays).HasColumnName("pm_days");
            entity.Property(e => e.PmFirst).HasColumnName("pm_first");
            entity.Property(e => e.PmFlag).HasColumnName("pm_flag");
            entity.Property(e => e.PriorCode)
                .HasMaxLength(10)
                .HasColumnName("prior_code");
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.UnitOfRate)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("unit_of_rate");
            entity.Property(e => e.UpdatedBy).HasMaxLength(30);
        });

        modelBuilder.Entity<FsItemWarr>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("fs_item_warr");

            entity.Property(e => e.Charfld1)
                .HasMaxLength(20)
                .HasColumnName("charfld1");
            entity.Property(e => e.Charfld2)
                .HasMaxLength(20)
                .HasColumnName("charfld2");
            entity.Property(e => e.Charfld3)
                .HasMaxLength(20)
                .HasColumnName("charfld3");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.Datefld)
                .HasColumnType("datetime")
                .HasColumnName("datefld");
            entity.Property(e => e.Decifld1)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld1");
            entity.Property(e => e.Decifld2)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld2");
            entity.Property(e => e.Decifld3)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld3");
            entity.Property(e => e.Item)
                .HasMaxLength(30)
                .HasColumnName("item");
            entity.Property(e => e.Logifld).HasColumnName("logifld");
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(30);
            entity.Property(e => e.WarrCode)
                .HasMaxLength(8)
                .HasColumnName("warr_code");
        });

        modelBuilder.Entity<FsOperCode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("fs_oper_code");

            entity.Property(e => e.Charfld1)
                .HasMaxLength(20)
                .HasColumnName("charfld1");
            entity.Property(e => e.Charfld2)
                .HasMaxLength(20)
                .HasColumnName("charfld2");
            entity.Property(e => e.Charfld3)
                .HasMaxLength(20)
                .HasColumnName("charfld3");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.Datefld)
                .HasColumnType("datetime")
                .HasColumnName("datefld");
            entity.Property(e => e.Decifld1)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld1");
            entity.Property(e => e.Decifld2)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld2");
            entity.Property(e => e.Decifld3)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld3");
            entity.Property(e => e.Description)
                .HasMaxLength(40)
                .HasColumnName("description");
            entity.Property(e => e.FixedPrice)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("fixed_price");
            entity.Property(e => e.Logifld).HasColumnName("logifld");
            entity.Property(e => e.OperCode)
                .HasMaxLength(8)
                .HasColumnName("oper_code");
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(30);
            entity.Property(e => e.UseItemPricing).HasColumnName("use_item_pricing");
        });

        modelBuilder.Entity<FsPartner>(entity =>
        {
            entity.HasKey(e => e.Rowpointer).HasName("PK__FS_Partn__8B3A1616876BA2E4");

            entity.ToTable("FS_Partner");

            entity.Property(e => e.Rowpointer)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ROWPOINTER");
            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.Charfld1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CHARFLD1");
            entity.Property(e => e.Charfld2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CHARFLD2");
            entity.Property(e => e.Charfld3)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CHARFLD3");
            entity.Property(e => e.Cost).HasColumnName("COST");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Createdby)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CREATEDBY");
            entity.Property(e => e.CurrCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CURR_CODE");
            entity.Property(e => e.CustNum)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("CUST_NUM");
            entity.Property(e => e.Datefld)
                .HasColumnType("datetime")
                .HasColumnName("DATEFLD");
            entity.Property(e => e.Decifld1).HasColumnName("DECIFLD1");
            entity.Property(e => e.Decifld2).HasColumnName("DECIFLD2");
            entity.Property(e => e.Decifld3).HasColumnName("DECIFLD3");
            entity.Property(e => e.Dept)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("DEPT");
            entity.Property(e => e.DisplayOnScheduleBoard).HasColumnName("DISPLAY_ON_SCHEDULE_BOARD");
            entity.Property(e => e.Email)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.ExchangeScheduleFolder)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EXCHANGE_SCHEDULE_FOLDER");
            entity.Property(e => e.ExchangeSync).HasColumnName("EXCHANGE_SYNC");
            entity.Property(e => e.GpsLastLatitude).HasColumnName("GPS_LAST_LATITUDE");
            entity.Property(e => e.GpsLastLongitude).HasColumnName("GPS_LAST_LONGITUDE");
            entity.Property(e => e.GpsLastTimestamp)
                .HasColumnType("datetime")
                .HasColumnName("GPS_LAST_TIMESTAMP");
            entity.Property(e => e.Hrs1).HasColumnName("HRS##1");
            entity.Property(e => e.Hrs2).HasColumnName("HRS##2");
            entity.Property(e => e.Hrs3).HasColumnName("HRS##3");
            entity.Property(e => e.Hrs4).HasColumnName("HRS##4");
            entity.Property(e => e.Hrs5).HasColumnName("HRS##5");
            entity.Property(e => e.Hrs6).HasColumnName("HRS##6");
            entity.Property(e => e.Hrs7).HasColumnName("HRS##7");
            entity.Property(e => e.Inworkflow).HasColumnName("INWORKFLOW");
            entity.Property(e => e.Logifld).HasColumnName("LOGIFLD");
            entity.Property(e => e.MiscCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("MISC_CODE");
            entity.Property(e => e.Name)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.Noteexistsflag).HasColumnName("NOTEEXISTSFLAG");
            entity.Property(e => e.PagerAddr)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("PAGER_ADDR");
            entity.Property(e => e.PartnerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PARTNER_ID");
            entity.Property(e => e.Password)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PASSWORD");
            entity.Property(e => e.Rate).HasColumnName("RATE");
            entity.Property(e => e.Recorddate)
                .HasColumnType("datetime")
                .HasColumnName("RECORDDATE");
            entity.Property(e => e.RefNum)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("REF_NUM");
            entity.Property(e => e.RefSeq).HasColumnName("REF_SEQ");
            entity.Property(e => e.RefType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("REF_TYPE");
            entity.Property(e => e.ReimbLabor).HasColumnName("REIMB_LABOR");
            entity.Property(e => e.ReimbMatl).HasColumnName("REIMB_MATL");
            entity.Property(e => e.ReimbMethod)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("REIMB_METHOD");
            entity.Property(e => e.SupId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SUP_ID");
            entity.Property(e => e.TxtMsgAddr)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("TXT_MSG_ADDR");
            entity.Property(e => e.UfSegLogin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UF_SEG_LOGIN");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("UPDATEDBY");
            entity.Property(e => e.Username)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("USERNAME");
            entity.Property(e => e.VendNum)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("VEND_NUM");
            entity.Property(e => e.Whse)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("WHSE");
            entity.Property(e => e.WorkCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("WORK_CODE");
        });

        modelBuilder.Entity<FsPriorCode>(entity =>
        {
            entity.HasKey(e => e.RowPointer).HasName("PK__FS_Prior__219964B166C3EC82");

            entity.ToTable("FS_Prior_Code");

            entity.Property(e => e.RowPointer)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ROW_POINTER");
            entity.Property(e => e.Charfld1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CHARFLD1");
            entity.Property(e => e.Charfld2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CHARFLD2");
            entity.Property(e => e.Charfld3)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CHARFLD3");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.Datefld)
                .HasColumnType("datetime")
                .HasColumnName("DATEFLD");
            entity.Property(e => e.DaysFollowup)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DAYS_FOLLOWUP");
            entity.Property(e => e.DaysLate)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DAYS_LATE");
            entity.Property(e => e.DaysUntilWarning)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DAYS_UNTIL_WARNING");
            entity.Property(e => e.Decifld1).HasColumnName("DECIFLD1");
            entity.Property(e => e.Decifld2).HasColumnName("DECIFLD2");
            entity.Property(e => e.Decifld3).HasColumnName("DECIFLD3");
            entity.Property(e => e.Description)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.FollowupBasis)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FOLLOWUP_BASIS");
            entity.Property(e => e.HrsFollowup).HasColumnName("HRS_FOLLOWUP");
            entity.Property(e => e.HrsLate).HasColumnName("HRS_LATE");
            entity.Property(e => e.HrsUntilWarning).HasColumnName("HRS_UNTIL_WARNING");
            entity.Property(e => e.InWorkflow).HasColumnName("IN_WORKFLOW");
            entity.Property(e => e.LateBasis)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LATE_BASIS");
            entity.Property(e => e.Logifld).HasColumnName("LOGIFLD");
            entity.Property(e => e.NoteExistsFlag).HasColumnName("NOTE_EXISTS_FLAG");
            entity.Property(e => e.PriorCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PRIOR_CODE");
            entity.Property(e => e.RecordDate)
                .HasColumnType("datetime")
                .HasColumnName("RECORD_DATE");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("UPDATED_BY");
            entity.Property(e => e.WarningBasis)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("WARNING_BASIS");
        });

        modelBuilder.Entity<FsRegion>(entity =>
        {
            entity.HasKey(e => e.Rowpointer).HasName("PK__FS_Regio__8B3A161634CB4E02");

            entity.ToTable("FS_Region");

            entity.Property(e => e.Rowpointer)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ROWPOINTER");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Createdby)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CREATEDBY");
            entity.Property(e => e.Description)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Inworkflow).HasColumnName("INWORKFLOW");
            entity.Property(e => e.Noteexistsflag).HasColumnName("NOTEEXISTSFLAG");
            entity.Property(e => e.Recorddate)
                .HasColumnType("datetime")
                .HasColumnName("RECORDDATE");
            entity.Property(e => e.Region)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("REGION");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("UPDATEDBY");
        });

        modelBuilder.Entity<FsResGen>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("fs_res_gen");

            entity.Property(e => e.Charfld1)
                .HasMaxLength(20)
                .HasColumnName("charfld1");
            entity.Property(e => e.Charfld2)
                .HasMaxLength(20)
                .HasColumnName("charfld2");
            entity.Property(e => e.Charfld3)
                .HasMaxLength(20)
                .HasColumnName("charfld3");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.Datefld)
                .HasColumnType("datetime")
                .HasColumnName("datefld");
            entity.Property(e => e.Decifld1)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld1");
            entity.Property(e => e.Decifld2)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld2");
            entity.Property(e => e.Decifld3)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld3");
            entity.Property(e => e.Description)
                .HasMaxLength(40)
                .HasColumnName("description");
            entity.Property(e => e.Logifld).HasColumnName("logifld");
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.ResCodeGen)
                .HasMaxLength(8)
                .HasColumnName("res_code_gen");
            entity.Property(e => e.UpdatedBy).HasMaxLength(30);
        });

        modelBuilder.Entity<FsResSpec>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("fs_res_spec");

            entity.Property(e => e.Charfld1)
                .HasMaxLength(20)
                .HasColumnName("charfld1");
            entity.Property(e => e.Charfld2)
                .HasMaxLength(20)
                .HasColumnName("charfld2");
            entity.Property(e => e.Charfld3)
                .HasMaxLength(20)
                .HasColumnName("charfld3");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.Datefld)
                .HasColumnType("datetime")
                .HasColumnName("datefld");
            entity.Property(e => e.Decifld1)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld1");
            entity.Property(e => e.Decifld2)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld2");
            entity.Property(e => e.Decifld3)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld3");
            entity.Property(e => e.Description)
                .HasMaxLength(40)
                .HasColumnName("description");
            entity.Property(e => e.Logifld).HasColumnName("logifld");
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.ResCodeGen)
                .HasMaxLength(8)
                .HasColumnName("res_code_gen");
            entity.Property(e => e.ResCodeSpec)
                .HasMaxLength(8)
                .HasColumnName("res_code_spec");
            entity.Property(e => e.UpdatedBy).HasMaxLength(30);
        });

        modelBuilder.Entity<FsSro>(entity =>
        {
            entity.HasKey(e => e.RowPointer).HasName("PK__fs_sro__30A54D44EFA42472");

            entity.ToTable("fs_sro");

            entity.Property(e => e.RowPointer).ValueGeneratedNever();
            entity.Property(e => e.AccumWip).HasColumnName("accum_wip");
            entity.Property(e => e.AllowPartial).HasColumnName("allow_partial");
            entity.Property(e => e.ApplyOpenDeposits).HasColumnName("apply_open_deposits");
            entity.Property(e => e.AwaitingParts).HasColumnName("awaiting_parts");
            entity.Property(e => e.BillCode)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("bill_code");
            entity.Property(e => e.BillCustNum)
                .HasMaxLength(7)
                .HasColumnName("bill_cust_num");
            entity.Property(e => e.BillCustSeq).HasColumnName("bill_cust_seq");
            entity.Property(e => e.BillMgr)
                .HasMaxLength(10)
                .HasColumnName("bill_mgr");
            entity.Property(e => e.BillStat)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("bill_stat");
            entity.Property(e => e.BillType)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("bill_type");
            entity.Property(e => e.CgsRevLocLabor)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("cgs_rev_loc_labor");
            entity.Property(e => e.CgsRevLocMatl)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("cgs_rev_loc_matl");
            entity.Property(e => e.CgsRevLocMisc)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("cgs_rev_loc_misc");
            entity.Property(e => e.Charfld1)
                .HasMaxLength(20)
                .HasColumnName("charfld1");
            entity.Property(e => e.Charfld2)
                .HasMaxLength(20)
                .HasColumnName("charfld2");
            entity.Property(e => e.Charfld3)
                .HasMaxLength(20)
                .HasColumnName("charfld3");
            entity.Property(e => e.CloseDate)
                .HasColumnType("datetime")
                .HasColumnName("close_date");
            entity.Property(e => e.Contact)
                .HasMaxLength(60)
                .HasColumnName("contact");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.CreditHold).HasColumnName("credit_hold");
            entity.Property(e => e.CreditHoldDate)
                .HasColumnType("datetime")
                .HasColumnName("credit_hold_date");
            entity.Property(e => e.CreditHoldReason)
                .HasMaxLength(3)
                .HasColumnName("credit_hold_reason");
            entity.Property(e => e.CreditHoldUser)
                .HasMaxLength(30)
                .HasColumnName("credit_hold_user");
            entity.Property(e => e.CustNum)
                .HasMaxLength(7)
                .HasColumnName("cust_num");
            entity.Property(e => e.CustPo)
                .HasMaxLength(22)
                .HasColumnName("cust_po");
            entity.Property(e => e.CustSeq).HasColumnName("cust_seq");
            entity.Property(e => e.Datefld)
                .HasColumnType("datetime")
                .HasColumnName("datefld");
            entity.Property(e => e.Decifld1)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld1");
            entity.Property(e => e.Decifld2)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld2");
            entity.Property(e => e.Decifld3)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld3");
            entity.Property(e => e.Delterm)
                .HasMaxLength(4)
                .HasColumnName("delterm");
            entity.Property(e => e.DepositApplied)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("deposit_applied");
            entity.Property(e => e.DepositExp)
                .HasColumnType("datetime")
                .HasColumnName("deposit_exp");
            entity.Property(e => e.DepositReceived)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("deposit_received");
            entity.Property(e => e.DepositReq).HasColumnName("deposit_req");
            entity.Property(e => e.DepositTotal)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("deposit_total");
            entity.Property(e => e.Dept)
                .HasMaxLength(6)
                .HasColumnName("dept");
            entity.Property(e => e.Description)
                .HasMaxLength(40)
                .HasColumnName("description");
            entity.Property(e => e.Disc)
                .HasColumnType("decimal(7, 4)")
                .HasColumnName("disc");
            entity.Property(e => e.DiscLabor)
                .HasColumnType("decimal(4, 1)")
                .HasColumnName("disc_labor");
            entity.Property(e => e.DiscMatl)
                .HasColumnType("decimal(4, 1)")
                .HasColumnName("disc_matl");
            entity.Property(e => e.DiscMisc)
                .HasColumnType("decimal(4, 1)")
                .HasColumnName("disc_misc");
            entity.Property(e => e.DiscT)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("disc_t");
            entity.Property(e => e.DriversLicense)
                .HasMaxLength(30)
                .HasColumnName("drivers_license");
            entity.Property(e => e.DropNum)
                .HasMaxLength(10)
                .HasColumnName("drop_num");
            entity.Property(e => e.DropSeq).HasColumnName("drop_seq");
            entity.Property(e => e.DropType)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("drop_type");
            entity.Property(e => e.Email)
                .HasMaxLength(60)
                .HasColumnName("email");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("end_date");
            entity.Property(e => e.EndUserType)
                .HasMaxLength(6)
                .HasColumnName("end_user_type");
            entity.Property(e => e.EstSalesTax1)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("est_sales_tax1");
            entity.Property(e => e.EstSalesTax2)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("est_sales_tax2");
            entity.Property(e => e.ExchRate)
                .HasColumnType("decimal(12, 7)")
                .HasColumnName("exch_rate");
            entity.Property(e => e.ExtendLbrTrans).HasColumnName("extend_lbr_trans");
            entity.Property(e => e.ExtendMatlTrans).HasColumnName("extend_matl_trans");
            entity.Property(e => e.ExtendMiscTrans).HasColumnName("extend_misc_trans");
            entity.Property(e => e.FaxNum)
                .HasMaxLength(25)
                .HasColumnName("fax_num");
            entity.Property(e => e.FixedRate).HasColumnName("fixed_rate");
            entity.Property(e => e.Freight)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("freight");
            entity.Property(e => e.FreightT)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("freight_t");
            entity.Property(e => e.FrtTaxCode1)
                .HasMaxLength(6)
                .HasColumnName("frt_tax_code1");
            entity.Property(e => e.FrtTaxCode2)
                .HasMaxLength(6)
                .HasColumnName("frt_tax_code2");
            entity.Property(e => e.IncNum)
                .HasMaxLength(10)
                .HasColumnName("inc_num");
            entity.Property(e => e.InclDemand).HasColumnName("incl_demand");
            entity.Property(e => e.InspFinalized)
                .HasColumnType("datetime")
                .HasColumnName("insp_finalized");
            entity.Property(e => e.InvClose).HasColumnName("inv_close");
            entity.Property(e => e.Item)
                .HasMaxLength(30)
                .HasColumnName("item");
            entity.Property(e => e.Logifld).HasColumnName("logifld");
            entity.Property(e => e.MChargesT)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("m_charges_t");
            entity.Property(e => e.MaintDate)
                .HasColumnType("datetime")
                .HasColumnName("maint_date");
            entity.Property(e => e.MaintDuration)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("maint_duration");
            entity.Property(e => e.MeterAmt).HasColumnName("meter_amt");
            entity.Property(e => e.MiscCharges)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("misc_charges");
            entity.Property(e => e.MscTaxCode1)
                .HasMaxLength(6)
                .HasColumnName("msc_tax_code1");
            entity.Property(e => e.MscTaxCode2)
                .HasMaxLength(6)
                .HasColumnName("msc_tax_code2");
            entity.Property(e => e.ObalFrtMsc)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("obal_frt_msc");
            entity.Property(e => e.OpenDate)
                .HasColumnType("datetime")
                .HasColumnName("open_date");
            entity.Property(e => e.PagerAddr)
                .HasMaxLength(60)
                .HasColumnName("pager_addr");
            entity.Property(e => e.PartnerId)
                .HasMaxLength(10)
                .HasColumnName("partner_id");
            entity.Property(e => e.Phone)
                .HasMaxLength(25)
                .HasColumnName("phone");
            entity.Property(e => e.Phone2)
                .HasMaxLength(25)
                .HasColumnName("phone2");
            entity.Property(e => e.PlanReq).HasColumnName("plan_req");
            entity.Property(e => e.Pricecode)
                .HasMaxLength(3)
                .HasColumnName("pricecode");
            entity.Property(e => e.PriorCode)
                .HasMaxLength(10)
                .HasColumnName("prior_code");
            entity.Property(e => e.ProcessInd)
                .HasMaxLength(1)
                .HasColumnName("process_ind");
            entity.Property(e => e.ProductCode)
                .HasMaxLength(10)
                .HasColumnName("product_code");
            entity.Property(e => e.ProjectedDate)
                .HasColumnType("datetime")
                .HasColumnName("projected_date");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(19, 8)")
                .HasColumnName("qty");
            entity.Property(e => e.QtyConv)
                .HasColumnType("decimal(19, 8)")
                .HasColumnName("qty_conv");
            entity.Property(e => e.QtyPacked)
                .HasColumnType("decimal(19, 8)")
                .HasColumnName("qty_packed");
            entity.Property(e => e.QtyShipped)
                .HasColumnType("decimal(19, 8)")
                .HasColumnName("qty_shipped");
            entity.Property(e => e.QtyShippedConv)
                .HasColumnType("decimal(19, 8)")
                .HasColumnName("qty_shipped_conv");
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.RefLineSuf).HasColumnName("ref_line_suf");
            entity.Property(e => e.RefNum)
                .HasMaxLength(10)
                .HasColumnName("ref_num");
            entity.Property(e => e.RefRelease).HasColumnName("ref_release");
            entity.Property(e => e.RefType)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("ref_type");
            entity.Property(e => e.Region)
                .HasMaxLength(10)
                .HasColumnName("region");
            entity.Property(e => e.ReimbMethod)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("reimb_method");
            entity.Property(e => e.RemoteId)
                .HasMaxLength(30)
                .HasColumnName("remote_id");
            entity.Property(e => e.SalesTax)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("sales_tax");
            entity.Property(e => e.SalesTax2)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("sales_tax_2");
            entity.Property(e => e.SalesTaxT)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("sales_tax_t");
            entity.Property(e => e.SalesTaxT2)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("sales_tax_t2");
            entity.Property(e => e.SchedDownTime).HasColumnName("sched_down_time");
            entity.Property(e => e.SegIsWarr).HasColumnName("SEG_IsWarr");
            entity.Property(e => e.SerNum)
                .HasMaxLength(30)
                .HasColumnName("ser_num");
            entity.Property(e => e.Shiftid)
                .HasMaxLength(30)
                .HasColumnName("SHIFTID");
            entity.Property(e => e.ShipCode)
                .HasMaxLength(4)
                .HasColumnName("ship_code");
            entity.Property(e => e.Slsman)
                .HasMaxLength(8)
                .HasColumnName("slsman");
            entity.Property(e => e.SroNum)
                .HasMaxLength(10)
                .HasColumnName("sro_num");
            entity.Property(e => e.SroStat)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("sro_stat");
            entity.Property(e => e.SroType)
                .HasMaxLength(10)
                .HasColumnName("sro_type");
            entity.Property(e => e.Ssn)
                .HasMaxLength(11)
                .HasColumnName("ssn");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("start_date");
            entity.Property(e => e.StatCode)
                .HasMaxLength(10)
                .HasColumnName("stat_code");
            entity.Property(e => e.TaxCode1)
                .HasMaxLength(6)
                .HasColumnName("tax_code1");
            entity.Property(e => e.TaxCode2)
                .HasMaxLength(6)
                .HasColumnName("tax_code2");
            entity.Property(e => e.TermsCode)
                .HasMaxLength(3)
                .HasColumnName("terms_code");
            entity.Property(e => e.ToSchedule).HasColumnName("to_schedule");
            entity.Property(e => e.TotalBilled)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("total_billed");
            entity.Property(e => e.TotalCostLbr)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("total_cost_lbr");
            entity.Property(e => e.TotalCostMatl)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("total_cost_matl");
            entity.Property(e => e.TotalCostMisc)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("total_cost_misc");
            entity.Property(e => e.TotalPrice)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("total_price");
            entity.Property(e => e.TotalReimb)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("total_reimb");
            entity.Property(e => e.TotalSalesTax1)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("total_sales_tax1");
            entity.Property(e => e.TotalSalesTax2)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("total_sales_tax2");
            entity.Property(e => e.TotalVouchered)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("total_vouchered");
            entity.Property(e => e.TransNat)
                .HasMaxLength(2)
                .HasColumnName("trans_nat");
            entity.Property(e => e.TxtMsgAddr)
                .HasMaxLength(60)
                .HasColumnName("txt_msg_addr");
            entity.Property(e => e.UM)
                .HasMaxLength(3)
                .HasColumnName("u_m");
            entity.Property(e => e.UfLrmIntegrate).HasColumnName("Uf_LRM_Integrate");
            entity.Property(e => e.UpdatedBy).HasMaxLength(30);
            entity.Property(e => e.UseEst).HasColumnName("use_est");
            entity.Property(e => e.UsrNum)
                .HasMaxLength(7)
                .HasColumnName("usr_num");
            entity.Property(e => e.UsrSeq).HasColumnName("usr_seq");
            entity.Property(e => e.VendNum)
                .HasMaxLength(7)
                .HasColumnName("vend_num");
            entity.Property(e => e.WebView).HasColumnName("web_view");
            entity.Property(e => e.Whse)
                .HasMaxLength(4)
                .HasColumnName("whse");
        });

        modelBuilder.Entity<FsSroLine>(entity =>
        {
            entity.HasKey(e => e.RowPointer).HasName("PK__fs_sro_l__30A54D4401E1A70B");

            entity.ToTable("fs_sro_line");

            entity.Property(e => e.RowPointer).ValueGeneratedNever();
            entity.Property(e => e.AccumWip).HasColumnName("accum_wip");
            entity.Property(e => e.AwaitingParts).HasColumnName("awaiting_parts");
            entity.Property(e => e.BillCode)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("bill_code");
            entity.Property(e => e.BillStat)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("bill_stat");
            entity.Property(e => e.BillType)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("bill_type");
            entity.Property(e => e.CgsRevLocLabor)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("cgs_rev_loc_labor");
            entity.Property(e => e.CgsRevLocMatl)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("cgs_rev_loc_matl");
            entity.Property(e => e.CgsRevLocMisc)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("cgs_rev_loc_misc");
            entity.Property(e => e.Charfld1)
                .HasMaxLength(20)
                .HasColumnName("charfld1");
            entity.Property(e => e.Charfld2)
                .HasMaxLength(20)
                .HasColumnName("charfld2");
            entity.Property(e => e.Charfld3)
                .HasMaxLength(20)
                .HasColumnName("charfld3");
            entity.Property(e => e.ContLine).HasColumnName("cont_line");
            entity.Property(e => e.Contract)
                .HasMaxLength(10)
                .HasColumnName("contract");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.CustItem)
                .HasMaxLength(30)
                .HasColumnName("cust_item");
            entity.Property(e => e.Datefld)
                .HasColumnType("datetime")
                .HasColumnName("datefld");
            entity.Property(e => e.Decifld1)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld1");
            entity.Property(e => e.Decifld2)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld2");
            entity.Property(e => e.Decifld3)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld3");
            entity.Property(e => e.Dept)
                .HasMaxLength(6)
                .HasColumnName("dept");
            entity.Property(e => e.Description)
                .HasMaxLength(40)
                .HasColumnName("description");
            entity.Property(e => e.DueDate)
                .HasColumnType("datetime")
                .HasColumnName("due_date");
            entity.Property(e => e.ExchDate)
                .HasColumnType("datetime")
                .HasColumnName("exch_date");
            entity.Property(e => e.ExtendLbrTrans).HasColumnName("extend_lbr_trans");
            entity.Property(e => e.ExtendMatlTrans).HasColumnName("extend_matl_trans");
            entity.Property(e => e.ExtendMiscTrans).HasColumnName("extend_misc_trans");
            entity.Property(e => e.IncNum)
                .HasMaxLength(10)
                .HasColumnName("inc_num");
            entity.Property(e => e.InspectType)
                .HasMaxLength(20)
                .HasColumnName("inspect_type");
            entity.Property(e => e.Item)
                .HasMaxLength(30)
                .HasColumnName("item");
            entity.Property(e => e.LineType)
                .HasMaxLength(9)
                .HasColumnName("line_type");
            entity.Property(e => e.Logifld).HasColumnName("logifld");
            entity.Property(e => e.MaintSeq).HasColumnName("maint_seq");
            entity.Property(e => e.MeterAmt).HasColumnName("meter_amt");
            entity.Property(e => e.MeterDate)
                .HasColumnType("datetime")
                .HasColumnName("meter_date");
            entity.Property(e => e.ObalLineMatl)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("obal_line_matl");
            entity.Property(e => e.PartnerId)
                .HasMaxLength(10)
                .HasColumnName("partner_id");
            entity.Property(e => e.Pricecode)
                .HasMaxLength(3)
                .HasColumnName("pricecode");
            entity.Property(e => e.ProductCode)
                .HasMaxLength(10)
                .HasColumnName("product_code");
            entity.Property(e => e.Qty)
                .HasColumnType("decimal(19, 8)")
                .HasColumnName("qty");
            entity.Property(e => e.QtyConv)
                .HasColumnType("decimal(19, 8)")
                .HasColumnName("qty_conv");
            entity.Property(e => e.QtyIssued)
                .HasColumnType("decimal(19, 8)")
                .HasColumnName("qty_issued");
            entity.Property(e => e.QtyIssuedConv)
                .HasColumnType("decimal(19, 8)")
                .HasColumnName("qty_issued_conv");
            entity.Property(e => e.QtyPacked)
                .HasColumnType("decimal(19, 8)")
                .HasColumnName("qty_packed");
            entity.Property(e => e.QtyReturned)
                .HasColumnType("decimal(19, 8)")
                .HasColumnName("qty_returned");
            entity.Property(e => e.QtyReturnedConv)
                .HasColumnType("decimal(19, 8)")
                .HasColumnName("qty_returned_conv");
            entity.Property(e => e.QtyShipped)
                .HasColumnType("decimal(19, 8)")
                .HasColumnName("qty_shipped");
            entity.Property(e => e.QtyShippedConv)
                .HasColumnType("decimal(19, 8)")
                .HasColumnName("qty_shipped_conv");
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.RefLineSuf).HasColumnName("ref_line_suf");
            entity.Property(e => e.RefNum)
                .HasMaxLength(10)
                .HasColumnName("ref_num");
            entity.Property(e => e.RefRelease).HasColumnName("ref_release");
            entity.Property(e => e.RefType)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("ref_type");
            entity.Property(e => e.SerNum)
                .HasMaxLength(30)
                .HasColumnName("ser_num");
            entity.Property(e => e.SroLine).HasColumnName("sro_line");
            entity.Property(e => e.SroNum)
                .HasMaxLength(10)
                .HasColumnName("sro_num");
            entity.Property(e => e.SroType)
                .HasMaxLength(10)
                .HasColumnName("sro_type");
            entity.Property(e => e.Stat)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("stat");
            entity.Property(e => e.ToSchedule).HasColumnName("to_schedule");
            entity.Property(e => e.TotalBilled)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("total_billed");
            entity.Property(e => e.TotalCostLbr)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("total_cost_lbr");
            entity.Property(e => e.TotalCostMatl)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("total_cost_matl");
            entity.Property(e => e.TotalCostMisc)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("total_cost_misc");
            entity.Property(e => e.TotalPrice)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("total_price");
            entity.Property(e => e.TotalSalesTax1)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("total_sales_tax1");
            entity.Property(e => e.TotalSalesTax2)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("total_sales_tax2");
            entity.Property(e => e.UM)
                .HasMaxLength(3)
                .HasColumnName("u_m");
            entity.Property(e => e.UfSegFsRepairType)
                .HasMaxLength(20)
                .HasColumnName("Uf_SEG_fsRepairType");
            entity.Property(e => e.UfSegFsStartDate)
                .HasColumnType("datetime")
                .HasColumnName("Uf_SEG_fsStartDate");
            entity.Property(e => e.UpdatedBy).HasMaxLength(30);
            entity.Property(e => e.UseEst).HasColumnName("use_est");
        });

        modelBuilder.Entity<FsSroLineMatl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("fs_sro_line_matl");

            entity.Property(e => e.AppliedFovhdCost)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("applied_fovhd_cost");
            entity.Property(e => e.AppliedVovhdCost)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("applied_vovhd_cost");
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(30)
                .HasColumnName("approved_by");
            entity.Property(e => e.ApprovedDate)
                .HasColumnType("datetime")
                .HasColumnName("approved_date");
            entity.Property(e => e.BillCode)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("bill_code");
            entity.Property(e => e.BillHold).HasColumnName("bill_hold");
            entity.Property(e => e.BillStat)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("bill_stat");
            entity.Property(e => e.Charfld1)
                .HasMaxLength(20)
                .HasColumnName("charfld1");
            entity.Property(e => e.Charfld2)
                .HasMaxLength(20)
                .HasColumnName("charfld2");
            entity.Property(e => e.Charfld3)
                .HasMaxLength(20)
                .HasColumnName("charfld3");
            entity.Property(e => e.CommCode)
                .HasMaxLength(12)
                .HasColumnName("comm_code");
            entity.Property(e => e.ConsNum).HasColumnName("cons_num");
            entity.Property(e => e.Cost)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("cost");
            entity.Property(e => e.CostConv)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("cost_conv");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.Datefld)
                .HasColumnType("datetime")
                .HasColumnName("datefld");
            entity.Property(e => e.Decifld1)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld1");
            entity.Property(e => e.Decifld2)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld2");
            entity.Property(e => e.Decifld3)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld3");
            entity.Property(e => e.Delterm)
                .HasMaxLength(4)
                .HasColumnName("delterm");
            entity.Property(e => e.Dept)
                .HasMaxLength(6)
                .HasColumnName("dept");
            entity.Property(e => e.Description)
                .HasMaxLength(40)
                .HasColumnName("description");
            entity.Property(e => e.Disc)
                .HasColumnType("decimal(4, 1)")
                .HasColumnName("disc");
            entity.Property(e => e.DropNum)
                .HasMaxLength(10)
                .HasColumnName("drop_num");
            entity.Property(e => e.DropSeq).HasColumnName("drop_seq");
            entity.Property(e => e.DropType)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("drop_type");
            entity.Property(e => e.EcCode)
                .HasMaxLength(2)
                .HasColumnName("ec_code");
            entity.Property(e => e.EstSalesTax1)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("est_sales_tax1");
            entity.Property(e => e.EstSalesTax2)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("est_sales_tax2");
            entity.Property(e => e.ExchDate)
                .HasColumnType("datetime")
                .HasColumnName("exch_date");
            entity.Property(e => e.ExpFovAcct)
                .HasMaxLength(12)
                .HasColumnName("exp_fov_acct");
            entity.Property(e => e.ExpFovAcctUnit1)
                .HasMaxLength(4)
                .HasColumnName("exp_fov_acct_unit1");
            entity.Property(e => e.ExpFovAcctUnit2)
                .HasMaxLength(4)
                .HasColumnName("exp_fov_acct_unit2");
            entity.Property(e => e.ExpFovAcctUnit3)
                .HasMaxLength(4)
                .HasColumnName("exp_fov_acct_unit3");
            entity.Property(e => e.ExpFovAcctUnit4)
                .HasMaxLength(4)
                .HasColumnName("exp_fov_acct_unit4");
            entity.Property(e => e.ExpLbrAcct)
                .HasMaxLength(12)
                .HasColumnName("exp_lbr_acct");
            entity.Property(e => e.ExpLbrAcctUnit1)
                .HasMaxLength(4)
                .HasColumnName("exp_lbr_acct_unit1");
            entity.Property(e => e.ExpLbrAcctUnit2)
                .HasMaxLength(4)
                .HasColumnName("exp_lbr_acct_unit2");
            entity.Property(e => e.ExpLbrAcctUnit3)
                .HasMaxLength(4)
                .HasColumnName("exp_lbr_acct_unit3");
            entity.Property(e => e.ExpLbrAcctUnit4)
                .HasMaxLength(4)
                .HasColumnName("exp_lbr_acct_unit4");
            entity.Property(e => e.ExpMatlAcct)
                .HasMaxLength(12)
                .HasColumnName("exp_matl_acct");
            entity.Property(e => e.ExpMatlAcctUnit1)
                .HasMaxLength(4)
                .HasColumnName("exp_matl_acct_unit1");
            entity.Property(e => e.ExpMatlAcctUnit2)
                .HasMaxLength(4)
                .HasColumnName("exp_matl_acct_unit2");
            entity.Property(e => e.ExpMatlAcctUnit3)
                .HasMaxLength(4)
                .HasColumnName("exp_matl_acct_unit3");
            entity.Property(e => e.ExpMatlAcctUnit4)
                .HasMaxLength(4)
                .HasColumnName("exp_matl_acct_unit4");
            entity.Property(e => e.ExpOutAcct)
                .HasMaxLength(12)
                .HasColumnName("exp_out_acct");
            entity.Property(e => e.ExpOutAcctUnit1)
                .HasMaxLength(4)
                .HasColumnName("exp_out_acct_unit1");
            entity.Property(e => e.ExpOutAcctUnit2)
                .HasMaxLength(4)
                .HasColumnName("exp_out_acct_unit2");
            entity.Property(e => e.ExpOutAcctUnit3)
                .HasMaxLength(4)
                .HasColumnName("exp_out_acct_unit3");
            entity.Property(e => e.ExpOutAcctUnit4)
                .HasMaxLength(4)
                .HasColumnName("exp_out_acct_unit4");
            entity.Property(e => e.ExpVovAcct)
                .HasMaxLength(12)
                .HasColumnName("exp_vov_acct");
            entity.Property(e => e.ExpVovAcctUnit1)
                .HasMaxLength(4)
                .HasColumnName("exp_vov_acct_unit1");
            entity.Property(e => e.ExpVovAcctUnit2)
                .HasMaxLength(4)
                .HasColumnName("exp_vov_acct_unit2");
            entity.Property(e => e.ExpVovAcctUnit3)
                .HasMaxLength(4)
                .HasColumnName("exp_vov_acct_unit3");
            entity.Property(e => e.ExpVovAcctUnit4)
                .HasMaxLength(4)
                .HasColumnName("exp_vov_acct_unit4");
            entity.Property(e => e.ExportValue)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("export_value");
            entity.Property(e => e.Extcost)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("extcost");
            entity.Property(e => e.Extprice)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("extprice");
            entity.Property(e => e.FovhdCost)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("fovhd_cost");
            entity.Property(e => e.FovhdCostConv)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("fovhd_cost_conv");
            entity.Property(e => e.InvLine).HasColumnName("inv_line");
            entity.Property(e => e.InvNum)
                .HasMaxLength(12)
                .HasColumnName("inv_num");
            entity.Property(e => e.Item)
                .HasMaxLength(30)
                .HasColumnName("item");
            entity.Property(e => e.LbrCost)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("lbr_cost");
            entity.Property(e => e.LbrCostConv)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("lbr_cost_conv");
            entity.Property(e => e.LoanerLoc)
                .HasMaxLength(15)
                .HasColumnName("loaner_loc");
            entity.Property(e => e.LoanerWhse)
                .HasMaxLength(4)
                .HasColumnName("loaner_whse");
            entity.Property(e => e.Loc)
                .HasMaxLength(15)
                .HasColumnName("loc");
            entity.Property(e => e.Logifld).HasColumnName("logifld");
            entity.Property(e => e.Lot)
                .HasMaxLength(15)
                .HasColumnName("lot");
            entity.Property(e => e.MatlCost)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("matl_cost");
            entity.Property(e => e.MatlCostConv)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("matl_cost_conv");
            entity.Property(e => e.MatlQty)
                .HasColumnType("decimal(19, 8)")
                .HasColumnName("matl_qty");
            entity.Property(e => e.MatlQtyConv)
                .HasColumnType("decimal(19, 8)")
                .HasColumnName("matl_qty_conv");
            entity.Property(e => e.MatltranTransNum)
                .HasColumnType("decimal(10, 0)")
                .HasColumnName("matltran_trans_num");
            entity.Property(e => e.Obal)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("obal");
            entity.Property(e => e.Origin)
                .HasMaxLength(2)
                .HasColumnName("origin");
            entity.Property(e => e.OutCost)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("out_cost");
            entity.Property(e => e.OutCostConv)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("out_cost_conv");
            entity.Property(e => e.PackNum).HasColumnName("pack_num");
            entity.Property(e => e.PackSeq).HasColumnName("pack_seq");
            entity.Property(e => e.PartnerId)
                .HasMaxLength(10)
                .HasColumnName("partner_id");
            entity.Property(e => e.PostDate)
                .HasColumnType("datetime")
                .HasColumnName("post_date");
            entity.Property(e => e.Posted).HasColumnName("posted");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("price");
            entity.Property(e => e.PriceConv)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("price_conv");
            entity.Property(e => e.Pricecode)
                .HasMaxLength(3)
                .HasColumnName("pricecode");
            entity.Property(e => e.ProcessInd)
                .HasMaxLength(1)
                .HasColumnName("process_ind");
            entity.Property(e => e.QtyBackOrder)
                .HasColumnType("decimal(19, 8)")
                .HasColumnName("qty_back_order");
            entity.Property(e => e.QtyBackOrderConv)
                .HasColumnType("decimal(19, 8)")
                .HasColumnName("qty_back_order_conv");
            entity.Property(e => e.QtyPacked)
                .HasColumnType("decimal(19, 8)")
                .HasColumnName("qty_packed");
            entity.Property(e => e.QtyShipped)
                .HasColumnType("decimal(19, 8)")
                .HasColumnName("qty_shipped");
            entity.Property(e => e.QtyShippedConv)
                .HasColumnType("decimal(19, 8)")
                .HasColumnName("qty_shipped_conv");
            entity.Property(e => e.ReasonCode)
                .HasMaxLength(3)
                .HasColumnName("reason_code");
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.RefLineSuf).HasColumnName("ref_line_suf");
            entity.Property(e => e.RefNum)
                .HasMaxLength(10)
                .HasColumnName("ref_num");
            entity.Property(e => e.RefRelease).HasColumnName("ref_release");
            entity.Property(e => e.RefType)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("ref_type");
            entity.Property(e => e.RevAcct)
                .HasMaxLength(12)
                .HasColumnName("rev_acct");
            entity.Property(e => e.RevAcctUnit1)
                .HasMaxLength(4)
                .HasColumnName("rev_acct_unit1");
            entity.Property(e => e.RevAcctUnit2)
                .HasMaxLength(4)
                .HasColumnName("rev_acct_unit2");
            entity.Property(e => e.RevAcctUnit3)
                .HasMaxLength(4)
                .HasColumnName("rev_acct_unit3");
            entity.Property(e => e.RevAcctUnit4)
                .HasMaxLength(4)
                .HasColumnName("rev_acct_unit4");
            entity.Property(e => e.RtnToStock).HasColumnName("rtn_to_stock");
            entity.Property(e => e.SaleDsAcct)
                .HasMaxLength(12)
                .HasColumnName("sale_ds_acct");
            entity.Property(e => e.SaleDsAcctUnit1)
                .HasMaxLength(4)
                .HasColumnName("sale_ds_acct_unit1");
            entity.Property(e => e.SaleDsAcctUnit2)
                .HasMaxLength(4)
                .HasColumnName("sale_ds_acct_unit2");
            entity.Property(e => e.SaleDsAcctUnit3)
                .HasMaxLength(4)
                .HasColumnName("sale_ds_acct_unit3");
            entity.Property(e => e.SaleDsAcctUnit4)
                .HasMaxLength(4)
                .HasColumnName("sale_ds_acct_unit4");
            entity.Property(e => e.SroLine).HasColumnName("sro_line");
            entity.Property(e => e.SroNum)
                .HasMaxLength(10)
                .HasColumnName("sro_num");
            entity.Property(e => e.SsdRefRowPointer).HasColumnName("ssd_RefRowPointer");
            entity.Property(e => e.SupplyQty)
                .HasColumnType("decimal(18, 8)")
                .HasColumnName("supply_qty");
            entity.Property(e => e.TaxCode1)
                .HasMaxLength(6)
                .HasColumnName("tax_code1");
            entity.Property(e => e.TaxCode2)
                .HasMaxLength(6)
                .HasColumnName("tax_code2");
            entity.Property(e => e.Teardown).HasColumnName("teardown");
            entity.Property(e => e.TransDate)
                .HasColumnType("datetime")
                .HasColumnName("trans_date");
            entity.Property(e => e.TransNat)
                .HasMaxLength(2)
                .HasColumnName("trans_nat");
            entity.Property(e => e.TransNum).HasColumnName("trans_num");
            entity.Property(e => e.TransType)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("trans_type");
            entity.Property(e => e.Type)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("type");
            entity.Property(e => e.UM)
                .HasMaxLength(3)
                .HasColumnName("u_m");
            entity.Property(e => e.UnitWeight)
                .HasColumnType("decimal(11, 3)")
                .HasColumnName("unit_weight");
            entity.Property(e => e.UpdatedBy).HasMaxLength(30);
            entity.Property(e => e.UsageType)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("usage_type");
            entity.Property(e => e.VovhdCost)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("vovhd_cost");
            entity.Property(e => e.VovhdCostConv)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("vovhd_cost_conv");
            entity.Property(e => e.Whse)
                .HasMaxLength(4)
                .HasColumnName("whse");
            entity.Property(e => e.WipFov)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("wip_fov");
            entity.Property(e => e.WipFovAcct)
                .HasMaxLength(12)
                .HasColumnName("wip_fov_acct");
            entity.Property(e => e.WipFovAcctUnit1)
                .HasMaxLength(4)
                .HasColumnName("wip_fov_acct_unit1");
            entity.Property(e => e.WipFovAcctUnit2)
                .HasMaxLength(4)
                .HasColumnName("wip_fov_acct_unit2");
            entity.Property(e => e.WipFovAcctUnit3)
                .HasMaxLength(4)
                .HasColumnName("wip_fov_acct_unit3");
            entity.Property(e => e.WipFovAcctUnit4)
                .HasMaxLength(4)
                .HasColumnName("wip_fov_acct_unit4");
            entity.Property(e => e.WipLbr)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("wip_lbr");
            entity.Property(e => e.WipLbrAcct)
                .HasMaxLength(12)
                .HasColumnName("wip_lbr_acct");
            entity.Property(e => e.WipLbrAcctUnit1)
                .HasMaxLength(4)
                .HasColumnName("wip_lbr_acct_unit1");
            entity.Property(e => e.WipLbrAcctUnit2)
                .HasMaxLength(4)
                .HasColumnName("wip_lbr_acct_unit2");
            entity.Property(e => e.WipLbrAcctUnit3)
                .HasMaxLength(4)
                .HasColumnName("wip_lbr_acct_unit3");
            entity.Property(e => e.WipLbrAcctUnit4)
                .HasMaxLength(4)
                .HasColumnName("wip_lbr_acct_unit4");
            entity.Property(e => e.WipMatl)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("wip_matl");
            entity.Property(e => e.WipMatlAcct)
                .HasMaxLength(12)
                .HasColumnName("wip_matl_acct");
            entity.Property(e => e.WipMatlAcctUnit1)
                .HasMaxLength(4)
                .HasColumnName("wip_matl_acct_unit1");
            entity.Property(e => e.WipMatlAcctUnit2)
                .HasMaxLength(4)
                .HasColumnName("wip_matl_acct_unit2");
            entity.Property(e => e.WipMatlAcctUnit3)
                .HasMaxLength(4)
                .HasColumnName("wip_matl_acct_unit3");
            entity.Property(e => e.WipMatlAcctUnit4)
                .HasMaxLength(4)
                .HasColumnName("wip_matl_acct_unit4");
            entity.Property(e => e.WipOut)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("wip_out");
            entity.Property(e => e.WipOutAcct)
                .HasMaxLength(12)
                .HasColumnName("wip_out_acct");
            entity.Property(e => e.WipOutAcctUnit1)
                .HasMaxLength(4)
                .HasColumnName("wip_out_acct_unit1");
            entity.Property(e => e.WipOutAcctUnit2)
                .HasMaxLength(4)
                .HasColumnName("wip_out_acct_unit2");
            entity.Property(e => e.WipOutAcctUnit3)
                .HasMaxLength(4)
                .HasColumnName("wip_out_acct_unit3");
            entity.Property(e => e.WipOutAcctUnit4)
                .HasMaxLength(4)
                .HasColumnName("wip_out_acct_unit4");
            entity.Property(e => e.WipRelFov)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("wip_rel_fov");
            entity.Property(e => e.WipRelLbr)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("wip_rel_lbr");
            entity.Property(e => e.WipRelMatl)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("wip_rel_matl");
            entity.Property(e => e.WipRelOut)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("wip_rel_out");
            entity.Property(e => e.WipRelVov)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("wip_rel_vov");
            entity.Property(e => e.WipVov)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("wip_vov");
            entity.Property(e => e.WipVovAcct)
                .HasMaxLength(12)
                .HasColumnName("wip_vov_acct");
            entity.Property(e => e.WipVovAcctUnit1)
                .HasMaxLength(4)
                .HasColumnName("wip_vov_acct_unit1");
            entity.Property(e => e.WipVovAcctUnit2)
                .HasMaxLength(4)
                .HasColumnName("wip_vov_acct_unit2");
            entity.Property(e => e.WipVovAcctUnit3)
                .HasMaxLength(4)
                .HasColumnName("wip_vov_acct_unit3");
            entity.Property(e => e.WipVovAcctUnit4)
                .HasMaxLength(4)
                .HasColumnName("wip_vov_acct_unit4");
        });

        modelBuilder.Entity<FsSroMatl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("fs_sro_matl");

            entity.Property(e => e.AppliedFovhdCost)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("applied_fovhd_cost");
            entity.Property(e => e.AppliedVovhdCost)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("applied_vovhd_cost");
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(30)
                .HasColumnName("approved_by");
            entity.Property(e => e.ApprovedDate)
                .HasColumnType("datetime")
                .HasColumnName("approved_date");
            entity.Property(e => e.BillCode)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("bill_code");
            entity.Property(e => e.BillHold).HasColumnName("bill_hold");
            entity.Property(e => e.BillMgr)
                .HasMaxLength(10)
                .HasColumnName("bill_mgr");
            entity.Property(e => e.BillStat)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("bill_stat");
            entity.Property(e => e.BoSrcTrans).HasColumnName("bo_src_trans");
            entity.Property(e => e.Charfld1)
                .HasMaxLength(20)
                .HasColumnName("charfld1");
            entity.Property(e => e.Charfld2)
                .HasMaxLength(20)
                .HasColumnName("charfld2");
            entity.Property(e => e.Charfld3)
                .HasMaxLength(20)
                .HasColumnName("charfld3");
            entity.Property(e => e.CommCode)
                .HasMaxLength(12)
                .HasColumnName("comm_code");
            entity.Property(e => e.ConsNum).HasColumnName("cons_num");
            entity.Property(e => e.Cost)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("cost");
            entity.Property(e => e.CostConv)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("cost_conv");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.CustItem)
                .HasMaxLength(30)
                .HasColumnName("cust_item");
            entity.Property(e => e.Datefld)
                .HasColumnType("datetime")
                .HasColumnName("datefld");
            entity.Property(e => e.Decifld1)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld1");
            entity.Property(e => e.Decifld2)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld2");
            entity.Property(e => e.Decifld3)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld3");
            entity.Property(e => e.Delterm)
                .HasMaxLength(4)
                .HasColumnName("delterm");
            entity.Property(e => e.Dept)
                .HasMaxLength(6)
                .HasColumnName("dept");
            entity.Property(e => e.Description)
                .HasMaxLength(40)
                .HasColumnName("description");
            entity.Property(e => e.Disc)
                .HasColumnType("decimal(4, 1)")
                .HasColumnName("disc");
            entity.Property(e => e.DropNum)
                .HasMaxLength(10)
                .HasColumnName("drop_num");
            entity.Property(e => e.DropSeq).HasColumnName("drop_seq");
            entity.Property(e => e.DropType)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("drop_type");
            entity.Property(e => e.EcCode)
                .HasMaxLength(2)
                .HasColumnName("ec_code");
            entity.Property(e => e.EstSalesTax1)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("est_sales_tax1");
            entity.Property(e => e.EstSalesTax2)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("est_sales_tax2");
            entity.Property(e => e.ExchDate)
                .HasColumnType("datetime")
                .HasColumnName("exch_date");
            entity.Property(e => e.ExpFovAcct)
                .HasMaxLength(12)
                .HasColumnName("exp_fov_acct");
            entity.Property(e => e.ExpFovAcctUnit1)
                .HasMaxLength(4)
                .HasColumnName("exp_fov_acct_unit1");
            entity.Property(e => e.ExpFovAcctUnit2)
                .HasMaxLength(4)
                .HasColumnName("exp_fov_acct_unit2");
            entity.Property(e => e.ExpFovAcctUnit3)
                .HasMaxLength(4)
                .HasColumnName("exp_fov_acct_unit3");
            entity.Property(e => e.ExpFovAcctUnit4)
                .HasMaxLength(4)
                .HasColumnName("exp_fov_acct_unit4");
            entity.Property(e => e.ExpLbrAcct)
                .HasMaxLength(12)
                .HasColumnName("exp_lbr_acct");
            entity.Property(e => e.ExpLbrAcctUnit1)
                .HasMaxLength(4)
                .HasColumnName("exp_lbr_acct_unit1");
            entity.Property(e => e.ExpLbrAcctUnit2)
                .HasMaxLength(4)
                .HasColumnName("exp_lbr_acct_unit2");
            entity.Property(e => e.ExpLbrAcctUnit3)
                .HasMaxLength(4)
                .HasColumnName("exp_lbr_acct_unit3");
            entity.Property(e => e.ExpLbrAcctUnit4)
                .HasMaxLength(4)
                .HasColumnName("exp_lbr_acct_unit4");
            entity.Property(e => e.ExpMatlAcct)
                .HasMaxLength(12)
                .HasColumnName("exp_matl_acct");
            entity.Property(e => e.ExpMatlAcctUnit1)
                .HasMaxLength(4)
                .HasColumnName("exp_matl_acct_unit1");
            entity.Property(e => e.ExpMatlAcctUnit2)
                .HasMaxLength(4)
                .HasColumnName("exp_matl_acct_unit2");
            entity.Property(e => e.ExpMatlAcctUnit3)
                .HasMaxLength(4)
                .HasColumnName("exp_matl_acct_unit3");
            entity.Property(e => e.ExpMatlAcctUnit4)
                .HasMaxLength(4)
                .HasColumnName("exp_matl_acct_unit4");
            entity.Property(e => e.ExpOutAcct)
                .HasMaxLength(12)
                .HasColumnName("exp_out_acct");
            entity.Property(e => e.ExpOutAcctUnit1)
                .HasMaxLength(4)
                .HasColumnName("exp_out_acct_unit1");
            entity.Property(e => e.ExpOutAcctUnit2)
                .HasMaxLength(4)
                .HasColumnName("exp_out_acct_unit2");
            entity.Property(e => e.ExpOutAcctUnit3)
                .HasMaxLength(4)
                .HasColumnName("exp_out_acct_unit3");
            entity.Property(e => e.ExpOutAcctUnit4)
                .HasMaxLength(4)
                .HasColumnName("exp_out_acct_unit4");
            entity.Property(e => e.ExpVovAcct)
                .HasMaxLength(12)
                .HasColumnName("exp_vov_acct");
            entity.Property(e => e.ExpVovAcctUnit1)
                .HasMaxLength(4)
                .HasColumnName("exp_vov_acct_unit1");
            entity.Property(e => e.ExpVovAcctUnit2)
                .HasMaxLength(4)
                .HasColumnName("exp_vov_acct_unit2");
            entity.Property(e => e.ExpVovAcctUnit3)
                .HasMaxLength(4)
                .HasColumnName("exp_vov_acct_unit3");
            entity.Property(e => e.ExpVovAcctUnit4)
                .HasMaxLength(4)
                .HasColumnName("exp_vov_acct_unit4");
            entity.Property(e => e.ExportValue)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("export_value");
            entity.Property(e => e.Extcost)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("extcost");
            entity.Property(e => e.Extprice)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("extprice");
            entity.Property(e => e.FovhdCost)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("fovhd_cost");
            entity.Property(e => e.FovhdCostConv)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("fovhd_cost_conv");
            entity.Property(e => e.InvLine).HasColumnName("inv_line");
            entity.Property(e => e.InvNum)
                .HasMaxLength(12)
                .HasColumnName("inv_num");
            entity.Property(e => e.Item)
                .HasMaxLength(30)
                .HasColumnName("item");
            entity.Property(e => e.LbrCost)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("lbr_cost");
            entity.Property(e => e.LbrCostConv)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("lbr_cost_conv");
            entity.Property(e => e.LoanerLoc)
                .HasMaxLength(15)
                .HasColumnName("loaner_loc");
            entity.Property(e => e.LoanerWhse)
                .HasMaxLength(4)
                .HasColumnName("loaner_whse");
            entity.Property(e => e.Loc)
                .HasMaxLength(15)
                .HasColumnName("loc");
            entity.Property(e => e.Logifld).HasColumnName("logifld");
            entity.Property(e => e.Lot)
                .HasMaxLength(15)
                .HasColumnName("lot");
            entity.Property(e => e.MatlCost)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("matl_cost");
            entity.Property(e => e.MatlCostConv)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("matl_cost_conv");
            entity.Property(e => e.MatlQty)
                .HasColumnType("decimal(19, 8)")
                .HasColumnName("matl_qty");
            entity.Property(e => e.MatlQtyConv)
                .HasColumnType("decimal(19, 8)")
                .HasColumnName("matl_qty_conv");
            entity.Property(e => e.MatltranTransNum)
                .HasColumnType("decimal(10, 0)")
                .HasColumnName("matltran_trans_num");
            entity.Property(e => e.Obal)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("obal");
            entity.Property(e => e.Origin)
                .HasMaxLength(2)
                .HasColumnName("origin");
            entity.Property(e => e.OutCost)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("out_cost");
            entity.Property(e => e.OutCostConv)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("out_cost_conv");
            entity.Property(e => e.PackNum).HasColumnName("pack_num");
            entity.Property(e => e.PackSeq).HasColumnName("pack_seq");
            entity.Property(e => e.PartnerId)
                .HasMaxLength(10)
                .HasColumnName("partner_id");
            entity.Property(e => e.PlanTrans).HasColumnName("plan_trans");
            entity.Property(e => e.PostDate)
                .HasColumnType("datetime")
                .HasColumnName("post_date");
            entity.Property(e => e.Posted).HasColumnName("posted");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("price");
            entity.Property(e => e.PriceConv)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("price_conv");
            entity.Property(e => e.Pricecode)
                .HasMaxLength(3)
                .HasColumnName("pricecode");
            entity.Property(e => e.ProcessInd)
                .HasMaxLength(1)
                .HasColumnName("process_ind");
            entity.Property(e => e.ProjectedDate)
                .HasColumnType("datetime")
                .HasColumnName("projected_date");
            entity.Property(e => e.QtyBackOrder)
                .HasColumnType("decimal(19, 8)")
                .HasColumnName("qty_back_order");
            entity.Property(e => e.QtyBackOrderConv)
                .HasColumnType("decimal(19, 8)")
                .HasColumnName("qty_back_order_conv");
            entity.Property(e => e.QtyPacked)
                .HasColumnType("decimal(19, 8)")
                .HasColumnName("qty_packed");
            entity.Property(e => e.QtyShipped)
                .HasColumnType("decimal(19, 8)")
                .HasColumnName("qty_shipped");
            entity.Property(e => e.QtyShippedConv)
                .HasColumnType("decimal(19, 8)")
                .HasColumnName("qty_shipped_conv");
            entity.Property(e => e.ReasonCode)
                .HasMaxLength(3)
                .HasColumnName("reason_code");
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.RefLineSuf).HasColumnName("ref_line_suf");
            entity.Property(e => e.RefNum)
                .HasMaxLength(10)
                .HasColumnName("ref_num");
            entity.Property(e => e.RefRelease).HasColumnName("ref_release");
            entity.Property(e => e.RefType)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("ref_type");
            entity.Property(e => e.ReimbAcct)
                .HasMaxLength(12)
                .HasColumnName("reimb_acct");
            entity.Property(e => e.ReimbAcctUnit1)
                .HasMaxLength(4)
                .HasColumnName("reimb_acct_unit1");
            entity.Property(e => e.ReimbAcctUnit2)
                .HasMaxLength(4)
                .HasColumnName("reimb_acct_unit2");
            entity.Property(e => e.ReimbAcctUnit3)
                .HasMaxLength(4)
                .HasColumnName("reimb_acct_unit3");
            entity.Property(e => e.ReimbAcctUnit4)
                .HasMaxLength(4)
                .HasColumnName("reimb_acct_unit4");
            entity.Property(e => e.ReimbBatchId)
                .HasMaxLength(40)
                .HasColumnName("reimb_batch_id");
            entity.Property(e => e.ReimbDate)
                .HasColumnType("datetime")
                .HasColumnName("reimb_date");
            entity.Property(e => e.ReimbPartner).HasColumnName("reimb_partner");
            entity.Property(e => e.ReimbSalesTax)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("reimb_sales_tax");
            entity.Property(e => e.ReimbStat)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("reimb_stat");
            entity.Property(e => e.ReimbTaxCode1)
                .HasMaxLength(6)
                .HasColumnName("reimb_tax_code1");
            entity.Property(e => e.ReimbTaxCode2)
                .HasMaxLength(6)
                .HasColumnName("reimb_tax_code2");
            entity.Property(e => e.ReimburseAmt)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("reimburse_amt");
            entity.Property(e => e.ReimburseDue)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("reimburse_due");
            entity.Property(e => e.ReimbursePaid)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("reimburse_paid");
            entity.Property(e => e.RevAcct)
                .HasMaxLength(12)
                .HasColumnName("rev_acct");
            entity.Property(e => e.RevAcctUnit1)
                .HasMaxLength(4)
                .HasColumnName("rev_acct_unit1");
            entity.Property(e => e.RevAcctUnit2)
                .HasMaxLength(4)
                .HasColumnName("rev_acct_unit2");
            entity.Property(e => e.RevAcctUnit3)
                .HasMaxLength(4)
                .HasColumnName("rev_acct_unit3");
            entity.Property(e => e.RevAcctUnit4)
                .HasMaxLength(4)
                .HasColumnName("rev_acct_unit4");
            entity.Property(e => e.RtnToStock).HasColumnName("rtn_to_stock");
            entity.Property(e => e.SaleDsAcct)
                .HasMaxLength(12)
                .HasColumnName("sale_ds_acct");
            entity.Property(e => e.SaleDsAcctUnit1)
                .HasMaxLength(4)
                .HasColumnName("sale_ds_acct_unit1");
            entity.Property(e => e.SaleDsAcctUnit2)
                .HasMaxLength(4)
                .HasColumnName("sale_ds_acct_unit2");
            entity.Property(e => e.SaleDsAcctUnit3)
                .HasMaxLength(4)
                .HasColumnName("sale_ds_acct_unit3");
            entity.Property(e => e.SaleDsAcctUnit4)
                .HasMaxLength(4)
                .HasColumnName("sale_ds_acct_unit4");
            entity.Property(e => e.SignOff)
                .HasMaxLength(10)
                .HasColumnName("sign_off");
            entity.Property(e => e.SignOffDate)
                .HasColumnType("datetime")
                .HasColumnName("sign_off_date");
            entity.Property(e => e.SroLine).HasColumnName("sro_line");
            entity.Property(e => e.SroNum)
                .HasMaxLength(10)
                .HasColumnName("sro_num");
            entity.Property(e => e.SroOper).HasColumnName("sro_oper");
            entity.Property(e => e.SsdRefRowPointer).HasColumnName("ssd_RefRowPointer");
            entity.Property(e => e.SupplyQty)
                .HasColumnType("decimal(18, 8)")
                .HasColumnName("supply_qty");
            entity.Property(e => e.TaxCode1)
                .HasMaxLength(6)
                .HasColumnName("tax_code1");
            entity.Property(e => e.TaxCode2)
                .HasMaxLength(6)
                .HasColumnName("tax_code2");
            entity.Property(e => e.Teardown).HasColumnName("teardown");
            entity.Property(e => e.TransDate)
                .HasColumnType("datetime")
                .HasColumnName("trans_date");
            entity.Property(e => e.TransNat)
                .HasMaxLength(2)
                .HasColumnName("trans_nat");
            entity.Property(e => e.TransNum).HasColumnName("trans_num");
            entity.Property(e => e.TransType)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("trans_type");
            entity.Property(e => e.Type)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("type");
            entity.Property(e => e.UM)
                .HasMaxLength(3)
                .HasColumnName("u_m");
            entity.Property(e => e.UfSegFsApproved).HasColumnName("Uf_SEG_fsApproved");
            entity.Property(e => e.UfSegFsInstalled).HasColumnName("Uf_SEG_fsInstalled");
            entity.Property(e => e.UfSegFsNewSerial)
                .HasMaxLength(30)
                .HasColumnName("Uf_SEG_fsNewSerial");
            entity.Property(e => e.UfSegFsOldSerial)
                .HasMaxLength(30)
                .HasColumnName("Uf_SEG_fsOldSerial");
            entity.Property(e => e.UfSegFsRequired).HasColumnName("Uf_SEG_fsRequired");
            entity.Property(e => e.UfSegServiceAct)
                .HasMaxLength(64)
                .HasColumnName("Uf_SEG_ServiceAct");
            entity.Property(e => e.UnitWeight)
                .HasColumnType("decimal(11, 3)")
                .HasColumnName("unit_weight");
            entity.Property(e => e.UpdatedBy).HasMaxLength(30);
            entity.Property(e => e.UsageType)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("usage_type");
            entity.Property(e => e.VovhdCost)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("vovhd_cost");
            entity.Property(e => e.VovhdCostConv)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("vovhd_cost_conv");
            entity.Property(e => e.Whse)
                .HasMaxLength(4)
                .HasColumnName("whse");
            entity.Property(e => e.WipFov)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("wip_fov");
            entity.Property(e => e.WipFovAcct)
                .HasMaxLength(12)
                .HasColumnName("wip_fov_acct");
            entity.Property(e => e.WipFovAcctUnit1)
                .HasMaxLength(4)
                .HasColumnName("wip_fov_acct_unit1");
            entity.Property(e => e.WipFovAcctUnit2)
                .HasMaxLength(4)
                .HasColumnName("wip_fov_acct_unit2");
            entity.Property(e => e.WipFovAcctUnit3)
                .HasMaxLength(4)
                .HasColumnName("wip_fov_acct_unit3");
            entity.Property(e => e.WipFovAcctUnit4)
                .HasMaxLength(4)
                .HasColumnName("wip_fov_acct_unit4");
            entity.Property(e => e.WipLbr)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("wip_lbr");
            entity.Property(e => e.WipLbrAcct)
                .HasMaxLength(12)
                .HasColumnName("wip_lbr_acct");
            entity.Property(e => e.WipLbrAcctUnit1)
                .HasMaxLength(4)
                .HasColumnName("wip_lbr_acct_unit1");
            entity.Property(e => e.WipLbrAcctUnit2)
                .HasMaxLength(4)
                .HasColumnName("wip_lbr_acct_unit2");
            entity.Property(e => e.WipLbrAcctUnit3)
                .HasMaxLength(4)
                .HasColumnName("wip_lbr_acct_unit3");
            entity.Property(e => e.WipLbrAcctUnit4)
                .HasMaxLength(4)
                .HasColumnName("wip_lbr_acct_unit4");
            entity.Property(e => e.WipMatl)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("wip_matl");
            entity.Property(e => e.WipMatlAcct)
                .HasMaxLength(12)
                .HasColumnName("wip_matl_acct");
            entity.Property(e => e.WipMatlAcctUnit1)
                .HasMaxLength(4)
                .HasColumnName("wip_matl_acct_unit1");
            entity.Property(e => e.WipMatlAcctUnit2)
                .HasMaxLength(4)
                .HasColumnName("wip_matl_acct_unit2");
            entity.Property(e => e.WipMatlAcctUnit3)
                .HasMaxLength(4)
                .HasColumnName("wip_matl_acct_unit3");
            entity.Property(e => e.WipMatlAcctUnit4)
                .HasMaxLength(4)
                .HasColumnName("wip_matl_acct_unit4");
            entity.Property(e => e.WipOut)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("wip_out");
            entity.Property(e => e.WipOutAcct)
                .HasMaxLength(12)
                .HasColumnName("wip_out_acct");
            entity.Property(e => e.WipOutAcctUnit1)
                .HasMaxLength(4)
                .HasColumnName("wip_out_acct_unit1");
            entity.Property(e => e.WipOutAcctUnit2)
                .HasMaxLength(4)
                .HasColumnName("wip_out_acct_unit2");
            entity.Property(e => e.WipOutAcctUnit3)
                .HasMaxLength(4)
                .HasColumnName("wip_out_acct_unit3");
            entity.Property(e => e.WipOutAcctUnit4)
                .HasMaxLength(4)
                .HasColumnName("wip_out_acct_unit4");
            entity.Property(e => e.WipRelFov)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("wip_rel_fov");
            entity.Property(e => e.WipRelLbr)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("wip_rel_lbr");
            entity.Property(e => e.WipRelMatl)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("wip_rel_matl");
            entity.Property(e => e.WipRelOut)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("wip_rel_out");
            entity.Property(e => e.WipRelVov)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("wip_rel_vov");
            entity.Property(e => e.WipVov)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("wip_vov");
            entity.Property(e => e.WipVovAcct)
                .HasMaxLength(12)
                .HasColumnName("wip_vov_acct");
            entity.Property(e => e.WipVovAcctUnit1)
                .HasMaxLength(4)
                .HasColumnName("wip_vov_acct_unit1");
            entity.Property(e => e.WipVovAcctUnit2)
                .HasMaxLength(4)
                .HasColumnName("wip_vov_acct_unit2");
            entity.Property(e => e.WipVovAcctUnit3)
                .HasMaxLength(4)
                .HasColumnName("wip_vov_acct_unit3");
            entity.Property(e => e.WipVovAcctUnit4)
                .HasMaxLength(4)
                .HasColumnName("wip_vov_acct_unit4");
        });

        modelBuilder.Entity<FsSroOper>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("fs_sro_oper");

            entity.Property(e => e.AccumWip).HasColumnName("accum_wip");
            entity.Property(e => e.AwaitingParts).HasColumnName("awaiting_parts");
            entity.Property(e => e.BillCode)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("bill_code");
            entity.Property(e => e.BillHold).HasColumnName("bill_hold");
            entity.Property(e => e.BillStat)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("bill_stat");
            entity.Property(e => e.BillType)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("bill_type");
            entity.Property(e => e.CgsRevLocLabor)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("cgs_rev_loc_labor");
            entity.Property(e => e.CgsRevLocMatl)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("cgs_rev_loc_matl");
            entity.Property(e => e.CgsRevLocMisc)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("cgs_rev_loc_misc");
            entity.Property(e => e.Charfld1)
                .HasMaxLength(20)
                .HasColumnName("charfld1");
            entity.Property(e => e.Charfld2)
                .HasMaxLength(20)
                .HasColumnName("charfld2");
            entity.Property(e => e.Charfld3)
                .HasMaxLength(20)
                .HasColumnName("charfld3");
            entity.Property(e => e.CloseDate)
                .HasColumnType("datetime")
                .HasColumnName("close_date");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.CustNum)
                .HasMaxLength(7)
                .HasColumnName("cust_num");
            entity.Property(e => e.Datefld)
                .HasColumnType("datetime")
                .HasColumnName("datefld");
            entity.Property(e => e.Decifld1)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld1");
            entity.Property(e => e.Decifld2)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld2");
            entity.Property(e => e.Decifld3)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld3");
            entity.Property(e => e.Dept)
                .HasMaxLength(6)
                .HasColumnName("dept");
            entity.Property(e => e.Description)
                .HasMaxLength(40)
                .HasColumnName("description");
            entity.Property(e => e.Duration)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("duration");
            entity.Property(e => e.DurationUnits)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("duration_units");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("end_date");
            entity.Property(e => e.EstSalesTax1)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("est_sales_tax1");
            entity.Property(e => e.EstSalesTax2)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("est_sales_tax2");
            entity.Property(e => e.EstimatedTimeRemaining)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("estimated_time_remaining");
            entity.Property(e => e.EstimatedTimeRemainingUnits)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("estimated_time_remaining_units");
            entity.Property(e => e.ExtendLbrTrans).HasColumnName("extend_lbr_trans");
            entity.Property(e => e.ExtendMatlTrans).HasColumnName("extend_matl_trans");
            entity.Property(e => e.ExtendMiscTrans).HasColumnName("extend_misc_trans");
            entity.Property(e => e.Inspector)
                .HasMaxLength(10)
                .HasColumnName("inspector");
            entity.Property(e => e.InvProcessed).HasColumnName("inv_processed");
            entity.Property(e => e.Logifld).HasColumnName("logifld");
            entity.Property(e => e.Obal)
                .HasColumnType("decimal(23, 8)")
                .HasColumnName("obal");
            entity.Property(e => e.OpenDate)
                .HasColumnType("datetime")
                .HasColumnName("open_date");
            entity.Property(e => e.OperCode)
                .HasMaxLength(8)
                .HasColumnName("oper_code");
            entity.Property(e => e.PartnerId)
                .HasMaxLength(10)
                .HasColumnName("partner_id");
            entity.Property(e => e.PlanReq).HasColumnName("plan_req");
            entity.Property(e => e.Pricecode)
                .HasMaxLength(3)
                .HasColumnName("pricecode");
            entity.Property(e => e.ProductCode)
                .HasMaxLength(10)
                .HasColumnName("product_code");
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.SignOff)
                .HasMaxLength(10)
                .HasColumnName("sign_off");
            entity.Property(e => e.SignOffDate)
                .HasColumnType("datetime")
                .HasColumnName("sign_off_date");
            entity.Property(e => e.SroLine).HasColumnName("sro_line");
            entity.Property(e => e.SroNum)
                .HasMaxLength(10)
                .HasColumnName("sro_num");
            entity.Property(e => e.SroOper).HasColumnName("sro_oper");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("start_date");
            entity.Property(e => e.Stat)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("stat");
            entity.Property(e => e.TaxCode1)
                .HasMaxLength(6)
                .HasColumnName("tax_code1");
            entity.Property(e => e.TaxCode2)
                .HasMaxLength(6)
                .HasColumnName("tax_code2");
            entity.Property(e => e.ToSchedule).HasColumnName("to_schedule");
            entity.Property(e => e.TotalBilled)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("total_billed");
            entity.Property(e => e.TotalCostLbr)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("total_cost_lbr");
            entity.Property(e => e.TotalCostMatl)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("total_cost_matl");
            entity.Property(e => e.TotalCostMisc)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("total_cost_misc");
            entity.Property(e => e.TotalPrice)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("total_price");
            entity.Property(e => e.TotalSalesTax1)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("total_sales_tax1");
            entity.Property(e => e.TotalSalesTax2)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("total_sales_tax2");
            entity.Property(e => e.UpdatedBy).HasMaxLength(30);
            entity.Property(e => e.UseEst).HasColumnName("use_est");
            entity.Property(e => e.Wc)
                .HasMaxLength(6)
                .HasColumnName("wc");
            entity.Property(e => e.Whse)
                .HasMaxLength(4)
                .HasColumnName("whse");
        });

        modelBuilder.Entity<FsSroStat>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("fs_sro_stat");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.GpsLocDate)
                .HasColumnType("datetime")
                .HasColumnName("gps_loc_date");
            entity.Property(e => e.GpsOnline).HasColumnName("gps_online");
            entity.Property(e => e.Latitude).HasColumnType("decimal(21, 10)");
            entity.Property(e => e.Longitude).HasColumnType("decimal(21, 10)");
            entity.Property(e => e.PartnerId)
                .HasMaxLength(10)
                .HasColumnName("partner_id");
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.Seq).HasColumnName("seq");
            entity.Property(e => e.SroNum)
                .HasMaxLength(10)
                .HasColumnName("sro_num");
            entity.Property(e => e.StatCode)
                .HasMaxLength(10)
                .HasColumnName("stat_code");
            entity.Property(e => e.StatDate)
                .HasColumnType("datetime")
                .HasColumnName("stat_date");
            entity.Property(e => e.UpdatedBy).HasMaxLength(30);
        });

        modelBuilder.Entity<FsSroType>(entity =>
        {
            entity.HasKey(e => e.RowPointer).HasName("PK__FS_SRO_T__219964B12D5BB02A");

            entity.ToTable("FS_SRO_Type");

            entity.Property(e => e.RowPointer)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ROW_POINTER");
            entity.Property(e => e.AccumWip).HasColumnName("ACCUM_WIP");
            entity.Property(e => e.BillCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("BILL_CODE");
            entity.Property(e => e.BillType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("BILL_TYPE");
            entity.Property(e => e.CgsRevLocLabor)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CGS_REV_LOC_LABOR");
            entity.Property(e => e.CgsRevLocMatl)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CGS_REV_LOC_MATL");
            entity.Property(e => e.CgsRevLocMisc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CGS_REV_LOC_MISC");
            entity.Property(e => e.Charfld1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CHARFLD1");
            entity.Property(e => e.Charfld2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CHARFLD2");
            entity.Property(e => e.Charfld3)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CHARFLD3");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.Datefld)
                .HasColumnType("datetime")
                .HasColumnName("DATEFLD");
            entity.Property(e => e.Decifld1).HasColumnName("DECIFLD1");
            entity.Property(e => e.Decifld2).HasColumnName("DECIFLD2");
            entity.Property(e => e.Decifld3).HasColumnName("DECIFLD3");
            entity.Property(e => e.Description)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Disc).HasColumnName("DISC");
            entity.Property(e => e.ExchangeDays).HasColumnName("EXCHANGE_DAYS");
            entity.Property(e => e.InWorkflow).HasColumnName("IN_WORKFLOW");
            entity.Property(e => e.InclDemand).HasColumnName("INCL_DEMAND");
            entity.Property(e => e.LeadTime).HasColumnName("LEAD_TIME");
            entity.Property(e => e.LeadType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LEAD_TYPE");
            entity.Property(e => e.Logifld).HasColumnName("LOGIFLD");
            entity.Property(e => e.NoteExistsFlag).HasColumnName("NOTE_EXISTS_FLAG");
            entity.Property(e => e.ProductCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PRODUCT_CODE");
            entity.Property(e => e.RecordDate)
                .HasColumnType("datetime")
                .HasColumnName("RECORD_DATE");
            entity.Property(e => e.SroType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SRO_TYPE");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("UPDATED_BY");
            entity.Property(e => e.Whse)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("WHSE");
        });

        modelBuilder.Entity<FsStatCode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("fs_stat_code");

            entity.Property(e => e.Charfld1)
                .HasMaxLength(20)
                .HasColumnName("charfld1");
            entity.Property(e => e.Charfld2)
                .HasMaxLength(20)
                .HasColumnName("charfld2");
            entity.Property(e => e.Charfld3)
                .HasMaxLength(20)
                .HasColumnName("charfld3");
            entity.Property(e => e.Closed).HasColumnName("closed");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.Datefld)
                .HasColumnType("datetime")
                .HasColumnName("datefld");
            entity.Property(e => e.Decifld1)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld1");
            entity.Property(e => e.Decifld2)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld2");
            entity.Property(e => e.Decifld3)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld3");
            entity.Property(e => e.Description)
                .HasMaxLength(40)
                .HasColumnName("description");
            entity.Property(e => e.IgnoreAlert).HasColumnName("ignore_alert");
            entity.Property(e => e.Logifld).HasColumnName("logifld");
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.StatCode)
                .HasMaxLength(10)
                .HasColumnName("stat_code");
            entity.Property(e => e.UpdatedBy).HasMaxLength(30);
        });

        modelBuilder.Entity<FsUnit>(entity =>
        {
            entity.HasKey(e => e.RowPointer);
            entity.ToTable("fs_unit");

            entity.Property(e => e.AvailForRent).HasColumnName("avail_for_rent");
            entity.Property(e => e.AvailForService).HasColumnName("avail_for_service");
            entity.Property(e => e.Charfld1)
                .HasMaxLength(20)
                .HasColumnName("charfld1");
            entity.Property(e => e.Charfld2)
                .HasMaxLength(20)
                .HasColumnName("charfld2");
            entity.Property(e => e.Charfld3)
                .HasMaxLength(20)
                .HasColumnName("charfld3");
            entity.Property(e => e.CoLine).HasColumnName("co_line");
            entity.Property(e => e.CoNum)
                .HasMaxLength(10)
                .HasColumnName("co_num");
            entity.Property(e => e.CoRelease).HasColumnName("co_release");
            entity.Property(e => e.CompId).HasColumnName("comp_id");
            entity.Property(e => e.Contract)
                .HasMaxLength(10)
                .HasColumnName("contract");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.CustItem)
                .HasMaxLength(30)
                .HasColumnName("cust_item");
            entity.Property(e => e.CustNum)
                .HasMaxLength(7)
                .HasColumnName("cust_num");
            entity.Property(e => e.CustSeq).HasColumnName("cust_seq");
            entity.Property(e => e.DateSeq).HasColumnName("date_seq");
            entity.Property(e => e.Datefld)
                .HasColumnType("datetime")
                .HasColumnName("datefld");
            entity.Property(e => e.Decifld1)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld1");
            entity.Property(e => e.Decifld2)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld2");
            entity.Property(e => e.Decifld3)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld3");
            entity.Property(e => e.Description)
                .HasMaxLength(40)
                .HasColumnName("description");
            entity.Property(e => e.FaNum)
                .HasMaxLength(12)
                .HasColumnName("fa_num");
            entity.Property(e => e.HoldFlag).HasColumnName("hold_flag");
            entity.Property(e => e.HoldReason)
                .HasMaxLength(40)
                .HasColumnName("hold_reason");
            entity.Property(e => e.InstallDate)
                .HasColumnType("datetime")
                .HasColumnName("install_date");
            entity.Property(e => e.Item)
                .HasMaxLength(30)
                .HasColumnName("item");
            entity.Property(e => e.LastCalibDate)
                .HasColumnType("datetime")
                .HasColumnName("last_calib_date");
            entity.Property(e => e.LastInsDate)
                .HasColumnType("datetime")
                .HasColumnName("last_ins_date");
            entity.Property(e => e.LastMeterAmt).HasColumnName("last_meter_amt");
            entity.Property(e => e.LastMeterDate)
                .HasColumnType("datetime")
                .HasColumnName("last_meter_date");
            entity.Property(e => e.LastPmDate)
                .HasColumnType("datetime")
                .HasColumnName("last_pm_date");
            entity.Property(e => e.ListPrice)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("list_price");
            entity.Property(e => e.Location)
                .HasMaxLength(15)
                .HasColumnName("location");
            entity.Property(e => e.Logifld).HasColumnName("logifld");
            entity.Property(e => e.Mfg)
                .HasMaxLength(25)
                .HasColumnName("mfg");
            entity.Property(e => e.MfgNum)
                .HasMaxLength(25)
                .HasColumnName("mfg_num");
            entity.Property(e => e.NextCalibDate)
                .HasColumnType("datetime")
                .HasColumnName("next_calib_date");
            entity.Property(e => e.NextInsDate)
                .HasColumnType("datetime")
                .HasColumnName("next_ins_date");
            entity.Property(e => e.NextPmDate)
                .HasColumnType("datetime")
                .HasColumnName("next_pm_date");
            entity.Property(e => e.PriorCode)
                .HasMaxLength(10)
                .HasColumnName("prior_code");
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.Region)
                .HasMaxLength(10)
                .HasColumnName("region");
            entity.Property(e => e.Resid)
                .HasMaxLength(30)
                .HasColumnName("RESID");
            entity.Property(e => e.SaleAmount)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("sale_amount");
            entity.Property(e => e.SerNum)
                .HasMaxLength(30)
                .HasColumnName("ser_num");
            entity.Property(e => e.ShipDate)
                .HasColumnType("datetime")
                .HasColumnName("ship_date");
            entity.Property(e => e.Site)
                .HasMaxLength(8)
                .HasColumnName("site");
            entity.Property(e => e.SrvDealer)
                .HasMaxLength(10)
                .HasColumnName("srv_dealer");
            entity.Property(e => e.UfFsUnitOptout).HasColumnName("Uf_fs_unit_optout");
            entity.Property(e => e.UfFsUnitOptoutDate)
                .HasColumnType("datetime")
                .HasColumnName("Uf_fs_unit_optout_date");
            entity.Property(e => e.UfSegAdapterSerial).HasColumnName("UF_SEG_Adapter_Serial");
            entity.Property(e => e.UfSegFixtureAdd).HasColumnName("Uf_SEG_Fixture_Add");
            entity.Property(e => e.UfSegOraCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("UF_SEG_Ora_Create_Date");
            entity.Property(e => e.UfSegRegBatteryFront)
                .HasMaxLength(20)
                .HasColumnName("Uf_SEG_Reg_Battery_Front");
            entity.Property(e => e.UfSegRegBatteryRear)
                .HasMaxLength(20)
                .HasColumnName("Uf_SEG_Reg_Battery_Rear");
            entity.Property(e => e.UfSegRegComment)
                .HasMaxLength(4000)
                .HasColumnName("UF_SEG_Reg_Comment");
            entity.Property(e => e.UfSegRegConsumer)
                .HasMaxLength(7)
                .HasColumnName("Uf_SEG_Reg_Consumer");
            entity.Property(e => e.UfSegRegConsumerAdd).HasColumnName("Uf_SEG_Reg_Consumer_Add");
            entity.Property(e => e.UfSegRegDate)
                .HasColumnType("datetime")
                .HasColumnName("Uf_SEG_Reg_Date");
            entity.Property(e => e.UfSegRegDealer)
                .HasMaxLength(7)
                .HasColumnName("Uf_SEG_Reg_Dealer");
            entity.Property(e => e.UfSegRegDealerAdd).HasColumnName("Uf_SEG_Reg_Dealer_Add");
            entity.Property(e => e.UfSegRegSaleDate)
                .HasColumnType("datetime")
                .HasColumnName("Uf_SEG_Reg_Sale_Date");
            entity.Property(e => e.UfSegRegUser)
                .HasMaxLength(50)
                .HasColumnName("Uf_SEG_Reg_User");
            entity.Property(e => e.UfSegShipDate)
                .HasColumnType("datetime")
                .HasColumnName("Uf_SEG_Ship_Date");
            entity.Property(e => e.UnitStat)
                .HasMaxLength(40)
                .HasColumnName("unit_stat");
            entity.Property(e => e.UnitStatCode)
                .HasMaxLength(10)
                .HasColumnName("unit_stat_code");
            entity.Property(e => e.UpdatedBy).HasMaxLength(30);
            entity.Property(e => e.UsrNum)
                .HasMaxLength(7)
                .HasColumnName("usr_num");
            entity.Property(e => e.UsrSeq).HasColumnName("usr_seq");
            entity.Property(e => e.Wc)
                .HasMaxLength(6)
                .HasColumnName("wc");
            entity.Property(e => e.Whse)
                .HasMaxLength(4)
                .HasColumnName("whse");
        });

        modelBuilder.Entity<FsUnitStatCode>(entity =>
        {
            entity.HasKey(e => e.Rowpointer).HasName("PK__FS_Unit___8B3A16167DCE41EE");

            entity.ToTable("FS_Unit_Stat_Code");

            entity.Property(e => e.Rowpointer)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ROWPOINTER");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Createdby)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CREATEDBY");
            entity.Property(e => e.Description)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Down).HasColumnName("DOWN");
            entity.Property(e => e.Inworkflow).HasColumnName("INWORKFLOW");
            entity.Property(e => e.Noteexistsflag).HasColumnName("NOTEEXISTSFLAG");
            entity.Property(e => e.Recorddate)
                .HasColumnType("datetime")
                .HasColumnName("RECORDDATE");
            entity.Property(e => e.UnitStatCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UNIT_STAT_CODE");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("UPDATEDBY");
        });

        modelBuilder.Entity<FsUnitWarr>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("fs_unit_warr");

            entity.Property(e => e.Charfld1)
                .HasMaxLength(20)
                .HasColumnName("charfld1");
            entity.Property(e => e.Charfld2)
                .HasMaxLength(20)
                .HasColumnName("charfld2");
            entity.Property(e => e.Charfld3)
                .HasMaxLength(20)
                .HasColumnName("charfld3");
            entity.Property(e => e.CompId).HasColumnName("comp_id");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.Datefld)
                .HasColumnType("datetime")
                .HasColumnName("datefld");
            entity.Property(e => e.Decifld1)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld1");
            entity.Property(e => e.Decifld2)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld2");
            entity.Property(e => e.Decifld3)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld3");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("end_date");
            entity.Property(e => e.EndMeterAmt).HasColumnName("end_meter_amt");
            entity.Property(e => e.Logifld).HasColumnName("logifld");
            entity.Property(e => e.OrigCompId).HasColumnName("orig_comp_id");
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("start_date");
            entity.Property(e => e.StartMeterAmt).HasColumnName("start_meter_amt");
            entity.Property(e => e.UpdatedBy).HasMaxLength(30);
            entity.Property(e => e.WarrCode)
                .HasMaxLength(8)
                .HasColumnName("warr_code");
            entity.Property(e => e.WarrLaborPct)
                .HasColumnType("decimal(4, 1)")
                .HasColumnName("warr_labor_pct");
            entity.Property(e => e.WarrMatlPct)
                .HasColumnType("decimal(4, 1)")
                .HasColumnName("warr_matl_pct");
        });

        modelBuilder.Entity<FsWarrCode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("fs_warr_code");

            entity.Property(e => e.Charfld1)
                .HasMaxLength(20)
                .HasColumnName("charfld1");
            entity.Property(e => e.Charfld2)
                .HasMaxLength(20)
                .HasColumnName("charfld2");
            entity.Property(e => e.Charfld3)
                .HasMaxLength(20)
                .HasColumnName("charfld3");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.Datefld)
                .HasColumnType("datetime")
                .HasColumnName("datefld");
            entity.Property(e => e.Decifld1)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld1");
            entity.Property(e => e.Decifld2)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld2");
            entity.Property(e => e.Decifld3)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld3");
            entity.Property(e => e.Description)
                .HasMaxLength(40)
                .HasColumnName("description");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.Duration2).HasColumnName("duration2");
            entity.Property(e => e.DurationType)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("duration_type");
            entity.Property(e => e.DurationType2)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("duration_type2");
            entity.Property(e => e.Logifld).HasColumnName("logifld");
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(30);
            entity.Property(e => e.WarrCode)
                .HasMaxLength(8)
                .HasColumnName("warr_code");
            entity.Property(e => e.WarrLaborPct)
                .HasColumnType("decimal(4, 1)")
                .HasColumnName("warr_labor_pct");
            entity.Property(e => e.WarrMatlPct)
                .HasColumnType("decimal(4, 1)")
                .HasColumnName("warr_matl_pct");
            entity.Property(e => e.WarrType)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("warr_type");
        });

        modelBuilder.Entity<Item>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("item");

            entity.Property(e => e.AbcCode)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("abc_code");
            entity.Property(e => e.AcceptReq).HasColumnName("accept_req");
            entity.Property(e => e.ActiveForCustomerPortal).HasColumnName("active_for_customer_portal");
            entity.Property(e => e.ActiveForDataIntegration).HasColumnName("active_for_data_integration");
            entity.Property(e => e.AltItem)
                .HasMaxLength(30)
                .HasColumnName("alt_item");
            entity.Property(e => e.AsmFixed)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("asm_fixed");
            entity.Property(e => e.AsmFixture)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("asm_fixture");
            entity.Property(e => e.AsmMatl)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("asm_matl");
            entity.Property(e => e.AsmOther)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("asm_other");
            entity.Property(e => e.AsmOutside)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("asm_outside");
            entity.Property(e => e.AsmRun)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("asm_run");
            entity.Property(e => e.AsmSetup)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("asm_setup");
            entity.Property(e => e.AsmTool)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("asm_tool");
            entity.Property(e => e.AsmVar)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("asm_var");
            entity.Property(e => e.AttrGroup)
                .HasMaxLength(10)
                .HasColumnName("attr_group");
            entity.Property(e => e.AutoJob)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("auto_job");
            entity.Property(e => e.AutoPost)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("auto_post");
            entity.Property(e => e.AvgFovhdCost)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("avg_fovhd_cost");
            entity.Property(e => e.AvgLbrCost)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("avg_lbr_cost");
            entity.Property(e => e.AvgMatlCost)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("avg_matl_cost");
            entity.Property(e => e.AvgOutCost)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("avg_out_cost");
            entity.Property(e => e.AvgUCost)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("avg_u_cost");
            entity.Property(e => e.AvgVovhdCost)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("avg_vovhd_cost");
            entity.Property(e => e.Backflush).HasColumnName("backflush");
            entity.Property(e => e.BatchReleaseAttribute1).HasColumnName("batch_release_attribute1");
            entity.Property(e => e.BatchReleaseAttribute2).HasColumnName("batch_release_attribute2");
            entity.Property(e => e.BatchReleaseAttribute3).HasColumnName("batch_release_attribute3");
            entity.Property(e => e.BflushLoc)
                .HasMaxLength(15)
                .HasColumnName("bflush_loc");
            entity.Property(e => e.BomLastImportDate)
                .HasColumnType("datetime")
                .HasColumnName("bom_last_import_date");
            entity.Property(e => e.Buyer)
                .HasMaxLength(60)
                .HasColumnName("buyer");
            entity.Property(e => e.CfgModel)
                .HasMaxLength(255)
                .HasColumnName("cfg_model");
            entity.Property(e => e.ChangeDate)
                .HasColumnType("datetime")
                .HasColumnName("change_date");
            entity.Property(e => e.Charfld1)
                .HasMaxLength(20)
                .HasColumnName("charfld1");
            entity.Property(e => e.Charfld2)
                .HasMaxLength(20)
                .HasColumnName("charfld2");
            entity.Property(e => e.Charfld3)
                .HasMaxLength(20)
                .HasColumnName("charfld3");
            entity.Property(e => e.Charfld4)
                .HasMaxLength(20)
                .HasColumnName("charfld4");
            entity.Property(e => e.ChgDate)
                .HasColumnType("datetime")
                .HasColumnName("chg_date");
            entity.Property(e => e.CoPostConfig)
                .HasMaxLength(80)
                .HasColumnName("co_post_config");
            entity.Property(e => e.CommCode)
                .HasMaxLength(12)
                .HasColumnName("comm_code");
            entity.Property(e => e.CompFixed)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("comp_fixed");
            entity.Property(e => e.CompFixture)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("comp_fixture");
            entity.Property(e => e.CompMatl)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("comp_matl");
            entity.Property(e => e.CompOther)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("comp_other");
            entity.Property(e => e.CompOutside)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("comp_outside");
            entity.Property(e => e.CompRun)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("comp_run");
            entity.Property(e => e.CompSetup)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("comp_setup");
            entity.Property(e => e.CompTool)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("comp_tool");
            entity.Property(e => e.CompVar)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("comp_var");
            entity.Property(e => e.ControlledByExternalIcs).HasColumnName("controlled_by_external_ics");
            entity.Property(e => e.CostMethod)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("cost_method");
            entity.Property(e => e.CostType)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("cost_type");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.CurBrokerageCost)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("cur_brokerage_cost");
            entity.Property(e => e.CurDutyCost)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("cur_duty_cost");
            entity.Property(e => e.CurFovhdCost)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("cur_fovhd_cost");
            entity.Property(e => e.CurFreightCost)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("cur_freight_cost");
            entity.Property(e => e.CurInsuranceCost)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("cur_insurance_cost");
            entity.Property(e => e.CurLbrCost)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("cur_lbr_cost");
            entity.Property(e => e.CurLocFrtCost)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("cur_loc_frt_cost");
            entity.Property(e => e.CurMatCost)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("cur_mat_cost");
            entity.Property(e => e.CurMatlCost)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("cur_matl_cost");
            entity.Property(e => e.CurOutCost)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("cur_out_cost");
            entity.Property(e => e.CurUCost)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("cur_u_cost");
            entity.Property(e => e.CurVovhdCost)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("cur_vovhd_cost");
            entity.Property(e => e.Datefld)
                .HasColumnType("datetime")
                .HasColumnName("datefld");
            entity.Property(e => e.DaysSupply).HasColumnName("days_supply");
            entity.Property(e => e.Decifld1)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld1");
            entity.Property(e => e.Decifld2)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld2");
            entity.Property(e => e.Decifld3)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld3");
            entity.Property(e => e.Description)
                .HasMaxLength(40)
                .HasColumnName("description");
            entity.Property(e => e.DimensionGroup)
                .HasMaxLength(10)
                .HasColumnName("dimension_group");
            entity.Property(e => e.DockTime).HasColumnName("dock_time");
            entity.Property(e => e.DrawingNbr)
                .HasMaxLength(25)
                .HasColumnName("drawing_nbr");
            entity.Property(e => e.DuePeriod).HasColumnName("due_period");
            entity.Property(e => e.EarliestPlannedPoReceipt)
                .HasColumnType("datetime")
                .HasColumnName("earliest_planned_po_receipt");
            entity.Property(e => e.ExciseTaxPercent)
                .HasColumnType("decimal(4, 2)")
                .HasColumnName("excise_tax_percent");
            entity.Property(e => e.ExpLeadTime).HasColumnName("exp_lead_time");
            entity.Property(e => e.FamilyCode)
                .HasMaxLength(10)
                .HasColumnName("family_code");
            entity.Property(e => e.FeatStr)
                .HasMaxLength(40)
                .HasColumnName("feat_str");
            entity.Property(e => e.FeatTempl)
                .HasMaxLength(55)
                .HasColumnName("feat_templ");
            entity.Property(e => e.FeatType)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("feat_type");
            entity.Property(e => e.Featured).HasColumnName("featured");
            entity.Property(e => e.FixedOrderQty)
                .HasColumnType("decimal(19, 8)")
                .HasColumnName("fixed_order_qty");
            entity.Property(e => e.FovhdCost)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("fovhd_cost");
            entity.Property(e => e.IncludeInNetChangePlanning).HasColumnName("include_in_net_change_planning");
            entity.Property(e => e.InfinitePart).HasColumnName("infinite_part");
            entity.Property(e => e.InventoryLclTolerance)
                .HasColumnType("decimal(7, 4)")
                .HasColumnName("inventory_lcl_tolerance");
            entity.Property(e => e.InventoryUclTolerance)
                .HasColumnType("decimal(7, 4)")
                .HasColumnName("inventory_ucl_tolerance");
            entity.Property(e => e.IssueBy)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("issue_by");
            entity.Property(e => e.Item1)
                .HasMaxLength(30)
                .HasColumnName("item");
            entity.Property(e => e.Job)
                .HasMaxLength(20)
                .HasColumnName("job");
            entity.Property(e => e.JobConfigurable).HasColumnName("job_configurable");
            entity.Property(e => e.JobPostConfig)
                .HasMaxLength(80)
                .HasColumnName("job_post_config");
            entity.Property(e => e.Kit).HasColumnName("kit");
            entity.Property(e => e.LastInv)
                .HasColumnType("datetime")
                .HasColumnName("last_inv");
            entity.Property(e => e.LbrCost)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("lbr_cost");
            entity.Property(e => e.LeadTime).HasColumnName("lead_time");
            entity.Property(e => e.Logifld).HasColumnName("logifld");
            entity.Property(e => e.LotAttrGroup)
                .HasMaxLength(10)
                .HasColumnName("lot_attr_group");
            entity.Property(e => e.LotGenExp).HasColumnName("lot_gen_exp");
            entity.Property(e => e.LotPrefix)
                .HasMaxLength(15)
                .HasColumnName("lot_prefix");
            entity.Property(e => e.LotSize)
                .HasColumnType("decimal(18, 8)")
                .HasColumnName("lot_size");
            entity.Property(e => e.LotTracked).HasColumnName("lot_tracked");
            entity.Property(e => e.LowLevel).HasColumnName("low_level");
            entity.Property(e => e.Lowdate)
                .HasColumnType("datetime")
                .HasColumnName("lowdate");
            entity.Property(e => e.LstLotSize)
                .HasColumnType("decimal(9, 3)")
                .HasColumnName("lst_lot_size");
            entity.Property(e => e.LstUCost)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("lst_u_cost");
            entity.Property(e => e.MatlCost)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("matl_cost");
            entity.Property(e => e.MatlType)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("matl_type");
            entity.Property(e => e.MfgSupplySwitchingActive).HasColumnName("mfg_supply_switching_active");
            entity.Property(e => e.MpsFlag).HasColumnName("mps_flag");
            entity.Property(e => e.MpsPlanFence).HasColumnName("mps_plan_fence");
            entity.Property(e => e.MrpPart).HasColumnName("mrp_part");
            entity.Property(e => e.NextConfig).HasColumnName("next_config");
            entity.Property(e => e.OrderConfigurable).HasColumnName("order_configurable");
            entity.Property(e => e.OrderMax)
                .HasColumnType("decimal(19, 8)")
                .HasColumnName("order_max");
            entity.Property(e => e.OrderMin)
                .HasColumnType("decimal(19, 8)")
                .HasColumnName("order_min");
            entity.Property(e => e.OrderMult)
                .HasColumnType("decimal(19, 8)")
                .HasColumnName("order_mult");
            entity.Property(e => e.Origin)
                .HasMaxLength(2)
                .HasColumnName("origin");
            entity.Property(e => e.OutCost)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("out_cost");
            entity.Property(e => e.Overview).HasColumnName("overview");
            entity.Property(e => e.PMTCode)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("p_m_t_code");
            entity.Property(e => e.PaperTime).HasColumnName("paper_time");
            entity.Property(e => e.PassReq).HasColumnName("pass_req");
            entity.Property(e => e.PhantomFlag).HasColumnName("phantom_flag");
            entity.Property(e => e.Picture).HasColumnName("picture");
            entity.Property(e => e.PlanCode)
                .HasMaxLength(3)
                .HasColumnName("plan_code");
            entity.Property(e => e.PlanFlag).HasColumnName("plan_flag");
            entity.Property(e => e.PreassignLots).HasColumnName("preassign_lots");
            entity.Property(e => e.PreassignSerials).HasColumnName("preassign_serials");
            entity.Property(e => e.PrintKitComponents).HasColumnName("print_kit_components");
            entity.Property(e => e.ProdMix)
                .HasMaxLength(7)
                .HasColumnName("prod_mix");
            entity.Property(e => e.ProdType)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("prod_type");
            entity.Property(e => e.ProductCode)
                .HasMaxLength(10)
                .HasColumnName("product_code");
            entity.Property(e => e.QtyAllocjob)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("qty_allocjob");
            entity.Property(e => e.QtyMfgYtd)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("qty_mfg_ytd");
            entity.Property(e => e.QtyUsedYtd)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("qty_used_ytd");
            entity.Property(e => e.RatePerDay)
                .HasColumnType("decimal(10, 3)")
                .HasColumnName("rate_per_day");
            entity.Property(e => e.RcptRqmt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("rcpt_rqmt");
            entity.Property(e => e.RcvdOverPoQtyTolerance)
                .HasColumnType("decimal(7, 4)")
                .HasColumnName("rcvd_over_po_qty_tolerance");
            entity.Property(e => e.RcvdUnderPoQtyTolerance)
                .HasColumnType("decimal(7, 4)")
                .HasColumnName("rcvd_under_po_qty_tolerance");
            entity.Property(e => e.ReasonCode)
                .HasMaxLength(3)
                .HasColumnName("reason_code");
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.ReorderPoint)
                .HasColumnType("decimal(19, 8)")
                .HasColumnName("reorder_point");
            entity.Property(e => e.Reservable).HasColumnName("reservable");
            entity.Property(e => e.Revision)
                .HasMaxLength(8)
                .HasColumnName("revision");
            entity.Property(e => e.SafetyStockPercent)
                .HasColumnType("decimal(3, 1)")
                .HasColumnName("safety_stock_percent");
            entity.Property(e => e.SafetyStockRule).HasColumnName("safety_stock_rule");
            entity.Property(e => e.SaveCurrentRevUponBomImport).HasColumnName("save_current_rev_upon_bom_import");
            entity.Property(e => e.SegEstHours)
                .HasColumnType("decimal(10, 5)")
                .HasColumnName("_SEG_Est_Hours");
            entity.Property(e => e.SegEstIndirect)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("_SEG_Est_Indirect");
            entity.Property(e => e.SegEstLabor)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("_SEG_Est_Labor");
            entity.Property(e => e.SegEstOverhead)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("_SEG_Est_Overhead");
            entity.Property(e => e.SegOraCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("_SEG_Ora_CreateDate");
            entity.Property(e => e.SeparationAttribute)
                .HasMaxLength(30)
                .HasColumnName("separation_attribute");
            entity.Property(e => e.SerialLength).HasColumnName("serial_length");
            entity.Property(e => e.SerialPrefix)
                .HasMaxLength(30)
                .HasColumnName("serial_prefix");
            entity.Property(e => e.SerialTracked).HasColumnName("serial_tracked");
            entity.Property(e => e.Setupgroup)
                .HasMaxLength(10)
                .HasColumnName("setupgroup");
            entity.Property(e => e.ShelfLife).HasColumnName("shelf_life");
            entity.Property(e => e.ShowInDropDownList).HasColumnName("show_in_drop_down_list");
            entity.Property(e => e.ShrinkFact)
                .HasColumnType("decimal(5, 4)")
                .HasColumnName("shrink_fact");
            entity.Property(e => e.Stat)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("stat");
            entity.Property(e => e.StatusChgUserCode)
                .HasMaxLength(3)
                .HasColumnName("status_chg_user_code");
            entity.Property(e => e.Stocked).HasColumnName("stocked");
            entity.Property(e => e.SubMatl)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("sub_matl");
            entity.Property(e => e.SubjectToExciseTax).HasColumnName("subject_to_excise_tax");
            entity.Property(e => e.Suffix).HasColumnName("suffix");
            entity.Property(e => e.SupplySite)
                .HasMaxLength(8)
                .HasColumnName("supply_site");
            entity.Property(e => e.SupplyToleranceHrs)
                .HasColumnType("decimal(4, 1)")
                .HasColumnName("supply_tolerance_hrs");
            entity.Property(e => e.SupplyWhse)
                .HasMaxLength(4)
                .HasColumnName("supply_whse");
            entity.Property(e => e.TariffClassification)
                .HasMaxLength(20)
                .HasColumnName("tariff_classification");
            entity.Property(e => e.TaxCode1)
                .HasMaxLength(6)
                .HasColumnName("tax_code1");
            entity.Property(e => e.TaxCode2)
                .HasMaxLength(6)
                .HasColumnName("tax_code2");
            entity.Property(e => e.TaxFreeDays).HasColumnName("tax_free_days");
            entity.Property(e => e.TaxFreeMatl).HasColumnName("tax_free_matl");
            entity.Property(e => e.TimeFenceRule).HasColumnName("time_fence_rule");
            entity.Property(e => e.TimeFenceValue).HasColumnName("time_fence_value");
            entity.Property(e => e.TopSeller).HasColumnName("top_seller");
            entity.Property(e => e.TrackEcn).HasColumnName("track_ecn");
            entity.Property(e => e.TrackPieces).HasColumnName("track_pieces");
            entity.Property(e => e.UM)
                .HasMaxLength(3)
                .HasColumnName("u_m");
            entity.Property(e => e.UWsPrice)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("u_ws_price");
            entity.Property(e => e.UfItemClassGroup)
                .HasMaxLength(40)
                .HasColumnName("Uf_ItemClassGroup");
            entity.Property(e => e.UfItemUnitType)
                .HasMaxLength(40)
                .HasColumnName("Uf_ItemUnitType");
            entity.Property(e => e.UfLrmAssemblyType)
                .HasMaxLength(1)
                .HasColumnName("Uf_LRM_AssemblyType");
            entity.Property(e => e.UfLrmIsShipped).HasColumnName("Uf_LRM_IsShipped");
            entity.Property(e => e.UfSegCountryOrigin)
                .HasMaxLength(30)
                .HasColumnName("Uf_SEG_CountryOrigin");
            entity.Property(e => e.UfSegItemHeight)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("Uf_SEG_ItemHeight");
            entity.Property(e => e.UfSegItemLength)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("Uf_SEG_ItemLength");
            entity.Property(e => e.UfSegItemNoStdCost).HasColumnName("Uf_SEG_Item_NoStdCost");
            entity.Property(e => e.UfSegItemObsolete).HasColumnName("Uf_SEG_Item_Obsolete");
            entity.Property(e => e.UfSegItemReplacedBy)
                .HasMaxLength(30)
                .HasColumnName("Uf_SEG_Item_ReplacedBy");
            entity.Property(e => e.UfSegItemUpsell).HasColumnName("Uf_SEG_Item_Upsell");
            entity.Property(e => e.UfSegItemWeight)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("Uf_SEG_ItemWeight");
            entity.Property(e => e.UfSegItemWidth)
                .HasColumnType("decimal(9, 2)")
                .HasColumnName("Uf_SEG_ItemWidth");
            entity.Property(e => e.UfSegSupplierOrigin)
                .HasMaxLength(7)
                .HasColumnName("Uf_SEG_SupplierOrigin");
            entity.Property(e => e.UfSegSupplierOriginName)
                .HasMaxLength(60)
                .HasColumnName("Uf_SEG_SupplierOriginName");
            entity.Property(e => e.UnitBrokerageCost)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("unit_brokerage_cost");
            entity.Property(e => e.UnitCost)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("unit_cost");
            entity.Property(e => e.UnitDutyCost)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("unit_duty_cost");
            entity.Property(e => e.UnitFreightCost)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("unit_freight_cost");
            entity.Property(e => e.UnitInsuranceCost)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("unit_insurance_cost");
            entity.Property(e => e.UnitLocFrtCost)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("unit_loc_frt_cost");
            entity.Property(e => e.UnitMatCost)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("unit_mat_cost");
            entity.Property(e => e.UnitWeight)
                .HasColumnType("decimal(11, 5)")
                .HasColumnName("unit_weight");
            entity.Property(e => e.UpdatedBy).HasMaxLength(30);
            entity.Property(e => e.UseReorderPoint).HasColumnName("use_reorder_point");
            entity.Property(e => e.VarExpLead)
                .HasColumnType("decimal(10, 5)")
                .HasColumnName("var_exp_lead");
            entity.Property(e => e.VarLead)
                .HasColumnType("decimal(10, 5)")
                .HasColumnName("var_lead");
            entity.Property(e => e.VovhdCost)
                .HasColumnType("decimal(20, 8)")
                .HasColumnName("vovhd_cost");
            entity.Property(e => e.WeightUnits)
                .HasMaxLength(3)
                .HasColumnName("weight_units");
        });

        modelBuilder.Entity<NoteHeader>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.NoteHeaderToken).HasColumnType("decimal(11, 0)");
            entity.Property(e => e.ObjectName).HasMaxLength(128);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(30);
        });

        modelBuilder.Entity<NoteType>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.NoteDesc).HasMaxLength(36);
            entity.Property(e => e.NoteType1).HasColumnName("NoteType");
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(30);
        });

        modelBuilder.Entity<ObjectNote>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.NoteHeaderToken).HasColumnType("decimal(11, 0)");
            entity.Property(e => e.ObjectNoteToken).HasColumnType("decimal(11, 0)");
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.SpecificNoteToken).HasColumnType("decimal(11, 0)");
            entity.Property(e => e.SystemNoteToken).HasColumnType("decimal(11, 0)");
            entity.Property(e => e.UpdatedBy).HasMaxLength(30);
            entity.Property(e => e.UserNoteToken).HasColumnType("decimal(11, 0)");
        });

        modelBuilder.Entity<ObjectType>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.ObjectCode).HasMaxLength(6);
            entity.Property(e => e.ObjectDesc).HasMaxLength(36);
            entity.Property(e => e.ObjectType1).HasColumnName("ObjectType");
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(30);
        });

        modelBuilder.Entity<Pricecode>(entity =>
        {
            entity.HasKey(e => e.Rowpointer).HasName("PK__Pricecod__8B3A1616A569CDD1");

            entity.ToTable("Pricecode");

            entity.Property(e => e.Rowpointer)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ROWPOINTER");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Createdby)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CREATEDBY");
            entity.Property(e => e.CustItem)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CUST_ITEM");
            entity.Property(e => e.Description)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Inworkflow).HasColumnName("INWORKFLOW");
            entity.Property(e => e.Noteexistsflag).HasColumnName("NOTEEXISTSFLAG");
            entity.Property(e => e.Pricecode1)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("PRICECODE");
            entity.Property(e => e.Recorddate)
                .HasColumnType("datetime")
                .HasColumnName("RECORDDATE");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("UPDATEDBY");
        });

        modelBuilder.Entity<SegEndUserChannel>(entity =>
        {
            entity.HasKey(e => e.Rowpointer).HasName("PK___Seg_End__8B3A161615519B0F");

            entity.ToTable("_Seg_End_User_Channel");

            entity.Property(e => e.Rowpointer)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ROWPOINTER");
            entity.Property(e => e.Channel)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CHANNEL");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATE");
            entity.Property(e => e.Createdby)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CREATEDBY");
            entity.Property(e => e.EndUserType)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("END_USER_TYPE");
            entity.Property(e => e.Inworkflow).HasColumnName("INWORKFLOW");
            entity.Property(e => e.Noteexistsflag).HasColumnName("NOTEEXISTSFLAG");
            entity.Property(e => e.Recorddate)
                .HasColumnType("datetime")
                .HasColumnName("RECORDDATE");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("UPDATEDBY");
        });

        modelBuilder.Entity<SegFsSrolineRecTest>(entity =>
        {
            entity.HasKey(e => e.RowPointer).HasName("PK___SEG_fsS__30A54D44A6FF9892");

            entity.ToTable("_SEG_fsSROLineRecTest");

            entity.Property(e => e.RowPointer).ValueGeneratedNever();
            entity.Property(e => e.AdditionalNotes)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("ADDITIONAL_NOTES");
            entity.Property(e => e.ApprovalReceived)
                .HasColumnType("datetime")
                .HasColumnName("APPROVAL_RECEIVED");
            entity.Property(e => e.Batteries)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.BsaCode).HasColumnName("BSA_CODE");
            entity.Property(e => e.BsaFixed).HasColumnName("BSA_FIXED");
            entity.Property(e => e.ChargePort)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ComfortMats)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ConfigFinalOverride).HasColumnName("CONFIG_FINAL_OVERRIDE");
            entity.Property(e => e.ConfigStartOverride).HasColumnName("CONFIG_START_OVERRIDE");
            entity.Property(e => e.ConfigureFinal).HasColumnName("CONFIGURE_FINAL");
            entity.Property(e => e.ConfigureStart).HasColumnName("CONFIGURE_START");
            entity.Property(e => e.ConsoleTrim)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.CsbRcv).HasColumnName("csb_rcv");
            entity.Property(e => e.CsbShp).HasColumnName("csb_shp");
            entity.Property(e => e.CuACode).HasColumnName("CU_A_CODE");
            entity.Property(e => e.CuALog).HasColumnName("CU_A_LOG");
            entity.Property(e => e.CuALogClear).HasColumnName("CU_A_LOG_CLEAR");
            entity.Property(e => e.CuALogCode).HasColumnName("CU_A_LOG_CODE");
            entity.Property(e => e.CuBCode).HasColumnName("CU_B_CODE");
            entity.Property(e => e.CuBLog).HasColumnName("CU_B_LOG");
            entity.Property(e => e.CuBLogClear).HasColumnName("CU_B_LOG_CLEAR");
            entity.Property(e => e.CuBLogCode).HasColumnName("CU_B_LOG_CODE");
            entity.Property(e => e.DateCompleted).HasColumnType("datetime");
            entity.Property(e => e.DateQuoted).HasColumnType("datetime");
            entity.Property(e => e.DateShipped).HasColumnType("datetime");
            entity.Property(e => e.DateTrans).HasColumnType("datetime");
            entity.Property(e => e.DiagBsaTest).HasColumnName("DIAG_BSA_TEST");
            entity.Property(e => e.DiagLedTest).HasColumnName("DIAG_LED_TEST");
            entity.Property(e => e.DiagMotorLeftTest).HasColumnName("DIAG_MOTOR_LEFT_TEST");
            entity.Property(e => e.DiagMotorRightTest).HasColumnName("DIAG_MOTOR_RIGHT_TEST");
            entity.Property(e => e.DiagMotorTest).HasColumnName("DIAG_MOTOR_TEST");
            entity.Property(e => e.DiagOtherTest).HasColumnName("DIAG_OTHER_TEST");
            entity.Property(e => e.DiagPowerbaseTest).HasColumnName("DIAG_POWERBASE_TEST");
            entity.Property(e => e.DiagRiderDefectTest).HasColumnName("DIAG_RIDER_DEFECT_TEST");
            entity.Property(e => e.DiagUiTest).HasColumnName("DIAG_UI_TEST");
            entity.Property(e => e.ErrorCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ERROR_CODE");
            entity.Property(e => e.ErrorCodeNoStart).HasColumnName("ERROR_CODE_NO_START");
            entity.Property(e => e.ErrorCodeNone).HasColumnName("ERROR_CODE_NONE");
            entity.Property(e => e.ErrorCodeNote).HasMaxLength(4000);
            entity.Property(e => e.FailReasonA).HasMaxLength(30);
            entity.Property(e => e.FailReasonB).HasMaxLength(30);
            entity.Property(e => e.FaultLogA).HasMaxLength(75);
            entity.Property(e => e.FaultLogB).HasMaxLength(75);
            entity.Property(e => e.Fenders)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.G1keysBlack).HasColumnName("G1Keys_Black");
            entity.Property(e => e.G1keysBlue).HasColumnName("G1Keys_Blue");
            entity.Property(e => e.G1keysLegacy)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("G1Keys_Legacy");
            entity.Property(e => e.G1keysRed).HasColumnName("G1Keys_Red");
            entity.Property(e => e.G1keysYellow).HasColumnName("G1Keys_Yellow");
            entity.Property(e => e.HiPotRcv).HasColumnName("HiPot_rcv");
            entity.Property(e => e.HiPotShp).HasColumnName("HiPot_shp");
            entity.Property(e => e.HubCaps)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.HyperElcon)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("HYPER_ELCON");
            entity.Property(e => e.InfoKeys)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.KickStand)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LaborHrsPb).HasColumnName("LABOR_HRS_PB");
            entity.Property(e => e.ManagementApproved)
                .HasColumnType("datetime")
                .HasColumnName("MANAGEMENT_APPROVED");
            entity.Property(e => e.ManagementRejected)
                .HasColumnType("datetime")
                .HasColumnName("MANAGEMENT_REJECTED");
            entity.Property(e => e.Mats)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Minutes)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MINUTES");
            entity.Property(e => e.MotorDiagRcv).HasColumnName("MotorDiag_rcv");
            entity.Property(e => e.MotorDiagShp).HasColumnName("MotorDiag_shp");
            entity.Property(e => e.NewPbPn)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("NEW_PB_PN");
            entity.Property(e => e.NewPbSn)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("NEW_PB_SN");
            entity.Property(e => e.NormRatioFailRcv).HasColumnName("NormRatioFail_rcv");
            entity.Property(e => e.NormRatioFailShp).HasColumnName("NormRatioFail_shp");
            entity.Property(e => e.OdometerReadingA)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ODOMETER_READING_A");
            entity.Property(e => e.OdometerReadingB)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ODOMETER_READING_B");
            entity.Property(e => e.OpenedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.OpsComments)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("OPS_COMMENTS");
            entity.Property(e => e.Owner)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("OWNER");
            entity.Property(e => e.PbServiceRequest)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("PB_SERVICE_REQUEST");
            entity.Property(e => e.ProblemDescription)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("PROBLEM_DESCRIPTION");
            entity.Property(e => e.ProductReceived)
                .HasColumnType("datetime")
                .HasColumnName("PRODUCT_RECEIVED");
            entity.Property(e => e.PwrBaseRcv).HasColumnName("PwrBase_rcv");
            entity.Property(e => e.PwrBaseShp).HasColumnName("PwrBase_shp");
            entity.Property(e => e.QuoteNote).HasMaxLength(4000);
            entity.Property(e => e.ReceivingNote).HasMaxLength(4000);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.RefurbPb)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REFURB_PB");
            entity.Property(e => e.RepairPerformed)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("REPAIR_PERFORMED");
            entity.Property(e => e.RepairPerformedNote).HasMaxLength(4000);
            entity.Property(e => e.RepairType)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPAIR_TYPE");
            entity.Property(e => e.ReportNumber)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REPORT_NUMBER");
            entity.Property(e => e.RevA).HasMaxLength(20);
            entity.Property(e => e.RevB).HasMaxLength(20);
            entity.Property(e => e.RmaNumber)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("RMA_NUMBER");
            entity.Property(e => e.SalesOrder)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("SALES_ORDER");
            entity.Property(e => e.SegwayObservation)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("SEGWAY_OBSERVATION");
            entity.Property(e => e.SerialA).HasMaxLength(30);
            entity.Property(e => e.SerialB).HasMaxLength(30);
            entity.Property(e => e.SroLine).HasColumnName("sro_line");
            entity.Property(e => e.SroNum)
                .HasMaxLength(10)
                .HasColumnName("sro_num");
            entity.Property(e => e.StartDate1)
                .HasColumnType("datetime")
                .HasColumnName("START_DATE_1");
            entity.Property(e => e.StartDate2)
                .HasColumnType("datetime")
                .HasColumnName("START_DATE_2");
            entity.Property(e => e.TimeA).HasMaxLength(12);
            entity.Property(e => e.TimeB).HasMaxLength(12);
            entity.Property(e => e.TirePsi)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TIRE_PSI");
            entity.Property(e => e.TirePsi1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TIRE_PSI1");
            entity.Property(e => e.TirePsiLeftRcv).HasColumnName("TIRE_PSI_LEFT_RCV");
            entity.Property(e => e.TirePsiLeftShp).HasColumnName("TIRE_PSI_LEFT_SHP");
            entity.Property(e => e.TirePsiRightRcv).HasColumnName("TIRE_PSI_RIGHT_RCV");
            entity.Property(e => e.TirePsiRightShp).HasColumnName("TIRE_PSI_RIGHT_SHP");
            entity.Property(e => e.UiRcv).HasColumnName("ui_rcv");
            entity.Property(e => e.UiShp).HasColumnName("ui_shp");
            entity.Property(e => e.UnitCleaned).HasColumnName("UNIT_CLEANED");
            entity.Property(e => e.UnitCondition)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("UNIT_CONDITION");
            entity.Property(e => e.UpdatedBy).HasMaxLength(30);
            entity.Property(e => e.WaitCustomerApproval).HasColumnName("WAIT_CUSTOMER_APPROVAL");
            entity.Property(e => e.Wheels)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SegFsUnitWarrHist>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_SEG_fs_unit_warr_hist");

            entity.Property(e => e.Action)
                .HasMaxLength(36)
                .HasColumnName("action");
            entity.Property(e => e.CompId).HasColumnName("CompID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("end_date");
            entity.Property(e => e.EndMeter).HasColumnName("end_meter");
            entity.Property(e => e.OrgCompId).HasColumnName("org_comp_id");
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("start_date");
            entity.Property(e => e.StartMeter).HasColumnName("start_meter");
            entity.Property(e => e.UpdatedBy).HasMaxLength(30);
            entity.Property(e => e.WarrCode)
                .HasMaxLength(8)
                .HasColumnName("warr_code");
        });

        modelBuilder.Entity<SegSalesRegionGroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_SEG_SALES_REGION_GROUPS");

            entity.Property(e => e.ChildRegion).HasMaxLength(20);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.ParentRegion).HasMaxLength(20);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(30);
        });

        modelBuilder.Entity<SegSartPicture>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_SEG_SART_Pictures");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.Description)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.PictureData).HasColumnName("PICTURE_DATA");
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.SroLine).HasColumnName("sro_line");
            entity.Property(e => e.SroNum)
                .HasMaxLength(10)
                .HasColumnName("sro_num");
            entity.Property(e => e.UniqueName)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("UNIQUE_NAME");
            entity.Property(e => e.UpdatedBy).HasMaxLength(30);
            entity.Property(e => e.UserName)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("USER_NAME");
        });

        modelBuilder.Entity<Serial>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("serial");

            entity.Property(e => e.CertNum)
                .HasMaxLength(20)
                .HasColumnName("cert_num");
            entity.Property(e => e.Charfld1)
                .HasMaxLength(20)
                .HasColumnName("charfld1");
            entity.Property(e => e.Charfld2)
                .HasMaxLength(20)
                .HasColumnName("charfld2");
            entity.Property(e => e.Charfld3)
                .HasMaxLength(20)
                .HasColumnName("charfld3");
            entity.Property(e => e.ContainerNum)
                .HasMaxLength(15)
                .HasColumnName("container_num");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateDate1)
                .HasColumnType("datetime")
                .HasColumnName("CreateDate");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.DateSeq).HasColumnName("date_seq");
            entity.Property(e => e.Datefld)
                .HasColumnType("datetime")
                .HasColumnName("datefld");
            entity.Property(e => e.Decifld1)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld1");
            entity.Property(e => e.Decifld2)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld2");
            entity.Property(e => e.Decifld3)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("decifld3");
            entity.Property(e => e.DoLine).HasColumnName("do_line");
            entity.Property(e => e.DoNum)
                .HasMaxLength(30)
                .HasColumnName("do_num");
            entity.Property(e => e.DoSeq).HasColumnName("do_seq");
            entity.Property(e => e.ExpDate)
                .HasColumnType("datetime")
                .HasColumnName("exp_date");
            entity.Property(e => e.GrnLine).HasColumnName("grn_line");
            entity.Property(e => e.GrnNum)
                .HasMaxLength(30)
                .HasColumnName("grn_num");
            entity.Property(e => e.ImportDocId)
                .HasMaxLength(25)
                .HasColumnName("import_doc_id");
            entity.Property(e => e.InvNum)
                .HasMaxLength(12)
                .HasColumnName("inv_num");
            entity.Property(e => e.Item)
                .HasMaxLength(30)
                .HasColumnName("item");
            entity.Property(e => e.Loc)
                .HasMaxLength(15)
                .HasColumnName("loc");
            entity.Property(e => e.Logifld).HasColumnName("logifld");
            entity.Property(e => e.Lot)
                .HasMaxLength(15)
                .HasColumnName("lot");
            entity.Property(e => e.PurgeDate)
                .HasColumnType("datetime")
                .HasColumnName("purge_date");
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.RefLine).HasColumnName("ref_line");
            entity.Property(e => e.RefNum)
                .HasMaxLength(10)
                .HasColumnName("ref_num");
            entity.Property(e => e.RefRelease).HasColumnName("ref_release");
            entity.Property(e => e.RefType)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("ref_type");
            entity.Property(e => e.RsvdNum)
                .HasColumnType("decimal(10, 0)")
                .HasColumnName("rsvd_num");
            entity.Property(e => e.SerNum)
                .HasMaxLength(30)
                .HasColumnName("ser_num");
            entity.Property(e => e.ShipDate)
                .HasColumnType("datetime")
                .HasColumnName("ship_date");
            entity.Property(e => e.Stat)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("stat");
            entity.Property(e => e.TransNum)
                .HasColumnType("decimal(11, 0)")
                .HasColumnName("trans_num");
            entity.Property(e => e.TrnLine).HasColumnName("trn_line");
            entity.Property(e => e.TrnNum)
                .HasMaxLength(10)
                .HasColumnName("trn_num");
            entity.Property(e => e.UpdatedBy).HasMaxLength(30);
            entity.Property(e => e.VendNum)
                .HasMaxLength(7)
                .HasColumnName("vend_num");
            entity.Property(e => e.Whse)
                .HasMaxLength(4)
                .HasColumnName("whse");
        });

        modelBuilder.Entity<Site>(entity =>
        {
            entity.HasKey(e => e.RowPointer).HasName("PK__Site__219964B105F20A22");

            entity.ToTable("Site");

            entity.Property(e => e.RowPointer)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ROW_POINTER");
            entity.Property(e => e.AppDbName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("APP_DB_NAME");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATE_DATE");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.Description)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.InWorkflow).HasColumnName("IN_WORKFLOW");
            entity.Property(e => e.IntranetName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("INTRANET_NAME");
            entity.Property(e => e.Intranetlicensing).HasColumnName("INTRANETLICENSING");
            entity.Property(e => e.LangCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("LANG_CODE");
            entity.Property(e => e.LastConsolidated)
                .HasColumnType("datetime")
                .HasColumnName("LAST_CONSOLIDATED");
            entity.Property(e => e.MessageBusLogicalId)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("MESSAGE_BUS_LOGICAL_ID");
            entity.Property(e => e.NoteExistsFlag).HasColumnName("NOTE_EXISTS_FLAG");
            entity.Property(e => e.RecordDate)
                .HasColumnType("datetime")
                .HasColumnName("RECORD_DATE");
            entity.Property(e => e.ReportsToSite)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("REPORTS_TO_SITE");
            entity.Property(e => e.Site1)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("SITE");
            entity.Property(e => e.SiteName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("SITE_NAME");
            entity.Property(e => e.StringsTable)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("STRINGS_TABLE");
            entity.Property(e => e.SystemType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SYSTEM_TYPE");
            entity.Property(e => e.TimeZone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TIME_ZONE");
            entity.Property(e => e.Type)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TYPE");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("UPDATED_BY");
        });

        modelBuilder.Entity<SpecificNote>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.NoteContent).HasColumnType("ntext");
            entity.Property(e => e.NoteDesc).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.SpecificNoteToken).HasColumnType("decimal(11, 0)");
            entity.Property(e => e.UpdatedBy).HasMaxLength(30);
        });

        modelBuilder.Entity<SystemNote>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.NoteContent).HasColumnType("ntext");
            entity.Property(e => e.NoteDesc).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.SystemNoteToken).HasColumnType("decimal(11, 0)");
            entity.Property(e => e.UpdatedBy).HasMaxLength(30);
        });

        modelBuilder.Entity<UM>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("U_M");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.Description)
                .HasMaxLength(40)
                .HasColumnName("description");
            entity.Property(e => e.IsoUM)
                .HasMaxLength(3)
                .HasColumnName("iso_u_m");
            entity.Property(e => e.Precision).HasColumnName("precision_");
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.UM1)
                .HasMaxLength(3)
                .HasColumnName("u_m");
            entity.Property(e => e.UpdatedBy).HasMaxLength(30);
        });

        modelBuilder.Entity<UserDefinedField>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.TableName).HasMaxLength(128);
            entity.Property(e => e.Udfdt1)
                .HasColumnType("datetime")
                .HasColumnName("UDFDT1");
            entity.Property(e => e.Udfdt2)
                .HasColumnType("datetime")
                .HasColumnName("UDFDT2");
            entity.Property(e => e.Udfdt3)
                .HasColumnType("datetime")
                .HasColumnName("UDFDT3");
            entity.Property(e => e.Udfdt4)
                .HasColumnType("datetime")
                .HasColumnName("UDFDT4");
            entity.Property(e => e.Udfdt5)
                .HasColumnType("datetime")
                .HasColumnName("UDFDT5");
            entity.Property(e => e.Udfdt6)
                .HasColumnType("datetime")
                .HasColumnName("UDFDT6");
            entity.Property(e => e.Udfint1).HasColumnName("UDFINT1");
            entity.Property(e => e.Udfint2).HasColumnName("UDFINT2");
            entity.Property(e => e.Udfint3).HasColumnName("UDFINT3");
            entity.Property(e => e.Udfint4).HasColumnName("UDFINT4");
            entity.Property(e => e.Udfint5).HasColumnName("UDFINT5");
            entity.Property(e => e.Udfint6).HasColumnName("UDFINT6");
            entity.Property(e => e.Udfnum1)
                .HasColumnType("decimal(24, 10)")
                .HasColumnName("UDFNUM1");
            entity.Property(e => e.Udfnum2)
                .HasColumnType("decimal(24, 10)")
                .HasColumnName("UDFNUM2");
            entity.Property(e => e.Udfnum3)
                .HasColumnType("decimal(24, 10)")
                .HasColumnName("UDFNUM3");
            entity.Property(e => e.Udfnum4)
                .HasColumnType("decimal(24, 10)")
                .HasColumnName("UDFNUM4");
            entity.Property(e => e.Udfnum5)
                .HasColumnType("decimal(24, 10)")
                .HasColumnName("UDFNUM5");
            entity.Property(e => e.Udfnum6)
                .HasColumnType("decimal(24, 10)")
                .HasColumnName("UDFNUM6");
            entity.Property(e => e.Udfvcld1)
                .HasMaxLength(255)
                .IsFixedLength()
                .HasColumnName("UDFVCLD1");
            entity.Property(e => e.Udfvcld2)
                .HasMaxLength(255)
                .IsFixedLength()
                .HasColumnName("UDFVCLD2");
            entity.Property(e => e.Udfvcmd1)
                .HasMaxLength(80)
                .IsFixedLength()
                .HasColumnName("UDFVCMD1");
            entity.Property(e => e.Udfvcmd2)
                .HasMaxLength(80)
                .IsFixedLength()
                .HasColumnName("UDFVCMD2");
            entity.Property(e => e.Udfvcmd3)
                .HasMaxLength(80)
                .IsFixedLength()
                .HasColumnName("UDFVCMD3");
            entity.Property(e => e.Udfvcmd4)
                .HasMaxLength(80)
                .IsFixedLength()
                .HasColumnName("UDFVCMD4");
            entity.Property(e => e.Udfvcmd5)
                .HasMaxLength(80)
                .IsFixedLength()
                .HasColumnName("UDFVCMD5");
            entity.Property(e => e.Udfvcmd6)
                .HasMaxLength(80)
                .IsFixedLength()
                .HasColumnName("UDFVCMD6");
            entity.Property(e => e.Udfvcsd1)
                .HasMaxLength(35)
                .IsFixedLength()
                .HasColumnName("UDFVCSD1");
            entity.Property(e => e.Udfvcsd2)
                .HasMaxLength(35)
                .IsFixedLength()
                .HasColumnName("UDFVCSD2");
            entity.Property(e => e.Udfvcsd3)
                .HasMaxLength(35)
                .IsFixedLength()
                .HasColumnName("UDFVCSD3");
            entity.Property(e => e.Udfvcsd4)
                .HasMaxLength(35)
                .IsFixedLength()
                .HasColumnName("UDFVCSD4");
            entity.Property(e => e.Udfvcsd5)
                .HasMaxLength(35)
                .IsFixedLength()
                .HasColumnName("UDFVCSD5");
            entity.Property(e => e.Udfvcsd6)
                .HasMaxLength(35)
                .IsFixedLength()
                .HasColumnName("UDFVCSD6");
            entity.Property(e => e.Udfvcsd7)
                .HasMaxLength(35)
                .IsFixedLength()
                .HasColumnName("UDFVCSD7");
            entity.Property(e => e.UpdatedBy).HasMaxLength(30);
        });

        modelBuilder.Entity<UserDefinedType>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(72);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(30);
        });

        modelBuilder.Entity<UserDefinedTypeValue>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.TypeName).HasMaxLength(72);
            entity.Property(e => e.UpdatedBy).HasMaxLength(30);
            entity.Property(e => e.Value).HasMaxLength(255);
        });

        modelBuilder.Entity<UserNote>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(30);
            entity.Property(e => e.NoteContent).HasColumnType("ntext");
            entity.Property(e => e.NoteDesc).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(30);
            entity.Property(e => e.UserName).HasMaxLength(30);
            entity.Property(e => e.UserNoteToken).HasColumnType("decimal(11, 0)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
