using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine77m : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine77m";
        public override double halfLife { get; } = 256.8d;
        public override double atomicWeight { get; } = 76.92149d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((105899.99999, 0.01171)), new Bromine77() } },

        };
    }
}
    
    