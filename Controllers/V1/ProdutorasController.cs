using ApiCatologoJogoDio.DTOs;
using ApiCatologoJogoDio.Repositoy;
using ApiCatologoJogoDio.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatologoJogoDio.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutorasController : ControllerBase
    {
        private readonly IProdutoraRepository _produtoraRepository;
        private readonly IMapper _mapper;

        public ProdutorasController(IProdutoraRepository produtoraRepository, IMapper mapper)
        {
            _produtoraRepository = produtoraRepository;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProdutoraDTO>>> Get()
        {
            var prod = await _produtoraRepository.Get();
            var prodDto = _mapper.Map<List<ProdutoraDTO>>(prod);

            return prodDto;
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<ProdutoraDTO>> Get(int id)
        {
            var prod = await _produtoraRepository.GetBydId(p => p.Id == id);

            if(prod == null)
            {
                return NotFound("Erro com o Id");
            }
            var prodDto = _mapper.Map<ProdutoraDTO>(prod);

            return prodDto;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody]ProdutoraDTO produtoraDTO)
        {
            var prod = _mapper.Map<Produtora>(produtoraDTO);

            _produtoraRepository.Add(prod);
            await _produtoraRepository.Commit();

            var prodDto = _mapper.Map<ProdutoraDTO>(prod);

            return Ok(prodDto);

           
        }

        [HttpPut]
        public async Task<ActionResult> Put(int id, [FromBody] ProdutoraDTO produtoraDTO)
        {
            if(id != produtoraDTO.ProdutoraId)
            {
                return BadRequest("Erro por Id nao existir");
            }

            var prod = _mapper.Map<Produtora>(produtoraDTO);

            _produtoraRepository.Update(prod);
            await _produtoraRepository.Commit();

            return Ok("Categoria atualizada copm Sucesso");
        }

        [HttpDelete]
        public async Task<ActionResult<ProdutoraDTO>> Delete(int id)
        {
            var prod = await _produtoraRepository.GetBydId(p => p.Id == id);

            if(prod == null)
            {
                return NotFound("Erro ao deletar a Produtora");
            }

            _produtoraRepository.Delete(prod);
            await _produtoraRepository.Commit();

            var prodDto = _mapper.Map<ProdutoraDTO>(prod);

            return prodDto
;        }

    }
}
