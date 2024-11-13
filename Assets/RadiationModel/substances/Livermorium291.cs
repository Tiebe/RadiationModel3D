
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Livermorium291 : RadioactiveSubstance
    {
        public override string name { get; } = "Livermorium291";
        public override double halfLife { get; } = 0.026d;
        public override double atomicWeight { get; } = 291.20101d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Flerovium287() } },

        };
    }
}
    
    