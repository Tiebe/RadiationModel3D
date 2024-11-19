using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum158 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum158";
        public override double halfLife { get; } = 0.049d;
        public override double atomicWeight { get; } = 157.96659d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(7147002.09), new Lutetium154() } },

        };
    }
}
    
    