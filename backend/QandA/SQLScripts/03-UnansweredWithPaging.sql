CREATE PROC dbo.Question_GetUnanswered_WithPaging
	(
	@PageNumber int,
	@PageSize int
)
AS
BEGIN
	SELECT QuestionId, Title, Content, UserId, UserName, Created
	FROM
		(	SELECT QuestionId, Title, Content, UserId, UserName, Created
			FROM dbo.Question q
			WHERE NOT EXISTS (SELECT *
			FROM dbo.Answer a
			WHERE a.QuestionId = q.QuestionId)) Sub
		ORDER BY QuestionId
		OFFSET @PageSize * (@PageNumber - 1) ROWS
		FETCH NEXT @PageSize ROWS ONLY
END