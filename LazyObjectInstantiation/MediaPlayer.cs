using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyObjectInstantiation
{
    internal class MediaPlayer
    {
        public void Play() {/* Воспроиведение композиции */ }
        public void Pause() {/* Пауза в воспроизведении */ }
        public void Stop() {/* Остановка воспроизведения */ }
        private Lazy<AllTracks> _allSongs = new Lazy<AllTracks>(() =>
        {
            Console.WriteLine("Создание объекта AllTracks");
            return new AllTracks();
        });
        
        public AllTracks GetAllTracks() 
        {
            return _allSongs.Value;
        }
    }
}
