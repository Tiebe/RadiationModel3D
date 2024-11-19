using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zinc78m : RadioactiveSubstance
    {
        public override string name { get; } = "Zinc78m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 77.94116d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00046, 2673700.0), new Zinc78() } },

        };
    }
}
    
    