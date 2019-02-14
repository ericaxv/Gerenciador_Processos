teste 1

Select sum(Valor) from Processo where Status = 'Ativo'

go

teste 2
Select Sum(Valor)/Count(Valor) as Media from Processo where EstadoExecucao = 'Rio de Janeiro' and IdCliente= 1
go

teste 3
Select Count(Valor) from Processo where Valor > 100000.00
go

teste 4
Select * from Processo where DataCriacao >= 01/09/2007 and DataCriacao <= 30/09/2007
go

teste 6
select NumeroProcesso from Processo where NumeroProcesso like '%TRAB%'
GO

