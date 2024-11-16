using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium214m : RadioactiveSubstance
    {
        public override string name { get; } = "Radium214m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 214.00205d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00068), new Radium214() } },

        };
    }
}
    
    