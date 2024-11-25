using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silicon39 : RadioactiveSubstance
    {
        public override string name { get; } = "Silicon39";
        public override double halfLife { get; } = 0.0475d;
        public override double atomicWeight { get; } = 39.00249d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Phosphorus39() }, { 1.0d, new BetaParticle(-1, 7545000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    