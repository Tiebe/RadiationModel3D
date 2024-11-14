using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium200m : RadioactiveSubstance
    {
        public override string name { get; } = "Francium200m";
        public override double halfLife { get; } = 0.19d;
        public override double atomicWeight { get; } = 200.00663d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8685047.4), new Astatine196() } },

        };
    }
}
    
    