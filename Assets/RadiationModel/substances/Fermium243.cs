using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fermium243 : RadioactiveSubstance
    {
        public override string name { get; } = "Fermium243";
        public override double halfLife { get; } = 0.231d;
        public override double atomicWeight { get; } = 243.07442d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.91d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Californium239() }, { 1.0d, new AlphaParticle(9717002.09) } } },
            { 0.1d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Californium243() }, { 1.0d, new BetaParticle(1, 4165000.0) } } },
            { 0.09d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    