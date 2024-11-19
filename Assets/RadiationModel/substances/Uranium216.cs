using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Uranium216 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium216";
        public override double halfLife { get; } = 0.0069d;
        public override double atomicWeight { get; } = 216.02476d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(9552002.09), new Thorium212() } },

        };
    }
}
    
    