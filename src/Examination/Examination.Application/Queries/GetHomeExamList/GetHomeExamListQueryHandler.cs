using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Examination.Domain.AggregateModels.ExamAggregate;
using Examination.Dtos;
using MediatR;
using MongoDB.Driver;

namespace Examination.Application.Queries.GetHomeExamList
{
    public class GetHomeExamListQueryHandler : IRequestHandler<GetHomeExamListQuery, IEnumerable<ExamDto>>
    {
        private readonly IExamRepository _examRepository;
        private readonly IClientSessionHandle _clientSessionHandle;
        private readonly IMapper _mapper;
        public GetHomeExamListQueryHandler(IExamRepository examRepository,
        IMapper mapper,
        IClientSessionHandle clientSessionHandle)
        {
            _mapper = mapper;
            _clientSessionHandle = clientSessionHandle;
            _examRepository = examRepository;
        }
        public async Task<IEnumerable<ExamDto>> Handle(GetHomeExamListQuery request, CancellationToken cancellationToken)
        {
            var exams = await _examRepository.GetExamListAsync();
            var examDtos = _mapper.Map<IEnumerable<ExamDto>>(exams);
            
            return examDtos;
        }
    }
}