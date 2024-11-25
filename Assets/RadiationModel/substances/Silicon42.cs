using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silicon42 : RadioactiveSubstance
    {
        public override string name { get; } = "Silicon42";
        public override double halfLife { get; } = 0.0125d;
        public override double atomicWeight { get; } = 42.01808d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Phosphorus42() }, { 1.0d, new BetaParticle(-1, 7875000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    