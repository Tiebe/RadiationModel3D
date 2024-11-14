using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten158m : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten158m";
        public override double halfLife { get; } = 0.00014d;
        public override double atomicWeight { get; } = 157.9766d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(9525047.4), new Hafnium154() } },

        };
    }
}
    
    