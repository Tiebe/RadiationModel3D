
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Meitnerium276m : RadioactiveSubstance
    {
        public override string name { get; } = "Meitnerium276m";
        public override double halfLife { get; } = 7.0d;
        public override double atomicWeight { get; } = 276.15197d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Bohrium272() } },

        };
    }
}
    
    