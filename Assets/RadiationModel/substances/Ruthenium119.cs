using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium119 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium119";
        public override double halfLife { get; } = 0.0695d;
        public override double atomicWeight { get; } = 118.94409d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhodium119() }, { 1.0d, new BetaParticle(-1, 5371500.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    