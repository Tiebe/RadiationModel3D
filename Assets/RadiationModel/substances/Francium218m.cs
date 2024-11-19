using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium218m : RadioactiveSubstance
    {
        public override string name { get; } = "Francium218m";
        public override double halfLife { get; } = 0.0219d;
        public override double atomicWeight { get; } = 218.00767d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(9123002.09), new Astatine214() } },

        };
    }
}
    
    