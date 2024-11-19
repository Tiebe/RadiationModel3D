using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium105m : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium105m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 104.90777d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.06019, 20600.0), new Ruthenium105() } },

        };
    }
}
    
    