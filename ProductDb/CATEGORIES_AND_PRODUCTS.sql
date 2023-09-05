CREATE TABLE [dbo].[CATEGORIES_AND_PRODUCTS]
(
	[ProductId] INT NOT NULL,
	[CategoryId] int not null,
	constraint PK_CATEGORIES_AND_PRODUCTS_ID primary key clustered (ProductId, CategoryId),
	constraint FK_CATEGORIES_AND_PRODUCTS_PRODUCTS foreign key (ProductId) references PRODUCTS (Id),
	constraint FK_CATEGORIES_AND_PRODUCTS_CATEGORIES foreign key (CategoryId) references CATEGORIES (Id)
)
