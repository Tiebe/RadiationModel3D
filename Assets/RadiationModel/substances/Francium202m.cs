
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium202m : RadioactiveSubstance
    {
        public override string name { get; } = "Francium202m";
        public override double halfLife { get; } = 0.286d;
        public override double atomicWeight { get; } = 202.00361d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Astatine198() } },

        };
    }
}
    
    