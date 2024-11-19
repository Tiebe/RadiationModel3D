using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten158 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten158";
        public override double halfLife { get; } = 0.00143d;
        public override double atomicWeight { get; } = 157.97457d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(7637002.09), new Hafnium154() } },

        };
    }
}
    
    