using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Carbon11 : RadioactiveSubstance
    {
        public override string name { get; } = "Carbon11";
        public override double halfLife { get; } = 1221.84d;
        public override double atomicWeight { get; } = 11.01143d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Beryllium11() }, { 1.0d, new BetaParticle(1, -4763885.0) }, { 1.995338d, new GammaParticle(511000.0, 0.00243) } } },

        };
    }
}
    