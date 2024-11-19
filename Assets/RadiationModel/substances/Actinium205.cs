using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium205 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium205";
        public override double halfLife { get; } = 0.08d;
        public override double atomicWeight { get; } = 205.01515d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(9118002.09), new Francium201() } },

        };
    }
}
    
    