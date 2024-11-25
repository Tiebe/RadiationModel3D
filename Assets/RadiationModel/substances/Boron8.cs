using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Boron8 : RadioactiveSubstance
    {
        public override string name { get; } = "Boron8";
        public override double halfLife { get; } = 0.77d;
        public override double atomicWeight { get; } = 8.02461d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lithium8() }, { 1.0d, new BetaParticle(1, 987900.0) }, { 2.0d, new GammaParticle(511000.0, 0.00243) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Beryllium8() }, { 1.0d, new BetaParticle(1, 8989965.0) } } },

        };
    }
}
    