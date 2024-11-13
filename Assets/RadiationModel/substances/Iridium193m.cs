
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium193m : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium193m";
        public override double halfLife { get; } = 909792.0d;
        public override double atomicWeight { get; } = 192.96301d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Iridium193() } },

        };
    }
}
    
    