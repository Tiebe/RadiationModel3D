using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lithium8 : RadioactiveSubstance
    {
        public override string name { get; } = "Lithium8";
        public override double halfLife { get; } = 0.8399d;
        public override double atomicWeight { get; } = 8.02249d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Beryllium8() }, { 1.0d, new BetaParticle(-1, 8002065.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Beryllium8() }, { 1.0d, new BetaParticle(-1, 8002065.0) } } },

        };
    }
}
    