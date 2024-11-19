using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium163m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium163m";
        public override double halfLife { get; } = 0.214d;
        public override double atomicWeight { get; } = 162.97221d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.66d, new List<RadioactiveSubstance> { new AlphaParticle(7154002.09), new Tantalum159() } },

        };
    }
}
    
    