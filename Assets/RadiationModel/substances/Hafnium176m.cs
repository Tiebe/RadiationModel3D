using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium176m : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium176m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 175.94284d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00093), new Hafnium176() } },

        };
    }
}
    
    