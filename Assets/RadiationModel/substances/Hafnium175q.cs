using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium175q : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium175q";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 174.94649d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00027), new Hafnium175() } },

        };
    }
}
    
    