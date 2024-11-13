
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Vanadium64m : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium64m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 63.98257d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Vanadium64() } },

        };
    }
}
    
    