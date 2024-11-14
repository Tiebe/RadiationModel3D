using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Berkelium247 : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium247";
        public override double halfLife { get; } = 43548593760.0d;
        public override double atomicWeight { get; } = 247.07031d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(6910047.4), new Americium243() } },

        };
    }
}
    
    