USE financeiro;

SELECT Tipo, NomeCurso, ValorMensalidade 
FROM Mensalidade 
INNER JOIN Curso ON Curso.idCurso = Mensalidade.Curso_idCurso 
INNER JOIN Tipo ON Tipo.idTipo = Curso.Tipo_idTipo AND ValorMensalidade > 1000;