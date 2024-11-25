using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silicon37 : RadioactiveSubstance
    {
        public override string name { get; } = "Silicon37";
        public override double halfLife { get; } = 0.09d;
        public override double atomicWeight { get; } = 36.99295d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Phosphorus37() }, { 1.0d, new BetaParticle(-1, 6215000.0) } } },
            { 0.17d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Phosphorus37() }, { 1.0d, new BetaParticle(-1, 6215000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    