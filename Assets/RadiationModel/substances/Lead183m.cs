
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead183m : RadioactiveSubstance
    {
        public override string name { get; } = "Lead183m";
        public override double halfLife { get; } = 0.415d;
        public override double atomicWeight { get; } = 182.99196d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Mercury179() } },

        };
    }
}
    
    