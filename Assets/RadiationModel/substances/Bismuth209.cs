using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth209 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth209";
        public override double halfLife { get; } = 6.342947352e+26d;
        public override double atomicWeight { get; } = 208.9804d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(4157247.4000000004), new Thallium205() } },

        };
    }
}
    
    