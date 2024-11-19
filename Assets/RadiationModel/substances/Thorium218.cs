using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thorium218 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium218";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 218.01328d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(10871002.09), new Radium214() } },

        };
    }
}
    
    