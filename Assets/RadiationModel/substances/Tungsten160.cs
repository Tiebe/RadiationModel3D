
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten160 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten160";
        public override double halfLife { get; } = 0.09d;
        public override double atomicWeight { get; } = 159.96851d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.87d, new List<RadioactiveSubstance> { new AlphaParticle(), new Hafnium156() } },

        };
    }
}
    
    