using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium199n : RadioactiveSubstance
    {
        public override string name { get; } = "Francium199n";
        public override double halfLife { get; } = 0.0022d;
        public override double atomicWeight { get; } = 199.00754d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(9085047.4), new Astatine195() } },

        };
    }
}
    
    