using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Livermorium293 : RadioactiveSubstance
    {
        public override string name { get; } = "Livermorium293";
        public override double halfLife { get; } = 0.07d;
        public override double atomicWeight { get; } = 293.20459d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(11697002.09), new Flerovium289() } },

        };
    }
}
    
    