
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium181m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium181m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 180.95034d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Rhenium181() } },

        };
    }
}
    
    