using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium107 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium107";
        public override double halfLife { get; } = 0.0031d;
        public override double atomicWeight { get; } = 106.93488d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.7d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin103() }, { 1.0d, new AlphaParticle(5027002.09) } } },
            { 0.3d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin107() }, { 1.0d, new BetaParticle(1, 8926000.0) } } },

        };
    }
}
    