using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QandA.Data.Models;

namespace QandA.Data
{
    public interface IDataRepository
    {
        Task<IEnumerable<QuestionGetManyResponse>> GetQuestionsAsync();
        Task<IEnumerable<QuestionGetManyResponse>> GetQuestionsWithAnswersAsync();
        Task<IEnumerable<QuestionGetManyResponse>> GetQuestionsBySearchAsync(string search);
        Task<IEnumerable<QuestionGetManyResponse>> GetQuestionsBySearchWithPagingAsync(string search, int pageNumber, int pageSize);
        Task<IEnumerable<QuestionGetManyResponse>> GetUnansweredQuestionsAsync();
        Task<IEnumerable<QuestionGetManyResponse>> GetUnansweredQuestionsWithPagingAsync(int pageNumber, int pageSize);
        Task<QuestionGetSingleResponse> GetQuestionAsync(int questionId);
        Task<AnswerGetResponse> GetAnswerAsync(int answerId);
        Task<bool> QuestionExistsAsync(int questionId);
        Task<QuestionGetSingleResponse> PostQuestionAsync(QuestionPostFullRequest question);
        Task<AnswerGetResponse> PostAnswerAsync(AnswerPostFullRequest answer);
        Task<QuestionGetSingleResponse> PutQuestionAsync(int questionId, QuestionPutRequest question);
        Task DeleteQuestionAsync(int questionId);
    }
}
