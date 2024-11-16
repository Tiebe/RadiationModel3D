using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium206m : RadioactiveSubstance
    {
        public override string name { get; } = "Francium206m";
        public override double halfLife { get; } = 16.0d;
        public override double atomicWeight { get; } = 205.99887d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.847d, new List<RadioactiveSubstance> { new AlphaParticle(8144002.09), new Astatine202() } },

        };
    }
}
    
    