namespace Walmart.Curiosity.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CuriosityContext : DbContext
    {
        public CuriosityContext()
            : base("name=CuriosityContext")
        {
        }

        public virtual DbSet<Accounting> Accountings { get; set; }
        public virtual DbSet<AccountingByTransaction> AccountingByTransactions { get; set; }
        public virtual DbSet<AccountingCode> AccountingCodes { get; set; }
        public virtual DbSet<Commission> Commissions { get; set; }
        public virtual DbSet<HistoryInvoiceControl> HistoryInvoiceControls { get; set; }
        public virtual DbSet<InvoiceControl> InvoiceControls { get; set; }
        public virtual DbSet<AuditCatalog> AuditCatalogs { get; set; }
        public virtual DbSet<EalUtilFile> EalUtilFiles { get; set; }
        public virtual DbSet<GL02LayOut> GL02LayOut { get; set; }
        public virtual DbSet<HistoryLoadUtil> HistoryLoadUtils { get; set; }
        public virtual DbSet<IncomingFile> IncomingFiles { get; set; }
        public virtual DbSet<Action> Actions { get; set; }
        public virtual DbSet<BankEntitie> BankEntities { get; set; }
        public virtual DbSet<BankMsiBin> BankMsiBins { get; set; }
        public virtual DbSet<Broker> Brokers { get; set; }
        public virtual DbSet<BrokerUri> BrokerUris { get; set; }
        public virtual DbSet<Calendar> Calendars { get; set; }
        public virtual DbSet<CaptureLinePrefix> CaptureLinePrefixes { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Colony> Colonies { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Configuration> Configurations { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<FileReceptionConfiguration> FileReceptionConfigurations { get; set; }
        public virtual DbSet<Format> Formats { get; set; }
        public virtual DbSet<FormatConversionByVendor> FormatConversionByVendors { get; set; }
        public virtual DbSet<Holiday> Holidays { get; set; }
        public virtual DbSet<LineasCaptura> LineasCapturas { get; set; }
        public virtual DbSet<LogRegalii> LogRegaliis { get; set; }
        public virtual DbSet<LogRegaliiDate> LogRegaliiDates { get; set; }
        public virtual DbSet<LogRegaliiDetail> LogRegaliiDetails { get; set; }
        public virtual DbSet<MasterVendor> MasterVendors { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Module> Modules { get; set; }
        public virtual DbSet<PagosProveedor> PagosProveedors { get; set; }
        public virtual DbSet<ParameterList> ParameterLists { get; set; }
        public virtual DbSet<ParameterValue> ParameterValues { get; set; }
        public virtual DbSet<PhoneType> PhoneTypes { get; set; }
        public virtual DbSet<PortTcpListener> PortTcpListeners { get; set; }
        public virtual DbSet<prefixConcept> prefixConcepts { get; set; }
        public virtual DbSet<Protocol> Protocols { get; set; }
        public virtual DbSet<RecordStatu> RecordStatus { get; set; }
        public virtual DbSet<RecordType> RecordTypes { get; set; }
        public virtual DbSet<RegistroProcesoEnvioSap> RegistroProcesoEnvioSaps { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Tbcatval> Tbcatvals { get; set; }
        public virtual DbSet<TblConcentradoProveedore> TblConcentradoProveedores { get; set; }
        public virtual DbSet<TblConfigCargaMasiva> TblConfigCargaMasivas { get; set; }
        public virtual DbSet<TenderType> TenderTypes { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<TransactionCreditSummary> TransactionCreditSummaries { get; set; }
        public virtual DbSet<TransactionSummary> TransactionSummaries { get; set; }
        public virtual DbSet<TransactionType> TransactionTypes { get; set; }
        public virtual DbSet<TypesOfAccounting> TypesOfAccountings { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }
        public virtual DbSet<VendorBalanceInquiryDetail> VendorBalanceInquiryDetails { get; set; }
        public virtual DbSet<VendorBalanceInquiryHeader> VendorBalanceInquiryHeaders { get; set; }
        public virtual DbSet<VendorBalanceInquirySubDetail> VendorBalanceInquirySubDetails { get; set; }
        public virtual DbSet<VendorCity> VendorCities { get; set; }
        public virtual DbSet<VendorFormat> VendorFormats { get; set; }
        public virtual DbSet<VendorPaymentDetail> VendorPaymentDetails { get; set; }
        public virtual DbSet<VendorPaymentHeader> VendorPaymentHeaders { get; set; }
        public virtual DbSet<VendorPaymentSubDetail> VendorPaymentSubDetails { get; set; }
        public virtual DbSet<VendorReverseDetail> VendorReverseDetails { get; set; }
        public virtual DbSet<VendorReverseHeader> VendorReverseHeaders { get; set; }
        public virtual DbSet<VendorReverseSubDetail> VendorReverseSubDetails { get; set; }
        public virtual DbSet<VendorType> VendorTypes { get; set; }
        public virtual DbSet<VendorUri> VendorUris { get; set; }
        public virtual DbSet<Environment> Environments { get; set; }
        public virtual DbSet<ServicesCuriosity> ServicesCuriosities { get; set; }
        public virtual DbSet<ServicesModule> ServicesModules { get; set; }
        public virtual DbSet<IncomingFile1> IncomingFile1 { get; set; }
        public virtual DbSet<IncomingFile_back> IncomingFile_back { get; set; }
        public virtual DbSet<IncomingFileDetail> IncomingFileDetails { get; set; }
        public virtual DbSet<Tbingca> Tbingcas { get; set; }
        public virtual DbSet<Tbingren> Tbingrens { get; set; }
        public virtual DbSet<TbingrenStaging> TbingrenStagings { get; set; }
        public virtual DbSet<Tbingre> Tbingres { get; set; }
        public virtual DbSet<TbingresStaging> TbingresStagings { get; set; }
        public virtual DbSet<ApplicationSettingVendor> ApplicationSettingVendors { get; set; }
        public virtual DbSet<ReportsColumn> ReportsColumns { get; set; }
        public virtual DbSet<TransactionsReportLayout> TransactionsReportLayouts { get; set; }
        public virtual DbSet<UserReport> UserReports { get; set; }
        public virtual DbSet<BrokerIncomeConfig> BrokerIncomeConfigs { get; set; }
        public virtual DbSet<BrokerPaymentType> BrokerPaymentTypes { get; set; }
        public virtual DbSet<Commission1> Commission1 { get; set; }
        public virtual DbSet<CommissionType> CommissionTypes { get; set; }
        public virtual DbSet<IncomeConfig> IncomeConfigs { get; set; }
        public virtual DbSet<PaymentType> PaymentTypes { get; set; }
        public virtual DbSet<PaymentTypeCat> PaymentTypeCats { get; set; }
        public virtual DbSet<PaymentTypeProvider> PaymentTypeProviders { get; set; }
        public virtual DbSet<SubVendor> SubVendors { get; set; }
        public virtual DbSet<SubVendorBin> SubVendorBins { get; set; }
        public virtual DbSet<SubVendorCommission> SubVendorCommissions { get; set; }
        public virtual DbSet<SubVendorPaymentType> SubVendorPaymentTypes { get; set; }
        public virtual DbSet<SubVendorValidation> SubVendorValidations { get; set; }
        public virtual DbSet<Validation> Validations { get; set; }
        public virtual DbSet<VendorCommission> VendorCommissions { get; set; }
        public virtual DbSet<VendorCompanyTmp> VendorCompanyTmps { get; set; }
        public virtual DbSet<VendorIncomeConfig> VendorIncomeConfigs { get; set; }
        public virtual DbSet<VendorPaymentType> VendorPaymentTypes { get; set; }
        public virtual DbSet<VendorSettlement> VendorSettlements { get; set; }
        public virtual DbSet<VendorValidation> VendorValidations { get; set; }
        public virtual DbSet<CatalogueValueTmp> CatalogueValueTmps { get; set; }
        public virtual DbSet<DDLEvent> DDLEvents { get; set; }
        public virtual DbSet<BalanceANTADTemp> BalanceANTADTemps { get; set; }
        public virtual DbSet<BalanceGUGATemp> BalanceGUGATemps { get; set; }
        public virtual DbSet<BalancePSETemp> BalancePSETemps { get; set; }
        public virtual DbSet<balanceRemunIzziTemp> balanceRemunIzziTemps { get; set; }
        public virtual DbSet<LoadUTILpos> LoadUTILpos { get; set; }
        public virtual DbSet<tmpGUGAlog> tmpGUGAlogs { get; set; }
        public virtual DbSet<borrar_ABFC1> borrar_ABFC1 { get; set; }
        public virtual DbSet<coso1> coso1 { get; set; }
        public virtual DbSet<PaymentType_FLEXPOS> PaymentType_FLEXPOS { get; set; }
        public virtual DbSet<TransactionSummary_Ini> TransactionSummary_Ini { get; set; }
        public virtual DbSet<TransactionSummary20180402> TransactionSummary20180402 { get; set; }
        public virtual DbSet<t> ts { get; set; }
        public virtual DbSet<AntadFileTemp> AntadFileTemps { get; set; }
        public virtual DbSet<AvonFile_> AvonFile_ { get; set; }
        public virtual DbSet<GenericFileTemp> GenericFileTemps { get; set; }
        public virtual DbSet<OpenPayFileTemp> OpenPayFileTemps { get; set; }
        public virtual DbSet<tmpANTADlog> tmpANTADlogs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Accounting>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Accounting>()
                .Property(e => e.Sign)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Accounting>()
                .Property(e => e.Amount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Accounting>()
                .Property(e => e.InterfaceType)
                .IsUnicode(false);

            modelBuilder.Entity<AccountingByTransaction>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AccountingByTransaction>()
                .Property(e => e.Sign)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AccountingByTransaction>()
                .Property(e => e.Amount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<AccountingByTransaction>()
                .Property(e => e.InterfaceType)
                .IsUnicode(false);

            modelBuilder.Entity<AccountingCode>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AccountingCode>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Commission>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Commission>()
                .Property(e => e.Sign)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Commission>()
                .Property(e => e.Value)
                .HasPrecision(10, 4);

            modelBuilder.Entity<Commission>()
                .Property(e => e.Iva)
                .HasPrecision(10, 4);

            modelBuilder.Entity<Commission>()
                .Property(e => e.TrTime)
                .HasPrecision(4);

            modelBuilder.Entity<Commission>()
                .Property(e => e.CreatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<Commission>()
                .Property(e => e.UpdatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<Commission>()
                .Property(e => e.Total)
                .HasPrecision(10, 4);

            modelBuilder.Entity<HistoryInvoiceControl>()
                .Property(e => e.IPFrom)
                .IsUnicode(false);

            modelBuilder.Entity<HistoryInvoiceControl>()
                .Property(e => e.HostFrom)
                .IsUnicode(false);

            modelBuilder.Entity<HistoryInvoiceControl>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<HistoryInvoiceControl>()
                .Property(e => e.ErrorDescription)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceControl>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceControl>()
                .Property(e => e.PaymentTypeProviderId)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceControl>()
                .Property(e => e.InvoiceSerie)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceControl>()
                .Property(e => e.FolioFiscal)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceControl>()
                .Property(e => e.InvoiceConcept)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceControl>()
                .Property(e => e.UnitValue)
                .HasPrecision(18, 4);

            modelBuilder.Entity<InvoiceControl>()
                .Property(e => e.Amount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<InvoiceControl>()
                .Property(e => e.IvaAmount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<InvoiceControl>()
                .Property(e => e.DiscountAmount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<InvoiceControl>()
                .Property(e => e.SubTotalAmount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<InvoiceControl>()
                .Property(e => e.TotalAmount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<InvoiceControl>()
                .Property(e => e.InvoiceCreatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceControl>()
                .Property(e => e.InvoiceGenerationDateStr)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceControl>()
                .Property(e => e.InvoiceGeneratedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceControl>()
                .Property(e => e.ReInvoiceCreatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceControl>()
                .Property(e => e.ReInvoiceCreatedReason)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceControl>()
                .Property(e => e.InvoiceCancelatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceControl>()
                .Property(e => e.InvoiceCancelationReason)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceControl>()
                .Property(e => e.InvoiceSource)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceControl>()
                .Property(e => e.IdTransaction)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceControl>()
                .Property(e => e.InvoiceObservation)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceControl>()
                .Property(e => e.UpdatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceControl>()
                .Property(e => e.ErrorDescription)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceControl>()
                .Property(e => e.InvoiceSerieOriginal)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceControl>()
                .Property(e => e.InvoiceFolioOriginal)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceControl>()
                .Property(e => e.UUIDOriginal_)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceControl>()
                .HasMany(e => e.Accountings)
                .WithOptional(e => e.InvoiceControl)
                .HasForeignKey(e => new { e.InvoiceControlId, e.CountryId });

            modelBuilder.Entity<InvoiceControl>()
                .HasMany(e => e.AccountingByTransactions)
                .WithOptional(e => e.InvoiceControl)
                .HasForeignKey(e => new { e.InvoiceControlId, e.CountryId });

            modelBuilder.Entity<AuditCatalog>()
                .Property(e => e.TYPE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AuditCatalog>()
                .Property(e => e.TableName)
                .IsUnicode(false);

            modelBuilder.Entity<AuditCatalog>()
                .Property(e => e.PK)
                .IsUnicode(false);

            modelBuilder.Entity<AuditCatalog>()
                .Property(e => e.FieldName)
                .IsUnicode(false);

            modelBuilder.Entity<AuditCatalog>()
                .Property(e => e.OldValue)
                .IsUnicode(false);

            modelBuilder.Entity<AuditCatalog>()
                .Property(e => e.NewValue)
                .IsUnicode(false);

            modelBuilder.Entity<AuditCatalog>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<EalUtilFile>()
                .Property(e => e.CustomerAccountId)
                .IsUnicode(false);

            modelBuilder.Entity<EalUtilFile>()
                .Property(e => e.AuthorizationNumber)
                .IsUnicode(false);

            modelBuilder.Entity<EalUtilFile>()
                .Property(e => e.BINNumber)
                .IsUnicode(false);

            modelBuilder.Entity<EalUtilFile>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<EalUtilFile>()
                .Property(e => e.PCIIndicator)
                .IsUnicode(false);

            modelBuilder.Entity<GL02LayOut>()
                .Property(e => e.StoreId)
                .IsUnicode(false);

            modelBuilder.Entity<GL02LayOut>()
                .Property(e => e.Body)
                .IsUnicode(false);

            modelBuilder.Entity<GL02LayOut>()
                .Property(e => e.Amount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<GL02LayOut>()
                .Property(e => e.CompanyId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GL02LayOut>()
                .Property(e => e.Sing_A)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GL02LayOut>()
                .Property(e => e.InterfaceTypeId)
                .IsUnicode(false);

            modelBuilder.Entity<HistoryLoadUtil>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<IncomingFile>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<IncomingFile>()
                .Property(e => e.VendorIncommingId)
                .IsUnicode(false);

            modelBuilder.Entity<IncomingFile>()
                .Property(e => e.MainChain)
                .IsUnicode(false);

            modelBuilder.Entity<Action>()
                .Property(e => e.Action1)
                .IsUnicode(false);

            modelBuilder.Entity<Action>()
                .Property(e => e.Comments)
                .IsUnicode(false);

            modelBuilder.Entity<BankEntitie>()
                .Property(e => e.BankEntitieId)
                .IsUnicode(false);

            modelBuilder.Entity<BankEntitie>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BankEntitie>()
                .Property(e => e.BankEntitieName)
                .IsUnicode(false);

            modelBuilder.Entity<BankEntitie>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<BankEntitie>()
                .Property(e => e.CreatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<BankEntitie>()
                .Property(e => e.UpdatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<BankEntitie>()
                .HasMany(e => e.VendorSettlements)
                .WithRequired(e => e.BankEntitie)
                .HasForeignKey(e => new { e.BankEntitieId, e.CountryId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BankMsiBin>()
                .Property(e => e.surcharge)
                .HasPrecision(7, 4);

            modelBuilder.Entity<Broker>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Broker>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<Broker>()
                .Property(e => e.CreatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<Broker>()
                .Property(e => e.UpdatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<Broker>()
                .Property(e => e.Rfc)
                .IsUnicode(false);

            modelBuilder.Entity<Broker>()
                .Property(e => e.LegalName)
                .IsUnicode(false);

            modelBuilder.Entity<Broker>()
                .Property(e => e.Street)
                .IsUnicode(false);

            modelBuilder.Entity<Broker>()
                .Property(e => e.NumExt)
                .IsUnicode(false);

            modelBuilder.Entity<Broker>()
                .Property(e => e.NumInt)
                .IsUnicode(false);

            modelBuilder.Entity<Broker>()
                .Property(e => e.ZipCode)
                .IsUnicode(false);

            modelBuilder.Entity<Broker>()
                .Property(e => e.ContactEmail)
                .IsUnicode(false);

            modelBuilder.Entity<Broker>()
                .Property(e => e.CountryId2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Broker>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Broker>()
                .HasMany(e => e.InvoiceControls)
                .WithOptional(e => e.Broker)
                .HasForeignKey(e => new { e.BrokerId, e.CountryId });

            modelBuilder.Entity<Broker>()
                .HasMany(e => e.BrokerIncomeConfigs)
                .WithRequired(e => e.Broker)
                .HasForeignKey(e => new { e.BrokerId, e.CountryId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Broker>()
                .HasMany(e => e.BrokerPaymentTypes)
                .WithRequired(e => e.Broker)
                .HasForeignKey(e => new { e.BrokerId, e.CountryId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Broker>()
                .HasMany(e => e.BrokerUris)
                .WithRequired(e => e.Broker)
                .HasForeignKey(e => new { e.BrokerId, e.CountryId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Broker>()
                .HasMany(e => e.MasterVendors)
                .WithOptional(e => e.Broker)
                .HasForeignKey(e => new { e.BrokerId, e.CountryId });

            modelBuilder.Entity<Broker>()
                .HasMany(e => e.Vendors)
                .WithOptional(e => e.Broker)
                .HasForeignKey(e => new { e.BrokerId, e.CountryId });

            modelBuilder.Entity<Broker>()
                .HasMany(e => e.VendorSettlements)
                .WithOptional(e => e.Broker)
                .HasForeignKey(e => new { e.BrokerId, e.CountryId });

            modelBuilder.Entity<BrokerUri>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BrokerUri>()
                .Property(e => e.Uri)
                .IsUnicode(false);

            modelBuilder.Entity<BrokerUri>()
                .Property(e => e.Bin)
                .IsUnicode(false);

            modelBuilder.Entity<Calendar>()
                .Property(e => e.DayOfWeekName)
                .IsUnicode(false);

            modelBuilder.Entity<Calendar>()
                .Property(e => e.DayOfWeekNameEs)
                .IsUnicode(false);

            modelBuilder.Entity<Calendar>()
                .Property(e => e.DscShortMonthEs)
                .IsUnicode(false);

            modelBuilder.Entity<Calendar>()
                .Property(e => e.DscShortMonth)
                .IsUnicode(false);

            modelBuilder.Entity<Calendar>()
                .Property(e => e.DscMonth)
                .IsUnicode(false);

            modelBuilder.Entity<Calendar>()
                .Property(e => e.DscMonthEs)
                .IsUnicode(false);

            modelBuilder.Entity<Calendar>()
                .Property(e => e.QuarterName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Calendar>()
                .Property(e => e.FiscalYearName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Calendar>()
                .Property(e => e.CalendarDateDescription)
                .IsUnicode(false);

            modelBuilder.Entity<City>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<City>()
                .Property(e => e.CityName)
                .IsUnicode(false);

            modelBuilder.Entity<City>()
                .Property(e => e.ZipCode)
                .IsUnicode(false);

            modelBuilder.Entity<City>()
                .HasMany(e => e.Brokers)
                .WithOptional(e => e.City)
                .HasForeignKey(e => new { e.CityId, e.CountryId });

            modelBuilder.Entity<City>()
                .HasMany(e => e.VendorCities)
                .WithRequired(e => e.City)
                .HasForeignKey(e => new { e.CityId, e.CountryId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.CreatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.UpdatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.PortTcpListeners)
                .WithRequired(e => e.Client)
                .HasForeignKey(e => new { e.ClientId, e.CountryId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Colony>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colony>()
                .Property(e => e.ZipCode)
                .IsUnicode(false);

            modelBuilder.Entity<Colony>()
                .HasMany(e => e.Brokers)
                .WithOptional(e => e.Colony)
                .HasForeignKey(e => new { e.ColonyId, e.CountryId });

            modelBuilder.Entity<Company>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.BusinessName)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.CompanyCode)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .Property(e => e.Rfc)
                .IsUnicode(false);

            modelBuilder.Entity<Company>()
                .HasMany(e => e.InvoiceControls)
                .WithOptional(e => e.Company)
                .HasForeignKey(e => new { e.CompanyId, e.CountryId });

            modelBuilder.Entity<Company>()
                .HasMany(e => e.Formats)
                .WithOptional(e => e.Company)
                .HasForeignKey(e => new { e.CompanyId, e.CountryId });

            modelBuilder.Entity<Company>()
                .HasMany(e => e.MasterVendors)
                .WithRequired(e => e.Company)
                .HasForeignKey(e => new { e.CompanyId, e.CountryId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Company>()
                .HasMany(e => e.Stores)
                .WithOptional(e => e.Company)
                .HasForeignKey(e => new { e.CompanyId, e.CountryId });

            modelBuilder.Entity<Configuration>()
                .Property(e => e.KeyConfiguration)
                .IsUnicode(false);

            modelBuilder.Entity<Configuration>()
                .Property(e => e.Value)
                .IsUnicode(false);

            modelBuilder.Entity<Configuration>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.CountryName)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.CreatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.UpdatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Accountings)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.AccountingByTransactions)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.AccountingCodes)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Commissions)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.InvoiceControls)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.IncomingFiles)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.BrokerUris)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Clients)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Companies)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Commission1)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.CommissionTypes)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.FormatConversionByVendors)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.IncomeConfigs)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.IncomingFile_back)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.MasterVendors)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.PaymentTypeCats)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.RecordStatus)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.States)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.TenderTypes)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Validations)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Vendors)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FileReceptionConfiguration>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<FileReceptionConfiguration>()
                .Property(e => e.FileEncodingType)
                .IsUnicode(false);

            modelBuilder.Entity<FileReceptionConfiguration>()
                .Property(e => e.Folder)
                .IsUnicode(false);

            modelBuilder.Entity<FileReceptionConfiguration>()
                .Property(e => e.BackupFolder)
                .IsUnicode(false);

            modelBuilder.Entity<FileReceptionConfiguration>()
                .Property(e => e.PlanFileName)
                .IsUnicode(false);

            modelBuilder.Entity<FileReceptionConfiguration>()
                .Property(e => e.NamePrefix)
                .IsUnicode(false);

            modelBuilder.Entity<FileReceptionConfiguration>()
                .Property(e => e.ColumnSeparator)
                .IsUnicode(false);

            modelBuilder.Entity<FileReceptionConfiguration>()
                .Property(e => e.NewLineChar)
                .IsUnicode(false);

            modelBuilder.Entity<FileReceptionConfiguration>()
                .Property(e => e.EndingType)
                .IsUnicode(false);

            modelBuilder.Entity<FileReceptionConfiguration>()
                .Property(e => e.DeliveryChannel)
                .IsUnicode(false);

            modelBuilder.Entity<Format>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Format>()
                .Property(e => e.SubBusinessTypeId)
                .IsUnicode(false);

            modelBuilder.Entity<Format>()
                .Property(e => e.FormatCode)
                .IsUnicode(false);

            modelBuilder.Entity<Format>()
                .Property(e => e.FormatShortDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Format>()
                .Property(e => e.FormatDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Format>()
                .HasMany(e => e.FormatConversionByVendors)
                .WithRequired(e => e.Format)
                .HasForeignKey(e => new { e.FormatId, e.CountryId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Format>()
                .HasMany(e => e.Stores)
                .WithOptional(e => e.Format)
                .HasForeignKey(e => new { e.FormatId, e.CountryId });

            modelBuilder.Entity<Format>()
                .HasMany(e => e.VendorFormats)
                .WithRequired(e => e.Format)
                .HasForeignKey(e => new { e.FormatId, e.CountryId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FormatConversionByVendor>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FormatConversionByVendor>()
                .Property(e => e.FormatConvertedId)
                .IsUnicode(false);

            modelBuilder.Entity<Holiday>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Holiday>()
                .Property(e => e.HolidayDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Holiday>()
                .Property(e => e.CreatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<Holiday>()
                .Property(e => e.UpdatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<LineasCaptura>()
                .Property(e => e.Prefix)
                .IsUnicode(false);

            modelBuilder.Entity<LineasCaptura>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<LineasCaptura>()
                .Property(e => e.CreatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<LineasCaptura>()
                .Property(e => e.UpdateByUser)
                .IsUnicode(false);

            modelBuilder.Entity<LogRegalii>()
                .Property(e => e.MessageStart)
                .IsUnicode(false);

            modelBuilder.Entity<LogRegalii>()
                .Property(e => e.MessageFinish)
                .IsUnicode(false);

            modelBuilder.Entity<LogRegalii>()
                .Property(e => e.Comments)
                .IsUnicode(false);

            modelBuilder.Entity<LogRegaliiDetail>()
                .Property(e => e.Message)
                .IsUnicode(false);

            modelBuilder.Entity<MasterVendor>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Message>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Module>()
                .Property(e => e.Module1)
                .IsUnicode(false);

            modelBuilder.Entity<ParameterList>()
                .Property(e => e.ParameterCode)
                .IsUnicode(false);

            modelBuilder.Entity<ParameterList>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<ParameterValue>()
                .Property(e => e.ParameterCode)
                .IsUnicode(false);

            modelBuilder.Entity<ParameterValue>()
                .Property(e => e.AlfNumericValue)
                .IsUnicode(false);

            modelBuilder.Entity<PhoneType>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PhoneType>()
                .Property(e => e.PhoneTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<PortTcpListener>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PortTcpListener>()
                .Property(e => e.CreatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<PortTcpListener>()
                .Property(e => e.UpdatedByUser)
                .IsFixedLength();

            modelBuilder.Entity<prefixConcept>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<prefixConcept>()
                .Property(e => e.CreatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<prefixConcept>()
                .Property(e => e.UpadteByUser)
                .IsUnicode(false);

            modelBuilder.Entity<Protocol>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Protocol>()
                .Property(e => e.ProtocolStr)
                .IsUnicode(false);

            modelBuilder.Entity<Protocol>()
                .HasMany(e => e.Clients)
                .WithRequired(e => e.Protocol)
                .HasForeignKey(e => new { e.ProtocolId, e.CountryId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RecordStatu>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RecordStatu>()
                .Property(e => e.TableName)
                .IsUnicode(false);

            modelBuilder.Entity<RecordStatu>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<RecordStatu>()
                .HasMany(e => e.Accountings)
                .WithRequired(e => e.RecordStatu)
                .HasForeignKey(e => new { e.RecordStatusId, e.CountryId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RecordStatu>()
                .HasMany(e => e.AccountingByTransactions)
                .WithRequired(e => e.RecordStatu)
                .HasForeignKey(e => new { e.RecordStatusId, e.CountryId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RecordStatu>()
                .HasMany(e => e.Commissions)
                .WithOptional(e => e.RecordStatu)
                .HasForeignKey(e => new { e.RecordStatusId, e.CountryId });

            modelBuilder.Entity<RecordStatu>()
                .HasMany(e => e.InvoiceControls)
                .WithOptional(e => e.RecordStatu)
                .HasForeignKey(e => new { e.RecordStatusId, e.CountryId });

            modelBuilder.Entity<RecordStatu>()
                .HasMany(e => e.HistoryLoadUtils)
                .WithOptional(e => e.RecordStatu)
                .HasForeignKey(e => new { e.RecordStatusId, e.CountryId });

            modelBuilder.Entity<RecordStatu>()
                .HasMany(e => e.IncomingFiles)
                .WithOptional(e => e.RecordStatu)
                .HasForeignKey(e => new { e.RecordStatusId, e.CountryId });

            modelBuilder.Entity<RecordStatu>()
                .HasMany(e => e.Brokers)
                .WithOptional(e => e.RecordStatu)
                .HasForeignKey(e => new { e.RecordStatusId, e.CountryId });

            modelBuilder.Entity<RecordStatu>()
                .HasMany(e => e.PortTcpListeners)
                .WithRequired(e => e.RecordStatu)
                .HasForeignKey(e => new { e.RecordStatusId, e.CountryId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RecordStatu>()
                .HasMany(e => e.BrokerIncomeConfigs)
                .WithOptional(e => e.RecordStatu)
                .HasForeignKey(e => new { e.RecordStatusId, e.CountryId });

            modelBuilder.Entity<RecordStatu>()
                .HasMany(e => e.BrokerPaymentTypes)
                .WithOptional(e => e.RecordStatu)
                .HasForeignKey(e => new { e.RecordStatusId, e.CountryId });

            modelBuilder.Entity<RecordStatu>()
                .HasMany(e => e.Commission1)
                .WithOptional(e => e.RecordStatu)
                .HasForeignKey(e => new { e.RecordStatusId, e.CountryId });

            modelBuilder.Entity<RecordStatu>()
                .HasMany(e => e.CommissionTypes)
                .WithOptional(e => e.RecordStatu)
                .HasForeignKey(e => new { e.RecordStatusId, e.CountryId });

            modelBuilder.Entity<RecordStatu>()
                .HasMany(e => e.IncomeConfigs)
                .WithOptional(e => e.RecordStatu)
                .HasForeignKey(e => new { e.RecordStatusId, e.CountryId });

            modelBuilder.Entity<RecordStatu>()
                .HasMany(e => e.IncomingFile_back)
                .WithOptional(e => e.RecordStatu)
                .HasForeignKey(e => new { e.RecordStatusId, e.CountryId });

            modelBuilder.Entity<RecordStatu>()
                .HasMany(e => e.PaymentTypes)
                .WithOptional(e => e.RecordStatu)
                .HasForeignKey(e => new { e.RecordStatusId, e.CountryId });

            modelBuilder.Entity<RecordStatu>()
                .HasMany(e => e.PaymentTypeCats)
                .WithOptional(e => e.RecordStatu)
                .HasForeignKey(e => new { e.RecordStatusId, e.CountryId });

            modelBuilder.Entity<RecordStatu>()
                .HasMany(e => e.PaymentTypeProviders)
                .WithOptional(e => e.RecordStatu)
                .HasForeignKey(e => new { e.RecordStatusId, e.CountryId });

            modelBuilder.Entity<RecordStatu>()
                .HasMany(e => e.Stores)
                .WithRequired(e => e.RecordStatu)
                .HasForeignKey(e => new { e.RecordStatusId, e.CountryId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RecordStatu>()
                .HasMany(e => e.SubVendors)
                .WithOptional(e => e.RecordStatu)
                .HasForeignKey(e => new { e.RecordStatusId, e.CountryId });

            modelBuilder.Entity<RecordStatu>()
                .HasMany(e => e.SubVendorBins)
                .WithOptional(e => e.RecordStatu)
                .HasForeignKey(e => new { e.RecordStatusId, e.CountryId });

            modelBuilder.Entity<RecordStatu>()
                .HasMany(e => e.SubVendorCommissions)
                .WithOptional(e => e.RecordStatu)
                .HasForeignKey(e => new { e.RecordStatusId, e.CountryId });

            modelBuilder.Entity<RecordStatu>()
                .HasMany(e => e.SubVendorPaymentTypes)
                .WithOptional(e => e.RecordStatu)
                .HasForeignKey(e => new { e.RecordStatusId, e.CountryId });

            modelBuilder.Entity<RecordStatu>()
                .HasMany(e => e.SubVendorValidations)
                .WithOptional(e => e.RecordStatu)
                .HasForeignKey(e => new { e.RecordStatusId, e.CountryId });

            modelBuilder.Entity<RecordStatu>()
                .HasMany(e => e.Tbcatvals)
                .WithOptional(e => e.RecordStatu)
                .HasForeignKey(e => new { e.RecordStatusId, e.CountryId });

            modelBuilder.Entity<RecordStatu>()
                .HasMany(e => e.Validations)
                .WithOptional(e => e.RecordStatu)
                .HasForeignKey(e => new { e.RecordStatusId, e.CountryId });

            modelBuilder.Entity<RecordStatu>()
                .HasMany(e => e.Vendors)
                .WithRequired(e => e.RecordStatu)
                .HasForeignKey(e => new { e.RecordStatusId, e.CountryId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RecordStatu>()
                .HasMany(e => e.VendorCommissions)
                .WithOptional(e => e.RecordStatu)
                .HasForeignKey(e => new { e.RecordStatusId, e.CountryId });

            modelBuilder.Entity<RecordStatu>()
                .HasMany(e => e.VendorCompanyTmps)
                .WithOptional(e => e.RecordStatu)
                .HasForeignKey(e => new { e.RecordStatusId, e.CountryId });

            modelBuilder.Entity<RecordStatu>()
                .HasMany(e => e.VendorIncomeConfigs)
                .WithOptional(e => e.RecordStatu)
                .HasForeignKey(e => new { e.RecordStatusId, e.CountryId });

            modelBuilder.Entity<RecordStatu>()
                .HasMany(e => e.VendorPaymentTypes)
                .WithOptional(e => e.RecordStatu)
                .HasForeignKey(e => new { e.RecordStatusId, e.CountryId });

            modelBuilder.Entity<RecordStatu>()
                .HasMany(e => e.VendorSettlements)
                .WithOptional(e => e.RecordStatu)
                .HasForeignKey(e => new { e.RecordStatusId, e.CountryId });

            modelBuilder.Entity<RecordStatu>()
                .HasMany(e => e.VendorValidations)
                .WithOptional(e => e.RecordStatu)
                .HasForeignKey(e => new { e.RecordStatusId, e.CountryId });

            modelBuilder.Entity<RecordType>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RecordType>()
                .Property(e => e.TableName)
                .IsUnicode(false);

            modelBuilder.Entity<RecordType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<RecordType>()
                .HasMany(e => e.Accountings)
                .WithRequired(e => e.RecordType)
                .HasForeignKey(e => new { e.RecordTypeId, e.CountryId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RecordType>()
                .HasMany(e => e.AccountingByTransactions)
                .WithRequired(e => e.RecordType)
                .HasForeignKey(e => new { e.RecordTypeId, e.CountryId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RecordType>()
                .HasMany(e => e.Commissions)
                .WithOptional(e => e.RecordType)
                .HasForeignKey(e => new { e.RecordTypeId, e.CountryId });

            modelBuilder.Entity<RecordType>()
                .HasMany(e => e.InvoiceControls)
                .WithOptional(e => e.RecordType)
                .HasForeignKey(e => new { e.RecordTypeId, e.CountryId });

            modelBuilder.Entity<RecordType>()
                .HasMany(e => e.HistoryLoadUtils)
                .WithOptional(e => e.RecordType)
                .HasForeignKey(e => new { e.RecordTypeId, e.CountryId });

            modelBuilder.Entity<RecordType>()
                .HasMany(e => e.IncomingFiles)
                .WithOptional(e => e.RecordType)
                .HasForeignKey(e => new { e.RecordTypeId, e.CountryId });

            modelBuilder.Entity<RecordType>()
                .HasMany(e => e.BrokerIncomeConfigs)
                .WithOptional(e => e.RecordType)
                .HasForeignKey(e => new { e.RecordTypeId, e.CountryId });

            modelBuilder.Entity<RecordType>()
                .HasMany(e => e.BrokerPaymentTypes)
                .WithOptional(e => e.RecordType)
                .HasForeignKey(e => new { e.RecordTypeId, e.CountryId });

            modelBuilder.Entity<RecordType>()
                .HasMany(e => e.Commission1)
                .WithOptional(e => e.RecordType)
                .HasForeignKey(e => new { e.RecordTypeId, e.CountryId });

            modelBuilder.Entity<RecordType>()
                .HasMany(e => e.CommissionTypes)
                .WithOptional(e => e.RecordType)
                .HasForeignKey(e => new { e.RecordTypeId, e.CountryId });

            modelBuilder.Entity<RecordType>()
                .HasMany(e => e.IncomeConfigs)
                .WithOptional(e => e.RecordType)
                .HasForeignKey(e => new { e.RecordTypeId, e.CountryId });

            modelBuilder.Entity<RecordType>()
                .HasMany(e => e.IncomingFile_back)
                .WithOptional(e => e.RecordType)
                .HasForeignKey(e => new { e.RecordTypeId, e.CountryId });

            modelBuilder.Entity<RecordType>()
                .HasMany(e => e.PaymentTypes)
                .WithOptional(e => e.RecordType)
                .HasForeignKey(e => new { e.RecordTypeId, e.CountryId });

            modelBuilder.Entity<RecordType>()
                .HasMany(e => e.PaymentTypeCats)
                .WithOptional(e => e.RecordType)
                .HasForeignKey(e => new { e.RecordTypeId, e.CountryId });

            modelBuilder.Entity<RecordType>()
                .HasMany(e => e.PaymentTypeProviders)
                .WithOptional(e => e.RecordType)
                .HasForeignKey(e => new { e.RecordTypeId, e.CountryId });

            modelBuilder.Entity<RecordType>()
                .HasMany(e => e.SubVendors)
                .WithOptional(e => e.RecordType)
                .HasForeignKey(e => new { e.RecordTypeId, e.CountryId });

            modelBuilder.Entity<RecordType>()
                .HasMany(e => e.SubVendorBins)
                .WithOptional(e => e.RecordType)
                .HasForeignKey(e => new { e.RecordTypeId, e.CountryId });

            modelBuilder.Entity<RecordType>()
                .HasMany(e => e.SubVendorCommissions)
                .WithOptional(e => e.RecordType)
                .HasForeignKey(e => new { e.RecordTypeId, e.CountryId });

            modelBuilder.Entity<RecordType>()
                .HasMany(e => e.SubVendorPaymentTypes)
                .WithOptional(e => e.RecordType)
                .HasForeignKey(e => new { e.RecordTypeId, e.CountryId });

            modelBuilder.Entity<RecordType>()
                .HasMany(e => e.SubVendorValidations)
                .WithOptional(e => e.RecordType)
                .HasForeignKey(e => new { e.RecordTypeId, e.CountryId });

            modelBuilder.Entity<RecordType>()
                .HasMany(e => e.Tbcatvals)
                .WithOptional(e => e.RecordType)
                .HasForeignKey(e => new { e.RecordTypeId, e.CountryId });

            modelBuilder.Entity<RecordType>()
                .HasMany(e => e.Validations)
                .WithOptional(e => e.RecordType)
                .HasForeignKey(e => new { e.RecordTypeId, e.CountryId });

            modelBuilder.Entity<RecordType>()
                .HasMany(e => e.Vendors)
                .WithRequired(e => e.RecordType)
                .HasForeignKey(e => new { e.RecordTypeId, e.CountryId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RecordType>()
                .HasMany(e => e.VendorCommissions)
                .WithOptional(e => e.RecordType)
                .HasForeignKey(e => new { e.RecordTypeId, e.CountryId });

            modelBuilder.Entity<RecordType>()
                .HasMany(e => e.VendorCompanyTmps)
                .WithOptional(e => e.RecordType)
                .HasForeignKey(e => new { e.RecordTypeId, e.CountryId });

            modelBuilder.Entity<RecordType>()
                .HasMany(e => e.VendorIncomeConfigs)
                .WithOptional(e => e.RecordType)
                .HasForeignKey(e => new { e.RecordTypeId, e.CountryId });

            modelBuilder.Entity<RecordType>()
                .HasMany(e => e.VendorPaymentTypes)
                .WithOptional(e => e.RecordType)
                .HasForeignKey(e => new { e.RecordTypeId, e.CountryId });

            modelBuilder.Entity<RecordType>()
                .HasMany(e => e.VendorSettlements)
                .WithOptional(e => e.RecordType)
                .HasForeignKey(e => new { e.RecordTypeId, e.CountryId });

            modelBuilder.Entity<RecordType>()
                .HasMany(e => e.VendorValidations)
                .WithOptional(e => e.RecordType)
                .HasForeignKey(e => new { e.RecordTypeId, e.CountryId });

            modelBuilder.Entity<State>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<State>()
                .Property(e => e.StateName)
                .IsUnicode(false);

            modelBuilder.Entity<State>()
                .Property(e => e.Abbreviation)
                .IsUnicode(false);

            modelBuilder.Entity<State>()
                .Property(e => e.Code1)
                .IsUnicode(false);

            modelBuilder.Entity<State>()
                .HasMany(e => e.Brokers)
                .WithOptional(e => e.State)
                .HasForeignKey(e => new { e.StateId, e.CountryId });

            modelBuilder.Entity<State>()
                .HasMany(e => e.Cities)
                .WithOptional(e => e.State)
                .HasForeignKey(e => new { e.StateId, e.CountryId });

            modelBuilder.Entity<Store>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.CreatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.UpdatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<Tbcatval>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tbcatval>()
                .Property(e => e.Cval_Codparam_0)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tbcatval>()
                .Property(e => e.Cval_Vechar_0)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tbcatval>()
                .Property(e => e.Cval_Valnum1_5)
                .HasPrecision(15, 3);

            modelBuilder.Entity<Tbcatval>()
                .Property(e => e.Cval_Valnum2_5)
                .HasPrecision(15, 3);

            modelBuilder.Entity<Tbcatval>()
                .Property(e => e.Cval_Valnum3_5)
                .HasPrecision(15, 3);

            modelBuilder.Entity<Tbcatval>()
                .Property(e => e.Cval_Valalf1_0)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tbcatval>()
                .Property(e => e.Cval_Valalf2_0)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tbcatval>()
                .Property(e => e.Cval_Valalf3_0)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TblConcentradoProveedore>()
                .Property(e => e.Rfc)
                .IsUnicode(false);

            modelBuilder.Entity<TblConcentradoProveedore>()
                .Property(e => e.Shortname)
                .IsUnicode(false);

            modelBuilder.Entity<TblConcentradoProveedore>()
                .Property(e => e.Legalname)
                .IsUnicode(false);

            modelBuilder.Entity<TblConcentradoProveedore>()
                .Property(e => e.idPais)
                .IsUnicode(false);

            modelBuilder.Entity<TblConcentradoProveedore>()
                .Property(e => e.TipoProveedor)
                .IsUnicode(false);

            modelBuilder.Entity<TblConcentradoProveedore>()
                .Property(e => e.ActividadProveedor)
                .IsUnicode(false);

            modelBuilder.Entity<TblConcentradoProveedore>()
                .Property(e => e.EstatusProveedor)
                .IsUnicode(false);

            modelBuilder.Entity<TblConcentradoProveedore>()
                .Property(e => e.Tpago)
                .IsUnicode(false);

            modelBuilder.Entity<TblConcentradoProveedore>()
                .Property(e => e.Cp)
                .IsUnicode(false);

            modelBuilder.Entity<TblConcentradoProveedore>()
                .Property(e => e.Calle)
                .IsUnicode(false);

            modelBuilder.Entity<TblConcentradoProveedore>()
                .Property(e => e.NoExt)
                .IsUnicode(false);

            modelBuilder.Entity<TblConcentradoProveedore>()
                .Property(e => e.NoInt)
                .IsUnicode(false);

            modelBuilder.Entity<TblConcentradoProveedore>()
                .Property(e => e.Colonia)
                .IsUnicode(false);

            modelBuilder.Entity<TblConcentradoProveedore>()
                .Property(e => e.Mundel)
                .IsUnicode(false);

            modelBuilder.Entity<TblConcentradoProveedore>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<TblConcentradoProveedore>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<TblConcentradoProveedore>()
                .Property(e => e.recibeEfec)
                .IsUnicode(false);

            modelBuilder.Entity<TblConcentradoProveedore>()
                .Property(e => e.recibeBancomer)
                .IsUnicode(false);

            modelBuilder.Entity<TblConcentradoProveedore>()
                .Property(e => e.recibeWalmart)
                .IsUnicode(false);

            modelBuilder.Entity<TblConcentradoProveedore>()
                .Property(e => e.recibeAmexco)
                .IsUnicode(false);

            modelBuilder.Entity<TblConcentradoProveedore>()
                .Property(e => e.recibeNomina)
                .IsUnicode(false);

            modelBuilder.Entity<TblConcentradoProveedore>()
                .Property(e => e.recibeDebito)
                .IsUnicode(false);

            modelBuilder.Entity<TblConcentradoProveedore>()
                .Property(e => e.recibeBanamex)
                .IsUnicode(false);

            modelBuilder.Entity<TblConcentradoProveedore>()
                .Property(e => e.recibeCarnet)
                .IsUnicode(false);

            modelBuilder.Entity<TblConcentradoProveedore>()
                .Property(e => e.RenglonIngresos)
                .IsUnicode(false);

            modelBuilder.Entity<TblConcentradoProveedore>()
                .Property(e => e.CasilleroIngresos)
                .IsUnicode(false);

            modelBuilder.Entity<TblConcentradoProveedore>()
                .Property(e => e.ClaveIngresos)
                .IsUnicode(false);

            modelBuilder.Entity<TblConcentradoProveedore>()
                .Property(e => e.AjustePositivo)
                .IsUnicode(false);

            modelBuilder.Entity<TblConcentradoProveedore>()
                .Property(e => e.AjusteNegativo)
                .IsUnicode(false);

            modelBuilder.Entity<TblConcentradoProveedore>()
                .Property(e => e.DigitoVerificador)
                .IsUnicode(false);

            modelBuilder.Entity<TblConcentradoProveedore>()
                .Property(e => e.AceptaPagoVencido)
                .IsUnicode(false);

            modelBuilder.Entity<TblConcentradoProveedore>()
                .Property(e => e.IniCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<TblConcentradoProveedore>()
                .Property(e => e.FinCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<TblConfigCargaMasiva>()
                .Property(e => e.CampoArchivo)
                .IsUnicode(false);

            modelBuilder.Entity<TblConfigCargaMasiva>()
                .Property(e => e.NombreArchivo)
                .IsUnicode(false);

            modelBuilder.Entity<TblConfigCargaMasiva>()
                .Property(e => e.TipoArchivo)
                .IsUnicode(false);

            modelBuilder.Entity<TblConfigCargaMasiva>()
                .Property(e => e.Columna)
                .IsUnicode(false);

            modelBuilder.Entity<TblConfigCargaMasiva>()
                .Property(e => e.Tipodedato)
                .IsUnicode(false);

            modelBuilder.Entity<TblConfigCargaMasiva>()
                .Property(e => e.NombreTabla)
                .IsUnicode(false);

            modelBuilder.Entity<TblConfigCargaMasiva>()
                .Property(e => e.Modulo)
                .IsUnicode(false);

            modelBuilder.Entity<TenderType>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TenderType>()
                .Property(e => e.TenderTypePos)
                .IsUnicode(false);

            modelBuilder.Entity<TenderType>()
                .Property(e => e.TenderTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.RequestClient)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.NameClient)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionCreditSummary>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TransactionCreditSummary>()
                .Property(e => e.BankAutoritationNumber)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionCreditSummary>()
                .Property(e => e.TcBin)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionCreditSummary>()
                .Property(e => e.CardType)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionCreditSummary>()
                .Property(e => e.BankName)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionCreditSummary>()
                .Property(e => e.BankID)
                .HasPrecision(19, 0);

            modelBuilder.Entity<TransactionCreditSummary>()
                .Property(e => e.LastFourBin)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionSummary>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TransactionSummary>()
                .Property(e => e.IpWcfCore)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionSummary>()
                .Property(e => e.RequestClient)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionSummary>()
                .Property(e => e.ResponseClient)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionSummary>()
                .Property(e => e.RequestVendor)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionSummary>()
                .Property(e => e.ResponseVendor)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionSummary>()
                .Property(e => e.ErrorType)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionSummary>()
                .Property(e => e.ErrorDescription)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionSummary>()
                .Property(e => e.DescResponseVendor)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionSummary>()
                .Property(e => e.CodeResponseVendor)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionSummary>()
                .Property(e => e.TransactionTime)
                .HasPrecision(3);

            modelBuilder.Entity<TransactionSummary>()
                .Property(e => e.TerminalNumber)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionSummary>()
                .Property(e => e.CashierNumber)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionSummary>()
                .Property(e => e.ServiceReference)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionSummary>()
                .Property(e => e.EntryMode)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionSummary>()
                .Property(e => e.PaymentType)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionSummary>()
                .Property(e => e.PosTrId)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionSummary>()
                .Property(e => e.Origen)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionSummary>()
                .Property(e => e.UserID)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionType>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TransactionType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionType>()
                .HasMany(e => e.BrokerUris)
                .WithRequired(e => e.TransactionType)
                .HasForeignKey(e => new { e.TransactionTypeId, e.CountryId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TransactionType>()
                .HasMany(e => e.VendorUris)
                .WithRequired(e => e.TransactionType)
                .HasForeignKey(e => new { e.TransactionTypeId, e.CountryId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TypesOfAccounting>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<TypesOfAccounting>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Vendor>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Vendor>()
                .Property(e => e.XmlConfig)
                .IsUnicode(false);

            modelBuilder.Entity<Vendor>()
                .Property(e => e.LegalName)
                .IsUnicode(false);

            modelBuilder.Entity<Vendor>()
                .Property(e => e.VendorNameShort)
                .IsUnicode(false);

            modelBuilder.Entity<Vendor>()
                .Property(e => e.ActivityDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Vendor>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<Vendor>()
                .Property(e => e.ShippingType)
                .IsUnicode(false);

            modelBuilder.Entity<Vendor>()
                .Property(e => e.Layout)
                .IsUnicode(false);

            modelBuilder.Entity<Vendor>()
                .Property(e => e.ShippingStatus)
                .IsUnicode(false);

            modelBuilder.Entity<Vendor>()
                .Property(e => e.FileType)
                .IsUnicode(false);

            modelBuilder.Entity<Vendor>()
                .Property(e => e.TransferType)
                .IsUnicode(false);

            modelBuilder.Entity<Vendor>()
                .Property(e => e.CreatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<Vendor>()
                .Property(e => e.UpdatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<Vendor>()
                .Property(e => e.Street)
                .IsUnicode(false);

            modelBuilder.Entity<Vendor>()
                .Property(e => e.NumExt)
                .IsUnicode(false);

            modelBuilder.Entity<Vendor>()
                .Property(e => e.NumInt)
                .IsUnicode(false);

            modelBuilder.Entity<Vendor>()
                .Property(e => e.CountryId2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Vendor>()
                .Property(e => e.ZipCode)
                .IsUnicode(false);

            modelBuilder.Entity<Vendor>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Vendor>()
                .Property(e => e.ContactEmail)
                .IsUnicode(false);

            modelBuilder.Entity<Vendor>()
                .Property(e => e.StatusNotificacion)
                .IsUnicode(false);

            modelBuilder.Entity<Vendor>()
                .HasMany(e => e.Accountings)
                .WithRequired(e => e.Vendor)
                .HasForeignKey(e => new { e.VendorId, e.CountryId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vendor>()
                .HasMany(e => e.AccountingByTransactions)
                .WithOptional(e => e.Vendor)
                .HasForeignKey(e => new { e.VendorId, e.CountryId });

            modelBuilder.Entity<Vendor>()
                .HasMany(e => e.InvoiceControls)
                .WithOptional(e => e.Vendor)
                .HasForeignKey(e => new { e.VendorId, e.CountryId });

            modelBuilder.Entity<Vendor>()
                .HasMany(e => e.IncomingFiles)
                .WithRequired(e => e.Vendor)
                .HasForeignKey(e => new { e.VendorId, e.CountryId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vendor>()
                .HasMany(e => e.FormatConversionByVendors)
                .WithRequired(e => e.Vendor)
                .HasForeignKey(e => new { e.VendorId, e.CountryId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vendor>()
                .HasMany(e => e.MasterVendors)
                .WithOptional(e => e.Vendor)
                .HasForeignKey(e => new { e.VendorId, e.CountryId });

            modelBuilder.Entity<Vendor>()
                .HasMany(e => e.IncomingFile_back)
                .WithRequired(e => e.Vendor)
                .HasForeignKey(e => new { e.VendorId, e.CountryId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vendor>()
                .HasMany(e => e.SubVendors)
                .WithRequired(e => e.Vendor)
                .HasForeignKey(e => new { e.VendorId, e.CountryId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vendor>()
                .HasMany(e => e.VendorBalanceInquiryHeaders)
                .WithRequired(e => e.Vendor)
                .HasForeignKey(e => new { e.VendorId, e.CountryId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vendor>()
                .HasMany(e => e.VendorCities)
                .WithRequired(e => e.Vendor)
                .HasForeignKey(e => new { e.VendorId, e.CountryId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vendor>()
                .HasMany(e => e.VendorCommissions)
                .WithRequired(e => e.Vendor)
                .HasForeignKey(e => new { e.VendorId, e.CountryId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vendor>()
                .HasMany(e => e.VendorCompanyTmps)
                .WithRequired(e => e.Vendor)
                .HasForeignKey(e => new { e.VendorId, e.CountryId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vendor>()
                .HasMany(e => e.VendorFormats)
                .WithRequired(e => e.Vendor)
                .HasForeignKey(e => new { e.VendorId, e.CountryId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vendor>()
                .HasMany(e => e.VendorIncomeConfigs)
                .WithRequired(e => e.Vendor)
                .HasForeignKey(e => new { e.VendorId, e.CountryId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vendor>()
                .HasMany(e => e.VendorPaymentHeaders)
                .WithRequired(e => e.Vendor)
                .HasForeignKey(e => new { e.VendorId, e.CountryId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vendor>()
                .HasMany(e => e.VendorPaymentTypes)
                .WithRequired(e => e.Vendor)
                .HasForeignKey(e => new { e.VendorId, e.CountryId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vendor>()
                .HasMany(e => e.VendorReverseHeaders)
                .WithRequired(e => e.Vendor)
                .HasForeignKey(e => new { e.VendorId, e.CountryId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vendor>()
                .HasMany(e => e.VendorSettlements)
                .WithOptional(e => e.Vendor)
                .HasForeignKey(e => new { e.VendorId, e.CountryId });

            modelBuilder.Entity<Vendor>()
                .HasMany(e => e.VendorUris)
                .WithRequired(e => e.Vendor)
                .HasForeignKey(e => new { e.VendorId, e.CountryId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vendor>()
                .HasOptional(e => e.VendorValidation)
                .WithRequired(e => e.Vendor);

            modelBuilder.Entity<VendorBalanceInquiryDetail>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VendorBalanceInquiryDetail>()
                .Property(e => e.Tag)
                .IsUnicode(false);

            modelBuilder.Entity<VendorBalanceInquiryDetail>()
                .Property(e => e.TagValue)
                .IsUnicode(false);

            modelBuilder.Entity<VendorBalanceInquiryDetail>()
                .HasMany(e => e.VendorBalanceInquirySubDetails)
                .WithRequired(e => e.VendorBalanceInquiryDetail)
                .HasForeignKey(e => new { e.TrDate, e.TransactionId, e.SequenceDetail, e.CountryId });

            modelBuilder.Entity<VendorBalanceInquiryHeader>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VendorBalanceInquiryHeader>()
                .Property(e => e.MainReference)
                .IsUnicode(false);

            modelBuilder.Entity<VendorBalanceInquiryHeader>()
                .Property(e => e.OptionalReference)
                .IsUnicode(false);

            modelBuilder.Entity<VendorBalanceInquiryHeader>()
                .Property(e => e.AuthorizationNumber)
                .IsUnicode(false);

            modelBuilder.Entity<VendorBalanceInquiryHeader>()
                .Property(e => e.TerminalId)
                .IsUnicode(false);

            modelBuilder.Entity<VendorBalanceInquiryHeader>()
                .Property(e => e.PosTrId)
                .IsUnicode(false);

            modelBuilder.Entity<VendorBalanceInquiryHeader>()
                .Property(e => e.UserNumber)
                .IsUnicode(false);

            modelBuilder.Entity<VendorBalanceInquiryHeader>()
                .HasMany(e => e.VendorBalanceInquiryDetails)
                .WithRequired(e => e.VendorBalanceInquiryHeader)
                .HasForeignKey(e => new { e.TrDate, e.TransactionId, e.CountryId });

            modelBuilder.Entity<VendorBalanceInquirySubDetail>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VendorBalanceInquirySubDetail>()
                .Property(e => e.TagType)
                .IsUnicode(false);

            modelBuilder.Entity<VendorBalanceInquirySubDetail>()
                .Property(e => e.Tag)
                .IsUnicode(false);

            modelBuilder.Entity<VendorBalanceInquirySubDetail>()
                .Property(e => e.TagValue)
                .IsUnicode(false);

            modelBuilder.Entity<VendorCity>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VendorFormat>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VendorFormat>()
                .Property(e => e.MasterVendor)
                .IsUnicode(false);

            modelBuilder.Entity<VendorFormat>()
                .Property(e => e.ArticleNumber)
                .IsUnicode(false);

            modelBuilder.Entity<VendorFormat>()
                .Property(e => e.Department)
                .IsUnicode(false);

            modelBuilder.Entity<VendorPaymentDetail>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VendorPaymentDetail>()
                .Property(e => e.UniqueId)
                .IsUnicode(false);

            modelBuilder.Entity<VendorPaymentDetail>()
                .Property(e => e.Tag)
                .IsUnicode(false);

            modelBuilder.Entity<VendorPaymentDetail>()
                .Property(e => e.TagValue)
                .IsUnicode(false);

            modelBuilder.Entity<VendorPaymentDetail>()
                .HasMany(e => e.VendorPaymentSubDetails)
                .WithRequired(e => e.VendorPaymentDetail)
                .HasForeignKey(e => new { e.TrDate, e.TransactionId, e.SequenceDetail, e.CountryId });

            modelBuilder.Entity<VendorPaymentHeader>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VendorPaymentHeader>()
                .Property(e => e.MainReference)
                .IsUnicode(false);

            modelBuilder.Entity<VendorPaymentHeader>()
                .Property(e => e.OptionalReference)
                .IsUnicode(false);

            modelBuilder.Entity<VendorPaymentHeader>()
                .Property(e => e.AuthorizationOfflineNumber)
                .IsUnicode(false);

            modelBuilder.Entity<VendorPaymentHeader>()
                .Property(e => e.AuthorizationNumber)
                .IsUnicode(false);

            modelBuilder.Entity<VendorPaymentHeader>()
                .Property(e => e.TerminalId)
                .IsUnicode(false);

            modelBuilder.Entity<VendorPaymentHeader>()
                .Property(e => e.PosTrId)
                .IsUnicode(false);

            modelBuilder.Entity<VendorPaymentHeader>()
                .Property(e => e.UserNumber)
                .IsUnicode(false);

            modelBuilder.Entity<VendorPaymentHeader>()
                .HasMany(e => e.VendorPaymentDetails)
                .WithRequired(e => e.VendorPaymentHeader)
                .HasForeignKey(e => new { e.TrDate, e.TransactionId, e.CountryId });

            modelBuilder.Entity<VendorPaymentSubDetail>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VendorPaymentSubDetail>()
                .Property(e => e.TagType)
                .IsUnicode(false);

            modelBuilder.Entity<VendorPaymentSubDetail>()
                .Property(e => e.Tag)
                .IsUnicode(false);

            modelBuilder.Entity<VendorPaymentSubDetail>()
                .Property(e => e.TagValue)
                .IsUnicode(false);

            modelBuilder.Entity<VendorReverseDetail>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VendorReverseDetail>()
                .Property(e => e.Tag)
                .IsUnicode(false);

            modelBuilder.Entity<VendorReverseDetail>()
                .Property(e => e.TagValue)
                .IsUnicode(false);

            modelBuilder.Entity<VendorReverseDetail>()
                .HasMany(e => e.VendorReverseSubDetails)
                .WithRequired(e => e.VendorReverseDetail)
                .HasForeignKey(e => new { e.TrDate, e.TransactionId, e.SequenceDetail, e.CountryId });

            modelBuilder.Entity<VendorReverseHeader>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VendorReverseHeader>()
                .Property(e => e.MainReference)
                .IsUnicode(false);

            modelBuilder.Entity<VendorReverseHeader>()
                .Property(e => e.OptionalReference)
                .IsUnicode(false);

            modelBuilder.Entity<VendorReverseHeader>()
                .Property(e => e.AuthorizationOfflineNumber)
                .IsUnicode(false);

            modelBuilder.Entity<VendorReverseHeader>()
                .Property(e => e.AuthorizationNumber)
                .IsUnicode(false);

            modelBuilder.Entity<VendorReverseHeader>()
                .Property(e => e.TerminalId)
                .IsUnicode(false);

            modelBuilder.Entity<VendorReverseHeader>()
                .Property(e => e.PosTrId)
                .IsUnicode(false);

            modelBuilder.Entity<VendorReverseHeader>()
                .Property(e => e.UserNumber)
                .IsUnicode(false);

            modelBuilder.Entity<VendorReverseHeader>()
                .HasMany(e => e.VendorReverseDetails)
                .WithRequired(e => e.VendorReverseHeader)
                .HasForeignKey(e => new { e.TrDate, e.TransactionId, e.CountryId });

            modelBuilder.Entity<VendorReverseSubDetail>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VendorReverseSubDetail>()
                .Property(e => e.TagType)
                .IsUnicode(false);

            modelBuilder.Entity<VendorReverseSubDetail>()
                .Property(e => e.Tag)
                .IsUnicode(false);

            modelBuilder.Entity<VendorReverseSubDetail>()
                .Property(e => e.TagValue)
                .IsUnicode(false);

            modelBuilder.Entity<VendorType>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VendorType>()
                .Property(e => e.VendorTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<VendorType>()
                .Property(e => e.CreatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<VendorType>()
                .Property(e => e.UpdatedByUsdr)
                .IsUnicode(false);

            modelBuilder.Entity<VendorType>()
                .HasMany(e => e.Vendors)
                .WithRequired(e => e.VendorType)
                .HasForeignKey(e => new { e.VendorTypeId, e.CountryId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VendorUri>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VendorUri>()
                .Property(e => e.Uri)
                .IsUnicode(false);

            modelBuilder.Entity<VendorUri>()
                .Property(e => e.Bin)
                .IsUnicode(false);

            modelBuilder.Entity<Environment>()
                .Property(e => e.NameEnvironment)
                .IsUnicode(false);

            modelBuilder.Entity<Environment>()
                .HasMany(e => e.ServicesCuriosities)
                .WithRequired(e => e.Environment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ServicesCuriosity>()
                .Property(e => e.EndPointService)
                .IsUnicode(false);

            modelBuilder.Entity<ServicesCuriosity>()
                .Property(e => e.ActionService)
                .IsUnicode(false);

            modelBuilder.Entity<ServicesModule>()
                .Property(e => e.NameModule)
                .IsUnicode(false);

            modelBuilder.Entity<ServicesModule>()
                .HasMany(e => e.ServicesCuriosities)
                .WithRequired(e => e.ServicesModule)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IncomingFile1>()
                .Property(e => e.IncomeRowId)
                .IsUnicode(false);

            modelBuilder.Entity<IncomingFile1>()
                .Property(e => e.IncomeLockerId)
                .IsUnicode(false);

            modelBuilder.Entity<IncomingFile1>()
                .Property(e => e.IncomeKeyId)
                .IsUnicode(false);

            modelBuilder.Entity<IncomingFile1>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<IncomingFile1>()
                .Property(e => e.VendorIncommingId)
                .IsUnicode(false);

            modelBuilder.Entity<IncomingFile_back>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<IncomingFile_back>()
                .Property(e => e.VendorIncommingId)
                .IsUnicode(false);

            modelBuilder.Entity<IncomingFile_back>()
                .Property(e => e.MainChain)
                .IsUnicode(false);

            modelBuilder.Entity<IncomingFileDetail>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<IncomingFileDetail>()
                .Property(e => e.VendorIncommingId)
                .IsUnicode(false);

            modelBuilder.Entity<Tbingca>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tbingca>()
                .Property(e => e.icas_importe_8)
                .HasPrecision(15, 2);

            modelBuilder.Entity<Tbingca>()
                .Property(e => e.icas_userid_0)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tbingca>()
                .Property(e => e.CreatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<Tbingca>()
                .Property(e => e.UpdatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<Tbingren>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tbingren>()
                .Property(e => e.Amount)
                .HasPrecision(15, 2);

            modelBuilder.Entity<Tbingren>()
                .Property(e => e.UserId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tbingren>()
                .Property(e => e.UpdatedDateIncome)
                .HasPrecision(0);

            modelBuilder.Entity<Tbingren>()
                .Property(e => e.UpdatedDate)
                .HasPrecision(0);

            modelBuilder.Entity<TbingrenStaging>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TbingrenStaging>()
                .Property(e => e.Amount)
                .HasPrecision(15, 2);

            modelBuilder.Entity<TbingrenStaging>()
                .Property(e => e.UserId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TbingrenStaging>()
                .Property(e => e.UpdatedDateIncome)
                .HasPrecision(0);

            modelBuilder.Entity<Tbingre>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tbingre>()
                .Property(e => e.ires_stcontab_0)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tbingre>()
                .Property(e => e.ires_autcaja_0)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tbingre>()
                .Property(e => e.ires_auttesorer_0)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tbingre>()
                .Property(e => e.ires_autpoliza_0)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tbingre>()
                .Property(e => e.UserId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tbingre>()
                .Property(e => e.AuthorizationDateIncome)
                .HasPrecision(0);

            modelBuilder.Entity<Tbingre>()
                .Property(e => e.UpdatedDate)
                .HasPrecision(0);

            modelBuilder.Entity<TbingresStaging>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TbingresStaging>()
                .Property(e => e.ires_stcontab_0)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TbingresStaging>()
                .Property(e => e.ires_autcaja_0)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TbingresStaging>()
                .Property(e => e.ires_auttesorer_0)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TbingresStaging>()
                .Property(e => e.ires_autpoliza_0)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TbingresStaging>()
                .Property(e => e.UserId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TbingresStaging>()
                .Property(e => e.AuthorizationDateIncome)
                .HasPrecision(0);

            modelBuilder.Entity<ApplicationSettingVendor>()
                .Property(e => e.VendorPosType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ApplicationSettingVendor>()
                .Property(e => e.Tag)
                .IsUnicode(false);

            modelBuilder.Entity<ApplicationSettingVendor>()
                .Property(e => e.IdentifierFileNextDay)
                .IsUnicode(false);

            modelBuilder.Entity<ApplicationSettingVendor>()
                .Property(e => e.NameFileNextDay)
                .IsUnicode(false);

            modelBuilder.Entity<ApplicationSettingVendor>()
                .Property(e => e.PathFileNextDay)
                .IsUnicode(false);

            modelBuilder.Entity<ApplicationSettingVendor>()
                .Property(e => e.PathLogNextDay)
                .IsUnicode(false);

            modelBuilder.Entity<ApplicationSettingVendor>()
                .Property(e => e.PathMoveNextDay)
                .IsUnicode(false);

            modelBuilder.Entity<ApplicationSettingVendor>()
                .Property(e => e.PathBackNextDay)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionsReportLayout>()
                .Property(e => e.ColumnLayoutObject)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionsReportLayout>()
                .Property(e => e.ColumnDescription)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionsReportLayout>()
                .HasMany(e => e.ReportsColumns)
                .WithRequired(e => e.TransactionsReportLayout)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserReport>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<UserReport>()
                .Property(e => e.ReportName)
                .IsUnicode(false);

            modelBuilder.Entity<UserReport>()
                .HasMany(e => e.ReportsColumns)
                .WithRequired(e => e.UserReport)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BrokerIncomeConfig>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BrokerIncomeConfig>()
                .Property(e => e.Value2)
                .IsUnicode(false);

            modelBuilder.Entity<BrokerIncomeConfig>()
                .Property(e => e.CreatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<BrokerIncomeConfig>()
                .Property(e => e.UpdatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<BrokerPaymentType>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BrokerPaymentType>()
                .Property(e => e.CreatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<BrokerPaymentType>()
                .Property(e => e.UpdatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<Commission1>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Commission1>()
                .Property(e => e.Sign)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Commission1>()
                .Property(e => e.Value)
                .HasPrecision(10, 4);

            modelBuilder.Entity<Commission1>()
                .Property(e => e.Iva)
                .HasPrecision(10, 4);

            modelBuilder.Entity<Commission1>()
                .Property(e => e.TrTime)
                .HasPrecision(4);

            modelBuilder.Entity<Commission1>()
                .Property(e => e.CreatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<Commission1>()
                .Property(e => e.UpdatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<Commission1>()
                .Property(e => e.TotalFee)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Commission1>()
                .Property(e => e.Total)
                .HasPrecision(10, 4);

            modelBuilder.Entity<CommissionType>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CommissionType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<CommissionType>()
                .Property(e => e.CreatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<CommissionType>()
                .Property(e => e.UpdatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<CommissionType>()
                .HasMany(e => e.SubVendorCommissions)
                .WithRequired(e => e.CommissionType)
                .HasForeignKey(e => new { e.CommissionTypeId, e.CountryId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CommissionType>()
                .HasMany(e => e.VendorCommissions)
                .WithRequired(e => e.CommissionType)
                .HasForeignKey(e => new { e.CommissionTypeId, e.CountryId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IncomeConfig>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<IncomeConfig>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<IncomeConfig>()
                .Property(e => e.CreatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<IncomeConfig>()
                .Property(e => e.UpdatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<IncomeConfig>()
                .HasMany(e => e.BrokerIncomeConfigs)
                .WithRequired(e => e.IncomeConfig)
                .HasForeignKey(e => new { e.IncomeConfigId, e.CountryId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IncomeConfig>()
                .HasMany(e => e.VendorIncomeConfigs)
                .WithRequired(e => e.IncomeConfig)
                .HasForeignKey(e => new { e.IncomeConfigId, e.CountryId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PaymentType>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PaymentType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentType>()
                .Property(e => e.CreatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentType>()
                .Property(e => e.UpdatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentType>()
                .Property(e => e.TenderTypePOS)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentType>()
                .HasMany(e => e.TenderTypes)
                .WithOptional(e => e.PaymentType)
                .HasForeignKey(e => new { e.PaymentTypeId, e.CountryId });

            modelBuilder.Entity<PaymentType>()
                .HasMany(e => e.BrokerPaymentTypes)
                .WithRequired(e => e.PaymentType)
                .HasForeignKey(e => new { e.PaymentTypeId, e.CountryId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PaymentType>()
                .HasMany(e => e.SubVendorCommissions)
                .WithRequired(e => e.PaymentType)
                .HasForeignKey(e => new { e.PaymentTypeId, e.CountryId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PaymentType>()
                .HasMany(e => e.SubVendorPaymentTypes)
                .WithRequired(e => e.PaymentType)
                .HasForeignKey(e => new { e.PaymentTypeId, e.CountryId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PaymentType>()
                .HasMany(e => e.VendorCommissions)
                .WithRequired(e => e.PaymentType)
                .HasForeignKey(e => new { e.PaymentTypeId, e.CountryId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PaymentType>()
                .HasMany(e => e.VendorPaymentTypes)
                .WithRequired(e => e.PaymentType)
                .HasForeignKey(e => new { e.PaymentTypeId, e.CountryId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PaymentTypeCat>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PaymentTypeCat>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentTypeCat>()
                .Property(e => e.CreatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentTypeCat>()
                .Property(e => e.UpdatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentTypeCat>()
                .HasMany(e => e.PaymentTypes)
                .WithRequired(e => e.PaymentTypeCat)
                .HasForeignKey(e => new { e.PaymentTypeCatId, e.CountryId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PaymentTypeCat>()
                .HasMany(e => e.PaymentTypeProviders)
                .WithRequired(e => e.PaymentTypeCat)
                .HasForeignKey(e => new { e.PaymentTypeCatId, e.CountryId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PaymentTypeProvider>()
                .Property(e => e.PaymentTypeProviderId)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentTypeProvider>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PaymentTypeProvider>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentTypeProvider>()
                .Property(e => e.CreatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentTypeProvider>()
                .Property(e => e.UpdatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentTypeProvider>()
                .HasMany(e => e.InvoiceControls)
                .WithOptional(e => e.PaymentTypeProvider)
                .HasForeignKey(e => new { e.PaymentTypeProviderId, e.CountryId });

            modelBuilder.Entity<PaymentTypeProvider>()
                .HasMany(e => e.VendorSettlements)
                .WithRequired(e => e.PaymentTypeProvider)
                .HasForeignKey(e => new { e.PaymentTypeProviderId, e.CountryId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SubVendor>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SubVendor>()
                .Property(e => e.LegalName)
                .IsUnicode(false);

            modelBuilder.Entity<SubVendor>()
                .Property(e => e.SubVendorNameShort)
                .IsUnicode(false);

            modelBuilder.Entity<SubVendor>()
                .Property(e => e.ActivityDescription)
                .IsUnicode(false);

            modelBuilder.Entity<SubVendor>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<SubVendor>()
                .Property(e => e.CreatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<SubVendor>()
                .Property(e => e.UpdatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<SubVendor>()
                .HasMany(e => e.SubVendorBins)
                .WithRequired(e => e.SubVendor)
                .HasForeignKey(e => new { e.SubVendorId, e.CountryId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SubVendor>()
                .HasMany(e => e.SubVendorCommissions)
                .WithRequired(e => e.SubVendor)
                .HasForeignKey(e => new { e.SubVendorId, e.CountryId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SubVendor>()
                .HasMany(e => e.SubVendorPaymentTypes)
                .WithRequired(e => e.SubVendor)
                .HasForeignKey(e => new { e.SubVendorId, e.CountryId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SubVendor>()
                .HasMany(e => e.SubVendorValidations)
                .WithRequired(e => e.SubVendor)
                .HasForeignKey(e => new { e.SubVendorId, e.CountryId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SubVendorBin>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SubVendorBin>()
                .Property(e => e.InitBin)
                .IsUnicode(false);

            modelBuilder.Entity<SubVendorBin>()
                .Property(e => e.EndBin)
                .IsUnicode(false);

            modelBuilder.Entity<SubVendorBin>()
                .Property(e => e.CreatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<SubVendorBin>()
                .Property(e => e.UpdatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<SubVendorCommission>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SubVendorCommission>()
                .Property(e => e.InitRange)
                .HasPrecision(10, 2);

            modelBuilder.Entity<SubVendorCommission>()
                .Property(e => e.EndRange)
                .HasPrecision(10, 2);

            modelBuilder.Entity<SubVendorCommission>()
                .Property(e => e.Value)
                .HasPrecision(10, 4);

            modelBuilder.Entity<SubVendorCommission>()
                .Property(e => e.iva)
                .HasPrecision(4, 2);

            modelBuilder.Entity<SubVendorCommission>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<SubVendorCommission>()
                .Property(e => e.EFT)
                .IsUnicode(false);

            modelBuilder.Entity<SubVendorCommission>()
                .Property(e => e.ChargeDeadline)
                .IsUnicode(false);

            modelBuilder.Entity<SubVendorCommission>()
                .Property(e => e.PaymentDeadline)
                .IsUnicode(false);

            modelBuilder.Entity<SubVendorCommission>()
                .Property(e => e.CreatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<SubVendorCommission>()
                .Property(e => e.UpdatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<SubVendorCommission>()
                .HasMany(e => e.Commission1)
                .WithRequired(e => e.SubVendorCommission)
                .HasForeignKey(e => new { e.SubVendorCommissionId, e.CountryId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SubVendorPaymentType>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SubVendorPaymentType>()
                .Property(e => e.CreatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<SubVendorPaymentType>()
                .Property(e => e.UpdatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<SubVendorValidation>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SubVendorValidation>()
                .Property(e => e.Value1)
                .IsUnicode(false);

            modelBuilder.Entity<SubVendorValidation>()
                .Property(e => e.Value2)
                .IsUnicode(false);

            modelBuilder.Entity<SubVendorValidation>()
                .Property(e => e.Value3)
                .IsUnicode(false);

            modelBuilder.Entity<SubVendorValidation>()
                .Property(e => e.Value4)
                .IsUnicode(false);

            modelBuilder.Entity<SubVendorValidation>()
                .Property(e => e.CreatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<SubVendorValidation>()
                .Property(e => e.UpdatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<Validation>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Validation>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Validation>()
                .Property(e => e.CreatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<Validation>()
                .Property(e => e.UpdatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<Validation>()
                .Property(e => e.ValuePosition)
                .IsUnicode(false);

            modelBuilder.Entity<Validation>()
                .HasMany(e => e.SubVendorValidations)
                .WithRequired(e => e.Validation)
                .HasForeignKey(e => new { e.ValidationId, e.CountryId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VendorCommission>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VendorCommission>()
                .Property(e => e.InitRange)
                .HasPrecision(10, 2);

            modelBuilder.Entity<VendorCommission>()
                .Property(e => e.EndRange)
                .HasPrecision(10, 2);

            modelBuilder.Entity<VendorCommission>()
                .Property(e => e.Value)
                .HasPrecision(10, 4);

            modelBuilder.Entity<VendorCommission>()
                .Property(e => e.iva)
                .HasPrecision(10, 4);

            modelBuilder.Entity<VendorCommission>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<VendorCommission>()
                .Property(e => e.EFT)
                .IsUnicode(false);

            modelBuilder.Entity<VendorCommission>()
                .Property(e => e.ChargeDeadline)
                .IsUnicode(false);

            modelBuilder.Entity<VendorCommission>()
                .Property(e => e.PaymentDeadline)
                .IsUnicode(false);

            modelBuilder.Entity<VendorCommission>()
                .Property(e => e.CreatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<VendorCommission>()
                .Property(e => e.UpdatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<VendorCommission>()
                .HasMany(e => e.Commissions)
                .WithRequired(e => e.VendorCommission)
                .HasForeignKey(e => new { e.VendorCommissionId, e.CountryId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VendorCompanyTmp>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VendorCompanyTmp>()
                .Property(e => e.MasterVendor)
                .IsUnicode(false);

            modelBuilder.Entity<VendorCompanyTmp>()
                .Property(e => e.ArticleNumber)
                .IsUnicode(false);

            modelBuilder.Entity<VendorCompanyTmp>()
                .Property(e => e.Department)
                .IsUnicode(false);

            modelBuilder.Entity<VendorCompanyTmp>()
                .Property(e => e.CreatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<VendorCompanyTmp>()
                .Property(e => e.UpdatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<VendorIncomeConfig>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VendorIncomeConfig>()
                .Property(e => e.Value2)
                .IsUnicode(false);

            modelBuilder.Entity<VendorIncomeConfig>()
                .Property(e => e.CreatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<VendorIncomeConfig>()
                .Property(e => e.UpdatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<VendorPaymentType>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VendorPaymentType>()
                .Property(e => e.CreatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<VendorPaymentType>()
                .Property(e => e.UpdatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<VendorSettlement>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VendorSettlement>()
                .Property(e => e.PaymentTypeProviderId)
                .IsUnicode(false);

            modelBuilder.Entity<VendorSettlement>()
                .Property(e => e.BankEntitieId)
                .IsUnicode(false);

            modelBuilder.Entity<VendorSettlement>()
                .Property(e => e.SettlementAccount)
                .IsUnicode(false);

            modelBuilder.Entity<VendorSettlement>()
                .Property(e => e.SettlementCLABE)
                .IsUnicode(false);

            modelBuilder.Entity<VendorSettlement>()
                .Property(e => e.CreatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<VendorSettlement>()
                .Property(e => e.UpdatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<VendorValidation>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VendorValidation>()
                .Property(e => e.AccountStart)
                .IsUnicode(false);

            modelBuilder.Entity<VendorValidation>()
                .Property(e => e.AccountEnd)
                .IsUnicode(false);

            modelBuilder.Entity<VendorValidation>()
                .Property(e => e.LegendPrintOnTicket)
                .IsUnicode(false);

            modelBuilder.Entity<VendorValidation>()
                .Property(e => e.CreatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<VendorValidation>()
                .Property(e => e.UpdatedByUser)
                .IsUnicode(false);

            modelBuilder.Entity<CatalogueValueTmp>()
                .Property(e => e.cval_codparam_0_)
                .IsUnicode(false);

            modelBuilder.Entity<CatalogueValueTmp>()
                .Property(e => e.cval_cvechar_0)
                .IsUnicode(false);

            modelBuilder.Entity<CatalogueValueTmp>()
                .Property(e => e.cval_valnum1_5)
                .HasPrecision(15, 3);

            modelBuilder.Entity<CatalogueValueTmp>()
                .Property(e => e.cval_valnum2_5)
                .HasPrecision(15, 3);

            modelBuilder.Entity<CatalogueValueTmp>()
                .Property(e => e.cval_valnum3_5)
                .HasPrecision(15, 3);

            modelBuilder.Entity<CatalogueValueTmp>()
                .Property(e => e.cval_valalf1_0)
                .IsUnicode(false);

            modelBuilder.Entity<CatalogueValueTmp>()
                .Property(e => e.cval_valalf2_0)
                .IsUnicode(false);

            modelBuilder.Entity<CatalogueValueTmp>()
                .Property(e => e.cval_valalf3_0)
                .IsUnicode(false);

            modelBuilder.Entity<DDLEvent>()
                .Property(e => e.HostName)
                .IsUnicode(false);

            modelBuilder.Entity<DDLEvent>()
                .Property(e => e.IPAddress)
                .IsUnicode(false);

            modelBuilder.Entity<BalanceANTADTemp>()
                .Property(e => e.CuerpoRep)
                .IsUnicode(false);

            modelBuilder.Entity<BalanceANTADTemp>()
                .Property(e => e.transactionid)
                .IsUnicode(false);

            modelBuilder.Entity<BalanceANTADTemp>()
                .Property(e => e.Recordtypeid)
                .IsUnicode(false);

            modelBuilder.Entity<BalanceGUGATemp>()
                .Property(e => e.CuerpoRep)
                .IsUnicode(false);

            modelBuilder.Entity<BalanceGUGATemp>()
                .Property(e => e.transactionid)
                .IsUnicode(false);

            modelBuilder.Entity<BalanceGUGATemp>()
                .Property(e => e.Recordtypeid)
                .IsUnicode(false);

            modelBuilder.Entity<BalancePSETemp>()
                .Property(e => e.Detail)
                .IsUnicode(false);

            modelBuilder.Entity<BalancePSETemp>()
                .Property(e => e.C1)
                .IsUnicode(false);

            modelBuilder.Entity<BalancePSETemp>()
                .Property(e => e.C2)
                .IsUnicode(false);

            modelBuilder.Entity<BalancePSETemp>()
                .Property(e => e.C3)
                .IsUnicode(false);

            modelBuilder.Entity<BalancePSETemp>()
                .Property(e => e.C4)
                .IsUnicode(false);

            modelBuilder.Entity<balanceRemunIzziTemp>()
                .Property(e => e.Detail)
                .IsUnicode(false);

            modelBuilder.Entity<balanceRemunIzziTemp>()
                .Property(e => e.C_Decim1_Amount)
                .HasPrecision(10, 6);

            modelBuilder.Entity<balanceRemunIzziTemp>()
                .Property(e => e.C_Decim2_BaseValueCom)
                .HasPrecision(10, 6);

            modelBuilder.Entity<balanceRemunIzziTemp>()
                .Property(e => e.C_Decim3_Iva)
                .HasPrecision(6, 0);

            modelBuilder.Entity<balanceRemunIzziTemp>()
                .Property(e => e.C_Decim4_CONTRAPRES)
                .HasPrecision(10, 6);

            modelBuilder.Entity<balanceRemunIzziTemp>()
                .Property(e => e.C_vc1_ReqPaymntType)
                .IsUnicode(false);

            modelBuilder.Entity<balanceRemunIzziTemp>()
                .Property(e => e.C_vc2_ProPaymntType)
                .IsUnicode(false);

            modelBuilder.Entity<balanceRemunIzziTemp>()
                .Property(e => e.C_vc3_CountryId)
                .IsUnicode(false);

            modelBuilder.Entity<LoadUTILpos>()
                .Property(e => e.BaseChain)
                .IsUnicode(false);

            modelBuilder.Entity<LoadUTILpos>()
                .Property(e => e.BaseChainType)
                .IsUnicode(false);

            modelBuilder.Entity<LoadUTILpos>()
                .Property(e => e.BaseChainStoreID)
                .IsUnicode(false);

            modelBuilder.Entity<tmpGUGAlog>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<tmpGUGAlog>()
                .Property(e => e.fechagen)
                .IsUnicode(false);

            modelBuilder.Entity<borrar_ABFC1>()
                .Property(e => e.BrokerName)
                .IsUnicode(false);

            modelBuilder.Entity<borrar_ABFC1>()
                .Property(e => e.VendorName)
                .IsUnicode(false);

            modelBuilder.Entity<borrar_ABFC1>()
                .Property(e => e.SettlementType)
                .IsUnicode(false);

            modelBuilder.Entity<borrar_ABFC1>()
                .Property(e => e.PagoMontoTotal)
                .HasPrecision(21, 2);

            modelBuilder.Entity<borrar_ABFC1>()
                .Property(e => e.TotalMontos)
                .HasPrecision(29, 2);

            modelBuilder.Entity<borrar_ABFC1>()
                .Property(e => e.TotalMontoComision)
                .HasPrecision(21, 2);

            modelBuilder.Entity<borrar_ABFC1>()
                .Property(e => e.TotalIvaComision)
                .HasPrecision(21, 2);

            modelBuilder.Entity<borrar_ABFC1>()
                .Property(e => e.TotalMontoAjustes)
                .HasPrecision(21, 2);

            modelBuilder.Entity<borrar_ABFC1>()
                .Property(e => e.TotalIvaAjustes)
                .HasPrecision(21, 2);

            modelBuilder.Entity<borrar_ABFC1>()
                .Property(e => e.TotalMontoAjustesNeg)
                .HasPrecision(21, 2);

            modelBuilder.Entity<borrar_ABFC1>()
                .Property(e => e.TotalIvaNeg)
                .HasPrecision(21, 2);

            modelBuilder.Entity<borrar_ABFC1>()
                .Property(e => e.GranTotalComision)
                .HasPrecision(23, 2);

            modelBuilder.Entity<borrar_ABFC1>()
                .Property(e => e.GranTotalComisionIva)
                .HasPrecision(23, 2);

            modelBuilder.Entity<borrar_ABFC1>()
                .Property(e => e.TotalCuentaPorPagar)
                .HasPrecision(31, 2);

            modelBuilder.Entity<borrar_ABFC1>()
                .Property(e => e.TotalCuentaPorCobrar)
                .HasPrecision(24, 2);

            modelBuilder.Entity<borrar_ABFC1>()
                .Property(e => e.PEP)
                .HasPrecision(3, 2);

            modelBuilder.Entity<borrar_ABFC1>()
                .Property(e => e.DiferenciaPago)
                .HasPrecision(32, 2);

            modelBuilder.Entity<coso1>()
                .Property(e => e.Sobretasa)
                .HasPrecision(7, 4);

            modelBuilder.Entity<PaymentType_FLEXPOS>()
                .Property(e => e.TenderTypePOS)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentType_FLEXPOS>()
                .Property(e => e.TenderTypeFLEXPOS)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionSummary_Ini>()
                .Property(e => e.PosTrId_2)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionSummary_Ini>()
                .Property(e => e.ServiceReference_2)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionSummary_Ini>()
                .Property(e => e.IsOnline)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionSummary_Ini>()
                .Property(e => e.HoraCrea)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionSummary_Ini>()
                .Property(e => e.NoCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionSummary_Ini>()
                .Property(e => e.CajeroId)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionSummary_Ini>()
                .Property(e => e.TerminalId)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionSummary_Ini>()
                .Property(e => e.EntryModeId)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionSummary_Ini>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TransactionSummary_Ini>()
                .Property(e => e.PosTrId)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionSummary_Ini>()
                .Property(e => e.ServiceReference)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionSummary20180402>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TransactionSummary20180402>()
                .Property(e => e.IpWcfCore)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionSummary20180402>()
                .Property(e => e.RequestClient)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionSummary20180402>()
                .Property(e => e.ResponseClient)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionSummary20180402>()
                .Property(e => e.RequestVendor)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionSummary20180402>()
                .Property(e => e.ResponseVendor)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionSummary20180402>()
                .Property(e => e.ErrorType)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionSummary20180402>()
                .Property(e => e.ErrorDescription)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionSummary20180402>()
                .Property(e => e.DescResponseVendor)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionSummary20180402>()
                .Property(e => e.CodeResponseVendor)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionSummary20180402>()
                .Property(e => e.TransactionTime)
                .HasPrecision(3);

            modelBuilder.Entity<TransactionSummary20180402>()
                .Property(e => e.TerminalNumber)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionSummary20180402>()
                .Property(e => e.CashierNumber)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionSummary20180402>()
                .Property(e => e.ServiceReference)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionSummary20180402>()
                .Property(e => e.EntryMode)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionSummary20180402>()
                .Property(e => e.PaymentType)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionSummary20180402>()
                .Property(e => e.PosTrId)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionSummary20180402>()
                .Property(e => e.Origen)
                .IsUnicode(false);

            modelBuilder.Entity<TransactionSummary20180402>()
                .Property(e => e.UserID)
                .IsUnicode(false);

            modelBuilder.Entity<t>()
                .Property(e => e.CountryId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t>()
                .Property(e => e.LegalName)
                .IsUnicode(false);

            modelBuilder.Entity<AntadFileTemp>()
                .Property(e => e.Detail)
                .IsUnicode(false);

            modelBuilder.Entity<AntadFileTemp>()
                .Property(e => e.C1)
                .IsUnicode(false);

            modelBuilder.Entity<AntadFileTemp>()
                .Property(e => e.C2)
                .IsUnicode(false);

            modelBuilder.Entity<AntadFileTemp>()
                .Property(e => e.C3)
                .IsUnicode(false);

            modelBuilder.Entity<AntadFileTemp>()
                .Property(e => e.C4)
                .IsUnicode(false);

            modelBuilder.Entity<AvonFile_>()
                .Property(e => e.Detail)
                .IsUnicode(false);

            modelBuilder.Entity<GenericFileTemp>()
                .Property(e => e.Detail)
                .IsUnicode(false);

            modelBuilder.Entity<GenericFileTemp>()
                .Property(e => e.C1)
                .IsUnicode(false);

            modelBuilder.Entity<GenericFileTemp>()
                .Property(e => e.C2)
                .IsUnicode(false);

            modelBuilder.Entity<GenericFileTemp>()
                .Property(e => e.C3)
                .IsUnicode(false);

            modelBuilder.Entity<GenericFileTemp>()
                .Property(e => e.C4)
                .IsUnicode(false);

            modelBuilder.Entity<OpenPayFileTemp>()
                .Property(e => e.Detail)
                .IsUnicode(false);

            modelBuilder.Entity<OpenPayFileTemp>()
                .Property(e => e.C1)
                .IsUnicode(false);

            modelBuilder.Entity<OpenPayFileTemp>()
                .Property(e => e.C2)
                .IsUnicode(false);

            modelBuilder.Entity<OpenPayFileTemp>()
                .Property(e => e.C3)
                .IsUnicode(false);

            modelBuilder.Entity<OpenPayFileTemp>()
                .Property(e => e.C4)
                .IsUnicode(false);

            modelBuilder.Entity<tmpANTADlog>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<tmpANTADlog>()
                .Property(e => e.fechagen)
                .IsUnicode(false);
        }
    }
}
