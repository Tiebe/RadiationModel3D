
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Uranium218m : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium218m";
        public override double halfLife { get; } = 0.00041d;
        public override double atomicWeight { get; } = 218.02577d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Thorium214() } },

        };
    }
}
    
    