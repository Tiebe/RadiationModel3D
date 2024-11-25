using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium163 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium163";
        public override double halfLife { get; } = 0.39d;
        public override double atomicWeight { get; } = 162.97209d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.68d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tantalum163() }, { 1.0d, new BetaParticle(1, 8264000.0) } } },
            { 0.32d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tantalum159() }, { 1.0d, new AlphaParticle(7034002.09) } } },

        };
    }
}
    