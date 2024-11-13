
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium204 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium204";
        public override double halfLife { get; } = 1.75d;
        public override double atomicWeight { get; } = 204.00065d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.96d, new List<RadioactiveSubstance> { new AlphaParticle(), new Astatine200() } },

        };
    }
}
    
    