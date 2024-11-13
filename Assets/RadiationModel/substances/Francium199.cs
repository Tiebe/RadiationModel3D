
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium199 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium199";
        public override double halfLife { get; } = 0.0066d;
        public override double atomicWeight { get; } = 199.00727d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Astatine195() } },

        };
    }
}
    
    