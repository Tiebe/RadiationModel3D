using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead196p : RadioactiveSubstance
    {
        public override string name { get; } = "Lead196p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 195.97568d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00046, 2695000.0), new Lead196() } },

        };
    }
}
    
    