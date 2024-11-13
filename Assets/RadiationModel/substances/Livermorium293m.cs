
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Livermorium293m : RadioactiveSubstance
    {
        public override string name { get; } = "Livermorium293m";
        public override double halfLife { get; } = 0.08d;
        public override double atomicWeight { get; } = 293.20536d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Flerovium289() } },

        };
    }
}
    
    