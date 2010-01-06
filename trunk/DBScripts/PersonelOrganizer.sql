USE [PersonelOrganizerDb]
GO
/****** Object:  Table [dbo].[TT_INCOME_CATEGORY]    Script Date: 01/06/2010 18:50:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TT_INCOME_CATEGORY]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TT_INCOME_CATEGORY](
	[IncomeCategoryID] [int] IDENTITY(1,1) NOT NULL,
	[IncomeCategoryName] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_TT_INCOME_CATEGORY] PRIMARY KEY CLUSTERED 
(
	[IncomeCategoryID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[TT_FREQUENCY]    Script Date: 01/06/2010 18:50:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TT_FREQUENCY]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TT_FREQUENCY](
	[FrequencyID] [int] IDENTITY(1,1) NOT NULL,
	[FrequencyName] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_TT_FREQUENCY] PRIMARY KEY CLUSTERED 
(
	[FrequencyID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[TT_EXPENSE_CATEGORY]    Script Date: 01/06/2010 18:50:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TT_EXPENSE_CATEGORY]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TT_EXPENSE_CATEGORY](
	[ExpenseCategoryID] [int] IDENTITY(1,1) NOT NULL,
	[ExpenseCategoryName] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_TT_EXPENSE_CATEGORY] PRIMARY KEY CLUSTERED 
(
	[ExpenseCategoryID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[TT_BANK]    Script Date: 01/06/2010 18:50:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TT_BANK]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TT_BANK](
	[BankID] [int] IDENTITY(1,1) NOT NULL,
	[BankName] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_TT_BANK] PRIMARY KEY CLUSTERED 
(
	[BankID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[INSTALLMENT]    Script Date: 01/06/2010 18:50:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[INSTALLMENT]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[INSTALLMENT](
	[InstallmentID] [uniqueidentifier] NOT NULL,
	[NumberOfInstallment] [int] NULL,
	[TotalAmount] [money] NULL,
 CONSTRAINT [PK_INSTALLMENT] PRIMARY KEY CLUSTERED 
(
	[InstallmentID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[PO_USER]    Script Date: 01/06/2010 18:50:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PO_USER]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PO_USER](
	[UserID] [uniqueidentifier] NOT NULL,
	[UserName] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](100) NOT NULL,
	[Name] [varchar](200) NULL,
	[Surname] [varchar](200) NULL,
 CONSTRAINT [PK_USER] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CREDIT_CARD]    Script Date: 01/06/2010 18:50:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CREDIT_CARD]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CREDIT_CARD](
	[CreditCardID] [uniqueidentifier] NOT NULL,
	[UserID] [uniqueidentifier] NOT NULL,
	[BankID] [int] NOT NULL,
	[CardNumber] [nvarchar](25) NOT NULL,
	[Limit] [money] NULL,
	[CurrentIssueDate] [datetime] NULL,
	[FutureIssueDate] [datetime] NULL,
	[CurrentDueDate] [datetime] NULL,
	[FutureDueDate] [datetime] NULL,
 CONSTRAINT [PK_CREDIT_CARD] PRIMARY KEY CLUSTERED 
(
	[CreditCardID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[CONTACT]    Script Date: 01/06/2010 18:50:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CONTACT]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CONTACT](
	[ContactID] [uniqueidentifier] NOT NULL,
	[UserID] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Surname] [nvarchar](100) NULL,
	[Company] [nvarchar](300) NULL,
 CONSTRAINT [PK_CONTACT] PRIMARY KEY CLUSTERED 
(
	[ContactID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[INCOME]    Script Date: 01/06/2010 18:50:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[INCOME]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[INCOME](
	[IncomeID] [uniqueidentifier] NOT NULL,
	[UserID] [uniqueidentifier] NOT NULL,
	[Subject] [nvarchar](100) NULL,
	[Date] [datetime] NULL,
	[Amount] [money] NULL,
	[IncomeCategoryID] [int] NULL,
 CONSTRAINT [PK_INCOME] PRIMARY KEY CLUSTERED 
(
	[IncomeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[EXPENSE_BILL]    Script Date: 01/06/2010 18:50:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EXPENSE_BILL]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[EXPENSE_BILL](
	[ExpenseBillID] [uniqueidentifier] NOT NULL,
	[UserID] [uniqueidentifier] NOT NULL,
	[Subject] [nvarchar](100) NULL,
	[DueDate] [datetime] NULL,
	[Amount] [money] NULL,
	[ExpenseCategory] [int] NULL,
	[CreditCardID] [uniqueidentifier] NULL,
	[InstallmentID] [uniqueidentifier] NULL,
 CONSTRAINT [PK_EXPENSE_BILL] PRIMARY KEY CLUSTERED 
(
	[ExpenseBillID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[EVENT]    Script Date: 01/06/2010 18:50:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EVENT]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[EVENT](
	[EventID] [uniqueidentifier] NOT NULL,
	[UserID] [uniqueidentifier] NOT NULL,
	[Subject] [nvarchar](200) NULL,
	[Location] [nvarchar](100) NULL,
	[StartDateTime] [datetime] NULL,
	[Duration] [int] NULL,
	[Note] [nvarchar](500) NULL,
	[Frequency] [int] NULL,
	[NumberOfOccurence] [int] NULL,
 CONSTRAINT [PK_EVENT] PRIMARY KEY CLUSTERED 
(
	[EventID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[WEBPAGE]    Script Date: 01/06/2010 18:50:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[WEBPAGE]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[WEBPAGE](
	[WebPageID] [uniqueidentifier] NOT NULL,
	[ContactID] [uniqueidentifier] NOT NULL,
	[WebPageAddress] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_WEBPAGE] PRIMARY KEY CLUSTERED 
(
	[WebPageID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[EMAIL]    Script Date: 01/06/2010 18:50:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EMAIL]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[EMAIL](
	[EmailID] [uniqueidentifier] NOT NULL,
	[ContactID] [uniqueidentifier] NOT NULL,
	[EmailAddress] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_EMAIL] PRIMARY KEY CLUSTERED 
(
	[EmailID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[POSTAL_ADDRESS]    Script Date: 01/06/2010 18:50:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[POSTAL_ADDRESS]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[POSTAL_ADDRESS](
	[PostalAddressID] [uniqueidentifier] NOT NULL,
	[ContactID] [uniqueidentifier] NOT NULL,
	[PostalAddress] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_POSTAL_ADDRESS] PRIMARY KEY CLUSTERED 
(
	[PostalAddressID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[PHONE_NUMBER]    Script Date: 01/06/2010 18:50:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PHONE_NUMBER]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PHONE_NUMBER](
	[PhoneNumberID] [uniqueidentifier] NOT NULL,
	[ContactID] [uniqueidentifier] NOT NULL,
	[PhoneNumber] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_PHONE_NUMBER] PRIMARY KEY CLUSTERED 
(
	[PhoneNumberID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[APPOINTMENT]    Script Date: 01/06/2010 18:50:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[APPOINTMENT]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[APPOINTMENT](
	[AppointmentID] [uniqueidentifier] NOT NULL,
	[UserID] [uniqueidentifier] NOT NULL,
	[ContactID] [uniqueidentifier] NOT NULL,
	[EventID] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_APPOINTMENT] PRIMARY KEY CLUSTERED 
(
	[AppointmentID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Default [DF_APPOINTMENT_AppointmentID]    Script Date: 01/06/2010 18:50:20 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_APPOINTMENT_AppointmentID]') AND parent_object_id = OBJECT_ID(N'[dbo].[APPOINTMENT]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_APPOINTMENT_AppointmentID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[APPOINTMENT] ADD  CONSTRAINT [DF_APPOINTMENT_AppointmentID]  DEFAULT (newid()) FOR [AppointmentID]
END


End
GO
/****** Object:  Default [DF_CONTACT_ContactID]    Script Date: 01/06/2010 18:50:20 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_CONTACT_ContactID]') AND parent_object_id = OBJECT_ID(N'[dbo].[CONTACT]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_CONTACT_ContactID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[CONTACT] ADD  CONSTRAINT [DF_CONTACT_ContactID]  DEFAULT (newid()) FOR [ContactID]
END


End
GO
/****** Object:  Default [DF_CREDIT_CARD_CreditCardID]    Script Date: 01/06/2010 18:50:20 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_CREDIT_CARD_CreditCardID]') AND parent_object_id = OBJECT_ID(N'[dbo].[CREDIT_CARD]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_CREDIT_CARD_CreditCardID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[CREDIT_CARD] ADD  CONSTRAINT [DF_CREDIT_CARD_CreditCardID]  DEFAULT (newid()) FOR [CreditCardID]
END


End
GO
/****** Object:  Default [DF_EMAIL_EmailID]    Script Date: 01/06/2010 18:50:20 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_EMAIL_EmailID]') AND parent_object_id = OBJECT_ID(N'[dbo].[EMAIL]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_EMAIL_EmailID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[EMAIL] ADD  CONSTRAINT [DF_EMAIL_EmailID]  DEFAULT (newid()) FOR [EmailID]
END


End
GO
/****** Object:  Default [DF_EVENT_EventID]    Script Date: 01/06/2010 18:50:20 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_EVENT_EventID]') AND parent_object_id = OBJECT_ID(N'[dbo].[EVENT]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_EVENT_EventID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[EVENT] ADD  CONSTRAINT [DF_EVENT_EventID]  DEFAULT (newid()) FOR [EventID]
END


End
GO
/****** Object:  Default [DF_EXPENSE_BILL_ExpenseBillID]    Script Date: 01/06/2010 18:50:20 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_EXPENSE_BILL_ExpenseBillID]') AND parent_object_id = OBJECT_ID(N'[dbo].[EXPENSE_BILL]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_EXPENSE_BILL_ExpenseBillID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[EXPENSE_BILL] ADD  CONSTRAINT [DF_EXPENSE_BILL_ExpenseBillID]  DEFAULT (newid()) FOR [ExpenseBillID]
END


End
GO
/****** Object:  Default [DF_INCOME_IncomeID]    Script Date: 01/06/2010 18:50:20 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_INCOME_IncomeID]') AND parent_object_id = OBJECT_ID(N'[dbo].[INCOME]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_INCOME_IncomeID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[INCOME] ADD  CONSTRAINT [DF_INCOME_IncomeID]  DEFAULT (newid()) FOR [IncomeID]
END


End
GO
/****** Object:  Default [DF_INSTALLMENT_InstallmentID]    Script Date: 01/06/2010 18:50:20 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_INSTALLMENT_InstallmentID]') AND parent_object_id = OBJECT_ID(N'[dbo].[INSTALLMENT]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_INSTALLMENT_InstallmentID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[INSTALLMENT] ADD  CONSTRAINT [DF_INSTALLMENT_InstallmentID]  DEFAULT (newid()) FOR [InstallmentID]
END


End
GO
/****** Object:  Default [DF_PHONE_NUMBER_PhoneNumberID]    Script Date: 01/06/2010 18:50:20 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_PHONE_NUMBER_PhoneNumberID]') AND parent_object_id = OBJECT_ID(N'[dbo].[PHONE_NUMBER]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_PHONE_NUMBER_PhoneNumberID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[PHONE_NUMBER] ADD  CONSTRAINT [DF_PHONE_NUMBER_PhoneNumberID]  DEFAULT (newid()) FOR [PhoneNumberID]
END


End
GO
/****** Object:  Default [DF_PO_USER_UserID]    Script Date: 01/06/2010 18:50:20 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_PO_USER_UserID]') AND parent_object_id = OBJECT_ID(N'[dbo].[PO_USER]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_PO_USER_UserID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[PO_USER] ADD  CONSTRAINT [DF_PO_USER_UserID]  DEFAULT (newid()) FOR [UserID]
END


End
GO
/****** Object:  Default [DF_POSTAL_ADDRESS_PostalAddressID]    Script Date: 01/06/2010 18:50:20 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_POSTAL_ADDRESS_PostalAddressID]') AND parent_object_id = OBJECT_ID(N'[dbo].[POSTAL_ADDRESS]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_POSTAL_ADDRESS_PostalAddressID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[POSTAL_ADDRESS] ADD  CONSTRAINT [DF_POSTAL_ADDRESS_PostalAddressID]  DEFAULT (newid()) FOR [PostalAddressID]
END


End
GO
/****** Object:  Default [DF_WEBPAGE_WebPageID]    Script Date: 01/06/2010 18:50:20 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_WEBPAGE_WebPageID]') AND parent_object_id = OBJECT_ID(N'[dbo].[WEBPAGE]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_WEBPAGE_WebPageID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[WEBPAGE] ADD  CONSTRAINT [DF_WEBPAGE_WebPageID]  DEFAULT (newid()) FOR [WebPageID]
END


End
GO
/****** Object:  ForeignKey [FK_APPOINTMENT_CONTACT]    Script Date: 01/06/2010 18:50:20 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_APPOINTMENT_CONTACT]') AND parent_object_id = OBJECT_ID(N'[dbo].[APPOINTMENT]'))
ALTER TABLE [dbo].[APPOINTMENT]  WITH CHECK ADD  CONSTRAINT [FK_APPOINTMENT_CONTACT] FOREIGN KEY([ContactID])
REFERENCES [dbo].[CONTACT] ([ContactID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_APPOINTMENT_CONTACT]') AND parent_object_id = OBJECT_ID(N'[dbo].[APPOINTMENT]'))
ALTER TABLE [dbo].[APPOINTMENT] CHECK CONSTRAINT [FK_APPOINTMENT_CONTACT]
GO
/****** Object:  ForeignKey [FK_APPOINTMENT_EVENT]    Script Date: 01/06/2010 18:50:20 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_APPOINTMENT_EVENT]') AND parent_object_id = OBJECT_ID(N'[dbo].[APPOINTMENT]'))
ALTER TABLE [dbo].[APPOINTMENT]  WITH CHECK ADD  CONSTRAINT [FK_APPOINTMENT_EVENT] FOREIGN KEY([EventID])
REFERENCES [dbo].[EVENT] ([EventID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_APPOINTMENT_EVENT]') AND parent_object_id = OBJECT_ID(N'[dbo].[APPOINTMENT]'))
ALTER TABLE [dbo].[APPOINTMENT] CHECK CONSTRAINT [FK_APPOINTMENT_EVENT]
GO
/****** Object:  ForeignKey [FK_APPOINTMENT_PO_USER]    Script Date: 01/06/2010 18:50:20 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_APPOINTMENT_PO_USER]') AND parent_object_id = OBJECT_ID(N'[dbo].[APPOINTMENT]'))
ALTER TABLE [dbo].[APPOINTMENT]  WITH CHECK ADD  CONSTRAINT [FK_APPOINTMENT_PO_USER] FOREIGN KEY([UserID])
REFERENCES [dbo].[PO_USER] ([UserID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_APPOINTMENT_PO_USER]') AND parent_object_id = OBJECT_ID(N'[dbo].[APPOINTMENT]'))
ALTER TABLE [dbo].[APPOINTMENT] CHECK CONSTRAINT [FK_APPOINTMENT_PO_USER]
GO
/****** Object:  ForeignKey [FK_CONTACT_PO_USER]    Script Date: 01/06/2010 18:50:20 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CONTACT_PO_USER]') AND parent_object_id = OBJECT_ID(N'[dbo].[CONTACT]'))
ALTER TABLE [dbo].[CONTACT]  WITH CHECK ADD  CONSTRAINT [FK_CONTACT_PO_USER] FOREIGN KEY([UserID])
REFERENCES [dbo].[PO_USER] ([UserID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CONTACT_PO_USER]') AND parent_object_id = OBJECT_ID(N'[dbo].[CONTACT]'))
ALTER TABLE [dbo].[CONTACT] CHECK CONSTRAINT [FK_CONTACT_PO_USER]
GO
/****** Object:  ForeignKey [FK_CREDIT_CARD_PO_USER]    Script Date: 01/06/2010 18:50:20 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CREDIT_CARD_PO_USER]') AND parent_object_id = OBJECT_ID(N'[dbo].[CREDIT_CARD]'))
ALTER TABLE [dbo].[CREDIT_CARD]  WITH CHECK ADD  CONSTRAINT [FK_CREDIT_CARD_PO_USER] FOREIGN KEY([UserID])
REFERENCES [dbo].[PO_USER] ([UserID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CREDIT_CARD_PO_USER]') AND parent_object_id = OBJECT_ID(N'[dbo].[CREDIT_CARD]'))
ALTER TABLE [dbo].[CREDIT_CARD] CHECK CONSTRAINT [FK_CREDIT_CARD_PO_USER]
GO
/****** Object:  ForeignKey [FK_CREDIT_CARD_TT_BANK]    Script Date: 01/06/2010 18:50:20 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CREDIT_CARD_TT_BANK]') AND parent_object_id = OBJECT_ID(N'[dbo].[CREDIT_CARD]'))
ALTER TABLE [dbo].[CREDIT_CARD]  WITH CHECK ADD  CONSTRAINT [FK_CREDIT_CARD_TT_BANK] FOREIGN KEY([BankID])
REFERENCES [dbo].[TT_BANK] ([BankID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_CREDIT_CARD_TT_BANK]') AND parent_object_id = OBJECT_ID(N'[dbo].[CREDIT_CARD]'))
ALTER TABLE [dbo].[CREDIT_CARD] CHECK CONSTRAINT [FK_CREDIT_CARD_TT_BANK]
GO
/****** Object:  ForeignKey [FK_EMAIL_CONTACT]    Script Date: 01/06/2010 18:50:20 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EMAIL_CONTACT]') AND parent_object_id = OBJECT_ID(N'[dbo].[EMAIL]'))
ALTER TABLE [dbo].[EMAIL]  WITH CHECK ADD  CONSTRAINT [FK_EMAIL_CONTACT] FOREIGN KEY([ContactID])
REFERENCES [dbo].[CONTACT] ([ContactID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EMAIL_CONTACT]') AND parent_object_id = OBJECT_ID(N'[dbo].[EMAIL]'))
ALTER TABLE [dbo].[EMAIL] CHECK CONSTRAINT [FK_EMAIL_CONTACT]
GO
/****** Object:  ForeignKey [FK_EVENT_PO_USER]    Script Date: 01/06/2010 18:50:20 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EVENT_PO_USER]') AND parent_object_id = OBJECT_ID(N'[dbo].[EVENT]'))
ALTER TABLE [dbo].[EVENT]  WITH CHECK ADD  CONSTRAINT [FK_EVENT_PO_USER] FOREIGN KEY([UserID])
REFERENCES [dbo].[PO_USER] ([UserID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EVENT_PO_USER]') AND parent_object_id = OBJECT_ID(N'[dbo].[EVENT]'))
ALTER TABLE [dbo].[EVENT] CHECK CONSTRAINT [FK_EVENT_PO_USER]
GO
/****** Object:  ForeignKey [FK_EVENT_TT_FREQUENCY]    Script Date: 01/06/2010 18:50:20 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EVENT_TT_FREQUENCY]') AND parent_object_id = OBJECT_ID(N'[dbo].[EVENT]'))
ALTER TABLE [dbo].[EVENT]  WITH CHECK ADD  CONSTRAINT [FK_EVENT_TT_FREQUENCY] FOREIGN KEY([Frequency])
REFERENCES [dbo].[TT_FREQUENCY] ([FrequencyID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EVENT_TT_FREQUENCY]') AND parent_object_id = OBJECT_ID(N'[dbo].[EVENT]'))
ALTER TABLE [dbo].[EVENT] CHECK CONSTRAINT [FK_EVENT_TT_FREQUENCY]
GO
/****** Object:  ForeignKey [FK_EXPENSE_BILL_INSTALLMENT]    Script Date: 01/06/2010 18:50:20 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EXPENSE_BILL_INSTALLMENT]') AND parent_object_id = OBJECT_ID(N'[dbo].[EXPENSE_BILL]'))
ALTER TABLE [dbo].[EXPENSE_BILL]  WITH CHECK ADD  CONSTRAINT [FK_EXPENSE_BILL_INSTALLMENT] FOREIGN KEY([InstallmentID])
REFERENCES [dbo].[INSTALLMENT] ([InstallmentID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EXPENSE_BILL_INSTALLMENT]') AND parent_object_id = OBJECT_ID(N'[dbo].[EXPENSE_BILL]'))
ALTER TABLE [dbo].[EXPENSE_BILL] CHECK CONSTRAINT [FK_EXPENSE_BILL_INSTALLMENT]
GO
/****** Object:  ForeignKey [FK_EXPENSE_BILL_PO_USER]    Script Date: 01/06/2010 18:50:20 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EXPENSE_BILL_PO_USER]') AND parent_object_id = OBJECT_ID(N'[dbo].[EXPENSE_BILL]'))
ALTER TABLE [dbo].[EXPENSE_BILL]  WITH CHECK ADD  CONSTRAINT [FK_EXPENSE_BILL_PO_USER] FOREIGN KEY([UserID])
REFERENCES [dbo].[PO_USER] ([UserID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EXPENSE_BILL_PO_USER]') AND parent_object_id = OBJECT_ID(N'[dbo].[EXPENSE_BILL]'))
ALTER TABLE [dbo].[EXPENSE_BILL] CHECK CONSTRAINT [FK_EXPENSE_BILL_PO_USER]
GO
/****** Object:  ForeignKey [FK_EXPENSE_BILL_TT_EXPENSE_CATEGORY]    Script Date: 01/06/2010 18:50:20 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EXPENSE_BILL_TT_EXPENSE_CATEGORY]') AND parent_object_id = OBJECT_ID(N'[dbo].[EXPENSE_BILL]'))
ALTER TABLE [dbo].[EXPENSE_BILL]  WITH CHECK ADD  CONSTRAINT [FK_EXPENSE_BILL_TT_EXPENSE_CATEGORY] FOREIGN KEY([ExpenseCategory])
REFERENCES [dbo].[TT_EXPENSE_CATEGORY] ([ExpenseCategoryID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EXPENSE_BILL_TT_EXPENSE_CATEGORY]') AND parent_object_id = OBJECT_ID(N'[dbo].[EXPENSE_BILL]'))
ALTER TABLE [dbo].[EXPENSE_BILL] CHECK CONSTRAINT [FK_EXPENSE_BILL_TT_EXPENSE_CATEGORY]
GO
/****** Object:  ForeignKey [FK_INCOME_PO_USER]    Script Date: 01/06/2010 18:50:20 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_INCOME_PO_USER]') AND parent_object_id = OBJECT_ID(N'[dbo].[INCOME]'))
ALTER TABLE [dbo].[INCOME]  WITH CHECK ADD  CONSTRAINT [FK_INCOME_PO_USER] FOREIGN KEY([UserID])
REFERENCES [dbo].[PO_USER] ([UserID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_INCOME_PO_USER]') AND parent_object_id = OBJECT_ID(N'[dbo].[INCOME]'))
ALTER TABLE [dbo].[INCOME] CHECK CONSTRAINT [FK_INCOME_PO_USER]
GO
/****** Object:  ForeignKey [FK_INCOME_TT_INCOME_CATEGORY]    Script Date: 01/06/2010 18:50:20 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_INCOME_TT_INCOME_CATEGORY]') AND parent_object_id = OBJECT_ID(N'[dbo].[INCOME]'))
ALTER TABLE [dbo].[INCOME]  WITH CHECK ADD  CONSTRAINT [FK_INCOME_TT_INCOME_CATEGORY] FOREIGN KEY([IncomeCategoryID])
REFERENCES [dbo].[TT_INCOME_CATEGORY] ([IncomeCategoryID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_INCOME_TT_INCOME_CATEGORY]') AND parent_object_id = OBJECT_ID(N'[dbo].[INCOME]'))
ALTER TABLE [dbo].[INCOME] CHECK CONSTRAINT [FK_INCOME_TT_INCOME_CATEGORY]
GO
/****** Object:  ForeignKey [FK_PHONE_NUMBER_CONTACT]    Script Date: 01/06/2010 18:50:20 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PHONE_NUMBER_CONTACT]') AND parent_object_id = OBJECT_ID(N'[dbo].[PHONE_NUMBER]'))
ALTER TABLE [dbo].[PHONE_NUMBER]  WITH CHECK ADD  CONSTRAINT [FK_PHONE_NUMBER_CONTACT] FOREIGN KEY([ContactID])
REFERENCES [dbo].[CONTACT] ([ContactID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PHONE_NUMBER_CONTACT]') AND parent_object_id = OBJECT_ID(N'[dbo].[PHONE_NUMBER]'))
ALTER TABLE [dbo].[PHONE_NUMBER] CHECK CONSTRAINT [FK_PHONE_NUMBER_CONTACT]
GO
/****** Object:  ForeignKey [FK_POSTAL_ADDRESS_CONTACT]    Script Date: 01/06/2010 18:50:20 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_POSTAL_ADDRESS_CONTACT]') AND parent_object_id = OBJECT_ID(N'[dbo].[POSTAL_ADDRESS]'))
ALTER TABLE [dbo].[POSTAL_ADDRESS]  WITH CHECK ADD  CONSTRAINT [FK_POSTAL_ADDRESS_CONTACT] FOREIGN KEY([ContactID])
REFERENCES [dbo].[CONTACT] ([ContactID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_POSTAL_ADDRESS_CONTACT]') AND parent_object_id = OBJECT_ID(N'[dbo].[POSTAL_ADDRESS]'))
ALTER TABLE [dbo].[POSTAL_ADDRESS] CHECK CONSTRAINT [FK_POSTAL_ADDRESS_CONTACT]
GO
/****** Object:  ForeignKey [FK_WEBPAGE_CONTACT]    Script Date: 01/06/2010 18:50:20 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_WEBPAGE_CONTACT]') AND parent_object_id = OBJECT_ID(N'[dbo].[WEBPAGE]'))
ALTER TABLE [dbo].[WEBPAGE]  WITH CHECK ADD  CONSTRAINT [FK_WEBPAGE_CONTACT] FOREIGN KEY([ContactID])
REFERENCES [dbo].[CONTACT] ([ContactID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_WEBPAGE_CONTACT]') AND parent_object_id = OBJECT_ID(N'[dbo].[WEBPAGE]'))
ALTER TABLE [dbo].[WEBPAGE] CHECK CONSTRAINT [FK_WEBPAGE_CONTACT]
GO
