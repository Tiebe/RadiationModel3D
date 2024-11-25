using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neon18 : RadioactiveSubstance
    {
        public override string name { get; } = "Neon18";
        public override double halfLife { get; } = 1.672d;
        public override double atomicWeight { get; } = 18.00571d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Oxygen18() }, { 1.0d, new BetaParticle(1, 3050208.15) }, { 0.00135d, new GammaParticle(659250.0, 0.00188) }, { 0.0783d, new GammaParticle(1041520.0, 0.00119) }, { 2.2599999999999997e-05d, new GammaParticle(1080510.0, 0.00115) }, { 0.000538d, new GammaParticle(1700720.0, 0.00073) }, { 1.999202d, new GammaParticle(511000.0, 0.00243) } } },

        };
    }
}
    