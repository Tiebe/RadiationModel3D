
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium212m : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium212m";
        public override double halfLife { get; } = 45.1d;
        public override double atomicWeight { get; } = 211.99201d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.9993000000000001d, new List<RadioactiveSubstance> { new AlphaParticle(), new Lead208() } },

        };
    }
}
    
    