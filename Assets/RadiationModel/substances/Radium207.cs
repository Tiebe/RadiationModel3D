using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium207 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium207";
        public override double halfLife { get; } = 1.35d;
        public override double atomicWeight { get; } = 207.00377d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.86d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Radon203() }, { 1.0d, new AlphaParticle(8291002.09) } } },
            { 0.14d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Radon207() }, { 1.0d, new BetaParticle(1, 6072500.0) } } },

        };
    }
}
    