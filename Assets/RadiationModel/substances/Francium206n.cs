using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium206n : RadioactiveSubstance
    {
        public override string name { get; } = "Francium206n";
        public override double halfLife { get; } = 0.7d;
        public override double atomicWeight { get; } = 205.99944d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.13d, new List<RadioactiveSubstance> { new AlphaParticle(8673047.4), new Astatine202() } },

        };
    }
}
    
    