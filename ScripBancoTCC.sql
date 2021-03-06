USE [EducawareGeografia]
GO
/****** Object:  Table [dbo].[RegiaoSul]    Script Date: 11/22/2014 19:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RegiaoSul](
	[PK_cod_regiao] [int] IDENTITY(1,1) NOT NULL,
	[cod_pergunta] [int] NULL,
	[cod_resposta] [int] NULL,
	[FK_cod_quiz] [int] NULL,
	[pergunta] [varchar](1000) NULL,
	[respostaCerta] [char](1) NULL,
	[alternativa_A] [varchar](500) NULL,
	[alternativa_B] [varchar](500) NULL,
	[alternativa_C] [varchar](500) NULL,
	[alternativa_D] [varchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[PK_cod_regiao] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RegiaoSudeste]    Script Date: 11/22/2014 19:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RegiaoSudeste](
	[PK_cod_regiao] [int] IDENTITY(1,1) NOT NULL,
	[cod_pergunta] [int] NULL,
	[cod_resposta] [int] NULL,
	[FK_cod_quiz] [int] NULL,
	[pergunta] [varchar](1000) NULL,
	[respostaCerta] [char](1) NULL,
	[alternativa_A] [varchar](500) NULL,
	[alternativa_B] [varchar](500) NULL,
	[alternativa_C] [varchar](500) NULL,
	[alternativa_D] [varchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[PK_cod_regiao] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RegiaoNorte]    Script Date: 11/22/2014 19:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RegiaoNorte](
	[PK_cod_regiao] [int] IDENTITY(1,1) NOT NULL,
	[cod_pergunta] [int] NULL,
	[cod_resposta] [int] NULL,
	[FK_cod_quiz] [int] NULL,
	[pergunta] [varchar](1000) NULL,
	[respostaCerta] [char](1) NULL,
	[alternativa_A] [varchar](500) NULL,
	[alternativa_B] [varchar](500) NULL,
	[alternativa_C] [varchar](500) NULL,
	[alternativa_D] [varchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[PK_cod_regiao] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RegiaoNordeste]    Script Date: 11/22/2014 19:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RegiaoNordeste](
	[PK_cod_regiao] [int] IDENTITY(1,1) NOT NULL,
	[cod_pergunta] [int] NULL,
	[cod_resposta] [int] NULL,
	[FK_cod_quiz] [int] NULL,
	[pergunta] [varchar](1000) NULL,
	[respostaCerta] [char](1) NULL,
	[alternativa_A] [varchar](500) NULL,
	[alternativa_B] [varchar](500) NULL,
	[alternativa_C] [varchar](500) NULL,
	[alternativa_D] [varchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[PK_cod_regiao] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RegiaoCentro]    Script Date: 11/22/2014 19:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RegiaoCentro](
	[PK_cod_regiao] [int] IDENTITY(1,1) NOT NULL,
	[cod_pergunta] [int] NULL,
	[cod_resposta] [int] NULL,
	[FK_cod_quiz] [int] NULL,
	[pergunta] [varchar](1000) NULL,
	[respostaCerta] [char](1) NULL,
	[alternativa_A] [varchar](500) NULL,
	[alternativa_B] [varchar](500) NULL,
	[alternativa_C] [varchar](500) NULL,
	[alternativa_D] [varchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[PK_cod_regiao] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Quiz]    Script Date: 11/22/2014 19:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Quiz](
	[PK_cod_quiz] [int] IDENTITY(1,1) NOT NULL,
	[FK_cod_jogo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[PK_cod_quiz] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Memoria]    Script Date: 11/22/2014 19:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Memoria](
	[PK_cod_imagens] [int] IDENTITY(1,1) NOT NULL,
	[FK_cod_jogo] [int] NULL,
	[imagens] [varchar](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[PK_cod_imagens] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 11/22/2014 19:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[PK_cod_usuario] [int] IDENTITY(1,1) NOT NULL,
	[nome_usuario] [varchar](50) NULL,
	[senha_usuario] [varchar](8) NULL,
	[idade_usuario] [int] NULL,
	[serie_usuario] [varchar](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[PK_cod_usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[trazerQuestaoSul]    Script Date: 11/22/2014 19:57:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[trazerQuestaoSul]
@numPergunta int
As 
select * from RegiaoSul where cod_pergunta = @numPergunta
GO
/****** Object:  StoredProcedure [dbo].[trazerQuestaoSudeste]    Script Date: 11/22/2014 19:57:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[trazerQuestaoSudeste]
@numPergunta int
As 
select * from RegiaoSudeste where cod_pergunta = @numPergunta
GO
/****** Object:  StoredProcedure [dbo].[trazerQuestaoNorte]    Script Date: 11/22/2014 19:57:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[trazerQuestaoNorte]
@numPergunta int
As 
select * from RegiaoNorte where cod_pergunta = @numPergunta
GO
/****** Object:  StoredProcedure [dbo].[trazerQuestaoNordeste]    Script Date: 11/22/2014 19:57:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[trazerQuestaoNordeste]
@numPergunta int
As 
select * from RegiaoNordeste where cod_pergunta = @numPergunta
GO
/****** Object:  StoredProcedure [dbo].[trazerQuestaoCentro]    Script Date: 11/22/2014 19:57:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[trazerQuestaoCentro]
@numPergunta int
As 
select * from RegiaoCentro where cod_pergunta = @numPergunta
GO
/****** Object:  StoredProcedure [dbo].[trazerAlternativaSul]    Script Date: 11/22/2014 19:57:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[trazerAlternativaSul]
@numPergunta int
As 
select alternativa_A,
alternativa_B,
alternativa_C,
alternativa_D,
respostaCerta
 from RegiaoSul where cod_pergunta=@numPergunta
GO
/****** Object:  StoredProcedure [dbo].[trazerAlternativaSudeste]    Script Date: 11/22/2014 19:57:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[trazerAlternativaSudeste]
@numPergunta int
As 
select alternativa_A,
alternativa_B,
alternativa_C,
alternativa_D,
respostaCerta
 from RegiaoSudeste where cod_pergunta=@numPergunta
GO
/****** Object:  StoredProcedure [dbo].[trazerAlternativaNorte]    Script Date: 11/22/2014 19:57:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[trazerAlternativaNorte]
@numPergunta int
As 
select alternativa_A,
alternativa_B,
alternativa_C,
alternativa_D,
respostaCerta
 from RegiaoNorte where cod_pergunta=@numPergunta
GO
/****** Object:  StoredProcedure [dbo].[trazerAlternativaNordeste]    Script Date: 11/22/2014 19:57:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[trazerAlternativaNordeste]
@numPergunta int
As 
select alternativa_A,
alternativa_B,
alternativa_C,
alternativa_D,
respostaCerta
 from RegiaoNordeste where cod_pergunta=@numPergunta
GO
/****** Object:  StoredProcedure [dbo].[trazerAlternativaCentro]    Script Date: 11/22/2014 19:57:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[trazerAlternativaCentro]
@numPergunta int
As 
select alternativa_A,
alternativa_B,
alternativa_C,
alternativa_D,
respostaCerta
 from RegiaoCentro where cod_pergunta=@numPergunta
GO
/****** Object:  StoredProcedure [dbo].[loginDoJogador]    Script Date: 11/22/2014 19:57:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[loginDoJogador]
@login varchar(50), @senha varchar(50) As
select * from Usuario where nome_usuario = @login and senha_usuario = @senha
GO
/****** Object:  Table [dbo].[Jogo]    Script Date: 11/22/2014 19:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Jogo](
	[PK_cod_jogo] [int] IDENTITY(1,1) NOT NULL,
	[Fk_cod_usuario] [int] NULL,
	[pontuacao] [int] NULL,
	[duracao] [date] NULL,
	[regiao] [varchar](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[PK_cod_jogo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[inserirPerguntasSul]    Script Date: 11/22/2014 19:57:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[inserirPerguntasSul]
@numPergunta int,
@pergunta varchar (1000),
@respostaCerta char(1),
@alternativaA varchar(500),
@alternativaB varchar(500),
@alternativaC varchar(500),
@alternativaD varchar(500)
As
Insert Into RegiaoSul(cod_pergunta, pergunta, respostaCerta, alternativa_A, alternativa_B, alternativa_C, alternativa_D)
values (@numPergunta, @pergunta, @respostaCerta, @alternativaA, @alternativaB, @alternativaC, @alternativaD)
GO
/****** Object:  StoredProcedure [dbo].[inserirPerguntasSudeste]    Script Date: 11/22/2014 19:57:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[inserirPerguntasSudeste]
@numPergunta int,
@pergunta varchar (1000),
@respostaCerta char(1),
@alternativaA varchar(500),
@alternativaB varchar(500),
@alternativaC varchar(500),
@alternativaD varchar(500)
As
Insert Into RegiaoSudeste(cod_pergunta, pergunta, respostaCerta, alternativa_A, alternativa_B, alternativa_C, alternativa_D)
values (@numPergunta, @pergunta, @respostaCerta, @alternativaA, @alternativaB, @alternativaC, @alternativaD)
GO
/****** Object:  StoredProcedure [dbo].[inserirPerguntasNorte]    Script Date: 11/22/2014 19:57:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[inserirPerguntasNorte]
@numPergunta int,
@pergunta varchar (1000),
@respostaCerta char(1),
@alternativaA varchar(500),
@alternativaB varchar(500),
@alternativaC varchar(500),
@alternativaD varchar(500)
As
Insert Into RegiaoNorte(cod_pergunta, pergunta, respostaCerta, alternativa_A, alternativa_B, alternativa_C, alternativa_D)
values (@numPergunta, @pergunta, @respostaCerta, @alternativaA, @alternativaB, @alternativaC, @alternativaD)
GO
/****** Object:  StoredProcedure [dbo].[inserirPerguntasNordeste]    Script Date: 11/22/2014 19:57:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[inserirPerguntasNordeste]
@numPergunta int,
@pergunta varchar (1000),
@respostaCerta char(1),
@alternativaA varchar(500),
@alternativaB varchar(500),
@alternativaC varchar(500),
@alternativaD varchar(500)
As
Insert Into RegiaoNordeste(cod_pergunta, pergunta, respostaCerta, alternativa_A, alternativa_B, alternativa_C, alternativa_D)
values (@numPergunta, @pergunta, @respostaCerta, @alternativaA, @alternativaB, @alternativaC, @alternativaD)
GO
/****** Object:  StoredProcedure [dbo].[inserirPerguntasCentro]    Script Date: 11/22/2014 19:57:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[inserirPerguntasCentro]
@numPergunta int,
@pergunta varchar (1000),
@respostaCerta char(1),
@alternativaA varchar(500),
@alternativaB varchar(500),
@alternativaC varchar(500),
@alternativaD varchar(500)
As
Insert Into RegiaoCentro(cod_pergunta, pergunta, respostaCerta, alternativa_A, alternativa_B, alternativa_C, alternativa_D)
values (@numPergunta, @pergunta, @respostaCerta, @alternativaA, @alternativaB, @alternativaC, @alternativaD)
GO
/****** Object:  StoredProcedure [dbo].[excluirUsuario]    Script Date: 11/22/2014 19:57:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[excluirUsuario]
@codigo int
as
delete from Usuario where PK_cod_usuario = @codigo
GO
/****** Object:  StoredProcedure [dbo].[excluirPerguntaSul]    Script Date: 11/22/2014 19:57:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[excluirPerguntaSul]
@numPergunta int
as
delete from RegiaoSul where cod_pergunta = @numPergunta
GO
/****** Object:  StoredProcedure [dbo].[excluirPerguntaSudeste]    Script Date: 11/22/2014 19:57:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[excluirPerguntaSudeste]
@numPergunta int
as
delete from RegiaoSudeste where cod_pergunta = @numPergunta
GO
/****** Object:  StoredProcedure [dbo].[excluirPerguntaNorte]    Script Date: 11/22/2014 19:57:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[excluirPerguntaNorte]
@numPergunta int
as
delete from RegiaoNorte where cod_pergunta = @numPergunta
GO
/****** Object:  StoredProcedure [dbo].[excluirPerguntaNordeste]    Script Date: 11/22/2014 19:57:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[excluirPerguntaNordeste]
@numPergunta int
as
delete from RegiaoNordeste where cod_pergunta = @numPergunta
GO
/****** Object:  StoredProcedure [dbo].[excluirPerguntaCentro]    Script Date: 11/22/2014 19:57:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[excluirPerguntaCentro]
@numPergunta int
as
delete from RegiaoCentro where cod_pergunta = @numPergunta
GO
/****** Object:  StoredProcedure [dbo].[editarUsuario]    Script Date: 11/22/2014 19:57:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[editarUsuario]
@codigo int,
@nomeUsuario varchar (50),
@senhaUsuario varchar (50),
@idadeUsuario int,
@serieUsuario varchar (5)
As
update Usuario set nome_usuario = @nomeUsuario,
senha_usuario = @senhaUsuario, idade_usuario = @idadeUsuario, serie_usuario = @serieUsuario
where PK_cod_usuario = @codigo
GO
/****** Object:  StoredProcedure [dbo].[consultarJogadores]    Script Date: 11/22/2014 19:57:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[consultarJogadores]
As 
select nome_usuario As 'Nome Usuário', senha_usuario As 'Senha', idade_usuario As 'Idade', serie_usuario as 'Série'
from Usuario
GO
/****** Object:  StoredProcedure [dbo].[consultarEditar]    Script Date: 11/22/2014 19:57:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[consultarEditar]
@nomeUsuario varchar (50)
as
select PK_cod_usuario as 'Codigo do Usuário',
nome_usuario as 'Nome',
senha_usuario as 'Senha',
idade_usuario 'Idade',
serie_usuario as 'Série'
from Usuario
where nome_usuario like @nomeUsuario + '%'
GO
/****** Object:  StoredProcedure [dbo].[cadastrarUsuario]    Script Date: 11/22/2014 19:57:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[cadastrarUsuario]
@nomeUsuario varchar (50),
@senhaUsuario varchar (50),
@idadeUsuario int,
@serieUsuario varchar (5)
As
Insert Into Usuario (nome_usuario, senha_usuario, idade_usuario, serie_usuario)
values (@nomeUsuario, @senhaUsuario, @idadeUsuario, @serieUsuario)
GO
/****** Object:  StoredProcedure [dbo].[alterarPerguntasSul]    Script Date: 11/22/2014 19:57:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[alterarPerguntasSul]
@numPergunta int,
@pergunta varchar (1000),
@respostaCerta char(1),
@alternativaA varchar(500),
@alternativaB varchar(500),
@alternativaC varchar(500),
@alternativaD varchar(500)
As
UPDATE RegiaoSul set 
cod_pergunta = @numPergunta,
pergunta = @pergunta,
respostaCerta = @respostaCerta,
alternativa_A = @alternativaA,
alternativa_B = @alternativaB,
alternativa_C = @alternativaC,
alternativa_D = @alternativaD
where cod_pergunta = @numPergunta
GO
/****** Object:  StoredProcedure [dbo].[alterarPerguntasSudeste]    Script Date: 11/22/2014 19:57:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[alterarPerguntasSudeste]
@numPergunta int,
@pergunta varchar (1000),
@respostaCerta char(1),
@alternativaA varchar(500),
@alternativaB varchar(500),
@alternativaC varchar(500),
@alternativaD varchar(500)
As
UPDATE RegiaoSudeste set 
cod_pergunta = @numPergunta,
pergunta = @pergunta,
respostaCerta = @respostaCerta,
alternativa_A = @alternativaA,
alternativa_B = @alternativaB,
alternativa_C = @alternativaC,
alternativa_D = @alternativaD
where cod_pergunta = @numPergunta
GO
/****** Object:  StoredProcedure [dbo].[alterarPerguntasNorte]    Script Date: 11/22/2014 19:57:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[alterarPerguntasNorte]
@numPergunta int,
@pergunta varchar (1000),
@respostaCerta char(1),
@alternativaA varchar(500),
@alternativaB varchar(500),
@alternativaC varchar(500),
@alternativaD varchar(500)
As
UPDATE RegiaoNorte set 
cod_pergunta = @numPergunta,
pergunta = @pergunta,
respostaCerta = @respostaCerta,
alternativa_A = @alternativaA,
alternativa_B = @alternativaB,
alternativa_C = @alternativaC,
alternativa_D = @alternativaD
where cod_pergunta = @numPergunta
GO
/****** Object:  StoredProcedure [dbo].[alterarPerguntasNordeste]    Script Date: 11/22/2014 19:57:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[alterarPerguntasNordeste]
@numPergunta int,
@pergunta varchar (1000),
@respostaCerta char(1),
@alternativaA varchar(500),
@alternativaB varchar(500),
@alternativaC varchar(500),
@alternativaD varchar(500)
As
UPDATE RegiaoNordeste set 
cod_pergunta = @numPergunta,
pergunta = @pergunta,
respostaCerta = @respostaCerta,
alternativa_A = @alternativaA,
alternativa_B = @alternativaB,
alternativa_C = @alternativaC,
alternativa_D = @alternativaD
where cod_pergunta = @numPergunta
GO
/****** Object:  StoredProcedure [dbo].[alterarPerguntasCentro]    Script Date: 11/22/2014 19:57:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[alterarPerguntasCentro]
@numPergunta int,
@pergunta varchar (1000),
@respostaCerta char(1),
@alternativaA varchar(500),
@alternativaB varchar(500),
@alternativaC varchar(500),
@alternativaD varchar(500)
As
UPDATE RegiaoCentro set 
cod_pergunta = @numPergunta,
pergunta = @pergunta,
respostaCerta = @respostaCerta,
alternativa_A = @alternativaA,
alternativa_B = @alternativaB,
alternativa_C = @alternativaC,
alternativa_D = @alternativaD
where cod_pergunta = @numPergunta
GO
/****** Object:  StoredProcedure [dbo].[perguntaPorNumeroSuL]    Script Date: 11/22/2014 19:57:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[perguntaPorNumeroSuL]
@numPergunta int
As 
select cod_pergunta As 'Nº da Pergunta',
 pergunta As 'Pergunta',
 respostaCerta As 'Resposta Certa',
 alternativa_A As 'Alternativa A',
 alternativa_B As 'Alternativa B',
 alternativa_C As 'Alternativa C',
 alternativa_D As 'Alternativa D'
 from RegiaoSul where cod_pergunta = @numPergunta
GO
/****** Object:  StoredProcedure [dbo].[perguntaPorNumeroSudeste]    Script Date: 11/22/2014 19:57:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[perguntaPorNumeroSudeste]
@numPergunta int
As 
select cod_pergunta As 'Nº da Pergunta',
 pergunta As 'Pergunta',
 respostaCerta As 'Resposta Certa',
 alternativa_A As 'Alternativa A',
 alternativa_B As 'Alternativa B',
 alternativa_C As 'Alternativa C',
 alternativa_D As 'Alternativa D'
 from RegiaoSudeste where cod_pergunta = @numPergunta
GO
/****** Object:  StoredProcedure [dbo].[perguntaPorNumeroNorte]    Script Date: 11/22/2014 19:57:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[perguntaPorNumeroNorte]
@numPergunta int
As 
select cod_pergunta As 'Nº da Pergunta',
 pergunta As 'Pergunta',
 respostaCerta As 'Resposta Certa',
 alternativa_A As 'Alternativa A',
 alternativa_B As 'Alternativa B',
 alternativa_C As 'Alternativa C',
 alternativa_D As 'Alternativa D'
 from RegiaoNorte where cod_pergunta = @numPergunta
GO
/****** Object:  StoredProcedure [dbo].[perguntaPorNumeroNordeste]    Script Date: 11/22/2014 19:57:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[perguntaPorNumeroNordeste]
@numPergunta int
As 
select cod_pergunta As 'Nº da Pergunta',
 pergunta As 'Pergunta',
 respostaCerta As 'Resposta Certa',
 alternativa_A As 'Alternativa A',
 alternativa_B As 'Alternativa B',
 alternativa_C As 'Alternativa C',
 alternativa_D As 'Alternativa D'
 from RegiaoNordeste where cod_pergunta = @numPergunta
GO
/****** Object:  StoredProcedure [dbo].[perguntaPorNumeroCentro]    Script Date: 11/22/2014 19:57:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[perguntaPorNumeroCentro]
@numPergunta int
As 
select cod_pergunta As 'Nº da Pergunta',
 pergunta As 'Pergunta',
 respostaCerta As 'Resposta Certa',
 alternativa_A As 'Alternativa A',
 alternativa_B As 'Alternativa B',
 alternativa_C As 'Alternativa C',
 alternativa_D As 'Alternativa D'
 from RegiaoCentro where cod_pergunta = @numPergunta
GO
/****** Object:  ForeignKey [jogo_usuario_fk]    Script Date: 11/22/2014 19:57:55 ******/
ALTER TABLE [dbo].[Jogo]  WITH CHECK ADD  CONSTRAINT [jogo_usuario_fk] FOREIGN KEY([Fk_cod_usuario])
REFERENCES [dbo].[Usuario] ([PK_cod_usuario])
GO
ALTER TABLE [dbo].[Jogo] CHECK CONSTRAINT [jogo_usuario_fk]
GO
