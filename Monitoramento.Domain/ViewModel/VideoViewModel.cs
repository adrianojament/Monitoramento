using Monitoramento.Domain.Models;

namespace Monitoramento.Domain.ViewModel
{
    public class VideoViewModel : BaseViewModel
    {
        public IEnumerable<Video> Videos { get; set; }
        public Video Video { get; set; }
    }
}
