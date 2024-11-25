using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silicon41 : RadioactiveSubstance
    {
        public override string name { get; } = "Silicon41";
        public override double halfLife { get; } = 0.02d;
        public override double atomicWeight { get; } = 41.01417d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Phosphorus41() }, { 1.0d, new BetaParticle(-1, 9090000.0) } } },
            { 0.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Phosphorus41() }, { 1.0d, new BetaParticle(-1, 9090000.0) } } },

        };
    }
}
    