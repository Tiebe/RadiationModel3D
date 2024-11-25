using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Flerovium286 : RadioactiveSubstance
    {
        public override string name { get; } = "Flerovium286";
        public override double halfLife { get; } = 0.166d;
        public override double atomicWeight { get; } = 286.18423d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.6d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Copernicium282() }, { 1.0d, new AlphaParticle(11377002.09) } } },
            { 0.4d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    