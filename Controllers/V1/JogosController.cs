using ApiCatologoJogoDio.DTOs;
using ApiCatologoJogoDio.Models;
using ApiCatologoJogoDio.Repositoy;
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
    public class JogosController : ControllerBase
    {
        private readonly IJogoRepository _jogoRepository;
        private readonly IMapper _mapper;

        public JogosController(IJogoRepository jogoRepository, IMapper mapper)
        {
            _jogoRepository = jogoRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<JogoDto>>> Obter()
        {
            var jogo = await _jogoRepository.Get();
            var jogoDto = _mapper.Map<List<JogoDto>>(jogo);
            return jogoDto;

        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<JogoDto>> Obter(Guid id)
        {
            var jogo = await _jogoRepository.GetBydId(j => j.Id == id);
            if(jogo == null)
            {
                return NotFound();
            }
            var jogoDto = _mapper.Map<JogoDto>(jogo);
            return jogoDto;
        }

        [HttpPost]
        public async Task<ActionResult> InserirJogo([FromBody] JogoDto jogoDto)
        {
            var jogo = _mapper.Map<Jogo>(jogoDto);

            _jogoRepository.Add(jogo);
            await _jogoRepository.Commit();

            var jogoDTO = _mapper.Map<JogoDto>(jogo);
            
           

            return Ok(jogoDTO);
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult> AtualizarJogo(Guid id, [FromBody] JogoDto jogoDto)
        {

            if(id != jogoDto.Id)
            {
                return BadRequest();
            }

            var jogo = _mapper.Map<Jogo>(jogoDto);
            _jogoRepository.Update(jogo);
            await _jogoRepository.Commit();

            return Ok();
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<JogoDto>> ApagarJogo(Guid id)
        {
            var jogo = await _jogoRepository.GetBydId(j => j.Id == id);

            if(jogo == null)
            {
                return NotFound();
            }
            _jogoRepository.Delete(jogo);
            await _jogoRepository.Commit();

            var jogoDto = _mapper.Map<JogoDto>(jogo);
            

            return jogoDto;
        }



    }
}
