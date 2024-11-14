using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine133m : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine133m";
        public override double halfLife { get; } = 9.0d;
        public override double atomicWeight { get; } = 132.90958d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00076), new Iodine133() } },

        };
    }
}
    
    