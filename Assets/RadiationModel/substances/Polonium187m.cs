using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium187m : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium187m";
        public override double halfLife { get; } = 0.0005d;
        public override double atomicWeight { get; } = 187.00304d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(9005047.4), new Lead183() } },

        };
    }
}
    
    