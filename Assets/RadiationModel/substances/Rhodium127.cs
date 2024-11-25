using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium127 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium127";
        public override double halfLife { get; } = 0.02d;
        public override double atomicWeight { get; } = 126.96379d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Palladium127() }, { 1.0d, new BetaParticle(-1, 6745000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    