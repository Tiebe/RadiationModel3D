
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium179m : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium179m";
        public override double halfLife { get; } = 0.00141d;
        public override double atomicWeight { get; } = 178.992d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Gold175() } },

        };
    }
}
    
    