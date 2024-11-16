using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum176n : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum176n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 175.94643d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00084), new Tantalum176() } },

        };
    }
}
    
    