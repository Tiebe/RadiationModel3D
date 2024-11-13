
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium171m : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium171m";
        public override double halfLife { get; } = 79.0d;
        public override double atomicWeight { get; } = 170.93799d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Lutetium171() } },

        };
    }
}
    
    