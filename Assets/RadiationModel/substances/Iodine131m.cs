
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine131m : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine131m";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 130.90819d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Iodine131() } },

        };
    }
}
    
    