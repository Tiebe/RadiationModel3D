using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Helium8 : RadioactiveSubstance
    {
        public override string name { get; } = "Helium8";
        public override double halfLife { get; } = 0.1191d;
        public override double atomicWeight { get; } = 8.03393d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lithium8() }, { 1.0d, new BetaParticle(-1, 5331940.0) }, { 0.84d, new GammaParticle(980000.0, 0.00127) } } },
            { 0.16d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lithium8() }, { 1.0d, new BetaParticle(-1, 5331940.0) }, { 0.84d, new GammaParticle(980000.0, 0.00127) } } },

        };
    }
}
    