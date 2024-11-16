using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium213 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium213";
        public override double halfLife { get; } = 0.738d;
        public override double atomicWeight { get; } = 213.00659d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8520002.09), new Francium209() } },

        };
    }
}
    
    