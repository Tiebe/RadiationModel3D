
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper60i : RadioactiveSubstance
    {
        public override string name { get; } = "Copper60i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 59.94009d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Copper60() } },

        };
    }
}
    
    