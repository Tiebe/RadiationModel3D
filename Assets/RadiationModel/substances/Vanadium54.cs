using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Vanadium54 : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium54";
        public override double halfLife { get; } = 49.8d;
        public override double atomicWeight { get; } = 53.94643d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Chromium54() }, { 1.0d, new BetaParticle(-1, 3518690.0) }, { 0.0423356d, new GammaParticle(563680.0, 0.0022) }, { 0.007379599999999999d, new GammaParticle(626560.0, 0.00198) }, { 0.035927d, new GammaParticle(639350.0, 0.00194) }, { 0.022333d, new GammaParticle(646270.0, 0.00192) }, { 0.971d, new GammaParticle(834750.0, 0.00149) }, { 0.080593d, new GammaParticle(923290.0, 0.00134) }, { 0.801075d, new GammaParticle(988960.0, 0.00125) }, { 0.013594d, new GammaParticle(1009250.0, 0.00123) }, { 0.025246d, new GammaParticle(1336220.0, 0.00093) }, { 0.045637d, new GammaParticle(1398630.0, 0.00089) }, { 0.086419d, new GammaParticle(1463510.0, 0.00085) }, { 0.081564d, new GammaParticle(1784440.0, 0.00069) }, { 0.047579d, new GammaParticle(1831270.0, 0.00068) }, { 0.100013d, new GammaParticle(1961530.0, 0.00063) }, { 0.044666d, new GammaParticle(1974330.0, 0.00063) }, { 0.012623d, new GammaParticle(2239110.0, 0.00055) }, { 0.45637d, new GammaParticle(2259350.0, 0.00055) }, { 0.022333d, new GammaParticle(2325020.0, 0.00053) }, { 0.11166499999999999d, new GammaParticle(2353000.0, 0.00053) }, { 0.030101d, new GammaParticle(2394820.0, 0.00052) }, { 0.027188d, new GammaParticle(2602040.0, 0.00048) }, { 0.02913d, new GammaParticle(2621300.0, 0.00047) }, { 0.015536000000000001d, new GammaParticle(2627000.0, 0.00047) }, { 0.03884d, new GammaParticle(2820000.0, 0.00044) }, { 0.034956d, new GammaParticle(2964290.0, 0.00042) }, { 0.11457800000000001d, new GammaParticle(3170000.0, 0.00039) }, { 0.039811d, new GammaParticle(3382960.0, 0.00037) } } },

        };
    }
}
    