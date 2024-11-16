using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium201m : RadioactiveSubstance
    {
        public override string name { get; } = "Francium201m";
        public override double halfLife { get; } = 0.024d;
        public override double atomicWeight { get; } = 201.00399d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8670002.09), new Astatine197() } },

        };
    }
}
    
    