using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium44m : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium44m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 43.95948d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.01826), new Scandium44() } },

        };
    }
}
    
    