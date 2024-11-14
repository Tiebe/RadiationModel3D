using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium209 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium209";
        public override double halfLife { get; } = 4.71d;
        public override double atomicWeight { get; } = 209.00199d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8163047.4), new Radon205() } },

        };
    }
}
    
    