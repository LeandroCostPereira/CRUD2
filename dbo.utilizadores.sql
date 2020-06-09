CREATE TABLE [dbo].[utilizadores] (
    [Id]         INT           NOT NULL IDENTITY,
    [nome]       NVARCHAR (30) NOT NULL,
    [utilizador] NVARCHAR (50) NOT NULL,
    [senha]      NVARCHAR (60) NOT NULL,
    [nivel]      BIT           DEFAULT ((0)) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

