using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Californium243 : RadioactiveSubstance
    {
        public override string name { get; } = "Californium243";
        public override double halfLife { get; } = 642.0d;
        public override double atomicWeight { get; } = 243.06548d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.86d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Curium243() }, { 1.0d, new BetaParticle(1, 1904050.0) } } },
            { 0.14d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Curium239() }, { 1.0d, new AlphaParticle(8437002.09) } } },

        };
    }
}
    