using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium87 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium87";
        public override double halfLife { get; } = 222.0d;
        public override double atomicWeight { get; } = 86.92069d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Yttrium87() }, { 1.0d, new BetaParticle(1, 4572200.0) }, { 0.272d, new GammaParticle(135200.0, 0.00917) }, { 0.9640000000000001d, new GammaParticle(201200.0, 0.00616) }, { 1.9380000000000002d, new GammaParticle(511000.0, 0.00243) }, { 0.025115337066880003d, new GammaParticle(2161.0, 0.57374) }, { 0.12555326290020669d, new GammaParticle(15691.0, 0.07902) }, { 0.24029332612479753d, new GammaParticle(15775.0, 0.0786) }, { 0.06122982179319006d, new GammaParticle(17736.0, 0.06991) }, { 0.0701693757749958d, new GammaParticle(17824.0, 0.06956) }, { 0.008939553981805749d, new GammaParticle(17968.0, 0.069) } } },

        };
    }
}
    