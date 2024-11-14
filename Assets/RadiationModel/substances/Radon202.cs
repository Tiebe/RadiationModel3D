using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon202 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon202";
        public override double halfLife { get; } = 9.7d;
        public override double atomicWeight { get; } = 201.99326d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.78d, new List<RadioactiveSubstance> { new AlphaParticle(7793047.4), new Polonium198() } },

        };
    }
}
    
    