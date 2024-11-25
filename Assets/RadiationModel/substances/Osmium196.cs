using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium196 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium196";
        public override double halfLife { get; } = 2094.0d;
        public override double atomicWeight { get; } = 195.96964d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iridium196() }, { 1.0d, new BetaParticle(-1, 580000.0) }, { 0.053d, new GammaParticle(126200.0, 0.00982) }, { 0.005600000000000001d, new GammaParticle(200800.0, 0.00617) }, { 0.024d, new GammaParticle(207100.0, 0.00599) }, { 0.023d, new GammaParticle(257800.0, 0.00481) }, { 0.0043d, new GammaParticle(308000.0, 0.00403) }, { 0.025d, new GammaParticle(315400.0, 0.00393) }, { 0.059000000000000004d, new GammaParticle(407900.0, 0.00304) }, { 0.0078000000000000005d, new GammaParticle(522200.0, 0.00237) }, { 0.0059d, new GammaParticle(586200.0, 0.00212) }, { 0.016d, new GammaParticle(629100.0, 0.00197) } } },

        };
    }
}
    