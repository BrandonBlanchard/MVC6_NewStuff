using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace New_Stuff.Helpers
{
    public class LoremIpsumHelpers
    {
        static Random rnd = new Random();

        public static string LoremIpsum = "Lorem ipsum dolor sit amet, consectetur adipiscing elit Morbi accumsan, metus in consectetur fringilla, lorem arcu mollis sapien, nec lacinia libero orci ut diam Duis vitae erat id nunc tempus fringilla Nullam vitae orci et lorem dapibus scelerisque quis vel enim Aliquam erat volutpat Cras laoreet feugiat consequat Donec dignissim ex eget leo interdum, ut cursus mauris pulvinar Pellentesque a vehicula ligula Donec ut mattis nulla Aenean congue dapibus dolor, ut consequat ex iaculis non Phasellus mi tortor, imperdiet nec pellentesque eu, vulputate eu enim Suspendisse pellentesque ut neque ac temporPellentesque est turpis, sodales eget convallis eget, sodales sed eratUt vestibulum, erat vel porttitor euismod, nisl justo tincidunt metus, quis dictum ligula ligula a orci Ut eget sapien sed felis tincidunt semperCurabitur justo velit, bibendum nec magna vel, volutpat ornare nequeMorbi nec volutpat libero Aenean pulvinar, nunc in convallis convallis, neque urna sollicitudin ex, in sagittis lacus erat quis arcuPellentesque elementum venenatis purus, eu consectetur dui rhoncus euismodVivamus sollicitudin in ante vitae porttitorNam sit amet mauris id purus placerat fringilla at id loremSed sit amet turpis feugiat sapien ullamcorper pretium non sed nulla Integer varius lorem non libero pharetra tristiqueNulla dolor urna, vestibulum in ligula vel, fringilla hendrerit dolorVestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Ut sagittis lorem et pharetra tinciduntPellentesque eget enim pharetra, malesuada erat in, molestie orci Nunc nec sodales dolor Ut auctor, magna nec finibus maximus, mi erat dapibus tortor, rhoncus luctus augue urna et libero Praesent fermentum est non consectetur mollis Curabitur mollis elit ut massa eleifend, id mattis risus gravida Cras ut arcu nec tellus placerat rutrum aliquet eget nulla Aenean molestie enim quis turpis sollicitudin tristique Fusce feugiat metus eget mattis gravida Morbi scelerisque, eros vel tempus pretium, risus velit finibus velit, ut commodo elit odio sollicitudin arcu Fusce fringilla libero in leo euismod, vitae tristique eros sodales Vestibulum non odio ligula Aenean convallis purus tempus, gravida mauris id, lobortis quam Duis enim nulla, efficitur at risus eu, lobortis vestibulum ligulaNunc nec sollicitudin purus, ac maximus arcuDonec iaculis tincidunt libero nec vestibulum Curabitur sit amet eros nec sapien sagittis fermentum Integer pulvinar lacus et nulla aliquam, eget iaculis lorem eleifend In hac habitasse platea dictumstVestibulum fermentum dolor ex Nam malesuada lectus eget tortor dignissim tristiqueNulla facilisi Aliquam semper arcu sed magna placerat mattisVestibulum laoreet odio at odio blandit finibusDuis id magna rutrum, laoreet felis eget, tempor est Donec dapibus urna lacus, sit amet viverra urna auctor ac Vestibulum sed sapien turpis Nam porta sem a lacinia molestie Etiam efficitur lacinia ligula, vel elementum felis tristique necMauris malesuada ac velit eget efficitur Integer et lorem ut ligula fermentum laoreetAliquam mattis at urna id pretium Aliquam erat volutpat Nunc lacinia orci eu elementum blandit Vestibulum sed nisi sed ipsum bibendum sagittisDonec nec rhoncus felis Donec at leo placerat, lobortis eros at, interdum nibh Integer et tortor faucibus, rhoncus est ut, lacinia quam Praesent in pharetra orci Sed dictum vel ante non finibus Ut eget urna ac ipsum eleifend commodo eu eu leo Morbi convallis dui eget scelerisque efficitur Duis nec erat quis mi ultrices tristiqueDuis eget gravida dolor Donec in nulla interdum, maximus ligula vel, venenatis tortor Curabitur hendrerit, nibh et tristique posuere, tellus urna iaculis metus, et suscipit urna eros in anteDonec ullamcorper viverra arcu consequat scelerisque Suspendisse ut turpis tincidunt, gravida urna sed, convallis velit";

        public static string GetParagraph()
        {
            
            int sentenceCount = rnd.Next(3, 5);
            string paragraph = string.Empty;

            for(int i = 0; i < sentenceCount; i += 1)
            {
                paragraph += GetSentence() + " ";
            }

            return paragraph.Trim();
        }

        public static string GetSentence()
        {
            int sentenceLength = rnd.Next(22, 90);
            int sentenceStart = rnd.Next(1, LoremIpsum.Length - 150);
            
            return LoremIpsum.Substring(sentenceStart, sentenceLength).ToLower() + ".";
        }
    }
}
