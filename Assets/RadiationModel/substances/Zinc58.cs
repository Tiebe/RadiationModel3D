using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zinc58 : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc58";
        public override double halfLife { get; } = 0.0867d;
        public override double atomicWeight { get; } = 57.95459d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nickel58() }, { 1.0d, new BetaParticle(1, 8964450.0) }, { 0.8d, new GammaParticle(203000.0, 0.00611) }, { 0.096d, new GammaParticle(848000.0, 0.00146) }, { 2.0d, new GammaParticle(511000.0, 0.00243) }, { 1.4681761308e-05d, new GammaParticle(952.0, 1.30236) }, { 0.00013958498554150737d, new GammaParticle(8028.0, 0.15444) }, { 0.00027193646121470366d, new GammaParticle(8048.0, 0.15406) }, { 5.724263324378895e-05d, new GammaParticle(8940.0, 0.13868) }, { 5.724263324378895e-05d, new GammaParticle(8940.0, 0.13868) } } },
            { 0.03d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nickel57() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    