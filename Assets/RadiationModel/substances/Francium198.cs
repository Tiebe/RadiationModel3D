
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium198 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium198";
        public override double halfLife { get; } = 0.015d;
        public override double atomicWeight { get; } = 198.01028d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Astatine194() } },

        };
    }
}
    
    