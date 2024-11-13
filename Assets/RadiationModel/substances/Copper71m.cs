
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper71m : RadioactiveSubstance
    {
        public override string name { get; } = "Copper71m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 70.93564d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Copper71() } },

        };
    }
}
    
    