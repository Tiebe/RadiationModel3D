using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium198m : RadioactiveSubstance
    {
        public override string name { get; } = "Francium198m";
        public override double halfLife { get; } = 0.0011d;
        public override double atomicWeight { get; } = 198.01028d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8891047.4), new Astatine194() } },

        };
    }
}
    
    