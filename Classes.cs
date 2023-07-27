using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LE_GRAND_REX_BETA
{

    public class Seat
    {
        public int SeatNumber { get; set; }
        public bool IsBooked { get; set; }
    }

    public class Show
    {
        public string Title { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public List<Seat> AvailableSeats { get; set; }
    }

    public class Theater
    {
        public string Name { get; set; }
        public List<Show> Shows { get; set; }
    }

    public class Booking
    {
        public Show Show { get; set; }
        public List<Seat> Seats { get; set; }
        public string CustomerName { get; set; }
        public DateTime BookingTime { get; set; }
    }

    public class BookingSystem
    {
        public List<Theater> Theaters { get; set; }
        public List<Booking> Bookings { get; set; }

        public bool BookSeats(Theater theater, Show show, List<Seat> seats, string customerName)
        {
            // Check if seats are available
                bool selected = false;
            if (seats.All(s => s.IsBooked))
            {
               selected = true;
                return selected;
            }
            return selected;


        
            

            
        }
    }
    public static class movieName
    {
        public static string Moviename  = "null";
    }
    public static class userName
    {
        public static string name = "null";
    }
    public static class check_special {
                
        public static bool Sp_ch(string n) {

            bool b=false;
            char[] specialCharacters = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '+', '=', '[', '{', ']', '}', ';', ':', '"', '\\', '|', ',', '.', '<', '>', '/', '?', '؟', '٠', '١', '٢', '٣', '٤', '٥', '٦', '٧', '٨', '٩', '،', '؛', '«', '»', 'ـ', 'ً', 'ٌ', 'ٍ', 'َ', 'ُ', 'ِ', 'ّ', 'ْ', 'ٓ', 'ٔ', 'ٰ', 'ٕ', 'ٖ', 'ٗ', '٘', 'ٙ', 'ٚ', 'ٛ', 'ٜ', 'ٝ', 'ٞ', 'ٟ', '٠', '١', '٢', '٣', '٤', '٥', '٦', '٧', '٨', '٩', '٪', '٫', '٬', '٭', 'ٮ', 'ٯ', 'ٰ', 'ٱ', 'ٲ', 'ٳ', 'ٴ', 'ٵ', 'ٶ', 'ٷ', 'ٸ', 'ٹ', 'ٺ', 'ٻ', 'ټ', 'ٽ', 'پ', 'ٿ', 'ڀ', 'ځ', 'ڂ', 'ڃ', 'ڄ', 'څ', 'چ', 'ڇ', 'ڈ', 'ډ', 'ڊ', 'ڋ', 'ڌ', 'ڍ', 'ڎ', 'ڏ', 'ڐ', 'ڑ', 'ڒ', 'ړ', 'ڔ', 'ڕ', 'ږ', 'ڗ', 'ژ', 'ڙ', 'ښ', 'ڛ', 'ڜ', 'ڝ', 'ڞ', 'ڟ', 'ڠ', 'ڡ', 'ڢ', 'ڣ', 'ڤ', 'ڥ', 'ڦ', 'ڧ', 'ڨ', 'ک', 'ڪ', 'ګ', 'ڬ', 'ڭ', 'ڮ', 'گ', 'ڰ', 'ڱ', 'ڲ', 'ڳ', 'ڴ', 'ڵ', 'ڶ', 'ڷ', 'ڸ', 'ڹ', 'ں', 'ڻ', 'ڼ', 'ڽ', 'ھ', 'ڿ', 'ۀ', 'ہ', 'ۂ', 'ۃ', 'ۄ', 'ۅ', 'ۆ', 'ۇ', 'ۈ', 'ۉ', 'ۊ', 'ۋ', 'ی', 'ۍ', 'ێ', 'ۏ', 'ې', 'ۑ', 'ے', 'ۓ', '۔', 'ە', 'ۖ', 'ۗ', 'ۘ', 'ۙ', 'ۚ', 'ۛ', 'ۜ', '۝', '۞', '۟', '۠', 'ۡ', 'ۢ', 'ۣ', 'ۤ', 'ۥ', 'ۦ', 'ۧ', 'ۨ', '۩', '۪', '۫', '۬', 'ۭ', 'ۮ', 'ۯ', '۰', '۱', '۲', '۳', '۴', '۵', '۶', '۷', '۸', '۹', 'ۺ', 'ۻ', 'ۼ', '۽', '۾', 'ۿ', 'ݰ', 'ݱ', 'ݲ', 'ݳ', 'ݴ', 'ݵ', 'ݶ', 'ݷ', 'ݸ', 'ݹ', 'ݺ', 'ݻ', 'ݼ', 'ݽ', 'ݾ', 'ݿ', 'ހ', 'ށ', 'ނ', 'ރ', 'ބ', 'ޅ', 'ކ', 'އ', 'ވ', 'މ', 'ފ', 'ދ', 'ތ', 'ލ', 'ގ', 'ޏ', 'ސ', 'ޑ', 'ޒ', 'ޓ', 'ޔ', 'ޕ', 'ޖ', 'ޗ', 'ޘ', 'ޙ', 'ޚ', 'ޛ', 'ޜ', 'ޝ', 'ޞ', 'ޟ', 'ޠ', 'ޡ', 'ޢ', 'ޣ', 'ޤ', 'ޥ', 'ަ', 'ާ', 'ި', 'ީ', 'ު', 'ޫ', 'ެ', 'ޭ', 'ޮ', 'ޯ', 'ް', 'ޱ', '޲', '޳', '޴', '޵', '޶', '޷', '޸', '޹', '޺', '޻', '޼', '޽', '޾', '޿', '߀', '߁', '߂', '߃', '߄', '߅', '߆', '߇', '߈', '߉' };


            foreach (char c in n)
            {
                int count = 0;
                if (n[count]==c) 
                {
                    b= true;
                }
                count++;
            }
            return b;
        }
    }
    public static class theme{ 
                
        public static Color themee ;

    }

}
