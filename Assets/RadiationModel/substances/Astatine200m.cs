using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine200m : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine200m";
        public override double halfLife { get; } = 47.0d;
        public override double atomicWeight { get; } = 199.99047d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.57d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bismuth200() }, { 1.0d, new BetaParticle(1, 5748000.0) } } },
            { 0.43d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bismuth196() }, { 1.0d, new AlphaParticle(7731002.09) }, { 4.7e-06d, new GammaParticle(102000.0, 0.01216) }, { 0.0055000000000000005d, new GammaParticle(158300.0, 0.00783) }, { 0.126372352052175d, new GammaParticle(12904.0, 0.09608) }, { 0.04858167783063643d, new GammaParticle(74815.0, 0.01657) }, { 0.08128104037248858d, new GammaParticle(77108.0, 0.01608) }, { 0.027841930395769526d, new GammaParticle(87388.0, 0.01419) }, { 0.036361561096875d, new GammaParticle(88458.0, 0.01402) }, { 0.008519630701105474d, new GammaParticle(89784.0, 0.01381) } } },

        };
    }
}
    