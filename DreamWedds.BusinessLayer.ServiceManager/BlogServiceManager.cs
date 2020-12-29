using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DreamWedds.CommonLayer.Application.DTO;
using DreamWedds.CommonLayer.Application.Interfaces;
using DreamWedds.PersistenceLayer.Entities.Entities;
using DreamWedds.PersistenceLayer.Repository;
using DreamWedds.PersistenceLayer.Repository.PersistenceServices;
using DreamWedds.PersistenceLayer.Repository.Repository;

namespace DreamWedds.BusinessLayer.ServiceManager
{
    public class BlogServiceManager : IBlogService
    {
        private readonly IAsyncRepository<DreamWeddsBlog> _blogRepository;
        protected readonly DreamWeddsDBContext DbContext;
        private readonly IMapper _mapper;
        public BlogServiceManager(IAsyncRepository<DreamWeddsBlog> blogRepository, IMapper mapper)
        {
            _mapper = mapper;
            _blogRepository = blogRepository;
        }
        public async Task<List<DreamWeddsBlogDTO>> GetAllBlogs()
        {
            var blogs = await _blogRepository.ListAllAsync();
            return _mapper.Map<List<DreamWeddsBlog>, List<DreamWeddsBlogDTO>>(blogs.ToList());
        }

        public async Task<DreamWeddsBlogDTO> GetBlogById(int id)
        {
            var data = await _blogRepository.GetByIdAsync(id);
            return _mapper.Map<DreamWeddsBlog, DreamWeddsBlogDTO>(data);
        }
    }
}
