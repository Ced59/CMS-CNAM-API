using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto.LyraDto
{
    public class LyraFormTokenResponseDto
    {
        public string status { get; set; }
        public string _type { get; set; }
        public string webService { get; set; }
        public string applicationProvider { get; set; }
        public string version { get; set; }
        public string applicationVersion { get; set; }
        public Answer answer { get; set; }
    }

    public class Answer
    {
        public string formToken { get; set; }
        public string _type { get; set; }
    }
}
