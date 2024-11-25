using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Flerovium288 : RadioactiveSubstance
    {
        public override string name { get; } = "Flerovium288";
        public override double halfLife { get; } = 0.64d;
        public override double atomicWeight { get; } = 288.18778d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Copernicium284() }, { 1.0d, new AlphaParticle(11097002.09) } } },
            { 0.03d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    