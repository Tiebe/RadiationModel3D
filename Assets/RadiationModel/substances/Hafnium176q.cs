using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium176q : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium176q";
        public override double halfLife { get; } = 4e-05d;
        public override double atomicWeight { get; } = 175.94663d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00025), new Hafnium176() } },

        };
    }
}
    
    