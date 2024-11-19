using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium163m : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium163m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 162.93052d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00279, 445000.0), new Erbium163() } },

        };
    }
}
    
    