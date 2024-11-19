using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium176p : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium176p";
        public override double halfLife { get; } = 0.0004d;
        public override double atomicWeight { get; } = 175.94449d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00043, 2865800.0), new Hafnium176() } },

        };
    }
}
    
    