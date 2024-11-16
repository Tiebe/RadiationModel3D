using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten180 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten180";
        public override double halfLife { get; } = 5.017555368e+25d;
        public override double atomicWeight { get; } = 179.94671d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(3537202.0900000003), new Hafnium176() } },

        };
    }
}
    
    