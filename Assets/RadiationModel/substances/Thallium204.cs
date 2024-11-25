using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium204 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium204";
        public override double halfLife { get; } = 119379850.96188d;
        public override double atomicWeight { get; } = 203.97386d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9708d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lead204() }, { 1.0d, new BetaParticle(-1, 381850.00001) } } },
            { 0.0292d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gold204() }, { 1.0d, new BetaParticle(1, -1978050.0) }, { 0.0080581842488d, new GammaParticle(11777.0, 0.10528) }, { 0.004766845972773667d, new GammaParticle(68894.0, 0.018) }, { 0.008080769575815674d, new GammaParticle(70820.0, 0.01751) }, { 0.0027424144558473766d, new GammaParticle(80316.0, 0.01544) }, { 0.0035459418914106583d, new GammaParticle(81285.0, 0.01525) }, { 0.0008035274355632814d, new GammaParticle(82477.0, 0.01503) } } },

        };
    }
}
    