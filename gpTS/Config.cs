using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gpTS {
    public class Config {
        public string garaponIP;
        public string outputPath;
        public string rtmpdumpPath;
        public string ffmpegPath;
        public string ffmpegOpt;


        public Config() {
            this.garaponIP = "";
            this.outputPath = "";
            this.rtmpdumpPath = "";
            this.ffmpegPath = "";
            this.ffmpegOpt = "";
        }
    }    
}
