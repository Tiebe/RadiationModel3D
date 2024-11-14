using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon212 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon212";
        public override double halfLife { get; } = 1434.0d;
        public override double atomicWeight { get; } = 211.9907d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(7405247.4), new Polonium208() } },

        };
    }
}
    
    