using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium208m : RadioactiveSubstance
    {
        public override string name { get; } = "Radium208m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 208.00416d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00058, 2147000.0), new Radium208() } },

        };
    }
}
    
    