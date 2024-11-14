using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thorium219 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium219";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 219.01552d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(10523047.4), new Radium215() } },

        };
    }
}
    
    