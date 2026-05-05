using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ACXBookingSystem.Entities;

public partial class ACXBookingSystemDbContext : DbContext
{
    public ACXBookingSystemDbContext()
    {
    }

    public ACXBookingSystemDbContext(DbContextOptions<ACXBookingSystemDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AccessEntryRecord> AccessEntryRecords { get; set; }

    public virtual DbSet<BookingDetail> BookingDetails { get; set; }

    public virtual DbSet<BookingGlobalSetting> BookingGlobalSettings { get; set; }

    public virtual DbSet<BookingGlobalSetting1> BookingGlobalSettings1 { get; set; }

    public virtual DbSet<BookingIndvSetting> BookingIndvSettings { get; set; }

    public virtual DbSet<BookingIndvSetting1> BookingIndvSettings1 { get; set; }

    public virtual DbSet<BuildingFloorsUnitInfo> BuildingFloorsUnitInfos { get; set; }

    public virtual DbSet<Captcha> Captchas { get; set; }

    public virtual DbSet<CompanyProfile> CompanyProfiles { get; set; }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<Meeting> Meetings { get; set; }

    public virtual DbSet<MeetingRoomTimeSlotStatus> MeetingRoomTimeSlotStatuses { get; set; }

    public virtual DbSet<Message> Messages { get; set; }

    public virtual DbSet<MessageEmail> MessageEmails { get; set; }

    public virtual DbSet<MessageSm> MessageSms { get; set; }

    public virtual DbSet<ReaderKey> ReaderKeys { get; set; }

    public virtual DbSet<Room> Rooms { get; set; }

    public virtual DbSet<Session> Sessions { get; set; }

    public virtual DbSet<TblTmpSendVisitCommand> TblTmpSendVisitCommands { get; set; }

    public virtual DbSet<Template> Templates { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<VisitRecord> VisitRecords { get; set; }

    public virtual DbSet<Visitor> Visitors { get; set; }

    public virtual DbSet<VisitorCardInfo> VisitorCardInfos { get; set; }

    public virtual DbSet<VisitorGroup> VisitorGroups { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=MorrisComputer;Database=ACXBookingSystem;User Id=sa;Password=P@ssw0rd;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Chinese_PRC_CI_AS");

        modelBuilder.Entity<AccessEntryRecord>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<BookingDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("booking_detail");

            entity.Property(e => e.AddDt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("add_dt");
            entity.Property(e => e.BookingId)
                .HasMaxLength(50)
                .HasColumnName("booking_id");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(50)
                .HasColumnName("company_id");
            entity.Property(e => e.EffectDay).HasColumnName("effect_day");
            entity.Property(e => e.Enable)
                .HasDefaultValue(false)
                .HasColumnName("enable");
            entity.Property(e => e.From).HasColumnName("from");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.RoomId)
                .HasMaxLength(50)
                .HasColumnName("room_id");
            entity.Property(e => e.TimeSlot)
                .HasMaxLength(50)
                .HasColumnName("time_slot");
            entity.Property(e => e.To).HasColumnName("to");
        });

        modelBuilder.Entity<BookingGlobalSetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("booking_global_setting");

            entity.Property(e => e.AddDt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("add_dt");
            entity.Property(e => e.BookingPeriod)
                .HasMaxLength(50)
                .HasColumnName("booking_period");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(50)
                .HasColumnName("company_id");
            entity.Property(e => e.EffectDay).HasColumnName("effect_day");
            entity.Property(e => e.From).HasColumnName("from");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.To).HasColumnName("to");
        });

        modelBuilder.Entity<BookingGlobalSetting1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BookingGlobalSetting");

            entity.Property(e => e.AddDt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("add_dt");
            entity.Property(e => e.BookingPeriod)
                .HasMaxLength(50)
                .HasColumnName("booking_period");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(50)
                .HasColumnName("company_id");
            entity.Property(e => e.EffectDay).HasColumnName("effect_day");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.ManualSet)
                .HasDefaultValue(false)
                .HasColumnName("manual_set");
        });

        modelBuilder.Entity<BookingIndvSetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("booking_indv_setting");

            entity.Property(e => e.AddDt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("add_dt");
            entity.Property(e => e.BookingPeriod)
                .HasMaxLength(50)
                .HasColumnName("booking_period");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(50)
                .HasColumnName("company_id");
            entity.Property(e => e.EffectDay).HasColumnName("effect_day");
            entity.Property(e => e.Enable).HasColumnName("enable");
            entity.Property(e => e.ExpiryDate).HasColumnName("expiry_date");
            entity.Property(e => e.From).HasColumnName("from");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.RoomId)
                .HasMaxLength(50)
                .HasColumnName("room_id");
            entity.Property(e => e.To).HasColumnName("to");
        });

        modelBuilder.Entity<BookingIndvSetting1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BookingIndvSetting");

            entity.Property(e => e.AddDt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("add_dt");
            entity.Property(e => e.BookingPeriod)
                .HasMaxLength(50)
                .HasColumnName("booking_period");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(50)
                .HasColumnName("company_id");
            entity.Property(e => e.EffectDay).HasColumnName("effect_day");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.ManualSet)
                .HasDefaultValue(false)
                .HasColumnName("manual_set");
            entity.Property(e => e.RoomId)
                .HasMaxLength(50)
                .HasColumnName("room_id");
        });

        modelBuilder.Entity<BuildingFloorsUnitInfo>(entity =>
        {
            entity.HasKey(e => new { e.BuildingCode, e.FloorNumber, e.RoomNumber });

            entity.ToTable("BuildingFloorsUnitInfo");

            entity.Property(e => e.BuildingCode)
                .HasMaxLength(30)
                .HasColumnName("Building_Code");
            entity.Property(e => e.FloorNumber).HasColumnName("Floor_Number");
            entity.Property(e => e.RoomNumber)
                .HasMaxLength(10)
                .HasColumnName("Room_number");
            entity.Property(e => e.DoorGroups).HasColumnName("Door_groups");
            entity.Property(e => e.RoomDesc)
                .HasMaxLength(30)
                .HasColumnName("Room_desc");
            entity.Property(e => e.SyncIndex).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Captcha>(entity =>
        {
            entity.HasKey(e => e.Random).HasName("PK_captcha_1");

            entity.ToTable("captcha");

            entity.Property(e => e.Random)
                .HasMaxLength(50)
                .HasColumnName("random");
            entity.Property(e => e.AddDt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("add_dt");
            entity.Property(e => e.Captcha1)
                .HasMaxLength(50)
                .HasColumnName("captcha");
            entity.Property(e => e.RemoteEndpoint)
                .HasMaxLength(256)
                .HasColumnName("remote_endpoint");
        });

        modelBuilder.Entity<CompanyProfile>(entity =>
        {
            entity.HasKey(e => e.CompanyId);

            entity.ToTable("company_profile");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(50)
                .HasColumnName("company_id");
            entity.Property(e => e.EmailPassword)
                .HasMaxLength(50)
                .HasColumnName("email_password");
            entity.Property(e => e.EmailUser)
                .HasMaxLength(50)
                .HasColumnName("email_user");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.SendEmail)
                .HasDefaultValue(false)
                .HasColumnName("send_email");
            entity.Property(e => e.SmtpEnableSsl)
                .HasDefaultValue(true)
                .HasColumnName("smtp_enable_ssl");
            entity.Property(e => e.SmtpPort).HasColumnName("smtp_port");
            entity.Property(e => e.SmtpServer)
                .HasMaxLength(50)
                .HasColumnName("smtp_server");
        });

        modelBuilder.Entity<Group>(entity =>
        {
            entity.HasKey(e => e.GroupId);

            entity.ToTable("group");

            entity.Property(e => e.GroupId)
                .HasMaxLength(150)
                .HasColumnName("group_id");
            entity.Property(e => e.AddDt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("add_dt");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(50)
                .HasColumnName("company_id");
            entity.Property(e => e.GroupName)
                .HasMaxLength(50)
                .HasColumnName("group_name");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<Meeting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("meeting");

            entity.Property(e => e.AccessExpiryDatetime)
                .HasColumnType("datetime")
                .HasColumnName("access_expiry_datetime");
            entity.Property(e => e.AddDt)
                .HasColumnType("datetime")
                .HasColumnName("add_dt");
            entity.Property(e => e.AddUser)
                .HasMaxLength(50)
                .HasColumnName("add_user");
            entity.Property(e => e.BookingPeriod)
                .HasMaxLength(50)
                .HasColumnName("booking_period");
            entity.Property(e => e.BookingPeriodDetail).HasColumnName("booking_period_detail");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(50)
                .HasColumnName("company_id");
            entity.Property(e => e.EntryAccessDatetime)
                .HasColumnType("datetime")
                .HasColumnName("entry_access_datetime");
            entity.Property(e => e.From)
                .HasColumnType("datetime")
                .HasColumnName("from");
            entity.Property(e => e.HostName)
                .HasMaxLength(100)
                .HasColumnName("host_name");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.MeetingId)
                .HasMaxLength(50)
                .HasColumnName("meeting_id");
            entity.Property(e => e.MeetingTitle)
                .HasMaxLength(50)
                .HasColumnName("meeting_title");
            entity.Property(e => e.RoomId)
                .HasMaxLength(1024)
                .HasColumnName("room_id");
            entity.Property(e => e.To)
                .HasColumnType("datetime")
                .HasColumnName("to");
        });

        modelBuilder.Entity<MeetingRoomTimeSlotStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("meeting_room_time_slot_status");

            entity.Property(e => e.AddDt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("add_dt");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(50)
                .HasColumnName("company_id");
            entity.Property(e => e.EffectDate).HasColumnName("effect_date");
            entity.Property(e => e.Enable)
                .HasDefaultValue(true)
                .HasColumnName("enable");
            entity.Property(e => e.From).HasColumnName("from");
            entity.Property(e => e.GlobalSettingId).HasColumnName("global_setting_id");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.IndvSettingId).HasColumnName("indv_setting_id");
            entity.Property(e => e.RoomId)
                .HasMaxLength(50)
                .HasColumnName("room_id");
            entity.Property(e => e.To).HasColumnName("to");
        });

        modelBuilder.Entity<Message>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("message");

            entity.Property(e => e.AddDt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("add_dt");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.MessageContent)
                .HasMaxLength(1000)
                .HasColumnName("message_content");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("type");
        });

        modelBuilder.Entity<MessageEmail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("message_email");

            entity.Property(e => e.AddDt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("add_dt");
            entity.Property(e => e.CardNo)
                .HasMaxLength(50)
                .HasColumnName("card_no");
            entity.Property(e => e.Company)
                .HasMaxLength(50)
                .HasColumnName("company");
            entity.Property(e => e.Content)
                .HasColumnType("text")
                .HasColumnName("content");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasColumnName("name");
            entity.Property(e => e.RecvEmail)
                .HasMaxLength(500)
                .HasColumnName("recv_email");
            entity.Property(e => e.SendStatus)
                .HasMaxLength(1024)
                .HasColumnName("send_status");
            entity.Property(e => e.Success).HasColumnName("success");
            entity.Property(e => e.UpdDt)
                .HasColumnType("datetime")
                .HasColumnName("upd_dt");
        });

        modelBuilder.Entity<MessageSm>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("message_sms");

            entity.Property(e => e.AddDt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("add_dt");
            entity.Property(e => e.CardNo)
                .HasMaxLength(50)
                .HasColumnName("card_no");
            entity.Property(e => e.Company)
                .HasMaxLength(50)
                .HasColumnName("company");
            entity.Property(e => e.Content)
                .HasColumnType("text")
                .HasColumnName("content");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasColumnName("name");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(50)
                .HasColumnName("phone_number");
            entity.Property(e => e.SendStatus)
                .HasMaxLength(1024)
                .HasColumnName("send_status");
            entity.Property(e => e.Success).HasColumnName("success");
            entity.Property(e => e.UpdDt)
                .HasColumnType("datetime")
                .HasColumnName("upd_dt");
        });

        modelBuilder.Entity<ReaderKey>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("reader_key");

            entity.Property(e => e.AddDt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("add_dt");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.ReaderKey1)
                .HasMaxLength(50)
                .HasColumnName("reader_key_1");
            entity.Property(e => e.ReaderKey2)
                .HasMaxLength(50)
                .HasColumnName("reader_key_2");
            entity.Property(e => e.UpdDt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("upd_dt");
        });

        modelBuilder.Entity<Room>(entity =>
        {
            entity.HasKey(e => new { e.CompanyId, e.RoomId });

            entity.ToTable("room");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(50)
                .HasColumnName("company_id");
            entity.Property(e => e.RoomId)
                .HasMaxLength(50)
                .HasColumnName("room_id");
            entity.Property(e => e.AcxDoorController)
                .HasMaxLength(50)
                .HasColumnName("acx_door_controller");
            entity.Property(e => e.AddDt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("add_dt");
            entity.Property(e => e.EnableBooking)
                .HasDefaultValue(false)
                .HasColumnName("enable_booking");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.RoomDetails)
                .HasMaxLength(256)
                .HasColumnName("room_details");
        });

        modelBuilder.Entity<Session>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("session");

            entity.Property(e => e.AddDt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("add_dt");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(50)
                .HasColumnName("company_id");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.SeseionToken)
                .HasMaxLength(500)
                .HasColumnName("seseion_token");
            entity.Property(e => e.UpdDt)
                .HasColumnType("datetime")
                .HasColumnName("upd_dt");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .HasColumnName("user_name");
        });

        modelBuilder.Entity<TblTmpSendVisitCommand>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_VisitCommand");

            entity.ToTable("tbl_tmp_SendVisitCommand");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddDt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("add_dt");
            entity.Property(e => e.AllowedTimes).HasColumnName("Allowed_times");
            entity.Property(e => e.BookingFrom)
                .HasColumnType("datetime")
                .HasColumnName("Booking_from");
            entity.Property(e => e.BookingTo)
                .HasColumnType("datetime")
                .HasColumnName("Booking_to");
            entity.Property(e => e.CardId)
                .HasMaxLength(20)
                .HasColumnName("Card_id");
            entity.Property(e => e.CardType).HasColumnName("card_type");
            entity.Property(e => e.DefaultFoor)
                .HasMaxLength(100)
                .HasDefaultValueSql("((1))")
                .HasColumnName("Default_foor");
            entity.Property(e => e.Floor)
                .HasMaxLength(50)
                .HasColumnName("floor");
            entity.Property(e => e.Gender).HasColumnName("gender");
            entity.Property(e => e.GuidId).HasColumnName("Guid_id");
            entity.Property(e => e.MeetingRoom).HasColumnType("text");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Status).HasMaxLength(15);
            entity.Property(e => e.SystemVersion).HasMaxLength(100);
            entity.Property(e => e.TenantId)
                .HasMaxLength(50)
                .HasColumnName("Tenant_id");
            entity.Property(e => e.Tower)
                .HasMaxLength(50)
                .HasColumnName("tower");
            entity.Property(e => e.Unit)
                .HasMaxLength(50)
                .HasColumnName("unit");
        });

        modelBuilder.Entity<Template>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("template");

            entity.Property(e => e.AddDt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("add_dt");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(50)
                .HasColumnName("company_id");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Template1)
                .HasColumnType("text")
                .HasColumnName("template");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("type");
            entity.Property(e => e.UpdDt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("upd_dt");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("user");

            entity.Property(e => e.AddDt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("add_dt");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(50)
                .HasColumnName("company_id");
            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .HasColumnName("department");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.ExpiryDatetime)
                .HasColumnType("datetime")
                .HasColumnName("expiry_datetime");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(128)
                .HasColumnName("password");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .HasColumnName("phone");
            entity.Property(e => e.UserLevel)
                .HasMaxLength(50)
                .HasColumnName("user_level");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .HasColumnName("user_name");
        });

        modelBuilder.Entity<VisitRecord>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddDt)
                .HasColumnType("datetime")
                .HasColumnName("Add_dt");
            entity.Property(e => e.BookingFromTime)
                .HasColumnType("datetime")
                .HasColumnName("Booking_from_time");
            entity.Property(e => e.BookingToTime)
                .HasColumnType("datetime")
                .HasColumnName("Booking_to_time");
            entity.Property(e => e.CardId)
                .HasMaxLength(20)
                .HasColumnName("Card_id");
            entity.Property(e => e.Company).HasMaxLength(100);
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(30)
                .HasColumnName("Email_address");
            entity.Property(e => e.EnatranceAccessDatetime).HasColumnType("datetime");
            entity.Property(e => e.ExpiryDatetime).HasColumnType("datetime");
            entity.Property(e => e.Floor)
                .HasMaxLength(50)
                .HasColumnName("floor");
            entity.Property(e => e.GuidId).HasColumnName("Guid_id");
            entity.Property(e => e.HomeId)
                .HasMaxLength(50)
                .HasColumnName("Home_id");
            entity.Property(e => e.Interviewer).HasMaxLength(20);
            entity.Property(e => e.InterviewerDepartment)
                .HasMaxLength(100)
                .HasColumnName("Interviewer_department");
            entity.Property(e => e.InterviewerEmailAddress)
                .HasMaxLength(30)
                .HasColumnName("Interviewer_email_address");
            entity.Property(e => e.InterviewerTelNo)
                .HasMaxLength(30)
                .HasColumnName("Interviewer_tel_no");
            entity.Property(e => e.IsUpdate).HasDefaultValue(false);
            entity.Property(e => e.MeetingRoom).HasMaxLength(100);
            entity.Property(e => e.Purpose).HasMaxLength(100);
            entity.Property(e => e.QrCode).HasMaxLength(2048);
            entity.Property(e => e.Reception).HasDefaultValue(0);
            entity.Property(e => e.Room).HasMaxLength(10);
            entity.Property(e => e.ScambleQrCodeUid)
                .HasMaxLength(128)
                .HasColumnName("scamble_qr_code_uid");
            entity.Property(e => e.Sigunature).HasColumnType("image");
            entity.Property(e => e.StaffId)
                .HasMaxLength(20)
                .HasColumnName("Staff_id");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.SystemVersion).HasMaxLength(100);
            entity.Property(e => e.TelNo)
                .HasMaxLength(20)
                .HasColumnName("Tel_no");
            entity.Property(e => e.TenantCompany)
                .HasMaxLength(100)
                .HasColumnName("Tenant_company");
            entity.Property(e => e.TenantId)
                .HasMaxLength(50)
                .HasColumnName("Tenant_id");
            entity.Property(e => e.Tower)
                .HasMaxLength(50)
                .HasColumnName("tower");
            entity.Property(e => e.TxNo)
                .HasMaxLength(50)
                .HasColumnName("tx_no");
            entity.Property(e => e.Unit)
                .HasMaxLength(50)
                .HasColumnName("unit");
            entity.Property(e => e.VisitEnterTime)
                .HasColumnType("datetime")
                .HasColumnName("Visit_Enter_Time");
            entity.Property(e => e.VisitLeaveTime)
                .HasColumnType("datetime")
                .HasColumnName("Visit_Leave_Time");
            entity.Property(e => e.VisitorName)
                .HasMaxLength(100)
                .HasColumnName("Visitor_name");
            entity.Property(e => e.VisitorPhoto)
                .HasColumnType("image")
                .HasColumnName("Visitor_photo");
        });

        modelBuilder.Entity<Visitor>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("visitor");

            entity.Property(e => e.AddDt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("add_dt");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(50)
                .HasColumnName("company_id");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(50)
                .HasColumnName("company_name");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Mobile)
                .HasMaxLength(20)
                .HasColumnName("mobile");
            entity.Property(e => e.UpdDt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("upd_dt");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("user_id");
            entity.Property(e => e.VisitorName)
                .HasMaxLength(50)
                .HasColumnName("visitor_name");
        });

        modelBuilder.Entity<VisitorCardInfo>(entity =>
        {
            entity.HasKey(e => e.TxNo);

            entity.ToTable("visitor_card_info");

            entity.Property(e => e.TxNo)
                .ValueGeneratedNever()
                .HasColumnName("tx_no");
            entity.Property(e => e.AddDt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("add_dt");
            entity.Property(e => e.BookingId)
                .HasMaxLength(50)
                .HasColumnName("booking_id");
            entity.Property(e => e.Building)
                .HasMaxLength(60)
                .HasColumnName("building");
            entity.Property(e => e.CardId)
                .HasMaxLength(50)
                .HasColumnName("card_id");
            entity.Property(e => e.Floor)
                .HasMaxLength(200)
                .HasColumnName("floor");
            entity.Property(e => e.From)
                .HasColumnType("datetime")
                .HasColumnName("from");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasColumnName("name");
            entity.Property(e => e.QrCode)
                .HasMaxLength(512)
                .HasColumnName("qr_code");
            entity.Property(e => e.ScambleQrCodeClientToken)
                .HasMaxLength(128)
                .HasColumnName("scamble_qr_code_client_token");
            entity.Property(e => e.ScambleQrCodeUid)
                .HasMaxLength(128)
                .HasColumnName("scamble_qr_code_uid");
            entity.Property(e => e.To)
                .HasColumnType("datetime")
                .HasColumnName("to");
            entity.Property(e => e.Unit)
                .HasMaxLength(10)
                .HasColumnName("unit");
            entity.Property(e => e.UpdDt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("upd_dt");
        });

        modelBuilder.Entity<VisitorGroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("visitor_group");

            entity.Property(e => e.AddDt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("add_dt");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(50)
                .HasColumnName("company_id");
            entity.Property(e => e.GroupId)
                .HasMaxLength(150)
                .HasColumnName("group_id");
            entity.Property(e => e.GroupName)
                .HasMaxLength(50)
                .HasColumnName("group_name");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("user_id");
            entity.Property(e => e.VisitorId).HasColumnName("visitor_id");
            entity.Property(e => e.VisitorName)
                .HasMaxLength(200)
                .HasColumnName("visitor_name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
