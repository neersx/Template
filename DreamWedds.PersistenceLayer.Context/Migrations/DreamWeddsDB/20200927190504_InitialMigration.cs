using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DreamWedds.PersistenceLayer.Repository.Migrations.DreamWeddsDB
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanyMaster",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    DivisionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyMaster", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DreamWeddsBlogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogName = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true),
                    Quote = table.Column<string>(nullable: true),
                    AuthorName = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    SpecialNote = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DreamWeddsBlogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ECampaigns",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true),
                    LogoUrl = table.Column<string>(nullable: true),
                    TemplateId = table.Column<int>(nullable: false),
                    Content = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CategoryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ECampaigns", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmailServices",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TemplateId = table.Column<int>(nullable: false),
                    FromEmail = table.Column<string>(nullable: true),
                    FromName = table.Column<string>(nullable: true),
                    ToName = table.Column<string>(nullable: true),
                    ToEmail = table.Column<string>(nullable: true),
                    CcEmail = table.Column<string>(nullable: true),
                    BccEmail = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true),
                    Mobile = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    IsHtml = table.Column<bool>(nullable: false),
                    Priority = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    IsAttachment = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    AttachmentFileName = table.Column<string>(nullable: true),
                    Remarks = table.Column<string>(nullable: true),
                    TemplateCode = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailServices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FAQs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(nullable: true),
                    Answer = table.Column<string>(nullable: true),
                    Website = table.Column<string>(nullable: true),
                    IsMainQue = table.Column<bool>(nullable: false),
                    Sequence = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FAQs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleMaster",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    IsAdmin = table.Column<bool>(nullable: false),
                    RoleDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleMaster", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubscriptionMasters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubsType = table.Column<int>(nullable: false),
                    SubsName = table.Column<string>(nullable: true),
                    SubsCode = table.Column<string>(nullable: true),
                    Days = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionMasters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TemplateMasters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TemplateName = table.Column<string>(nullable: true),
                    TemplateType = table.Column<int>(nullable: false),
                    TemplateStatus = table.Column<int>(nullable: false),
                    TemplateContent = table.Column<string>(nullable: true),
                    TemplateSubject = table.Column<string>(nullable: true),
                    TemplateTags = table.Column<string>(nullable: true),
                    TemplateUrl = table.Column<string>(nullable: true),
                    TemplateFolderPath = table.Column<string>(nullable: true),
                    ThumbnailImageUrl = table.Column<string>(nullable: true),
                    TagLine = table.Column<string>(nullable: true),
                    Cost = table.Column<int>(nullable: true),
                    AuthorName = table.Column<string>(nullable: true),
                    AboutTemplate = table.Column<string>(nullable: true),
                    Features = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    TemplateCode = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemplateMasters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Weddings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WeddingDate = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    WeddingStyle = table.Column<int>(nullable: false),
                    IconUrl = table.Column<string>(nullable: true),
                    TemplateId = table.Column<int>(nullable: true),
                    IsLoveMarriage = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: true),
                    BackgroundImage = table.Column<string>(nullable: true),
                    Quote = table.Column<string>(nullable: true),
                    FbPageUrl = table.Column<string>(nullable: true),
                    VideoUrl = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weddings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserMasters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    EmpCode = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    AccountStatus = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: true),
                    SeniorEmpId = table.Column<int>(nullable: true),
                    IsEmployee = table.Column<bool>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Mobile = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMasters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserMasters_CompanyMaster_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "CompanyMaster",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleModule",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    RoleId = table.Column<int>(nullable: false),
                    ModuleId = table.Column<int>(nullable: false),
                    Sequence = table.Column<int>(nullable: false),
                    IsMandatory = table.Column<bool>(nullable: false),
                    RoleMasterId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleModule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleModule_RoleMaster_RoleMasterId",
                        column: x => x.RoleMasterId,
                        principalTable: "RoleMaster",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TemplateImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageName = table.Column<string>(nullable: true),
                    ImageTitle = table.Column<string>(nullable: true),
                    ImageTagLine = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    ImageFolderPath = table.Column<string>(nullable: true),
                    IsBannerImage = table.Column<bool>(nullable: false),
                    TemplateId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    ImageType = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemplateImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TemplateImages_TemplateMasters_TemplateId",
                        column: x => x.TemplateId,
                        principalTable: "TemplateMasters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TemplateMergeFields",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MergefieldName = table.Column<string>(nullable: true),
                    SrcField = table.Column<string>(nullable: true),
                    SrcFieldValue = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    TemplateId = table.Column<int>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Sequence = table.Column<int>(nullable: true),
                    TemplateCode = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemplateMergeFields", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TemplateMergeFields_TemplateMasters_TemplateId",
                        column: x => x.TemplateId,
                        principalTable: "TemplateMasters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TemplatePages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PageName = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    PageContent = table.Column<string>(nullable: true),
                    PageUrl = table.Column<string>(nullable: true),
                    PageFolderPath = table.Column<string>(nullable: true),
                    ThumbnailImageUrl = table.Column<string>(nullable: true),
                    TemplateId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemplatePages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TemplatePages_TemplateMasters_TemplateId",
                        column: x => x.TemplateId,
                        principalTable: "TemplateMasters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DailyLoginHistory",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: true),
                    CustomerId = table.Column<int>(nullable: true),
                    SessionId = table.Column<string>(nullable: true),
                    IpAddress = table.Column<string>(nullable: true),
                    BrowserName = table.Column<string>(nullable: true),
                    LoginType = table.Column<int>(nullable: true),
                    LogOutTime = table.Column<DateTime>(nullable: true),
                    LoginTime = table.Column<DateTime>(nullable: true),
                    IsLogin = table.Column<bool>(nullable: false),
                    ApkDeviceName = table.Column<string>(nullable: true),
                    Apkversion = table.Column<string>(nullable: true),
                    Lattitude = table.Column<string>(nullable: true),
                    Longitude = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyLoginHistory", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DailyLoginHistory_UserMasters_UserId",
                        column: x => x.UserId,
                        principalTable: "UserMasters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderMasters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    RequiredDate = table.Column<DateTime>(nullable: true),
                    OrderStatus = table.Column<string>(nullable: true),
                    AddressId = table.Column<string>(nullable: true),
                    Cgst = table.Column<int>(nullable: true),
                    Sgst = table.Column<int>(nullable: true),
                    Discount = table.Column<int>(nullable: true),
                    Amount = table.Column<decimal>(nullable: false),
                    ReceivedAmount = table.Column<decimal>(nullable: true),
                    PaymentMode = table.Column<int>(nullable: true),
                    PaymentTerms = table.Column<string>(nullable: true),
                    OderNote = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderMasters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderMasters_UserMasters_UserId",
                        column: x => x.UserId,
                        principalTable: "UserMasters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    RoleId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRoles_RoleMaster_RoleId",
                        column: x => x.RoleId,
                        principalTable: "RoleMaster",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_UserMasters_UserId",
                        column: x => x.UserId,
                        principalTable: "UserMasters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Discount = table.Column<int>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    OrderId = table.Column<int>(nullable: false),
                    TemplateId = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    SubscrptionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_OrderMasters_OrderId",
                        column: x => x.OrderId,
                        principalTable: "OrderMasters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_SubscriptionMasters_SubscrptionId",
                        column: x => x.SubscrptionId,
                        principalTable: "SubscriptionMasters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderDetails_TemplateMasters_TemplateId",
                        column: x => x.TemplateId,
                        principalTable: "TemplateMasters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserWeddingSubscriptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    TemplateId = table.Column<int>(nullable: false),
                    OrderNo = table.Column<int>(nullable: true),
                    WeddingId = table.Column<int>(nullable: true),
                    SubscriptionType = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: true),
                    EndDate = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    ReasonOfUpdate = table.Column<string>(nullable: true),
                    SubscriptionStatus = table.Column<int>(nullable: false),
                    InvoiceNoNavigationId = table.Column<int>(nullable: true),
                    SubscriptionTypeNavigationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserWeddingSubscriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserWeddingSubscriptions_OrderMasters_InvoiceNoNavigationId",
                        column: x => x.InvoiceNoNavigationId,
                        principalTable: "OrderMasters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserWeddingSubscriptions_SubscriptionMasters_SubscriptionTypeNavigationId",
                        column: x => x.SubscriptionTypeNavigationId,
                        principalTable: "SubscriptionMasters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserWeddingSubscriptions_TemplateMasters_TemplateId",
                        column: x => x.TemplateId,
                        principalTable: "TemplateMasters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserWeddingSubscriptions_Weddings_WeddingId",
                        column: x => x.WeddingId,
                        principalTable: "Weddings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DailyLoginHistory_UserId",
                table: "DailyLoginHistory",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_SubscrptionId",
                table: "OrderDetails",
                column: "SubscrptionId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_TemplateId",
                table: "OrderDetails",
                column: "TemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderMasters_UserId",
                table: "OrderMasters",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleModule_RoleMasterId",
                table: "RoleModule",
                column: "RoleMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_TemplateImages_TemplateId",
                table: "TemplateImages",
                column: "TemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_TemplateMergeFields_TemplateId",
                table: "TemplateMergeFields",
                column: "TemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_TemplatePages_TemplateId",
                table: "TemplatePages",
                column: "TemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMasters_CompanyId",
                table: "UserMasters",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserWeddingSubscriptions_InvoiceNoNavigationId",
                table: "UserWeddingSubscriptions",
                column: "InvoiceNoNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_UserWeddingSubscriptions_SubscriptionTypeNavigationId",
                table: "UserWeddingSubscriptions",
                column: "SubscriptionTypeNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_UserWeddingSubscriptions_TemplateId",
                table: "UserWeddingSubscriptions",
                column: "TemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_UserWeddingSubscriptions_WeddingId",
                table: "UserWeddingSubscriptions",
                column: "WeddingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DailyLoginHistory");

            migrationBuilder.DropTable(
                name: "DreamWeddsBlogs");

            migrationBuilder.DropTable(
                name: "ECampaigns");

            migrationBuilder.DropTable(
                name: "EmailServices");

            migrationBuilder.DropTable(
                name: "FAQs");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "RoleModule");

            migrationBuilder.DropTable(
                name: "TemplateImages");

            migrationBuilder.DropTable(
                name: "TemplateMergeFields");

            migrationBuilder.DropTable(
                name: "TemplatePages");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserWeddingSubscriptions");

            migrationBuilder.DropTable(
                name: "RoleMaster");

            migrationBuilder.DropTable(
                name: "OrderMasters");

            migrationBuilder.DropTable(
                name: "SubscriptionMasters");

            migrationBuilder.DropTable(
                name: "TemplateMasters");

            migrationBuilder.DropTable(
                name: "Weddings");

            migrationBuilder.DropTable(
                name: "UserMasters");

            migrationBuilder.DropTable(
                name: "CompanyMaster");
        }
    }
}
