using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silicon40 : RadioactiveSubstance
    {
        public override string name { get; } = "Silicon40";
        public override double halfLife { get; } = 0.033d;
        public override double atomicWeight { get; } = 40.00609d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Phosphorus40() }, { 1.0d, new BetaParticle(-1, 6905000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    