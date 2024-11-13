
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium211 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium211";
        public override double halfLife { get; } = 0.516d;
        public override double atomicWeight { get; } = 210.98665d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Lead207() } },

        };
    }
}
    
    