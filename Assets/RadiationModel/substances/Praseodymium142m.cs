
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium142m : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium142m";
        public override double halfLife { get; } = 876.0d;
        public override double atomicWeight { get; } = 141.91006d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Praseodymium142() } },

        };
    }
}
    
    