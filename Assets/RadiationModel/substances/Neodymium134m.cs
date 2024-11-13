
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium134m : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium134m";
        public override double halfLife { get; } = 0.00039d;
        public override double atomicWeight { get; } = 133.92125d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Neodymium134() } },

        };
    }
}
    
    