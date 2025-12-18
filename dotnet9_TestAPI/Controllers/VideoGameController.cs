using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dotnet9_TestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoGameController : ControllerBase
    {
        static private List<VideoGame> videoGames = new List<VideoGame>
        {
            new VideoGame { Id = 1, Title = "The Legend of Zelda: Breath of the Wild", Platform = "Nintendo Switch", Developer = "Nintendo", Publisher = "Nintendo" },
            new VideoGame { Id = 2, Title = "God of War", Platform = "PlayStation 4", Developer = "Santa Monica Studio", Publisher = "Sony Interactive Entertainment" },
            new VideoGame { Id = 3, Title = "Red Dead Redemption 2", Platform = "Multiple", Developer = "Rockstar Games", Publisher = "Rockstar Games" }
        };

        [HttpGet]
        [Route("GetAllVideoGames")]
        [Authorize]
        public ActionResult<List<VideoGame>> GetAllVideoGames()
        {
            return Ok(videoGames);
        }

        [HttpGet("GetVideoGame/{id}")]
        public ActionResult<VideoGame>GetVideoGameById(int id)
        {
            var game = videoGames.FirstOrDefault(g => g.Id == id);
            if (game is null)
                return NotFound();

            return Ok(game);
        }

        [HttpPost]
        [Route("AddVideoGame")]
        public ActionResult<VideoGame>AddVideoGame(VideoGame newGame)
        {
            if (newGame is null)
                return BadRequest();

            newGame.Id = videoGames.Max(g => g.Id) + 1;
            videoGames.Add(newGame);
            return CreatedAtAction(nameof(GetVideoGameById), new {id = newGame.Id}, newGame);

        }

        [HttpDelete("DeleteVideoGame/{id}")]
        public ActionResult DeleteVideoGame(int id)
        {
            var game = videoGames.FirstOrDefault(g => g.Id == id);
            if (game is null)
                return NotFound();

            videoGames.Remove(game);
            return NoContent();
        }
    }
}
